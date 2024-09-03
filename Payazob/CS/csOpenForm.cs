using System.Windows.Forms;
using System.Drawing;
namespace Payazob.CS
{
    public class csOpenForm
    {
        public void FindForm(string frm, string TitleForm)
        {
            Form f;

            switch (frm)
            {
                case "PerFoodToken":
                    f = new frmEmpty_Report("SlPerFoodToken", "crsPerFoodToken");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = false;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "GenGroup_EXITTYPE":
                    f = new FRM.GenGroup.frmGenGroup("EXITTYPE", true, true, false, true, false);
                    break;
                //SlProductPlanMachiningReportTotal//crsPerFoodToken
                case "SlFoundryMaterialUsageByDay_Report":
                    f = new frmEmpty_Report("SlFoundryMaterialUsageByDay_Report", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "SlProductPlanMachiningReportTotal":
                    f = new frmEmpty_Report("SlProductPlanMachiningReportTotal", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "SlProductPlanMachiningReport":
                    f = new frmEmpty_Report("SlProductPlanMachiningReport", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "SlSectionAidDeliveryTotalByDate":
                    f = new frmEmpty_Report("SlSectionAidDeliveryTotalByDate", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SendPiecesToProduct":
                    f = new Payazob.FRM.SendPiecesToProduct.frmSendPiecesToProduct();
                    break;
                case "CodingGoodsRequest":
                    f = new FRM.CodingGoods.frmCodingGoods("User");
                    break;
                case "CodingGoodsChecking":
                    f = new FRM.CodingGoods.frmCodingGoods("WareHouse");
                    break;
                case "SlInventoryPiecesAllSite":
                    f = new frmEmpty_Report("SlInventoryPiecesAllSite", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SlProductInspectionDetails_Date_R":
                    f = new frmEmpty_Report("SlProductInspectionDetails_Date_R", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SlSectionAidDeliveryUsePerDay":
                    f = new frmEmpty_Report("SlSectionAidDeliveryUsePerDay", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "MoldRecordActions":
                    f = new FRM.Mold.frmMoldRecordActions();
                    break;
                case "GenGroup_SHTDEF":
                    f = new FRM.GenGroup.frmGenGroup("SHTDEF", true, true, false, true, false);
                    break;
                case "SlStockAfterShotBlastingPieces":
                    f = new frmEmpty_Report("SlStockAfterShotBlastingPieces", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SlStockShotBlastingPieces":
                    f = new frmEmpty_Report("SlStockShotBlastingPieces", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ShotBlastingInspection":
                    f = new FRM.ShotBlasting.frmShotBlastingInspection();
                    break;
                case "ShotBlastingPicese":
                    f = new FRM.ShotBlasting.frmShotBlastingPicese();
                    break;

                case "MoldListByPiecesAndStatus_R":
                    f = new FRM.Mold.frmMoldListByPiecesAndStatus_R();
                    break;

                case "MoldActivities_Eng":
                    f = new FRM.Mold.frmMoldActivits(CS.csEnum.FactorySection.ENG);
                    break;
                case "SlMoldList_R":
                    f = new frmEmpty_Report("SlMoldList_R", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = false;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "MoldCountGrByMoldCode":
                    f = new FRM.Mold.frmMoldCountGrByMoldCode();
                    break;
                case "GenGroup_MLDCHK":
                    f = new FRM.GenGroup.frmGenGroup("MLDCHK", false, true, false, true, false);
                    break;
                case "MoldCount_QC":
                    f = new FRM.Mold.frmMoldCount(CS.csEnum.FactorySection.QC);
                    break;
                case "MoldCount":
                    f = new FRM.Mold.frmMoldCount(CS.csEnum.FactorySection.Product);
                    break;
                case "MoldList":
                    f = new FRM.Mold.frmMoldList();
                    break;
                case "SlPiecesProductByShift":
                    f = new frmEmpty_Report("SlPiecesProductByShift", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ConfirmMoldCompressNumber":
                    f = new FRM.ConfirmMoldCompressNumber.frmConfirmMoldCompressNumber();
                    break;

                case "ReproductCasting":
                    f = new FRM.Reproduct.frmReproductCasting();
                    break;

                case "GenGroup_REPRD":
                    f = new FRM.GenGroup.frmGenGroup("REPRD", true, true, false, true, false);
                    break;
                case "KPIStockPieces":
                    f = new FRM.KPI.frmKPIStockPieces();
                    break;
                case "SlPiecesProductMachiningOnFinalOp":
                    f = new frmEmpty_Report("SlPiecesProductMachiningOnFinalOp", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "MachineSettingChange":
                    f = new FRM.MachineSettingChange.frmMachineSettingChange();
                    break;
                case "GageListMachinig":
                    f = new FRM.GageList.frmGageList(CS.csEnum.Factory.Site3);
                    break;

                case "GageList":
                    f = new FRM.GageList.frmGageList(CS.csEnum.Factory.Site1);
                    break;
                case "TimeLineMachine":
                    f = new FRM.TimeLineMachine.frmTimeLineMachine();
                    break;
                case "ProductInseptionMachining_Chart":
                    f = new FRM.ProductInspection.frmProductInspectionMachining_Chart();
                    break;
                case "GenGroup_LINENAME3":
                    f = new FRM.GenGroup.frmGenGroup("LINENAME3", false, true, true, true, false);
                    break;
                case "ProductInspectionMachining_Report":
                    f = new Payazob.FRM.ProductInspection.frmProductInspectionMachining_Report();
                    break;

                case "SlStockPiecesMachining":
                    f = new frmEmpty_Report("SlStockPiecesMachining", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SendProductInspectionMachining":
                    f = new Payazob.FRM.SendProductInspectionMachining.frmSendProductInspectionMachining();
                    break;

                case "BudgetPlan_SalesPerformance":
                    f = new Payazob.FRM.Budget.frmBudgetPlan_SalesPerformance(csEnum.Factory.Site1, csEnum.GenFactoryGroupPieces.Site1);
                    break;
                case "BudgetPlan":
                    f = new Payazob.FRM.Budget.frmBudgetPlan(csEnum.Factory.Site1, csEnum.GenFactoryGroupPieces.Site1);
                    break;
                case "SlMoldingDownTimeByDetails":
                    f = new frmEmpty_Report("SlMoldingDownTimeByDetails", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;

                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "SlPiecesProductMachining":
                    f = new frmEmpty_Report("SlPiecesProductMachining", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;

                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = false;
                    break;
                case "SlMoldingDownTimeByMachine":
                    f = new frmEmpty_Report("SlMoldingDownTimeByMachine", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;

                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "InventoryMaterialTurning":
                    f = new frmEmpty_Report("InventoryMaterialTurning", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).SetParamColor("InventoryCount", Color.LightBlue);

                    (f as frmEmpty_Report).SetParamColor("xMaterial_", Color.LightSteelBlue);

                    (f as frmEmpty_Report).SetParamColor("ProductTurningCountB", Color.LimeGreen);
                    (f as frmEmpty_Report).SetParamColor("ProductToTurningCountB", Color.LimeGreen);
                    (f as frmEmpty_Report).SetParamColor("BeforDefectNumber", Color.LimeGreen);
                    (f as frmEmpty_Report).FilterDate = true;

                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "MoldingDownTimeTtTiGr_Report_Site3":
                    f = new Payazob.frmMoldingDownTimeTtTiGr_Report(csEnum.Factory.Site3);
                    break;
                case "MoldingDownTime_Site3":
                    f = new Payazob.frmMoldingDownTime(true, csEnum.Factory.Site3);
                    break;
                case "CustomerReturnTurning":
                    f = new Payazob.FRM.CustomerReturn.frmCustomerReturnTurning();
                    break;
                case "DestructionMaterialTurning":
                    f = new Payazob.FRM.DestructionReport.frmDestructionMaterialTurning();
                    break;
                case "DestructionPiecesTurning":
                    f = new Payazob.FRM.DestructionReport.frmDestructionPiecesTurning();
                    break;
                case "SlInventoryMaterial_S3":
                    f = new frmEmpty_Report("SlInventoryMaterial_S3", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).SetParam("x_", false);
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;

                case "ProcurmentMaterialTurning":
                    f = new Payazob.FRM.Procurment.frmProcurmentMaterialTurning();
                    break;

                case "MaterialByGenSite3":
                    f = new FRM.Material.frmMaterialByGen(160);
                    //  (f as FRM.Material.frmMaterialByGen).SetParam("xMaterialName", true, false, 200);
                    break;

                case "BalanceBeginningMaterialTuring":
                    f = new FRM.BalanceBeginningMaterial.frmmBalanceBeginningMaterialTuring();
                    break;

                case "WorkTime":
                    f = new Payazob.FRM.OverTime.frmWorkTime();
                    break;

                case "SlPruductInspectionMachiningCheckList":
                    f = new frmEmpty_Report("SlPruductInspectionMachiningCheckList", "crsPruductInspectionMachiningCheckList");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).SetParam("xShift_", false);
                    (f as frmEmpty_Report).SetParam("xDefectList_", false);
                    break;

                case "BalanceBeginningPiecesCirculatingTurning":
                    f = new Payazob.FRM.Blance.frmBalanceBeginningPiecesCirculatingTurning();
                    break;

                case "SendProductToTurning":
                    f = new Payazob.FRM.SendProductToTurning.frmSendProductToTurning();
                    break;

                case "MoldingDownTimeSumTopNode_Site3":
                    f = new Payazob.FRM.MoldingDownTime.frmMoldingDownTimeSumTopNode(csEnum.Factory.Site3);
                    break;

                case "MoldingDownTimeSumTopNode":
                    f = new Payazob.FRM.MoldingDownTime.frmMoldingDownTimeSumTopNode(csEnum.Factory.Site1);
                    break;

                case "DeliveryWareHouse_3":
                    f = new FRM.DeliveryWareHouse.frmDeliveryWareHouse(csEnum.Factory.Site3);
                    break;

                case "ProductInspectionMachining":
                    f = new Payazob.FRM.ProductInspection.frmProductInspectionMachining();
                    break;

                case "DefectListMachining":
                    f = new Payazob.FRM.Defect.frmDefectListMachining();
                    break;

                case "MachineMuscle":
                    f = new Payazob.FRM.Machine.frmMachine(CS.csEnum.Factory.Site2);
                    break;
                case "Machine":
                    f = new Payazob.FRM.Machine.frmMachine(CS.csEnum.Factory.Site3);
                    break;

                case "ProductOperation":
                    f = new Payazob.FRM.ProductOperation.frmProductOperation();
                    break;

                case "PiecesProducsMachining":
                    f = new Payazob.FRM.Product.frmPiecesProducsMachining();
                    break;

                case "PiecesMachining":
                    f = new frmPieces(true, CS.csEnum.GenFactoryGroupPieces.Site3);
                    break;


                case "BalanceBeginningPiecesCirculating":
                    f = new Payazob.FRM.BalanceBeginningPieces.frmBalanceBeginningPiecesCirculating();
                    break;
                case "GenGroup_SPIMD":
                    f = new FRM.GenGroup.frmGenGroup("SPIMD", false, true, true, true, true);
                    break;
                case "GenGroup_MNGCHART":
                    f = new FRM.GenGroup.frmGenGroup("MNGCHART", false, true, true, true, true);
                    break;
                case "GenGroup_PCSM":
                    f = new FRM.GenGroup.frmGenGroup("PCSM", true, true, true, true, false);
                    break;
                case "SlSectionAidUseForSec":
                    f = new frmEmpty_Report("SlSectionAidUseForSec", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = false;
                    break;
                case "SlProductPlanningVsPieceProduct":
                    f = new frmEmpty_Report("SlProductPlanningVsPieceProduct", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "SlSectionAidListAidForPer":
                    f = new frmEmpty_Report("SlSectionAidListAidForPer", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = false;
                    break;
                case "SlFireExtingusherEXP":
                    f = new frmEmpty_Report("SlFireExtingusherEXP", "crsSlFireExtinguisherEXP");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = false;
                    break;
                case "DoctorReportList":

                    f = new Payazob.FRM.Hygiene.frmDoctorReportList();
                    break;

                case "FireExtinguisher":

                    f = new Payazob.FRM.Accidents.frmFireExtinguisher();
                    break;

                case "SlCustomerReturn_Status":
                    f = new frmEmpty_Report("SlCustomerReturn_Status", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "SlSectionAidDelivryToPerCnt":
                    f = new frmEmpty_Report("SlSectionAidDelivryToPerCnt", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "ObjectListEditName":
                    f = new frmEmpty_SaveLevel1("ObjectListEditName", false, true, false, csEnum.Factory.Site1);
                    (f as frmEmpty_SaveLevel1).SetParam("x_", false, true, 0);
                    (f as frmEmpty_SaveLevel1).SetParam("xObjectname", true, true, 300);
                    (f as frmEmpty_SaveLevel1).SetParam("xObjectFarsiName", true, false, 300);
                    (f as frmEmpty_SaveLevel1).SetParam("xRegistringGroup_", false, false, 0);
                    (f as frmEmpty_SaveLevel1).SetParam("xType_", false, false, 0);
                    (f as frmEmpty_SaveLevel1).SetParam("xGroup_", false, false, 0);

                    break;
                case "SafetyNotes":

                    f = new Payazob.FRM.Accidents.frmSafetyNotes();
                    break;
                case "InspectionWork":

                    f = new Payazob.FRM.Accidents.frmInspectionWork();
                    break;

                case "AccidentsMinor":

                    f = new Payazob.FRM.Accidents.frmAccidentsMinor();
                    break;
                case "AccidentsSemi":

                    f = new Payazob.FRM.Accidents.frmAccidentsSemi();
                    break;

                case "AccidentsExtreme":

                    f = new Payazob.FRM.Accidents.frmAccidentsExtreme();
                    break;
                case "ToolsPerson":

                    f = new Payazob.FRM.Tools.frmToolsPerson();
                    break;
                case "ToolsPersonTotalReport":

                    f = new Payazob.FRM.Tools.frmToolsPersonTotalReport();
                    break;

                case "ToolsDelivery_Man":

                    f = new Payazob.FRM.Tools.frmToolsDelivery(CS.csEnum.TypeUser.Manager);
                    break;
                case "SlToolsUnknown":
                    f = new frmEmpty_Report("SlToolsUnknown", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "SlToolsRetiring":
                    f = new frmEmpty_Report("SlToolsRetiring", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "Tools":

                    f = new Payazob.FRM.Tools.frmTools(CS.csEnum.MaterilaType.abzar);
                    break;
                case "calibrationTools":

                    f = new Payazob.FRM.Tools.frmTools(CS.csEnum.MaterilaType.AbzarAndazeGiri);
                    break;
                case "ToolsDelivery":

                    f = new Payazob.FRM.Tools.frmToolsDelivery(CS.csEnum.TypeUser.User);
                    break;
                case "ToolsReturn_M":

                    f = new Payazob.FRM.Tools.frmToolsReturn(CS.csEnum.TypeUser.Manager);
                    break;
                case "ToolsReturn_B":

                    f = new Payazob.FRM.Tools.frmToolsReturn(CS.csEnum.TypeUser.Boos);
                    break;
                case "ToolsReturn":

                    f = new Payazob.FRM.Tools.frmToolsReturn(CS.csEnum.TypeUser.Warehose);
                    break;
                case "RegEntExitSearch":

                    f = new Payazob.FRM.RegEntExit.frmRegEntExitSearch();
                    break;
                case "RegShift":
                    f = new frmEmpty_SaveLevel1("RegShift", false, true, false, csEnum.Factory.Site1);
                    (f as frmEmpty_SaveLevel1).SetParam("x_", false, true, 5);

                    break;
                case "ObjectUseListAndLocation":
                    f = new frmEmpty_Report("ObjectUseListAndLocation", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "ObjectListAndLocation":
                    f = new frmEmpty_Report("ObjectListAndLocation", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = false;
                    (f as frmEmpty_Report).FilterDate = false;
                    //  (f as frmEmpty_Report).SetParam("xSection_", false);
                    break;
                case "RegEntExit_User":
                    f = new Payazob.FRM.RegEntExit.frmRegEntExit("USER");
                    break;
                case "RegEntExit_Reg":
                    f = new Payazob.FRM.RegEntExit.frmRegEntExit("REG");
                    break;
                case "interupt_comp":
                    f = new PAYAZOBNET.form.interupt.frm_interupt_comp();
                    break;
                case "interupt_plan":
                    f = new PAYAZOBNET.form.interupt.frm_interupt_plan();
                    break;
                case "mtbf":
                    f = new PAYAZOBNET.form.indicator.frmmtbf();
                    break;
                case "mttr":
                    f = new PAYAZOBNET.form.indicator.frm_mttr();
                    break;
                case "codingobjects":
                    f = new PAYAZOBNET.form.frmcodingobjects();
                    break;
                case "RequestObject_WR":
                    f = new Payazob.FRM.RequestObject.frmRequestObject("WR");
                    break;
                case "RequestObject_NET":
                    f = new Payazob.FRM.RequestObject.frmRequestObject("NET");
                    break;
                case "RequestObject_USR":
                    f = new Payazob.FRM.RequestObject.frmRequestObject("USR");
                    break;
                case "SlSectionAidPerdicUsage":
                    f = new frmEmpty_Report("SlSectionAidPerdicUsage", "");
                    (f as frmEmpty_Report).FilterDate = false;
                    break;
                case "Register":
                    f = new FRM.RegisterUser.mRegister();
                    break;
                case "ControlPrj_rep":
                    f = new FRM.ControlPrj.frmControlPrj("rep");
                    break;
                case "Model":
                    f = new FRM.Model.frmModel("adm");
                    break;
                case "Model_usr":
                    f = new FRM.Model.frmModel("usr");
                    break;
                case "ControlPrj_adm":
                    f = new FRM.ControlPrj.frmControlPrj("adm");
                    break;
                case "ControlPrj":
                    f = new FRM.ControlPrj.frmControlPrj("usr");
                    break;
                case "SlOverTime_R":
                    f = new frmEmpty_Report("SlOverTime_R", "crsOverTime_R");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).SetParam("xSection_", false);
                    break;
                case "ProductRepairRequest_User":
                    f = new FRM.ProductRepairRequest.frmProductRepairRequest("US");
                    break;
                case "ProductRepairRequest_Net":
                    f = new FRM.ProductRepairRequest.frmProductRepairRequest("Net");
                    break;
                case "DefectList":
                    f = new FRM.Defect.frmDefectList();
                    break;
                case "GenGroup_PRJTYP":
                    f = new FRM.GenGroup.frmGenGroup("PRJTYP", true, true, true, true, false);
                    break;
                case "GenGroup_TRP":
                    f = new FRM.GenGroup.frmGenGroup("TRP", true, true, true, true, false);
                    break;
                case "GenGroup_TYPMA":
                    f = new FRM.GenGroup.frmGenGroup("TYPMA", true, true, true, true, false);
                    break;
                case "GenGroup_SEC":
                    f = new FRM.GenGroup.frmGenGroup("SEC", true, true, true, true, false);
                    break;
                case "GenGroup_CNPRC":
                    f = new FRM.GenGroup.frmGenGroup("CNPRC", true, true, true, true, false);
                    break;
                case "GenGroup_STU":
                    f = new FRM.GenGroup.frmGenGroup("STU", true, true, true, true, false);
                    break;
                case "GenGroup_PCS":
                    f = new FRM.GenGroup.frmGenGroup("PCS", true, true, true, true, false);
                    break;

                case "GenGroup_DVC":
                    f = new FRM.GenGroup.frmGenGroup("DVC", true, true, true, true, false);

                    break;
                case "SlSalePlanTurningStock":
                    f = new frmEmpty_Report("SlSalePlanTurningStock", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).SetParam("xPieces_", false);
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ScrabUsage":
                    f = new FRM.ProductInspection.frmScrabUsage();
                    break;
                case "OverTimeDefTime":
                    f = new FRM.OverTime.frmOverTimeDefTime();
                    break;

                case "OverTimeScu":
                    f = new FRM.OverTime.frmOverTimeScu();
                    break;


                case "DeliveryWareHouse":
                    f = new FRM.DeliveryWareHouse.frmDeliveryWareHouse(csEnum.Factory.Site1);
                    break;
                case "SalePlanTurning_Report":
                    f = new frmEmpty_Report("SalePlanTurning", "crsSalePlanTurning");
                    (f as frmEmpty_Report).SetParam("x_", false);
                    (f as frmEmpty_Report).SetParam("xPieces_", false);
                    (f as frmEmpty_Report).SetParam("xCustomer_", false);
                    (f as frmEmpty_Report).SetParam("xSupplier_", false);
                    (f as frmEmpty_Report).SetParam("xPlanUserConfirm_", false);
                    (f as frmEmpty_Report).SetParam("xQcUserConfirm_", false);
                    (f as frmEmpty_Report).SetParam("xScUserConfirm_", false);
                    (f as frmEmpty_Report).SetParam("xTradeExitConfirm", false);
                    (f as frmEmpty_Report).SetParam("xTradeExitConfirm_", false);
                    (f as frmEmpty_Report).SetParam("xTradeExitUser", false);
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "SendProductTurning_Report":
                    f = new frmEmpty_Report("SendProductTurning_Report", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).SetParam("x_", false);
                    (f as frmEmpty_Report).SetParam("xPieces_", false);
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "OverTime":
                    f = new FRM.OverTime.frmOverTime();
                    break;
                case "OverTimeChk_Man":
                    f = new FRM.OverTime.frmOverTimeChk("Man");
                    break;
                case "OverTimeChk_Apr":
                    f = new FRM.OverTime.frmOverTimeChk("Apr");
                    break;
                case "OverTimeHR":
                    f = new FRM.OverTime.frmOverTimeHR();
                    break;
                case "CustomerReturn_Report":
                    f = new Payazob.FRM.CustomerReturn.frmCustomerReturn("$$");
                    break;
                case "CustomerReturn_TR":
                    f = new Payazob.FRM.CustomerReturn.frmCustomerReturn("TR");
                    break;
                case "CustomerReturn_PR":
                    f = new Payazob.FRM.CustomerReturn.frmCustomerReturn("PR");
                    break;
                case "CustomerReturn_QC":
                    f = new Payazob.FRM.CustomerReturn.frmCustomerReturn("QC");
                    break;
                case "CustomerReturn_PL":
                    f = new Payazob.FRM.CustomerReturn.frmCustomerReturn("PL");
                    break;
                case "RequestItServiceUser":
                    f = new Payazob.FRM.RequestItService.frmRequestItService("User");
                    break;
                case "RequestItServiceAdmin":
                    f = new Payazob.FRM.RequestItService.frmRequestItService("");
                    break;
                case "AidPersonListUSER":
                    f = new Payazob.FRM.Aid.frmAidPersonList("USER");
                    break;
                case "AidPersonListINV":
                    f = new Payazob.FRM.Aid.frmAidPersonList("INV");
                    break;
                case "AidPersonListSUP":
                    f = new Payazob.FRM.Aid.frmAidPersonList("SUP");
                    break;
                case "AidPersonListMAN":
                    f = new Payazob.FRM.Aid.frmAidPersonList("MAN");
                    break;
                case "BlanceProductTurning":
                    f = new Payazob.FRM.Blance.frmBlanceProductTurning();
                    break;
                case "PersonInfo_PerPhone":
                    f = new Payazob.FRM.PersonInfo.frmPersonInfo(false, "PerPhone");
                    break;
                case "PersonInfo":
                    f = new Payazob.FRM.PersonInfo.frmPersonInfo(false, "Man");
                    break;
                case "PersonInfo_R":
                    f = new Payazob.FRM.PersonInfo.frmPersonInfo(true, "User");
                    break;

                case "SectionAid":
                    f = new Payazob.FRM.Aid.frmSectionAidDetials();
                    break;
                case "SendProductTurning":
                    f = new Payazob.FRM.SendProductTurning.frmSendProductTurning();
                    break;
                case "SalePlanTurningTR":
                    f = new Payazob.FRM.SalePlan.frmSalePlanTurning("TR");
                    break;
                case "SalePlanTurningPL":
                    f = new Payazob.FRM.SalePlan.frmSalePlanTurning("PL");
                    break;
                case "SalePlanTurningQC":
                    f = new Payazob.FRM.SalePlan.frmSalePlanTurning("QC");
                    break;
                case "SalePlanTurningSC":
                    f = new Payazob.FRM.SalePlan.frmSalePlanTurning("SC");
                    break;
                case "ProcurmentMaterialSampleQC":
                    f = new Payazob.FRM.Procurment.frmProcurmentMaterialSample("QC");
                    break;
                case "ProcurmentMaterialSampleST":
                    f = new Payazob.FRM.Procurment.frmProcurmentMaterialSample("ST");
                    break;
                case "ProcurmentMaterialSampleTR":
                    f = new Payazob.FRM.Procurment.frmProcurmentMaterialSample("TR");
                    break;
                case "ProcurmentMaterialSampleSC":
                    f = new Payazob.FRM.Procurment.frmProcurmentMaterialSample("SC");
                    break;
                case "SlStockPieces":
                    f = new frmEmpty_Report("SlStockPieces", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).FilterDateTo_Visible = false;
                    (f as frmEmpty_Report).SetParam("xPieces_", false);
                    (f as frmEmpty_Report).SetParam("Inventory", false);
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ProcurmentMaterialTestFN_Report":
                    f = new Payazob.FRM.Procurment.frmProcurmentMaterialTestFN_Report();
                    break;

                case "EditObjectGroup":
                    f = new Payazob.FRM.EditObjectGroup.frmEditObjectGroup();
                    break;
                case "SalePlan_TE":
                    f = new Payazob.FRM.SalePlan.frmSalePlan("TE");
                    break;
                case "MusclePlan":
                    f = new frmEmpty_Report("SlMusclePlan", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "MinStockMuscle":
                    f = new FRM.MuscleProduct.frmMinStockMuscle();
                    break;
                case "NesPrcSpc":
                    f = new FRM.NesPrcSpc.frmNesPrcSpc();
                    break;

                case "SlMucsleSendReport":
                    f = new frmEmpty_Report("SlMucsleSendReport", "crsMucsleSendReport");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;
                case "Muscle":
                    f = new FRM.MuscleProduct.frmMuscle();
                    break;
                case "MuscleInv":
                    f = new FRM.MuscleProduct.frmMuscleInv();
                    break;

                case "BalanceBeginningMuscle":
                    f = new FRM.MuscleProduct.frmBalanceBeginningMuscle();
                    break;

                case "MuscleSend_PL":
                    f = new FRM.MuscleProduct.frmMuscleSend("PL");
                    break;

                case "MuscleSend_PR":
                    f = new FRM.MuscleProduct.frmMuscleSend("PR");
                    break;

                case "MuscleSend_MU":
                    f = new FRM.MuscleProduct.frmMuscleSend("MU");
                    break;

                case "MuscleProduct":
                    f = new FRM.MuscleProduct.frmMuscleProduct();

                    break;

                case "PruductInspectionByMonthTotal":
                    f = new frmEmpty_Report("PruductInspectionByMonthTotal", "PruductInspectionByMonthTotal");
                    (f as frmEmpty_Report).FilterDate = false;

                    break;

                case "MoldingDownTime_EXCEL_Site3":
                    f = new frmEmpty_Report("MoldingDownTime_EXCEL_Site3", "crsMoldingDownTimeByDetial");

                    (f as frmEmpty_Report).FilterDate = true;

                    break;
                case "MoldingDownTime_EXCEL":
                    f = new frmEmpty_Report("MoldingDownTime_EXCEL", "crsMoldingDownTimeByDetial");

                    (f as frmEmpty_Report).FilterDate = true;

                    break;


                case "ProductPlanning_Report":
                    f = new FRM.ProductPlanning.frmProductPlanning("REPORT", csEnum.Factory.Site1);

                    break;
                case "ProductPlanning":
                    f = new FRM.ProductPlanning.frmProductPlanning("FULL", csEnum.Factory.Site1);

                    break;
                case "ProductPlanning_Report_Machining":
                    f = new FRM.ProductPlanning.frmProductPlanning("REPORT", csEnum.Factory.Site3);

                    break;
                case "ProductPlanning_Machining":
                    f = new FRM.ProductPlanning.frmProductPlanning("FULL", csEnum.Factory.Site3);

                    break;
                case "ProcurmentScrabTestFN2_Report":
                    f = new FRM.Procurment.frmProcurmentScrabTestFN2_Report();
                    break;
                case "PruductInspectionflow":
                    f = new FRM.ProductInspection.frmProductInspectionflow();
                    break;
                case "WorkHourHR":
                    f = new FRM.WorkHour.frmWorkHour("HR");
                    break;
                case "WorkHourPL":
                    f = new FRM.WorkHour.frmWorkHour("PL");
                    break;


                case "SalePlan_RP":
                    f = new frmEmpty_Report("SalePlan", "crsSalePlan");
                    (f as frmEmpty_Report).SetParam("x_", false);
                    (f as frmEmpty_Report).SetParam("xPieces_", false);
                    (f as frmEmpty_Report).SetParam("xCustomer_", false);
                    (f as frmEmpty_Report).SetParam("xSupplier_", false);
                    (f as frmEmpty_Report).SetParam("xPlanUserConfirm_", false);
                    (f as frmEmpty_Report).SetParam("xQcUserConfirm_", false);
                    (f as frmEmpty_Report).SetParam("xScUserConfirm_", false);
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;

                    break;

                case "PiecesProuductTime":
                    f = new frmEmpty_Report("PiecesProuductTime", "crsPiecesProuductTime");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;

                    break;
                case "MoldingSpeed":
                    f = new frmEmpty_Report("MoldingSpeed", "crsMoldingSpeed");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;

                case "PruductInspectionCompare":
                    f = new frmEmpty_Report("PruductInspectionCompare", "crsProductInspectionCompare");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    break;

                case "FoundryMaterialUsageCheck":
                    f = new Payazob.FRM.Foundry.frmFoundryMaterialUsageCheck();
                    break;

                case "frmManager":
                    f = new Payazob.frmManager();
                    break;

                case "BalanceBeginningMaterial":
                    f = new Payazob.FRM.BalanceBeginningMaterial.frmBalanceBeginningMaterial();
                    break;

                case "PerFoodCenterPrice":
                    f = new frmEmpty_Report("PerFoodCenterPrice", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;

                case "InventoryScrab":
                    f = new frmEmpty_Report("InventoryScrab", "crsInventoryScrab");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).SetParam("xMaterial_", false);
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ProcurmentScrabSuStu":
                    f = new frmEmpty_Report("ProcurmentScrabSuStu", "crsProcurmentScrabSuStu");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "ProcurmentMaterialSuStu":
                    f = new frmEmpty_Report("ProcurmentMaterialSuStu", "crsProcurmentMaterialSuStu");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "InvMaterialInput_Report":
                    f = new frmEmpty_Report("InvMaterialInput_Report", "crsInvMaterialInput");


                    (f as frmEmpty_Report).ReportHaveDateDetails = false;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "Material":
                    f = new Payazob.FRM.FIFO.frmMaterial();
                    break;
                case "InvMaterialInput":
                    f = new Payazob.FRM.FIFO.frmInvMaterialInput();
                    break;
                case "SendProduct_Report":
                    f = new frmEmpty_Report("SendProduct_Report", "crsSendProduct");
                    (f as frmEmpty_Report).SetParam("x_", false);
                    (f as frmEmpty_Report).SetParam("xPieces_", false);

                    f.Text = "گزارش ارسال محصول به انبار";

                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;
                case "BalanceBeginningPieces":
                    f = new Payazob.FRM.BalanceBeginningPieces.frmBalanceBeginningPieces();
                    break;
                case "PerFoodStatus":
                    f = new Payazob.FRM.PerFood.frmPerFoodStatus();
                    break;
                //case "ProductionPlanning":
                //    f = new Payazob.frmProductionPlanning();
                //    break;
                //case "Planning":
                //    f = new Payazob.frmPlanning();
                //    break;
                case "Correspondence":
                    f = new Payazob.frmCorrespondenceList();
                    break;

                case "FoundryDetialsList":
                    f = new Payazob.frmFoundryDetialsList();
                    break;

                case "ProductInspectionList":
                    f = new Payazob.frmProductInspectionList();
                    break;


                case "ReturnCustomer":
                    f = new Payazob.frmReturnCustomer();
                    break;


                case "SandDailyReportList":
                    f = new Payazob.frmSandDailyReportList(false);
                    break;
                case "SandDailyReportList_ReadOnly":
                    f = new Payazob.frmSandDailyReportList(true);
                    break;

                case "SandWeeklyTestList":
                    f = new Payazob.frmSandWeeklyTestList();
                    break;

                case "QualityControlMeltReport":
                    f = new Payazob.frmQualityControlMeltReport();
                    break;


                //case "ProcurementGoodsOut":
                //    f = new Payazob.frmProcurementGoodsOut();
                //    break;
                case "DestructionReport":
                    f = new Payazob.FRM.DestructionReport.frmDestructionReport();
                    break;

                //case "ProcurmentGuest":
                //    f = new Payazob.frmProcurmentGuest();
                //    break;
                //case "ProcurmentSalesProduct":
                //    f = new Payazob.frmProcurmentSalesProduct();
                //    break;
                //case "MeltTestResult_Report":
                //    f = new Payazob.frmMeltTestResult_Report();
                //    break;
                case "ProductInspection_Report":
                    f = new frmEmpty_Report("ProductInspection_Report", "crsProductInspection");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش ضایعات به تفکیک";
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    break;

                //case "ProcurementGoodsOut_Report":
                //    f = new Payazob.frmProcurementGoodsOut_Report();
                //    break;

                //case "ProcurmentSalesProduct_Report":
                //    f = new Payazob.frmProcurmentSalesProduct_Report();
                //    break;
                //case "ProcurmentGuest_Report":
                //    f = new Payazob.frmProcurmentGuest_Report();
                //    break;
                case "ProductInspectionDefect_Report":
                    f = new Payazob.frmProductInspectionDefect_Report();
                    break;
                //case "MeltTestResult_Report1":
                //    f = new Payazob.frmMeltTestResult_Report1();
                //    break;
                //case "MeltTestResultScrab_Report1":
                //    f = new Payazob.frmMeltTestResultScrab_Report1();
                //    break;
                //case "MeltTestResultScrab":
                //    f = new Payazob.frmMeltTestResultScrab();
                //    break;
                case "NonConforming_Report":
                    f = new FRM.NonConforming.frmNonConforming_Report();
                    break;

                case "UpdateFromSgdb":
                    f = new Payazob.frmUpdateFromSgdb();
                    break;

                case "FoundryDetailsTotalMeltByZint_Report":
                    f = new frmEmpty_Report("FoundryDetailsTotalMeltByZint_Report", "crsFoundryDetailsTotalMeltByZinter");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش زینتر کوره ها";
                    break;

                case "SandDailyReport_Report":

                    f = new frmEmpty_Report("SandDailyReport_Report", "crsSandDailyReport");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش روزانه خط ماسه ";

                    break;

                case "SandMaterialUsage_Report":
                    f = new frmEmpty_Report("SandMaterialUsage_Report", "crsSandMaterialUsage");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش مصرف مواد خط ماسه ";
                    break;
                case "SandMaterialAndDaily_Report":
                    f = new Payazob.frmSandMaterialAndDaily_Report();
                    break;
                case "SandWeeklyTestChart":
                    f = new Payazob.frmSandWeeklyTestChart(csEnum.TypeLineMachine.Tokyo);
                    break;
                case "AccessRights":
                    f = new Payazob.frmAccessRights();
                    break;
                case "PiecesProducs":
                    f = new Payazob.frmPiecesProducs();
                    break;
                case "SendProduct":
                    f = new Payazob.frmSendProduct();
                    break;

                case "InventoryTotal_Report":

                    f = new frmEmpty_Report("InventoryTotal_Report", "crsInventoryTotal");
                    (f as frmEmpty_Report).SetParam("x_", false);
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش گردش موجودی کل قطعات ";
                    (f as frmEmpty_Report).SizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    (f as frmEmpty_Report).dataGridViewAutoSizeFillColumnMode = true;
                    break;
                case "Pieces":
                    f = new Payazob.frmPieces(true, csEnum.GenFactoryGroupPieces.Site1);
                    break;
                case "PruductInspectionDefectDetials_Report":

                    f = new frmEmpty_Report("PruductInspectionDefectDetials_Report", "crsPruductInspectionDefectDetials");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش ضایعات و نوع آن ";
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;

                    break;
                case "PiecesProuductAndDetial_Report":

                    f = new frmEmpty_Report("PiecesProuductAndDetial_Report", "crsPiecesProuductAndDetial");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش مقدار تولید محصول";
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;


                    break;
                case "PiecesProuductAndDetialAll_Report":

                    f = new frmEmpty_Report("PiecesProuductAndDetialAll_Report", "crsPiecesProuductAndDetialAll");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارش مقدار تولید محصول به تفکیک";
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;


                    break;
                case "SandDailyReportAndRptEqu_Report":


                    f = new frmEmpty_Report("SandDailyReportAndRptEqu_Report", "crsSandDailyReportAndRptEqu");
                    (f as frmEmpty_Report).FilterDate = true;
                    f.Text = "گزارشات برقی مکانیکی خط ماسه";
                    (f as frmEmpty_Report).SizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    (f as frmEmpty_Report).dataGridViewAutoSizeFillColumnMode = true;

                    //    f = new Payazob.frmSandDailyReportAndRptEqu_Report();


                    break;
                case "MoldingDownTime":
                    f = new Payazob.frmMoldingDownTime(true, csEnum.Factory.Site1);
                    break;
                case "MoldingDownTimeTtTiGr_Report":
                    f = new Payazob.frmMoldingDownTimeTtTiGr_Report(csEnum.Factory.Site1);
                    break;
                case "ProductInspection_Chart":
                    f = new Payazob.frmProductInspection_Chart();
                    break;
                case "FoundryMaterialUsage_Report":
                    f = new Payazob.frmFoundryMaterialUsage_Report();
                    break;
                case "SandDailyTestSpc_Report":
                    f = new Payazob.frmSandDailyTestSpc_Report(CS.csEnum.TypeLineMachine.Tokyo);
                    break;
                case "SandDailyTestSpc_Report_Disa":
                    f = new Payazob.frmSandDailyTestSpc_Report(CS.csEnum.TypeLineMachine.Disa);
                    break;
                case "CompanyList":
                    f = new Payazob.frmCompanyList();
                    break;
                case "AnalysisFurnace":
                    f = new Payazob.FRM.AnalysisFurnace.frmAnalysisFurnace();
                    break;
                //case "ProcurmentSalesProductTtPcByCu_Report":
                //   f = new frmProcurmentSalesProductTtPcByCu_Report();
                //   break;
                case "ProcurmentScarbTestQC":
                    f = new FRM.Procurment.frmProcurmentScarbTest("QC");
                    break;
                case "ProcurmentScarbTestPR":
                    f = new FRM.Procurment.frmProcurmentScarbTest("PR");
                    break;
                case "ProcurmentScarbTestTR":
                    f = new FRM.Procurment.frmProcurmentScarbTest("TR");
                    break;
                case "ProcurmentScarbTestFN":
                    f = new FRM.Procurment.frmProcurmentScarbTest("FN");
                    break;

                case "ProcurmentMaterialTestFN":
                    f = new FRM.Procurment.frmProcurmentMaterialTest("FN");
                    break;
                case "ProcurmentMaterialTestQC":
                    f = new FRM.Procurment.frmProcurmentMaterialTest("QC");
                    break;
                case "ProcurmentMaterialTestTR":
                    f = new FRM.Procurment.frmProcurmentMaterialTest("TR");
                    break;
                case "ProcurmentMaterialTestPR":
                    f = new FRM.Procurment.frmProcurmentMaterialTest("PR");
                    break;
                case "ProcurmentMaterialTestPL":
                    f = new FRM.Procurment.frmProcurmentMaterialTest("PL");
                    break;
                    //برای تایید بعد از بازرگانی برنامه ریزی
                case "ProcurmentMaterialTestLS":
                    f = new FRM.Procurment.frmProcurmentMaterialTest("LS");
                    break;
                case "ProcurmentMaterialTest_Report":
                    f = new FRM.Procurment.frmProcurmentMaterialTest_Report();
                    break;
                case "ProcurmentScarbTest_Report":
                    f = new FRM.Procurment.frmProcurmentScarbTest_Report();
                    break;
                case "ExitPermitUS":
                    f = new FRM.ExitPermit.frmExitPermit("US");
                    break;
                case "ExitPermitMN":
                    f = new FRM.ExitPermit.frmExitPermit("MN");
                    break;
                case "ExitPermitIN":
                    f = new FRM.ExitPermit.frmExitPermit("IN");
                    break;
                case "ExitPermitBS":
                    f = new FRM.ExitPermit.frmExitPermit("BS");
                    break;
                case "ExitPermitSC":
                    f = new FRM.ExitPermit.frmExitPermit("SC");
                    break;
                case "ExitPermit_Report":
                    f = new FRM.ExitPermit.frmExitPermit_Report();
                    break;
                case "NonConformingList":
                    f = new frmNonConformingList();
                    break;
                case "SandDailyReportRange":
                    f = new Payazob.FRM.Sand.frmSandDailyReportRange();
                    break;
                case "AnalysisFurnace_Report":
                    f = new Payazob.FRM.AnalysisFurnace.frmAnalysisFurnace_Report();
                    break;
                case "AnalyzeFurnaceRange":
                    f = new Payazob.FRM.AnalysisFurnace.frmAnalyzeFurnaceRange();
                    break;
                case "SalePlanTR":
                    f = new Payazob.FRM.SalePlan.frmSalePlan("TR");
                    break;
                case "SalePlanPL":
                    f = new Payazob.FRM.SalePlan.frmSalePlan("PL");
                    break;
                case "SalePlanQC":
                    f = new Payazob.FRM.SalePlan.frmSalePlan("QC");
                    break;
                case "SalePlanSC":
                    f = new Payazob.FRM.SalePlan.frmSalePlan("SC");
                    break;
                case "DayHourPlanning":
                    f = new frmDayHourPlanning();
                    break;
                case "Pieces_Report":
                    f = new FRM.Pieces.frmPiecesList(csEnum.Factory.Site1);
                    break;
                case "MoldingDownTimeByDetials":
                    f = new Payazob.frmMoldingDownTime(false, csEnum.Factory.Site1);
                    break;
                case "SandWeeklyTestRange":
                    f = new Payazob.FRM.Sand.frmSandWeeklyRange();
                    break;

                default:
                    return;
                    // f = new Form();
                    // break;
            }
            if (BLL.authentication.objectallow(frm))
            {
                BLL.csEvent Event = new BLL.csEvent();
                Event.eventlogin("LOGIN FORM", "", TitleForm, frm, BLL.authentication.x_.ToString());
                //    if (BLL.authentication.x_ == 5 || BLL.authentication.x_ == 58 || BLL.authentication.x_ == 51 || BLL.authentication.x_ == 26)
                //  {
                f.Text = TitleForm;
                f.Size = new System.Drawing.Size(950, 500);
                f.Show();


                // f.BringToFront();
                //   }
                //    else
                //    {
                //f.Text = TitleForm;
                //f.Size = new System.Drawing.Size(950, 500);
                //f.Show();
                //   }

            }
        }
    }
}
