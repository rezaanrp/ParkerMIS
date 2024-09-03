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
    public partial class frmProductPiecesOnMolding : Form
    {
        public frmProductPiecesOnMolding(CS.csEnum.TypeUser  typeUser)
        {
            InitializeComponent();
            TypeUser_ = typeUser;
  
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("PRLINE"),
                DisplayMember = "xName",
                HeaderText = "نام ایستگاه تولید",
                ValueMember = "x_",
                DataPropertyName = "xGenLine_",
                Name = "xGenLine_",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);

            DataGridViewComboBoxColumn combobox_Shift_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "نام شیفت",
                DataSource = new BLL.csShift().mShiftDataTable(),
                DataPropertyName = "xShift_",
                DisplayMember = "xShiftName",
                ValueMember = "x_",
                Name = "xShift_",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                Width = 100
            };
            dataGridView1.Columns.Add(combobox_Shift_);

            LoadForm();
        }
        DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingDataTable dt_R;
        CS.csEnum.TypeUser TypeUser_;
        void LoadForm()
        {
            dt_R = new DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingDataTable();
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator_D.BindingSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            Generate();
        }
        void ShowDate()
        {
            dt_R = new BLL.ProductPiecesOnMolding.csProductPiecesOnMolding().ProductPiecesOnMolding(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator_D.BindingSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
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
            if (TypeUser_ == CS.csEnum.TypeUser.User)
            {
                dataGridView1.Columns["xConfirm"].Visible = false;
            }
        }
        void SaveData()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.ProductPiecesOnMolding.csProductPiecesOnMolding cs = new BLL.ProductPiecesOnMolding.csProductPiecesOnMolding();
                MessageBox.Show(cs.UdProductPiecesOnMolding(dt_R));
            }
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDate();
        }
        private void toolStripButton_D_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && (int)dataGridView1["x_",e.RowIndex].Value > 0)
            {
                bool ch;
                if (dataGridView1["xConfirm", e.RowIndex].Value == DBNull.Value)
                     ch = false;
                else
                     ch = (bool)dataGridView1["xConfirm", e.RowIndex].Value;

                new Payazob.FRM.ProductPiecesOnMolding.frmProductPiecesOnMoldingList((int)dataGridView1["x_", e.RowIndex].Value ,ch).ShowDialog();
            }
        }
    }
}
