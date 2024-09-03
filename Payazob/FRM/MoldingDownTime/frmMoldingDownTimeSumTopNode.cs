using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.MoldingDownTime
{
    public partial class frmMoldingDownTimeSumTopNode : Form
    {
        public frmMoldingDownTimeSumTopNode(CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            fct_ = FCT;
            Generate();
        }
        CS.csEnum.Factory fct_;
        DataTable dt_D = new DataTable();
        void generate()
        {
            dataGridView1.Columns["DownTime"].HeaderText = "مدت توقف";
            dataGridView1.Columns["NameDownTime"].HeaderText = "نوع توقف";
            dataGridView1.Columns["Child_id"].Visible = false;
            dataGridView1.Columns["Parent_id"].Visible = false;
            dataGridView1.Columns["xAvailableTime"].HeaderText = "زمان درد دسترس";
            dataGridView1.Columns["PercetDownTime"].HeaderText = "درصد توقف به زمان در دسترس";
        }
        void GenChart(string XValue, string YValue)
        {

            chart1.DataSource = dt_D;
            chart1.Series["Series1"].XValueMember = XValue;
            chart1.Series["Series1"].YValueMembers = YValue;
            chart1.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            this.chart1.ChartAreas[0].AxisX.Interval = 1;
            this.chart1.ChartAreas[0].AxisX.Interval = double.NaN;
            this.chart1.ChartAreas[0].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
        }

        void ShowData(int x_)
        {
            //frmMoldingDownTimeType frm = new frmMoldingDownTimeType(false, CS.csEnum.TypeTree.DownTimeType,fct_);
            //frm.StartPosition = FormStartPosition.CenterParent;
            //frm.ShowDialog();
            BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
            dt_D = cs.SlMoldingDownTimeSumTopNode(x_ < 0 ?-1:x_,  uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,(int)fct_);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            generate();
            GenChart("NameDownTime", "DownTime");
        }
        string TreeName = "توقفات";
        string TypeTree = "xNameDownTime";

        CS.csEnum.TypeTree typT;
        DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDowntimeTypeDataTable dt_T;

        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();
        void Generate()
        {
            treeView_DownTime.Nodes.Clear();

            TreeNode trn = new TreeNode(TreeName);
            trn.Tag = "-2";
            BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
            DataRow[] drR;

                dt_T = cs.SelectMoldingDownTimeType((int)fct_, false);
                drR = dt_T.Select("xParentId = -1");
            
 

            foreach (DataRow item in drR)
            {
                string st = item["xCode"] == null || item["xCode"] == DBNull.Value ? "" : item["xCode"].ToString();
                TreeNode tr = new TreeNode("" + st + "-" + "" + "" + item["x_"].ToString() + "-" + "" + item[TypeTree].ToString());
                tr.Tag = item["x_"].ToString();
                trn.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            treeView_DownTime.Nodes.Add(trn);
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                    drR = dt_T.Select("xParentId = " + S_tr.Tag);


                foreach (DataRow item in drR)
                {
                    string st = item["xCode"] == null || item["xCode"] == DBNull.Value ? "" : item["xCode"].ToString();

                    TreeNode tr = new TreeNode("" + st + "-" + "" + "" + item["x_"].ToString() + "-" + "" + item[TypeTree].ToString()) { Name = "i" + item["x_"].ToString() };
                    tr.Tag = item["x_"].ToString();
                    S_tr.Nodes.Add(tr);
                    Stack_tree.Push(tr);
                }
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
           // ShowData();
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView_DownTime_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_DownTime.SelectedNode == null)
                return;

            ShowData( int.Parse(treeView_DownTime.SelectedNode.Tag.ToString())  );
           //     CallRecursive(treeView_DownTime);
            //    ChildNode += '+' + Node_x_.ToString() + '+';
        }
    }
}
