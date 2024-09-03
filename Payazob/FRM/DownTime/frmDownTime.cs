using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.DownTime
{
    public partial class frmDownTime : Form
    {
        public frmDownTime()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 2,
                HeaderText = "نام دستگاه",
                DataSource = new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site3),
                DisplayMember = "CodeName",
                ValueMember = "x_",
                DataPropertyName = "xMachine_",
                Name = "xMachine_",
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView2.Columns.Add(column2);

            BLL.MoldingDownTime.MoldingDownTime time = new BLL.MoldingDownTime.MoldingDownTime();
            DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 0,
                HeaderText = "نوع توقف",
                DataSource = time.SelectMoldingDownTimeType((int)CS.csEnum.Factory.Site3, false),
                DisplayMember = "NameAndCode",
                ValueMember = "x_",
                DataPropertyName = "xDownTimeType_",
                Name = "xDownTimeType_",
                MaxDropDownItems = 20,
                Width = 250,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView3.Columns.Add(column3);

            uc_Month1.Mo = int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2));
            uc_Month1.Ye = int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4));
            uc_Month1.GenBtn();

            //   DataTable dts = new BLL.DayHourPlanning.csDayHourPlanning().SlDayHourPlanning(uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + "01", uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo.ToString() : uc_Month1.Mo.ToString()) + "/" + "31");
            string sta = "";
            //foreach (DataRow drs in dts.Rows)
            //{
            //    sta += "*" + int.Parse(drs["xDate"].ToString().Substring(8, 2)).ToString(); ;
            //}

            uc_Month1.GenColor(sta.Split('*'), Color.HotPink);

            dataGridView1.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SHI");

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xType"].Visible = false;
            dataGridView1.Columns["xName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




            uc_Month1.ChangeMonthActive = true;
            formFunctionPointerchmon += new functioncallchmon(chmon);
            uc_Month1.ChangeMonth = formFunctionPointerchmon;

            //------------------------------------------------------

            uc_Month1.ClickActive = true;
            formFunctionPointerClick += new functioncallClick(uc_Mounth_Click);
            uc_Month1.userFunctionPointer = formFunctionPointerClick;
            this.frmT = new frmMoldingDownTimeType(true, Payazob.CS.csEnum.TypeTree.DownTimeType, CS.csEnum.Factory.Site3);


        }

        public delegate void functioncallchmon();

        private event functioncallchmon formFunctionPointerchmon;

        private void chmon()
        {
            //DataTable dts = new BLL.DayHourPlanning.csDayHourPlanning().SlDayHourPlanning(uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + "01", uc_Month1.Ye + "/" + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo : uc_Month1.Mo.ToString()) + "/" + "31");
            //dts = dts.DefaultView.ToTable(true, "xDate");
            //string sta = "";
            //foreach (DataRow drs in dts.Rows)
            //{
            //    sta += "*" + int.Parse(drs["xDate"].ToString().Substring(8, 2)).ToString(); ;
            //}

            //uc_Month1.GenColor(sta.Split('*'), Color.HotPink);
        }

        public delegate void functioncallClick(string Date);

        private event functioncallClick formFunctionPointerClick;
        string datefromuc = "";
        private void uc_Mounth_Click(string Date)
        {
            datefromuc = Date;
            ShowDataGridView(Date, Date);
        }

        DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDataTable dt_D;
        DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDetailsDataTable dt_DD;

        void ShowDataGridView(string DateFrom, string DateTo)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                dt_D = new BLL.MoldingDownTime.MoldingDownTime().SelectMoldingDownTime(DateFrom, DateTo, (int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                if (dt_D.Rows.Count < 1)
                {
                    DataTable dt_temp = new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site3);
                    foreach (DataRow item in dt_temp.Rows)
                    {
                        DataRow drr = dt_D.NewRow();
                        drr["xDate"] = datefromuc;
                        drr["xGenShift_"] = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
                        drr["xMachine_"] = item["x_"];
                        dt_D.Rows.Add(drr);
                    }

                }
                bindingSource2.DataSource = dt_D;
                dataGridView2.DataSource = bindingSource2;
                bindingNavigator2.BindingSource = bindingSource2;
                Generate();
            }
        }
        void ShowDataGridView3(int x_)
        {

            dt_DD = new BLL.MoldingDownTime.MoldingDownTime().SelectMoldingDownTimeDetials(x_);
            bindingSource1.DataSource = dt_DD;
            dataGridView3.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_DD.Columns["xDownTime_"].DefaultValue = x_;
            Generate3();

        }



        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView2.Columns["xWorking"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xDate"].Visible = false;
            dataGridView2.Columns["xGenShift_"].Visible = false;
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
              if(item.Cells["xWorking"].Value != DBNull.Value &&   (bool)item.Cells["xWorking"].Value == true)
                {
                    item.DefaultCellStyle.BackColor = Color.Aqua;
                }
            }

        }
        void Generate3()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_DD.Columns)
            {
                dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView3.Columns[dc.ColumnName].DisplayIndex = dt_DD.Columns[dc.ColumnName].Ordinal;

            }
            dataGridView3.Columns["x_"].Visible = false;
            dataGridView3.Columns["xDownTime_"].Visible = false;

            dataGridView3.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
           new BLL.MoldingDownTime.MoldingDownTime().UdMoldingDownTime(dt_D);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGridView(datefromuc, datefromuc);


        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                ShowDataGridView3((int)dataGridView2["x_", e.RowIndex].Value);
            }
        }

        private void toolStripButton_Save_DD_Click(object sender, EventArgs e)
        {
            this.dataGridView3.EndEdit();
            this.Validate();
           new BLL.MoldingDownTime.MoldingDownTime().UdMoldingDownTimeDetials(dt_DD);
        }
        frmMoldingDownTimeType frmT;// = new frmMoldingDownTimeType(true, CS.csEnum.TypeTree.DownTimeType);

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.frmT.tyfrm = CS.csEnum.TypeForm.InputForm;
            this.frmT.StartPosition = FormStartPosition.CenterParent;
            this.frmT.Node_x_ = -1;
            this.frmT.ShowDialog();
            if (this.frmT.IsUpdate)
            {
                BLL.MoldingDownTime.MoldingDownTime time = new BLL.MoldingDownTime.MoldingDownTime();
                (this.dataGridView3.Columns["xDownTimeType_"] as DataGridViewComboBoxColumn).DisplayIndex = 0;
                (this.dataGridView3.Columns["xDownTimeType_"] as DataGridViewComboBoxColumn).DataSource = time.SelectMoldingDownTimeType((int)CS.csEnum.Factory.Site3, true);
                (this.dataGridView3.Columns["xDownTimeType_"] as DataGridViewComboBoxColumn).DisplayMember = "xNameDownTime";
                (this.dataGridView3.Columns["xDownTimeType_"] as DataGridViewComboBoxColumn).ValueMember = "x_";
                (this.dataGridView3.Columns["xDownTimeType_"] as DataGridViewComboBoxColumn).DataPropertyName = "xDownTimeType_";
            }
            if (this.frmT.Node_x_ != -1)
            {
                this.dataGridView3["xDownTimeType_", e.RowIndex].Value = this.frmT.Node_x_;
            }
        }
    }
}