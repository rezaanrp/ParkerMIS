using System;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace Payazob.FRM.RequestItService
{
    public partial class frmRequestItService : Form
    {
        public frmRequestItService(string Se)
        {
            InitializeComponent();

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csm.SlGenGroup("ITPRB");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نوع درخواست";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xTypeProblem_";
            combobox_Type_.Name = "xTypeProblem_";
            //combobox_Type_.Width = 150;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Type_);


            DataGridViewComboBoxColumn combobox_Status_ = new DataGridViewComboBoxColumn();
            combobox_Status_.DataSource = csm.SlGenGroup("ITSTU");
            combobox_Status_.DisplayMember = "xName";
            combobox_Status_.HeaderText = "وضعیت در خواست";
            combobox_Status_.ValueMember = "x_";
            combobox_Status_.DataPropertyName = "xStatusProblem_";
            combobox_Status_.Name = "xStatusProblem_";
            //combobox_Status_.Width = 150;
            combobox_Status_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Status_);

            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 4;
            combobox_xSupplier_.HeaderText = "درخواست کننده";
            combobox_xSupplier_.DataSource = new BLL.authentication().NameOfUser();
            combobox_xSupplier_.DisplayMember = "NameAndFamily";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xUser_";
            combobox_xSupplier_.Name = "xUser_";
          //  combobox_xSupplier_.Width = 150;
            combobox_xSupplier_.ReadOnly = true;
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xSupplier_);

            DataGridViewComboBoxColumn combobox_1_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 4,
                HeaderText = "تایید کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xApprove_",
                Name = "xApprove_",
               // Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_1_);
            dt_R = new DAL.RequestITService.DataSet_RequestItService.mRequestItServiceDataTable();
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xUser_Column.DefaultValue = BLL.authentication.x_;
            try
            {
                string hn = Dns.GetHostName();
                dt_R.xHostNameColumn.DefaultValue = hn; // Retrive the Name of HOST
                dt_R.xUserIPColumn.DefaultValue = Dns.GetHostByName(hn).AddressList[0].ToString();
            }
            catch (Exception)
            {


            }


            Sec = Se;
            Generate(Sec);


        }
        string Sec;
        DAL.RequestITService.DataSet_RequestItService.mRequestItServiceDataTable dt_R;

        void Generate(string section)
        {
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_R.Columns)
            {
               
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_R.Columns[dc.ColumnName].Ordinal;
            }
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if(dr.Cells["xApprove"].Value != null && dr.Cells["xApprove"].Value != DBNull.Value && (bool)dr.Cells["xApprove"].Value == true)
                dr.DefaultCellStyle.BackColor = System.Drawing.Color.LemonChiffon;
            }
                if (section == "User")
            {
                dataGridView1.Columns["xSolution"].ReadOnly = true;
                dataGridView1.Columns["xDateSolution"].ReadOnly = true;
                dataGridView1.Columns["xStatusProblem_"].ReadOnly = true;
                dataGridView1.Columns["xApprove"].Visible = false;
                dataGridView1.AllowUserToDeleteRows = false;

                dataGridView1.Columns["xUserIP"].Visible = false;
                dataGridView1.Columns["xHostName"].Visible = false;
            }
            dataGridView1.Columns["xUserIP"].ReadOnly = true;
            dataGridView1.Columns["xHostName"].ReadOnly = true;

            dataGridView1.Columns["xDate"].ReadOnly = true;

            dataGridView1.Columns["xDescribeProblem"].HeaderText = "شرح درخواست";
            dataGridView1.Columns["xSolution"].HeaderText = "شرح اقدامات";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ درخواست";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید اتمام";
            dataGridView1.Columns["xUser_"].HeaderText = "نام کاربر";

            dataGridView1.Columns["xTypeProblem_"].HeaderText = " نوع درخواست";
            dataGridView1.Columns["xStatusProblem_"].HeaderText = "وضعیت در خواست ";
            dataGridView1.Columns["xApprove_"].HeaderText = "تایید کننده ";

            dataGridView1.Columns["xUserIP"].HeaderText = "IP";
            dataGridView1.Columns["xHostName"].HeaderText = "Host Name";

            dataGridView1.Columns["xDescribeProblem"].Width = 500;
            //dataGridView1.Columns["xSolution"].Width = 500;
            dataGridView1.Columns["xDateSolution"].HeaderText = "تاریخ اتمام ";

            dataGridView1.Columns["xDate"].Visible = true;
            dataGridView1.Columns["x_"].Visible = false;
            //dataGridView1.Columns["xUser_"].Visible = false;
            // dataGridView1.Columns["xApprove_"].Visible = false;
        }

        [Obsolete]
        void ShowDataGridView()
        {
            int x_ = -1;
            if (Sec == "User")
                x_ = BLL.authentication.x_;
            BLL.RequestItService.csRequestItService cs = new BLL.RequestItService.csRequestItService();
            dt_R = cs.RequestItService(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, x_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            dt_R.xApproveColumn.DefaultValue = false;
            dt_R.xUser_Column.DefaultValue = BLL.authentication.x_;
            try
            {
                string hn = Dns.GetHostName();
                dt_R.xHostNameColumn.DefaultValue = hn; // Retrive the Name of HOST
                dt_R.xUserIPColumn.DefaultValue = Dns.GetHostByName(hn).AddressList[0].ToString();
            }
            catch (Exception)
            {
                

            }
            Generate(Sec);
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                BLL.RequestItService.csRequestItService cs = new BLL.RequestItService.csRequestItService();


                MessageBox.Show(cs.UdRequestITService(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
                Generate(Sec);

                if (BLL.authentication.x_ == 51 || BLL.authentication.x_ == 144)
                {

                }
                else
                {
                    new BLL.Message.csMessage().SendMessage(BLL.authentication.x_, "درخواست خدمات IT", "شما یک دردرخواست در مورد خدمات IT دارید", BLL.csshamsidate.shamsidate, 51, false);
                    new BLL.Message.csMessage().SendMessage(BLL.authentication.x_, "درخواست خدمات IT", "شما یک دردرخواست در مورد خدمات IT دارید", BLL.csshamsidate.shamsidate, 144, false);
                }

                // new BLL.Message.csMessage().SendMessage(5, "درخواست خدمات IT", "شما یک دردرخواست در مورد خدمات IT دارید", BLL.csshamsidate.shamsidate, BLL.authentication.x_);
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xApprove")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xDateSolution", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xDateSolution", e.RowIndex].Value = DBNull.Value;

                }

            }
        }


    }
}
