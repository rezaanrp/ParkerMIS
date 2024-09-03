using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.ExitPermit
{
    public partial class frmExitPermit : Form
    {
        public frmExitPermit(string section_)
        {
            Se = section_;
            InitializeComponent();
            splitContainer5.Panel2Collapsed = true;

            dt_E = new DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitDataTable();
            GenComboBoxColumn();
            bindingSource1.DataSource = dt_E;
            dt_E.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();


            uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            uc_DataGridViewBtn1.Ds = new BLL.csCompony().SelectCompony();

            uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
                                                            "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;


            uc_DataGridViewBtn2.ColumnsFilter_ = "xMaterialName";
            uc_DataGridViewBtn2.Ds = new BLL.csMaterial().SlMaterial("$", (int)CS.csEnum.MaterilaType.hamkaransystem);

            uc_DataGridViewBtn2.ParamName = new string[] { "xMaterialName" };
            uc_DataGridViewBtn2.ParamValue = new string[] { "نام کالا" };
            uc_DataGridViewBtn2.ParamHide = new string[] { "x_"};

            formFunctionPointer2 += new functioncall2(Replicate2);
            uc_DataGridViewBtn2.userFunctionPointer = formFunctionPointer2;

            if (Se == "US")
                this.Text = "درخواست مجوز خروج";
            else if (Se == "BS")
                this.Text = "تایید مجوز خروج کالا مدیریت کارخانه";

            else if (Se == "SC")
                this.Text = "تایید مجوز خروج کالا - انتظامات";

            else if (Se == "MN")
                this.Text = "تایید مجوز خروج کالا مدیریت";

            else if (Se == "IN")
                this.Text = "تایید مجوز خروج کالا انبار";
        }

        DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitDataTable dt_E;
        DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitBackDataTable dt_P_D;


        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xCompany_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }

        public delegate void functioncall2(string Display, string value);

        private event functioncall2 formFunctionPointer2;

        private void Replicate2(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xMaterial_", uc_DataGridViewBtn2.RI].Value = int.Parse(value);
            }
        }
        void GenComboBoxColumn()
        {
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.csCompony().SelectCompony(),
                DisplayMember = "xComponyName",
                ValueMember = "x_",
                DataPropertyName = "xCompany_",
                Name = "xCompany_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            this.dataGridView1.Columns.Add(column2);

            DataGridViewComboBoxColumn combobox_xMaterial_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.csMaterial().SlMaterial("$", (int)CS.csEnum.MaterilaType.hamkaransystem),
                DisplayMember = "xMaterialName",
                ValueMember = "x_",
                Name = "xMaterial_",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                Width = 150,
                ReadOnly = true,
                DataPropertyName = "xMaterial_"
            };
            dataGridView1.Columns.Add(combobox_xMaterial_);

            DataGridViewComboBoxColumn combobox_xModule_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.Module.Module().SelectMudole(),
                DisplayMember = "xModuleName",
                ValueMember = "x_",
                Name = "xModule_",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                DataPropertyName = "xModule_"
            };
            dataGridView1.Columns.Add(combobox_xModule_);

            DataGridViewComboBoxColumn combobox_xGenExitType_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("EXITTYPE"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenExitType_",
                Name = "xGenExitType_",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xGenExitType_);

            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn()
            {
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


            DataGridViewComboBoxColumn combobox_xManager_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xManager_",
                Name = "xManager_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xManager_);

            DataGridViewComboBoxColumn combobox_xSecuritySection_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSecuritySection_",
                Name = "xSecuritySection_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xSecuritySection_);


            DataGridViewComboBoxColumn combobox_xBoss_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xBoss_",
                Name = "xBoss_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xBoss_);

            DataGridViewComboBoxColumn combobox_xConfirmBackSupplier_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xConfirmBackSupplier_",
                Name = "xConfirmBackSupplier_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xConfirmBackSupplier_);

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();

            if (Se == "US")
                dt_E = cs.SlExitPermit(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, BLL.authentication.x_, -1);
            else
                dt_E = cs.SlExitPermit(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1, -1);

            bindingSource1.DataSource = dt_E;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        string Se = "";

        bool Dtable(string Cl, string Ty)
        {
            DataTable dt_AC = new DataTable();

            dt_AC.Columns.Add("Name", typeof(String));
            dt_AC.Columns.Add("Type", typeof(String));
            dt_AC.Columns.Add("Allow", typeof(bool));

            
            dt_AC.Rows.Add("x_", "US", true);
            dt_AC.Rows.Add("xDate", "US", true);
            dt_AC.Rows.Add("xType", "US", true);
            dt_AC.Rows.Add("xAmount", "US", true);
            dt_AC.Rows.Add("xModule_", "US", true);
            dt_AC.Rows.Add("xReceiver", "US", true);
            dt_AC.Rows.Add("xDateReturn", "US", true);
            dt_AC.Rows.Add("xOutCause", "US", true);
            dt_AC.Rows.Add("xInventorConfirm", "US", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "US", false);
            dt_AC.Rows.Add("xManagerConfirm", "US", false);
            dt_AC.Rows.Add("xBossConfirm", "US", false);
            dt_AC.Rows.Add("xReceiver", "US", false);
            dt_AC.Rows.Add("xSupplier_", "US", true);
            dt_AC.Rows.Add("xSupplierDate", "US", true);
            dt_AC.Rows.Add("xSupplierTime", "US", true);
            dt_AC.Rows.Add("Supplier", "US", true);
            dt_AC.Rows.Add("xSection_", "US", true);
            dt_AC.Rows.Add("xManager_", "US", true);
            dt_AC.Rows.Add("xManagerConfirm", "US", false);
            dt_AC.Rows.Add("xSecuritySection_", "US", false);
            dt_AC.Rows.Add("SecuritySection", "US", false);
            dt_AC.Rows.Add("xManager_", "US", false);
            dt_AC.Rows.Add("Manager", "US", false);
            dt_AC.Rows.Add("xBoss_", "US", false);
            dt_AC.Rows.Add("Boss", "US", false);
            dt_AC.Rows.Add("xConfirmBack", "US", false);
            dt_AC.Rows.Add("xConfirmBackSupplier_", "US", false);
            dt_AC.Rows.Add("xConfirmBackDate", "US", false);
            dt_AC.Rows.Add("xConfirmBackTime", "US", false);
            dt_AC.Rows.Add("xManagerComment", "US", false);
            dt_AC.Rows.Add("xReturnAmount", "US", false);


            dt_AC.Rows.Add("x_", "IN", false);
            dt_AC.Rows.Add("xDate", "IN", true);
            dt_AC.Rows.Add("xType", "IN", true);
            dt_AC.Rows.Add("xAmount", "IN", true);
            dt_AC.Rows.Add("xModule_", "IN", true);
            dt_AC.Rows.Add("xReceiver", "IN", true);
            dt_AC.Rows.Add("xDateReturn", "IN", true);
            dt_AC.Rows.Add("xOutCause", "IN", true);
            dt_AC.Rows.Add("xInventorConfirm", "IN", true);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "IN", false);
            dt_AC.Rows.Add("xManagerConfirm", "IN", false);
            dt_AC.Rows.Add("xBossConfirm", "IN", false);
            dt_AC.Rows.Add("xReceiver", "IN", false);
            dt_AC.Rows.Add("xSupplier_", "IN", true);
            dt_AC.Rows.Add("xSupplierDate", "IN", true);
            dt_AC.Rows.Add("xSupplierTime", "IN", true);
            dt_AC.Rows.Add("Supplier", "IN", true);
            dt_AC.Rows.Add("xSection_", "IN", true);
            dt_AC.Rows.Add("xManager_", "IN", false);
            dt_AC.Rows.Add("xManagerConfirm", "IN", false);
            dt_AC.Rows.Add("xSecuritySection_", "IN", false);
            dt_AC.Rows.Add("SecuritySection", "IN", false);
            dt_AC.Rows.Add("xManager_", "IN", false);
            dt_AC.Rows.Add("Manager", "IN", false);
            dt_AC.Rows.Add("xBoss_", "IN", false);
            dt_AC.Rows.Add("Boss", "IN", false);
            dt_AC.Rows.Add("xConfirmBack", "IN", false);
            dt_AC.Rows.Add("xConfirmBackSupplier_", "IN", false);
            dt_AC.Rows.Add("xConfirmBackDate", "IN", false);
            dt_AC.Rows.Add("xConfirmBackTime", "IN", false);
            dt_AC.Rows.Add("xManagerComment", "IN", false);
            dt_AC.Rows.Add("xReturnAmount", "IN", false);


            dt_AC.Rows.Add("x_", "MN", false);
            dt_AC.Rows.Add("xDate", "MN", true);
            dt_AC.Rows.Add("xType", "MN", true);
            dt_AC.Rows.Add("xAmount", "MN", true);
            dt_AC.Rows.Add("xModule_", "MN", true);
            dt_AC.Rows.Add("xReceiver", "MN", false);
            dt_AC.Rows.Add("xDateReturn", "MN", true);
            dt_AC.Rows.Add("xReceiver", "MN", false);
            dt_AC.Rows.Add("xOutCause", "MN", true);
            dt_AC.Rows.Add("xInventorConfirm", "MN", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "MN", false);
            dt_AC.Rows.Add("xManagerConfirm", "MN", true);
            dt_AC.Rows.Add("xBossConfirm", "MN", false);
            dt_AC.Rows.Add("xSupplier_", "MN", true);
            dt_AC.Rows.Add("Supplier", "MN", true);
            dt_AC.Rows.Add("xSupplierDate", "MN", true);
            dt_AC.Rows.Add("xSupplierTime", "MN", true);
            dt_AC.Rows.Add("xSection_", "MN", true);
            dt_AC.Rows.Add("xManager_", "MN", true);
            dt_AC.Rows.Add("xManagerConfirm", "MN", false);
            dt_AC.Rows.Add("xSecuritySection_", "MN", false);
            dt_AC.Rows.Add("SecuritySection", "MN", false);
            dt_AC.Rows.Add("xManager_", "MN", false);
            dt_AC.Rows.Add("Manager", "MN", true);
            dt_AC.Rows.Add("xBoss_", "MN", false);
            dt_AC.Rows.Add("Boss", "MN", false);
            dt_AC.Rows.Add("xConfirmBack", "MN", false);
            dt_AC.Rows.Add("xConfirmBackSupplier_", "MN", false);
            dt_AC.Rows.Add("xConfirmBackDate", "MN", false);
            dt_AC.Rows.Add("xConfirmBackTime", "MN", false);
            dt_AC.Rows.Add("xManagerComment", "MN", true);
            dt_AC.Rows.Add("xReturnAmount", "MN", false);

            dt_AC.Rows.Add("x_", "BS", false);
            dt_AC.Rows.Add("xDate", "BS", true);
            dt_AC.Rows.Add("xType", "BS", true);
            dt_AC.Rows.Add("xAmount", "BS", true);
            dt_AC.Rows.Add("xModule_", "BS", true);
            dt_AC.Rows.Add("xReceiver", "BS", false);

            dt_AC.Rows.Add("xReceiver", "BS", false);
            dt_AC.Rows.Add("xDateReturn", "BS", true);
            dt_AC.Rows.Add("xOutCause", "BS", true);
            dt_AC.Rows.Add("xInventorConfirm", "BS", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "BS", false);
            dt_AC.Rows.Add("xManagerConfirm", "BS", false);
            dt_AC.Rows.Add("xBossConfirm", "BS", true);
            dt_AC.Rows.Add("xSupplier_", "BS", true);
            dt_AC.Rows.Add("xSupplierDate", "BS", true);
            dt_AC.Rows.Add("xSupplierTime", "BS", true);
            dt_AC.Rows.Add("Supplier", "BS", true);
            dt_AC.Rows.Add("xSection_", "BS", true);
            dt_AC.Rows.Add("xManager_", "BS", true);
            dt_AC.Rows.Add("xManagerConfirm", "BS", false);
            dt_AC.Rows.Add("xSecuritySection_", "BS", false);
            dt_AC.Rows.Add("SecuritySection", "BS", false);
            dt_AC.Rows.Add("xBoss_", "BS", false);
            dt_AC.Rows.Add("Boss", "BS", true);
            dt_AC.Rows.Add("xConfirmBack", "BS", false);
            dt_AC.Rows.Add("xConfirmBackSupplier_", "BS", false);
            dt_AC.Rows.Add("xConfirmBackDate", "BS", false);
            dt_AC.Rows.Add("xConfirmBackTime", "BS", false);
            dt_AC.Rows.Add("xManagerComment", "BS", true);
            dt_AC.Rows.Add("xReturnAmount", "BS", false);

            dt_AC.Rows.Add("x_", "SC", false);
            dt_AC.Rows.Add("xDate", "SC", true);
            dt_AC.Rows.Add("xCode", "SC", true);
            dt_AC.Rows.Add("xMaterial", "SC", true);
            dt_AC.Rows.Add("xType", "SC", true);
            dt_AC.Rows.Add("xAmount", "SC", true);
            dt_AC.Rows.Add("xModule_", "SC", true);
            dt_AC.Rows.Add("xReceiver", "SC", false);

            dt_AC.Rows.Add("xReceiver", "SC", false);
            dt_AC.Rows.Add("xDateReturn", "SC", true);
            dt_AC.Rows.Add("xOutCause", "SC", true);
            dt_AC.Rows.Add("xInventorConfirm", "SC", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "SC", true);
            dt_AC.Rows.Add("xManagerConfirm", "SC", false);
            dt_AC.Rows.Add("xBossConfirm", "SC", false);
            dt_AC.Rows.Add("xSupplier_", "SC", true);
            dt_AC.Rows.Add("xSupplierDate", "SC", true);
            dt_AC.Rows.Add("xSupplierTime", "SC", true);
            dt_AC.Rows.Add("Supplier", "SC", true);
            dt_AC.Rows.Add("xSection_", "SC", true);
            dt_AC.Rows.Add("xManager_", "SC", true);
            dt_AC.Rows.Add("xManagerConfirm", "SC", false);
            dt_AC.Rows.Add("xManagerComment", "SC", false);
            dt_AC.Rows.Add("xSecuritySection_", "SC", false);
            dt_AC.Rows.Add("SecuritySection", "SC", false);
            dt_AC.Rows.Add("xManager_", "SC", false);
            dt_AC.Rows.Add("Manager", "SC", true);
            dt_AC.Rows.Add("xBoss_", "SC", false);
            dt_AC.Rows.Add("Boss", "SC", true);
            dt_AC.Rows.Add("xConfirmBack", "SC", true);
            dt_AC.Rows.Add("xConfirmBackSupplier_", "SC", false);
            dt_AC.Rows.Add("xConfirmBackDate", "SC", false);
            dt_AC.Rows.Add("xConfirmBackTime", "SC", false);
            dt_AC.Rows.Add("xReturnAmount", "SC", false);

            DataRow[] dr = dt_AC.Select("Name = '" + Cl + "' AND Type = '" + Ty + "'");
            if (dr.Length > 0)
                return (bool)dr[0]["Allow"];
            else
                return true;

        }

        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_E.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].Visible = Dtable(dc.ColumnName, Se);
                dataGridView1.Columns[dc.ColumnName].DisplayIndex = dt_E.Columns[dc.ColumnName].Ordinal;
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dt_E.xManagerConfirmColumn.DefaultValue = dt_E.xBossConfirmColumn.DefaultValue = dt_E.xSecuritySectionConfirmColumn.DefaultValue = false;


            if (Se != "US")
            {
                bindingNavigator1.AddNewItem.Visible = false;
                bindingNavigator1.DeleteItem.Visible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.CellType.Name == "DataGridViewCheckBoxCell")
                        item.ReadOnly = false;
                    else
                        item.ReadOnly = true;
                }
                uc_DataGridViewBtn1.Enabled = false;
                uc_DataGridViewBtn2.Enabled = false;
                //dataGridView1.Columns["xConfirmBack"].ReadOnly = false;
            }
            if (Se == "US")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (
                        (bool?)item.Cells["xSecuritySectionConfirm"].Value == true ||
                        (bool?)item.Cells["xBossConfirm"].Value == true ||
                        (bool?)item.Cells["xConfirmBack"].Value == true
                        
                        )
                        item.ReadOnly = true;
                    else
                        item.ReadOnly = false;

                }
            }
            if(Se == "MN")
            {
                dataGridView1.Columns["xManagerComment"].ReadOnly = false;
            }
            dataGridView1.Columns["xSupplierDate"].ReadOnly = true;
            dataGridView1.Columns["xSupplierTime"].ReadOnly = true;
            dataGridView1.Columns["xManagerComment"].Width = 200;

            if (Se == "SC")
            {
                dataGridView1.Columns["xReturnAmount"].ReadOnly = false;
            }
            dt_E.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_E.xSupplierDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_E.xSupplierTimeColumn.DefaultValue = new  BLL.csshamsidate().CurrentTime;
            dt_E.xConfirmBackColumn.DefaultValue = false;
            dt_E.xSecuritySectionConfirmColumn.DefaultValue = false;
            dt_E.xSupplier_Column.DefaultValue = BLL.authentication.x_;

        }

        void Generate_D()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P_D.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xExitPermit_"].Visible = false;
            dataGridView2.Columns["xCommentBack"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //====================================================================||||||||||||||||
            Validation.VDate v = new Validation.VDate();

            //foreach (DataGridViewRow item in dataGridView1.Rows)
            //{
            //    if ((item.Cells["xDateReturn"].Value.ToString() == "" || item.Cells["xDateReturn"].Value.ToString() == "0000/00/00")
            //        && (item.Cells["xDateReturn"].Value == DBNull.Value || (bool)item.Cells["xDateReturn"].Value != false))
            //    {
            //        item.Cells["xDateReturn"].Style.BackColor = Color.Red;
            //        MessageBox.Show("خطا در وارد کردن تاریخ");
            //        return;
            //    }
            //}

            this.dataGridView1.EndEdit();
            this.Validate();
            BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
            MessageBox.Show(cs.UdExitPermit(dt_E));

            // dt_P.xSupplierColumn.DefaultValue = BLL.authentication.NameAndFamily;

            bindingSource1.DataSource = dt_E;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xBossConfirm"].Index)
                if ((bool?)dataGridView1["xBossConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xBoss_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xBoss_", e.RowIndex].Value = DBNull.Value;

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xManagerConfirm"].Index)
                if ((bool?)dataGridView1["xManagerConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xManager_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xManager_", e.RowIndex].Value = DBNull.Value;
            //---------------------------------------------------------------------------------------------------------

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xSecuritySectionConfirm"].Index)
                if ((bool?)dataGridView1["xSecuritySectionConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xSecuritySection_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xSecuritySection_", e.RowIndex].Value = DBNull.Value;

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xConfirmBack"].Index)
                if ((bool?)dataGridView1["xConfirmBack", e.RowIndex].Value == true)
                {
                    dataGridView1["xConfirmBackSupplier_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xConfirmBackDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                    dataGridView1["xConfirmBackTime", e.RowIndex].Value =new  BLL.csshamsidate().CurrentTime;
                }
                else
                {
                    dataGridView1["xConfirmBackSupplier_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xConfirmBackDate", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xConfirmBackTime", e.RowIndex].Value = DBNull.Value;
                }

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate" || dataGridView1.Columns[e.ColumnIndex].Name == "xDateReturn")
            {
                Validation.VDate v = new Validation.VDate();
                if (e.FormattedValue.ToString() != "")
                    e.Cancel = !v.ValidationDate(e.FormattedValue.ToString());
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Se == "SC")
            {

                splitContainer5.Panel2Collapsed = false;
                BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
                dt_P_D = cs.SlExitPermitBack((int?)dataGridView1["x_", e.RowIndex].Value);
                dt_P_D.xDateBackColumn.DefaultValue = BLL.csshamsidate.shamsidate;
                bindingSource2.DataSource = dt_P_D;
                dataGridView2.DataSource = bindingSource2;
                bindingNavigator2.BindingSource = bindingSource2;
                dt_P_D.xExitPermit_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
                Generate_D();

            }
            else
            {
                splitContainer5.Panel2Collapsed = true;
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView2.EndEdit();
            if (dataGridView2["xExitPermit_", 0].Value == null)
                return;
            int? t = (int?)dataGridView2["xExitPermit_", 0].Value;
            BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
            MessageBox.Show(cs.UdExitPermitBack(dt_P_D));
            dt_P_D = cs.SlExitPermitBack(t);
            bindingSource2.DataSource = dt_P_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            Generate_D();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateBack")
            {
                Validation.VDate v = new Validation.VDate();

                e.Cancel = !v.ValidationDate(e.FormattedValue.ToString());
            }

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.BeginEdit(false);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate" || dataGridView1.Columns[e.ColumnIndex].Name == "xDateReturn")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    //    fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xCompany_")
            {
                uc_DataGridViewBtn1.Visible = true;
                var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y); ;
                uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                uc_DataGridViewBtn1.RI = e.RowIndex;
                uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }
          else  if (dataGridView1.Columns[e.ColumnIndex].Name == "xMaterial_")
            {
                uc_DataGridViewBtn2.Visible = true;
                var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                uc_DataGridViewBtn2.Location = new Point(cellRectangle.X, cellRectangle.Y); ;
                uc_DataGridViewBtn2.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                uc_DataGridViewBtn2.RI = e.RowIndex;
                uc_DataGridViewBtn2.CI = e.ColumnIndex;
            }
            else
            {
                uc_DataGridViewBtn1.Visible = false;
                uc_DataGridViewBtn2.Visible = false;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            int inx = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                inx = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
            if (inx > 0)
            {
                if((bool?)dataGridView1.SelectedRows[0].Cells["xManagerConfirm"].Value == true)
                {
                    BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
                    Report.SendReport crs = new Report.SendReport();
                    crs.SetParam("DateNow", uc_Filter_Date1.DateTo);
                    frmReport r = new frmReport();
                    r.GetReport = crs.GetReport(cs.SlExitPermitForPrint( inx), "crsExitPermitRequest");
                    r.ShowDialog();
                    r.Dispose();
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
