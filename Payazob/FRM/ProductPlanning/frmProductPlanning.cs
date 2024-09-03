using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ProductPlanning
{
    public partial class frmProductPlanning : Form
    {
        public frmProductPlanning(string Access, CS.csEnum.Factory FCT_)
        {
            InitializeComponent();
            fct = FCT_;

            if (fct == CS.csEnum.Factory.Site1)
                fct_P = CS.csEnum.GenFactoryGroupPieces.Site1;
            else
                fct_P = CS.csEnum.GenFactoryGroupPieces.Site3;

            access_ = Access;
            if (Access == "FULL")
            {
                dataGridView1.ReadOnly = false;
                dataGridView2.ReadOnly = false;
            }
            else if (Access == "REPORT")
            {
                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;

                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                saveToolStripButton.Enabled = false;

                uc_bindingNavigator3.Enabled = false;
            }

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csm.SlGenGroup("SHIP");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "شیفت";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xShiftObj_";
            combobox_Type_.Name = "cmb_Type";
            combobox_Type_.Width = 150;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Type_);


            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine1_.HeaderText = "نام قطعه";
            combobox_PiecesLine1_.DataSource = cs.mPiecesDataTable((int)fct_P);
            combobox_PiecesLine1_.DisplayMember = "xName";
            combobox_PiecesLine1_.ValueMember = "x_";
            combobox_PiecesLine1_.Name = "combobox_PiecesLine1_";
            combobox_PiecesLine1_.DataPropertyName = "xPieces_";
            combobox_PiecesLine1_.Visible = true;
            combobox_PiecesLine1_.MaxDropDownItems = 30;
            combobox_PiecesLine1_.Width = 220;
            combobox_PiecesLine1_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView2.Columns.Add(combobox_PiecesLine1_);

            DataGridViewComboBoxColumn dataGridViewColumn1 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("LINENAME3"),
                DisplayMember = "xName",
                HeaderText = "ایستگاه کاری ",
                ValueMember = "x_",
                Name = "xGenLINENAME3_",
                DataPropertyName = "xGenLINENAME3_",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView2.Columns.Add(dataGridViewColumn1);


            bindingSource1.DataSource = dt_P = new DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDataTable();
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            generate();

            bindingSource2.DataSource = dt_D = new DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDetialsDataTable();
            dataGridView2.DataSource = bindingSource2;
            uc_bindingNavigator3.BindingSource = bindingSource2;
            generate_D();

        }
        CS.csEnum.Factory fct;
        CS.csEnum.GenFactoryGroupPieces fct_P;

        string access_;

        void ShowData()
        {
            dt_P = new BLL.ProductPlanning.csProductPlanning().SlProductPlanning(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)fct);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            dt_P.xGenFactory_Column.DefaultValue = (int)fct;
            generate();
        }
        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xGenFactory_"].Visible = false;
            dataGridView1.Columns["cmb_Type"].DisplayIndex = 2;


        }

        void generate_D()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xProductPlanning_"].Visible = false;
            dataGridView2.Columns["xComment"].Width = 400;
            dataGridView2.Columns["xConfirm"].Width = 50;

            if (fct == CS.csEnum.Factory.Site1)
            {
                dataGridView2.Columns["xLineNumber"].Visible = true;
                dataGridView2.Columns["xGenLINENAME3_"].Visible = false;
            }
            else
            {
                dataGridView2.Columns["xLineNumber"].Visible = false;
                dataGridView2.Columns["xGenLINENAME3_"].Visible = true;
                dataGridView2.Columns["xConfirm"].Visible = false;
                dataGridView2.Columns["xCount"].HeaderText = "ساعت";
            }
        }


        DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDataTable dt_P;
        DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDetialsDataTable dt_D;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                BLL.ProductPlanning.csProductPlanning cs = new BLL.ProductPlanning.csProductPlanning();
                dt_D = cs.SlProductPlanningDetials((int?)dataGridView1["x_", e.RowIndex].Value);
                bindingSource2.DataSource = dt_D;
                dataGridView2.DataSource = bindingSource2;
                uc_bindingNavigator3.BindingSource = bindingSource2;
                dt_D.xProductPlanning_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.ProductPlanning.csProductPlanning cs = new BLL.ProductPlanning.csProductPlanning();
                MessageBox.Show(cs.UdProductPlanning(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
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
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                        dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex + 1, e.RowIndex];
                    }

                }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            PrintReport();
        }
        void PrintReport()
        {
            Report.SendReport csr = new Report.SendReport();
            frmReport r = new frmReport();
            csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            if (fct == CS.csEnum.Factory.Site1)
            {
                r.GetReport = csr.GetReport(new BLL.ProductPlanning.csProductPlanning().SlProductPlanning_Report(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)CS.csEnum.Factory.Site1),
                "crsPiecesProductPlan", new BLL.ProductPlanning.csProductPlanning().SlProductPlanningTotal_Report(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)CS.csEnum.Factory.Site1), "crsPiecesProductPlanTotal.rpt");
                r.ShowDialog();
                r.Dispose();
            } 
            else
            {
                r.GetReport = csr.GetReport(new BLL.ProductPlanning.csProductPlanning().SlProductPlanningMachinig_Report(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo),
                    "crsPiecesProductPlan_Machining");
                r.ShowDialog();
                r.Dispose();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.P):
                    PrintReport();
                    break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripButton15_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.ProductPlanning.csProductPlanning cs = new BLL.ProductPlanning.csProductPlanning();
                MessageBox.Show(cs.UdProductPlanningDetials(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton_ListOnNewForm_Click(object sender, EventArgs e)
        {
            Form f;
            f = new frmEmpty_Report("SlProductPlanningMachinig_Report", "");
            (f as frmEmpty_Report).ReportHaveDateDetails = true;
            (f as frmEmpty_Report).FilterDate = true;
            (f as frmEmpty_Report).FilterDateTo_Visible = true;
            (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
            f.ShowDialog();
        }
    }
}
