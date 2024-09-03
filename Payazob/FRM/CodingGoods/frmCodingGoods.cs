using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.CodingGoods
{
    public partial class frmCodingGoods : Form
    {
        public frmCodingGoods(string Se)
        {
            InitializeComponent();
            DvgCmbLoad();
            dt_R = new DAL.CodingGoods.DataSet_CodingGoods.mCodingGoodsDataTable();
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            Sec = Se;
            Generate(Sec);//CODINGGOOD
        }
        string Sec;
        DAL.CodingGoods.DataSet_CodingGoods.mCodingGoodsDataTable dt_R;
        void DvgCmbLoad()
        {
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "درخواست کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xSupplier_);


            DataGridViewComboBoxColumn xGenStatus_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("CODINGGOOD"),
                DisplayMember = "xName",
                HeaderText = "وضعیت ",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "xGenStatus_",
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(xGenStatus_);

        }
        void Generate(string section)
        {
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                    dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_R.Columns[dc.ColumnName].Ordinal;
                }
            }
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;


            if (section == "User")
            {
                dataGridView1.Columns["xComment"].ReadOnly = true;
                dataGridView1.Columns["xSgCode"].ReadOnly = true;
                dataGridView1.Columns["xGenStatus_"].ReadOnly = true;
                dataGridView1.AllowUserToDeleteRows = false;
            }
            else if (section == "WareHouse")
            {
                dataGridView1.Columns["xComment"].ReadOnly = false;
                dataGridView1.Columns["xSgCode"].ReadOnly = false;
                dataGridView1.Columns["xGenStatus_"].ReadOnly = false;
                dataGridView1.AllowUserToDeleteRows = true;
            }
            dataGridView1.Columns["xDate"].ReadOnly = true;
            dataGridView1.Columns["xTime"].ReadOnly = true;
            dataGridView1.Columns["xGoodsDescription"].Width = 200;
            dataGridView1.Columns["xComment"].Width = 300;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSendMessage"].Visible = false;


        }
        void ShowDataGridView()
        {
            int x_ = -1;
            if (Sec == "User")
            {
                x_ = BLL.authentication.x_;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["xGenStatus_"].Value == DBNull.Value || item.Cells["xGenStatus_"].Value == null)
                    {
                        item.DefaultCellStyle.BackColor = Color.MediumOrchid;
                    }
                }
            }
            BLL.CodingGoods.csCodingGoods cs = new BLL.CodingGoods.csCodingGoods();
            dt_R = cs.mCodingGoods(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, x_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            Generate(Sec);

            if (Sec == "WareHouse")
            {
                foreach (DataRow item in dt_R.Rows)
                {
                    if (item["xGenStatus_"] == DBNull.Value || item["xGenStatus_"] == null)
                        item["xGenStatus_"] = 245;
                }
                new BLL.CodingGoods.csCodingGoods().UdCodingGoods(dt_R);

            }

        }
        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                SendMessageData(306);

                BLL.CodingGoods.csCodingGoods cs = new BLL.CodingGoods.csCodingGoods();
                MessageBox.Show(cs.UdCodingGoods(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
                Generate(Sec);
            }
        }
        void SendMessageData(int Object_)
        {
            foreach (DataRow item in dt_R.Rows)
            {
                if (
                    item["xSgCode"] != null &&
                    item["xSgCode"] != DBNull.Value &&
                    item["xGenStatus_"] != null &&
                    item["xGenStatus_"] != DBNull.Value &&
                    (int)item["xGenStatus_"] != 246
                   )
                    if (item["xSendMessage"] == DBNull.Value || item["xSendMessage"] == null)
                    {
                        string st = "با سلام";
                        st += "\n ";
                        st += "درخواست شما برای ساخت کد  کالا به شرح";
                        st += "\t ";
                        st += item["xGoodsDescription"].ToString();
                        st += "\t ";
                        st += "با کد ";
                        st += "\t ";
                        st += item["xSgCode"].ToString();
                        st += "\n ";
                        st += "تکمیل گردید";
                        st += "\n ";
                        st += "\n ";
                        st += "\n ";
                        st += "با تشکر ";
                        new BLL.Message.csMessage().SendMessage(57, " وضعیت درخواست ایجاد کدکالا", st, BLL.csshamsidate.shamsidate, (int)item["xSupplier_"], false);
                        item["xSendMessage"] = true;
                        item["xGenStatus_"] = 246;
                    }
            }
        }
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex < 0)
            //    return;

            //if (dataGridView1.Columns[e.ColumnIndex].Name == "xApprove")
            //{
            //    if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
            //    {
            //        dataGridView1["xApprove_", e.RowIndex].Value = BLL.authentication.x_;
            //        dataGridView1["xDateSolution", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
            //    }
            //    else
            //    {
            //        dataGridView1["xApprove_", e.RowIndex].Value = DBNull.Value;
            //        dataGridView1["xDateSolution", e.RowIndex].Value = DBNull.Value;

            //    }

            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
