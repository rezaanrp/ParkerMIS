using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.SendPiecesToProduct
{
    public partial class frmSendPiecesToProduct : Form
    {
        public frmSendPiecesToProduct()
        {
            InitializeComponent();
            BLL.csPieces cs = new BLL.csPieces();

            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "نام قطعه",
                DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "combobox_Pieces",
                Visible = true,
                Width = 180,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "ثبت کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);

            dataGridView1.Columns.Add(combobox_PiecesLine1_);

            ShowDataGridView();
            Generate_I();
            //    toolStripTextBoxDateFrom.Text = BLL.csshamsidate.shamsidate;
            //     toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;
        }

        DAL.SendPiecesToProduct.DataSet_SendPiecesToProduct.mSendPiecesToProductDataTable dt_I;

        void ShowDataGridView()
        {
            BLL.SendPiecesToProduct.csSendPiecesToProduct cs = new BLL.SendPiecesToProduct.csSendPiecesToProduct();
            dt_I = cs.SendPiecesToProduct(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_I;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            dt_I.Columns["xDate"].DefaultValue = BLL.csshamsidate.shamsidate;
            dt_I.xPieces_Column.AllowDBNull = false;
            dt_I.xSendNumberColumn.AllowDBNull = false;
            dt_I.xSupplier_Column.DefaultValue = BLL.authentication.x_;
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
        }

        void Generate_I()
        {
            dataGridView1.Columns["xDate"].DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            dataGridView1.Columns["xSendNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["combobox_Pieces"].DataPropertyName = "xPieces_";
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // dataGridView1.Columns["xDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["xSupplier_"].DisplayIndex = 4;

        //    dataGridView1.Columns["xWeight"].Visible = false;
            dataGridView1.Columns["xPieces_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xRegisterTime"].Visible = false;
            dataGridView1.Columns["xRegisterDate"].ReadOnly = true;

            dataGridView1.Columns["xSupplier_"].HeaderText = "ثبت کننده";
            dataGridView1.Columns["xRegisterDate"].HeaderText = "تاریخ ثبت";
            dataGridView1.Columns["xRegisterTime"].HeaderText = "زمان ثبت";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xSendNumber"].HeaderText = " تعداد ارسالی  ";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.SendPiecesToProduct.csSendPiecesToProduct cs = new BLL.SendPiecesToProduct.csSendPiecesToProduct();
            cs.UdSendPiecesToProduct(dt_I);
            ShowDataGridView();
            Generate_I();
            MessageBox.Show("ارسال با موفقیت انجام شد");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
            {
                Validation.VDate v = new Validation.VDate();
                e.Cancel = !v.ValidationDate(e.FormattedValue.ToString());
            }
            else if (
                dataGridView1["xPieces_", e.RowIndex].Value != DBNull.Value &&
                dataGridView1.Columns[e.ColumnIndex].Name == "xSendNumber")
            {
                if (dataGridView1["xDate", e.RowIndex].Value == DBNull.Value)
                {
                    MessageBox.Show("مقدار تاریخ ثبت نشده");
                }
                else
                {

                    int iv = (int)dataGridView1["xPieces_", e.RowIndex].Value;
                    int iv1;
                    int.TryParse(dataGridView1["xSendNumber", e.RowIndex].EditedFormattedValue.ToString(), out iv1);
                    int cinv = new BLL.csInventory().fnStockPiecesCheck(Payazob.Properties.Settings.Default.WorkYear, iv);
                    if (dataGridView1["xSendNumber", e.RowIndex].EditedFormattedValue.ToString() == "" || iv1 == 0)
                    {
                        e.Cancel = false;

                    }
                    else if (cinv - iv1 < 0)
                    {
                        MessageBox.Show(cinv.ToString() + "  " + "حداکثر مقدار مجاز ");
                        e.Cancel = true;
                    }

                 
                }
            }

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();

        }
    }
}
