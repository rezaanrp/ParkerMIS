using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.ProductPiecesOnMolding
{
    public partial class frmProductPiecesOnMoldingList : Form
    {
        public frmProductPiecesOnMoldingList(int x ,bool ReadOnlyForm)
        {
            InitializeComponent();
            dataGridView1.ReadOnly = ReadOnlyForm;
            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "نام قطعه",
                DataSource = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "xPieces_",
                Visible = true,
                DataPropertyName = "xPieces_",
                Width = 250,
                MaxDropDownItems = 30 
            };
            dataGridView1.Columns.Add(combobox_PiecesLine1_);
            x_ = x;
            ShowDate(x_);
        }
        int x_ = -1;
        DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingListDataTable dt_R;

        void LoadForm()
        {
            dt_R = new DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingListDataTable();
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator_D.BindingSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            Generate();
        }
        void ShowDate(int xProductPiecesOnMolding_)
        {
            dt_R = new BLL.ProductPiecesOnMolding.csProductPiecesOnMolding().mProductPiecesOnMoldingList(xProductPiecesOnMolding_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator_D.BindingSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xProductPiecesOnMolding_Column.DefaultValue = xProductPiecesOnMolding_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xProductPiecesOnMolding_"].Visible = false;
            dataGridView1.Columns["xPieces_"].DisplayIndex = 0;


            Generate();
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                //BLL.ProductPiecesOnMolding.csProductPiecesOnMolding cs = new BLL.ProductPiecesOnMolding.csProductPiecesOnMolding();
                //MessageBox.Show(cs.UdProductPiecesOnMolding(dt_R));
            }
        }

        private void frmProductPiecesOnMoldingList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            //if (new CS.csMessage().ShowMessageSaveYesNo())
            //{
                BLL.ProductPiecesOnMolding.csProductPiecesOnMolding cs = new BLL.ProductPiecesOnMolding.csProductPiecesOnMolding();
               cs.UdProductPiecesOnMoldingList(dt_R);
            //}
        }
    }
}
