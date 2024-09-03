using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DAL.MoldingDownTime;
using Payazob.CS;

namespace Payazob
{
    public partial class frmMoldingDownTime : Form
    {
        public frmMoldingDownTime(bool editable, CS.csEnum.Factory factory_)
        {
            this.InitializeComponent();
            this.fct = factory_;

            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SHI"),
                DisplayMember = "xName",
                HeaderText = "نوع شیفت",
                ValueMember = "x_",
                DataPropertyName = "xGenShift_",
                Name = "xGenShift_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);

            //dataGridViewColumn.Visible = false;
            DataGridViewComboBoxColumn dataGridViewColumn1 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("LINENAME3"),
                DisplayMember = "xName",
                HeaderText = "ایستگاه کاری ",
                ValueMember = "x_",
                Name = "xGenLineName_",
                DataPropertyName = "xGenLineName_",
                ReadOnly = false,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn1);
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 2,
                HeaderText = "نام دستگاه",
                DataSource = new BLL.Machine.csMachine().mMachine((int)fct),
                DisplayMember = "CodeName",
                ValueMember = "x_",
                DataPropertyName = "xMachine_",
                Name = "cmb_Machine",
                Width = 200,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column2);
            DataGridViewComboBoxColumn column_P = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام قطعه",
                DataSource = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site3),
                DisplayMember = "Piece",
                ValueMember = "x_",
                DataPropertyName = "xPieces_",
                Name = "xPieces_",
                Visible = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                Width = 200
            };
            //xGenLineName_
            this.dataGridView1.Columns.Add(column_P);


            if (this.fct != Payazob.CS.csEnum.Factory.Site3)
            {
                column2.Visible = false;
            }
            else
            {
                column2.Visible = true;
            }
            BLL.MoldingDownTime.MoldingDownTime time = new BLL.MoldingDownTime.MoldingDownTime();
            DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 0,
                HeaderText = "نوع توقف",
                DataSource = time.SelectMoldingDownTimeType((int)this.fct,false),
                DisplayMember = "NameAndCode",
                ValueMember = "x_",
                DataPropertyName = "xDownTimeType_",
                Name = "DownTimeType",
                MaxDropDownItems = 20,
                Width = 250,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView_D.Columns.Add(column3);
            column3.Visible = false;
            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 0,
                HeaderText = "نام مکانیز",
                DataSource = time.SelectMoldingDownTimeObject(),
                DisplayMember = "xNameObject",
                ValueMember = "x_",
                DataPropertyName = "xDownTimeObject_",
                Name = "xDownTimeObject",
                MaxDropDownItems = 20,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView_D.Columns.Add(column4);
            column4.Visible = false;
            this.dt_I = new DataSet_MoldingDownTime.SlMoldingDownTimeDataTable();
            this.dt_D = new DataSet_MoldingDownTime.SlMoldingDownTimeDetailsDataTable();
            this.dataGridView1.DataSource = this.dt_I;

            dt_I.xGenFact_Column.DefaultValue = fct;

            this.bindingSource1.DataSource = this.dataGridView1.DataSource;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingSource_D.DataSource = this.dt_D;
            this.dataGridView_D.DataSource = this.bindingSource_D;
            this.bindingNavigator_D.BindingSource = this.bindingSource_D;
            this.generateForm_I();
            this.generateForm_D();
            this.edit_Gen(editable);
            this.frmO = new frmMoldingDownTimeType(true, Payazob.CS.csEnum.TypeTree.DownTimeObject, this.fct);
            this.frmT = new frmMoldingDownTimeType(true, Payazob.CS.csEnum.TypeTree.DownTimeType, this.fct);


        }
        DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDataTable dt_I;
        DAL.MoldingDownTime.DataSet_MoldingDownTime.SlMoldingDownTimeDetailsDataTable dt_D;
        CS.csEnum.Factory fct;

        private void edit_Gen(bool e_)
        {
            toolStripButton_D_Save.Visible = e_;
            toolStripButton_D_Del.Visible = e_;
            bindingNavigatorAddNewItem.Visible = e_;
            toolStripButton1.Visible = e_;
            bindingNavigatorDeleteItem.Visible = e_;
            saveToolStripButton.Visible = e_;
            dataGridView_D.ReadOnly = !e_;
            dataGridView1.ReadOnly = !e_;
        }

        private void generateForm_I()
        {

            this.dt_I.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            this.dt_I.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            dt_I.xGenFact_Column.DefaultValue = fct;


            this.dataGridView1.Columns["xDate"].HeaderText = "تاریخ ";
            this.dataGridView1.Columns["xDate"].DisplayIndex = 0;
            this.dataGridView1.Columns["xMoldNumber"].HeaderText = "تعداد قالب ";
            this.dataGridView1.Columns["xAvailableTime"].HeaderText = "زمان در دسترس ";
            this.dataGridView1.Columns["xComment"].HeaderText = "توضیحات ";
            this.dataGridView1.Columns["xLineNumber"].HeaderText = "شماره خط ";
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xSupplier_"].Visible = false;
            this.dataGridView1.Columns["xLineNumber"].DisplayIndex = 4;
            this.dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["xGenFact_"].Visible = false;
            if (this.fct == csEnum.Factory.Site3)
            {
                this.dataGridView1.Columns["xLineNumber"].Visible = false;
                this.dataGridView1.Columns["xMoldNumber"].Visible = false;
            }


        }

        private void generateForm_D()
        {
            dataGridView_D.Columns["xDuration"].HeaderText = "مدت توقف ";
            dataGridView_D.Columns["x_"].Visible = false;
            dataGridView_D.Columns["xDownTime_"].Visible = false;
            dataGridView_D.Columns["DownTimeType"].Visible = true;
            this.dataGridView_D.Columns["xComment"].HeaderText = "توضیحات ";
            this.dataGridView_D.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView1();
        }
        enum JShift { Shab,Roz,Both }
        private void ShowDataGridView1(JShift js)
        {                



                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                dt_I = cs.SelectMoldingDownTime(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)fct);
                dataGridView1.DataSource = dt_I;


            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            generateForm_I();      


        }

        private void SaveDataGridView1()
        {
            CS.csMessage cm = new CS.csMessage();
            if (cm.ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                cs.UdMoldingDownTime(dt_I);
                ShowDataGridView1(JShift.Both);
            }
        }

        private void SaveDataGridViewD()
        {
            CS.csMessage cm = new CS.csMessage();
            if (cm.ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView_D.EndEdit();
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                cs.UdMoldingDownTimeDetials(dt_D);
            }
        }

        private void toolStripButton_D_Save_Click(object sender, EventArgs e)
        {
            SaveDataGridViewD();
        }

        private void dataGridView_D_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.frmT.tyfrm = csEnum.TypeForm.InputForm;
            this.frmT.StartPosition = FormStartPosition.CenterParent;
            this.frmT.Node_x_ = -1;
            this.frmT.ShowDialog();
            if (this.frmT.IsUpdate)
            {
                BLL.MoldingDownTime.MoldingDownTime time = new BLL.MoldingDownTime.MoldingDownTime();
                (this.dataGridView_D.Columns["DownTimeType"] as DataGridViewComboBoxColumn).DisplayIndex = 0;
                (this.dataGridView_D.Columns["DownTimeType"] as DataGridViewComboBoxColumn).DataSource = time.SelectMoldingDownTimeType((int)this.fct,true);
                (this.dataGridView_D.Columns["DownTimeType"] as DataGridViewComboBoxColumn).DisplayMember = "xNameDownTime";
                (this.dataGridView_D.Columns["DownTimeType"] as DataGridViewComboBoxColumn).ValueMember = "x_";
                (this.dataGridView_D.Columns["DownTimeType"] as DataGridViewComboBoxColumn).DataPropertyName = "xDownTimeType_";
            }
            if (this.frmT.Node_x_ != -1)
            {
                this.dataGridView_D["DownTimeType", e.RowIndex].Value = this.frmT.Node_x_;
            }



        }

        private void toolStripTextBoxDateFrom_Enter(object sender, EventArgs e)
        {

            //string st = new CS.csDateform().DateOutPut((sender as ToolStripTextBox).Owner, (sender as ToolStripTextBox).Owner.Width / 2, 0);
            //(sender as ToolStripTextBox).Text = st == "" ? (sender as ToolStripTextBox).Text : st;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                dt_D = cs.SelectMoldingDownTimeDetials((int)dataGridView1["x_", e.RowIndex].Value);
                bindingSource_D.DataSource = dt_D;
                dataGridView_D.DataSource = bindingSource_D;
                bindingNavigator_D.BindingSource = bindingSource_D;
                dt_D.Columns["xDownTime_"].DefaultValue = (int)dataGridView1["x_", e.RowIndex].Value;
                generateForm_D();
            }

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!this.dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xDate"))
            {
                Payazob.FRM.frmDate.frmDate date = new Payazob.FRM.frmDate.frmDate
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                date.ShowDialog();
                if (date.accept)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = date.fDate;
                }
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
               case (System.Windows.Forms.Keys.Control | Keys.Enter):
                    ShowDataGridView1(JShift.Both);
                    break;
               case (System.Windows.Forms.Keys.Control | Keys.S):
                    SaveDataGridView1();
                    break;
               case (System.Windows.Forms.Keys.Control | Keys.Shift | Keys.S):
                    SaveDataGridViewD();
                    break;
               case (System.Windows.Forms.Keys.Control | Keys.Shift | Keys.N):
                    dataGridView_D.Focus(); 
                    dt_D.Rows.Add();
                    break;
            
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
          
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();

            DataTable dt = new BLL.MoldingDownTime.MoldingDownTime().SlMoldingDownTimeByDetial(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo,(int)fct);


            r.GetReport = cs.GetReport(dt, "crsMoldingDownTimeByDetial");

            r.ShowDialog();
            r.Dispose();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            new ControlLibrary.uc_ExportExcelFile { Fildvg = this.dataGridView1 }.RunExcel();

        }


        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //DataTable dt;
            //dt.ExportToExcel(ExcelFilePath);
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDataGridView1(JShift.Both);

        }

        private void dataGridView_D_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
           
        }
        frmMoldingDownTimeType frmO;
        frmMoldingDownTimeType frmT;// = new frmMoldingDownTimeType(true, CS.csEnum.TypeTree.DownTimeType);

        private void dataGridView_D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (((e.RowIndex > -1) && (e.ColumnIndex > -1)) && (this.dataGridView_D.Columns[e.ColumnIndex].Name == "xDownTimeObject"))
            {
                this.frmO.tyfrm = csEnum.TypeForm.InputForm;
                this.frmO.StartPosition = FormStartPosition.CenterParent;
                this.frmO.Node_x_ = -1;
                this.frmO.ShowDialog();
                if (this.frmO.IsUpdate)
                {
                    BLL.MoldingDownTime.MoldingDownTime time = new BLL.MoldingDownTime.MoldingDownTime();
                    (this.dataGridView_D.Columns["xDownTimeObject"] as DataGridViewComboBoxColumn).DisplayIndex = 0;
                    (this.dataGridView_D.Columns["xDownTimeObject"] as DataGridViewComboBoxColumn).DataSource = time.SelectMoldingDownTimeObject();
                    (this.dataGridView_D.Columns["xDownTimeObject"] as DataGridViewComboBoxColumn).DisplayMember = "xNameObject";
                    (this.dataGridView_D.Columns["xDownTimeObject"] as DataGridViewComboBoxColumn).ValueMember = "x_";
                    (this.dataGridView_D.Columns["xDownTimeObject"] as DataGridViewComboBoxColumn).DataPropertyName = "xDownTimeObject_";
                }
                if (this.frmO.Node_x_ != -1)
                {
                    this.dataGridView_D["xDownTimeObject", e.RowIndex].Value = this.frmO.Node_x_;
                }
            }
            else if ((e.RowIndex > -1) && (e.ColumnIndex > -1))
            {
                bool flag1 = this.dataGridView_D.Columns[e.ColumnIndex].Name == "DownTimeType";
            }

        }

        private void dataGridView_D_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                dataGridView_D.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    e.ThrowException = false;
                
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
              if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xGenLineName_")
            {
                this.dataGridView1["cmb_Machine", e.RowIndex].Value = DBNull.Value;
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    (this.dataGridView1["cmb_Machine", e.RowIndex] as DataGridViewComboBoxCell).DataSource =
                        new BLL.Machine.csMachine().mMachineByLineName((int?)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value,
                                                        (int)CS.csEnum.Factory.Site3);
                }
                else
                {
                    (this.dataGridView1["cmb_Machine", e.RowIndex] as DataGridViewComboBoxCell).DataSource =
                        new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site3);
                }
            }
        }
    }
}
