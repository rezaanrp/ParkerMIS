﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Payazob.FRM.PersonInfo
{
    public partial class frmPersonInfo : Form
    {
        public frmPersonInfo(bool ReadOnlyForm, string TypeForm)
        {

            InitializeComponent();


            TypFrm = TypeForm;
            if (ReadOnlyForm)
            {
                dataGridView1.ReadOnly = true;
                bindingNavigator1.Enabled = false;
            }
            rdf = ReadOnlyForm;

            uc_txtBoxName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xName", true));
            uc_txtBox_xFamily.DataBindings.Add(new Binding("Text", this.bindingSource1, "xFamily", true));
            uc_txtBox_xIdentity.DataBindings.Add(new Binding("Text", this.bindingSource1, "xIdentity", true));
            uc_txtBox_xMob.DataBindings.Add(new Binding("Text", this.bindingSource1, "xMob", true));
            uc_txtBox_xNationalCode.DataBindings.Add(new Binding("Text", this.bindingSource1, "xNationalCode", true));
            uc_txtBox_xPerID.DataBindings.Add(new Binding("Text", this.bindingSource1, "xPerID", true));
            uc_txtBox_xTel.DataBindings.Add(new Binding("Text", this.bindingSource1, "xTel", true));
            uc_txtBox_FatherName.DataBindings.Add(new Binding("Text", this.bindingSource1, "xFatherName", true));
            uc_txtBox_xAddress.DataBindings.Add(new Binding("Text", this.bindingSource1, "xAddress", true));
            uc_txtBox_xEmail.DataBindings.Add(new Binding("Text", this.bindingSource1, "xEmail", true));

            cmb_Section.DataBindings.Add(new Binding("SelectedValue", this.bindingSource1, "xSection_", true));
            cmb_Sex.DataBindings.Add(new Binding("SelectedValue", this.bindingSource1, "xSex_", true));
            chb_xActive.DataBindings.Add(new Binding("CheckState", this.bindingSource1, "xActive", true));

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Sex_ = new DataGridViewComboBoxColumn();
            combobox_Sex_.DataSource = csm.SlGenGroup("SEX");
            combobox_Sex_.DisplayMember = "xName";
            combobox_Sex_.HeaderText = "جنسیت";
            combobox_Sex_.ValueMember = "x_";
            combobox_Sex_.DataPropertyName = "xSex_";
            combobox_Sex_.Name = "xSex_";
            combobox_Sex_.Width = 100;
            combobox_Sex_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Sex_);

            DataGridViewComboBoxColumn xGenHSEWarningType_ = new DataGridViewComboBoxColumn();
            xGenHSEWarningType_.DataSource = csm.SlGenGroup("HSEW");
            xGenHSEWarningType_.DisplayMember = "xName";
            xGenHSEWarningType_.HeaderText = "xGenHSEWarningType_";
            xGenHSEWarningType_.ValueMember = "x_";
            xGenHSEWarningType_.DataPropertyName = "xGenHSEWarningType_";
            xGenHSEWarningType_.Name = "xGenHSEWarningType_";
            xGenHSEWarningType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(xGenHSEWarningType_);

            DataGridViewComboBoxColumn combobox_Section_ = new DataGridViewComboBoxColumn();
            combobox_Section_.DataSource = csm.SlGenGroup("SEC");
            combobox_Section_.DisplayMember = "xName";
            combobox_Section_.HeaderText = "قسمت";
            combobox_Section_.ValueMember = "x_";
            combobox_Section_.DataPropertyName = "xSection_";
            combobox_Section_.Name = "xSection_";
            combobox_Section_.Width = 100;
            combobox_Section_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Section_);


            DataGridViewComboBoxColumn combobox_EDU_ = new DataGridViewComboBoxColumn();
            combobox_EDU_.DataSource = csm.SlGenGroup("EDU");
            combobox_EDU_.DisplayMember = "xName";
            combobox_EDU_.HeaderText = "تحصیلات";
            combobox_EDU_.ValueMember = "x_";
            combobox_EDU_.DataPropertyName = "xEducation_";
            combobox_EDU_.Name = "xEducation_";
            combobox_EDU_.Width = 100;
            combobox_EDU_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_EDU_);


            cmb_Section.DataSource = csm.SlGenGroup("SEC");
            cmb_Section.DisplayMember = "xName";
            cmb_Section.ValueMember = "x_";

            cmb_Sex.DataSource = csm.SlGenGroup("SEX");
            cmb_Sex.DisplayMember = "xName";
            cmb_Sex.ValueMember = "x_";

            dt_P = new DAL.Person.DataSet_PersonInfo.SlPersonInfoDataTable();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_P.xActiveColumn.DefaultValue = true;


        }
        bool rdf = false;
        string TypFrm = "";
        void ShowData()
        {

            BLL.Person.csPersonInfo cs = new BLL.Person.csPersonInfo();
            dt_P = cs.SlPersonInfo("$$", "$");
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_P.xActiveColumn.DefaultValue = true;

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_P.Columns[dc.ColumnName].Ordinal;

            }
            dataGridView1.Columns["xName"].HeaderText = "نام";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xFamily"].HeaderText = "نام خانوادگی";
            dataGridView1.Columns["xAddress"].Width = 350;

            //dataGridView1.Columns["Sex_"].DisplayIndex = 15;
            //dataGridView1.Columns["xSection_"].DisplayIndex = dataGridView1.Columns["xPost"].DisplayIndex;

            dataGridView1.Columns["xBirthDay"].DisplayIndex = 10;
            dataGridView1.Columns["xDateEmployeement"].DisplayIndex = 10;


            if (TypFrm == "PerPhone")
            {
                splitContainer1.Panel2Collapsed = true;
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.Name == "xName" || item.Name == "xFamily" || item.Name == "xSection_" || item.Name == "xMob")
                    {
                        item.Visible = true;
                        item.ReadOnly = true;
                    }
                    else
                        item.Visible = false;

                }

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["xSex_"].Value == DBNull.Value || item.Cells["xActive"].Value == DBNull.Value)
                    {
                        item.Visible = false;
                    }
                    else if (!item.IsNewRow && (int)item.Cells["xSex_"].Value == 57)
                    {
                        item.Visible = false;
                    }

                    else if (!item.IsNewRow && (bool)item.Cells["xActive"].Value == false)
                    {
                        item.Visible = false;
                    }

                }
            }


        }
        void LastEnter()
        {
            if (TypFrm == "Man")
                try
                {
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (item.Cells["xPerID"].Value != null)
                        {
                            string te = item.Cells["xPerID"].Value.ToString();

                            double n = 0;
                            bool isNumeric = double.TryParse(te, out n);
                            string dt_st = new BLL.OverTime.csOverTime().OverTimeIOLastEnter(n);
                            item.Cells["dvg_LastEnter"].Value = dt_st;
                            int dt_st_m_c = int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2));
                            if (dt_st != "*")
                            {
                                int dt_st_m_l = int.Parse(dt_st.Substring(5, 2));
                                if (dt_st_m_c > dt_st_m_l && dt_st_m_c - dt_st_m_l > 0)
                                    item.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                            }
                        }
                    }
                }
                catch (Exception)
                {


                }

        }
        DAL.Person.DataSet_PersonInfo.SlPersonInfoDataTable dt_P;
        Stack<int> dvg_ind = new Stack<int>();
        private void frmPersonInfo_Load(object sender, EventArgs e)
        {

            ShowData();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool?)item.Cells["xActive"].Value != true)
                    item.DefaultCellStyle.BackColor = Color.Pink;

                if (item.Cells["xPerID"].Value == DBNull.Value || item.Cells["xPerID"].Value == null)
                    item.DefaultCellStyle.BackColor = Color.Red;


            }
            // LastEnter();
            Thread thread_LastEnter = new Thread(new ThreadStart(LastEnter));
            thread_LastEnter.Start();
            //chb_xActive.Checked = true;
            //cmb_Section.SelectedValue
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (!rdf)
            {
                this.dataGridView1.EndEdit();
                this.Validate();
                if (new CS.csMessage().ShowMessageSaveYesNo())
                {
                    BLL.Person.csPersonInfo cs = new BLL.Person.csPersonInfo();

                    MessageBox.Show(cs.UdPersonInfo(dt_P));
                    ShowData();
                }
            }
        }
        private void uc_txtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
            else
            {
                dvg_ind.Clear();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Selected = false;
                }


                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    foreach (DataGridViewCell itemCell in item.Cells)
                    {

                        if (
                            itemCell.ColumnIndex < 8 &&
                            itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null &&
                            (itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text) ||
                             itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ی', 'ي')) ||
                              itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ي', 'ی')) ||
                               itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ک', 'ك')) ||
                                itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ك', 'ک')))
                            )
                        {

                            dvg_ind.Push(item.Index);
                            break;
                            //return;
                        }
                    }
                }
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
            ///////////////////////////
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
