using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Test
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();

       
        }

        DAL.Test.DataSet_Test.mTest01DataTable dt_I;

        void ShowDataGridView()
        {
            dt_I = new BLL.Test.csTest().mTest();
            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dt_I;
            bindingNavigator1.BindingSource = bindingSource1;


        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        void Generate_I()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_I.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }



        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                base.Validate();
                this.dataGridView1.EndEdit();
                MessageBox.Show(new BLL.Test.csTest().UdTest(this.dt_I)
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ShowDataGridView();
                this.Generate_I();
                MessageBox.Show("ارسال با موفقیت انجام شد");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

         
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }



     


    }
}
