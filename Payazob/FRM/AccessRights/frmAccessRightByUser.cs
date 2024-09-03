using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.AccessRights
{
    public partial class frmAccessRightByUser : Form
    {
        public frmAccessRightByUser()
        {
            InitializeComponent();
            ShowData1();
        }
        DAL.DataSet_Authentication.SlObjectAllowByUser_DataTable dt_I;
        private void btn_Show_Click(object sender, EventArgs e)
        {

        }
        void ShowData1()
        {
            BLL.User cs = new BLL.User();
            dataGridView1.DataSource = cs.SelectUserPorfile();

            dataGridView1.Columns["Family"].HeaderText = "نام و نام خانوادگی";
            dataGridView1.Columns["SectionName"].HeaderText = "نام قسمت";

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xUserName"].Visible = false;
            dataGridView1.Columns["xSection_"].Visible = false;
            dataGridView1.Columns["SectionName"].Width = 150;
            dataGridView1.Columns["Family"].Width = 150;


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int x = (int)dataGridView1["x_", e.RowIndex].Value;
                ShowDataDetails(x);
            }
        }
        void ShowDataDetails(int xUser_)
        {
            dt_I = new BLL.authentication().SlObjectAllowByUser_(xUser_);
            bindingSource2.DataSource = dt_I;
            dataGridView2.DataSource = bindingSource2;
            uc_bindingNavigator2.BindingSource = bindingSource2;
            dataGridView2.Columns["xObjectFarsiName"].Width = 330;
            dataGridView2.Columns["x_"].Visible = false;

            dataGridView2.Columns["xObjectFarsiName"].HeaderText = "نام فرم ";
            dataGridView2.Columns["xObjectType"].HeaderText = "نوع فرم ";


        }
        private void toolStripButton_Save_D_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView2.EndEdit();
                MessageBox.Show(new BLL.authentication().UdObjectAllowByUser_(dt_I),
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
