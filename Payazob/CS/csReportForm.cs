namespace Payazob.CS
{
    public class csReportForm
    {
        public System.Data.DataTable OpenForm(string st)
        {
            System.Data.DataTable dt;
            switch (st)
            {
                //
                case "SlProductPlanningMachinig_Report":
                    dt = new BLL.ProductPlanning.csProductPlanning().SlProductPlanningMachinig_Report(DateFrom, DateTo);
                    break;
                case "SlPerFoodToken":
                    dt = new BLL.PerFoodStatus.csPerFoodStatus().SlPerFoodToken();
                    break;
                case "SlFoundryMaterialUsageByDay_Report":
                    dt = new BLL.csFoundry().SlFoundryMaterialUsageByDay_Report(DateFrom, DateTo);
                    break;
                case "SlProductPlanMachiningReportTotal":
                    dt = new BLL.ProductPlanning.csProductPlanning().SlProductPlanMachiningReportTotal(DateFrom, DateTo);
                    break;
                case "SlProductPlanMachiningReport":
                    dt = new BLL.ProductPlanning.csProductPlanning().SlProductPlanMachiningReport(DateFrom, DateTo);
                    break;
                case "SlSectionAidDeliveryTotalByDate":
                    dt = new BLL.Aid.csAid().SlSectionAidDeliveryTotalByDate(DateFrom, DateTo);
                    break;
                case "SlInventoryPiecesAllSite":
                    dt = new BLL.Inventory.csInventory().SlInventoryPiecesAllSite(Payazob.Properties.Settings.Default.WorkYear, DateFrom, DateTo);
                    break;
                case "SlProductInspectionDetails_Date_R":
                    dt = new BLL.csDefect().SlProductInspectionDetails_Date_R(DateFrom, DateTo);
                    break;
                case "SlSectionAidDeliveryUsePerDay":
                    dt = new BLL.Aid.csAid().SlSectionAidDeliveryUsePerDay(DateFrom, DateTo);
                    break;
                case "SlStockAfterShotBlastingPieces":
                    dt = new BLL.ShotBlasting.csShotBlasting().SlStockAfterShotBlastingPieces(DateFrom, DateFrom, Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "SlStockShotBlastingPieces":
                    dt = new BLL.ShotBlasting.csShotBlasting().SlStockShotBlastingPieces(DateFrom, DateFrom, Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "SlMoldList_R":
                    dt = new BLL.Mold.csMold().SlMoldListByPieces_R(-1);
                    break;
                case "SlPiecesProductMachiningOnFinalOp":
                    dt = new BLL.Inventory.csInventoryTurning().SlPiecesProductMachiningOnFinalOp(this.DateFrom, this.DateTo);
                    break;
                case "SlMoldingDownTimeByDetails":
                    dt = new BLL.MoldingDownTime.MoldingDownTime().SlMoldingDownTimeByDetails(DateFrom, DateTo, (int)CS.csEnum.Factory.Site3);
                    break;
                case "SlStockPiecesMachining":
                    dt = new BLL.Inventory.csInventoryTurning().SlStockPiecesMachining(DateFrom, DateFrom, Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "MoldingDownTime_EXCEL_Site3":
                    dt = new BLL.MoldingDownTime.MoldingDownTime().SlMoldingDownTimeByDetial(DateFrom, DateTo, (int)CS.csEnum.Factory.Site3);
                    break;
                case "SlPiecesProductMachining":
                    return new BLL.Inventory.csInventoryTurning().SlPiecesProductMachining(this.DateFrom, this.DateTo);

                case "SlMoldingDownTimeByMachine":
                    return new BLL.MoldingDownTime.MoldingDownTime().SlMoldingDownTimeByMachine(this.DateFrom, this.DateTo, 159);

                case "InventoryMaterialTurning":
                    return new BLL.Inventory.csInventoryTurning().SlInventoryMaterialTurning(this.DateFrom, this.DateTo, Payazob.Properties.Settings.Default.WorkYear);

                case "SlInventoryMaterial_S3":
                    return new BLL.Inventory.csInventoryTurning().SlInventoryMaterial_S3(Payazob.Properties.Settings.Default.WorkYear, this.DateFrom);

                case "SlPruductInspectionMachiningCheckList":
                    return new BLL.QualityControl.csProductInspectionMachining().SlPruductInspectionMachiningCheckList(this.DateFrom, this.DateTo);


                case "SlSectionAidUseForSec":
                    dt = new BLL.Aid.csAid().SlSectionAidUseForSec();
                    break;
                case "SlProductPlanningVsPieceProduct":
                    dt = new BLL.ProductPlanning.csProductPlanning().SlProductPlanningVsPieceProduct(DateFrom, DateTo);
                    break;
                case "SlSectionAidListAidForPer":
                    dt = new BLL.Aid.csAid().SlSectionAidListAidForPer();
                    break;
                case "SlFireExtingusherEXP":
                    dt = new BLL.AccidentsMinor.Accidents().SlFireExtingusherEXP();
                    break;
                case "SlCustomerReturn_Status":
                    dt = new BLL.CustomerReturn.csCustomerReturn().SlCustomerReturn_Status(DateFrom, DateTo);
                    break;
                case "SlSectionAidDelivryToPerCnt":
                    dt = new BLL.Aid.csAid().SlSectionAidDelivryToPerCnt(DateFrom, DateTo);
                    break;
                case "SlToolsUnknown":
                    dt = new BLL.Tools.csTools().SlToolsUnknown(DateFrom, DateTo);
                    break;
                case "SlToolsRetiring":
                    dt = new BLL.Tools.csTools().SlToolsRetiring(DateFrom, DateTo);
                    break;
                case "ObjectUseListAndLocation":
                    dt = new BLL.RequestObject.csRequestObject().SlObjectUseListAndLocation(DateFrom, DateTo);
                    break;
                case "ObjectListAndLocation":
                    dt = new BLL.RequestObject.csRequestObject().ObjectListAndLocation();
                    break;
                case "SlSectionAidPerdicUsage":
                    dt = new BLL.Aid.csAid().SlSectionAidPerdicUsage(Payazob.Properties.Settings.Default.WorkYear);
                    break;

                //case "SlOverTime_R":
                //    dt = new BLL.OverTime.csOverTime().SlOverTime_R(DateFrom, DateTo, -1);
                //    break;
                case "SlSalePlanTurningStock":
                    dt = new BLL.SalePlan.csSalePlanTurning().SlSalePlanTurningStock(Payazob.Properties.Settings.Default.WorkYear, DateFrom);
                    break;
                case "SendProductTurning_Report":
                    dt = new BLL.Inventory.csSendProductTurning().SlSendProductTurning(DateFrom, DateTo);
                    break;
                case "MuscleSend_R":
                    dt = new BLL.MuscleProduct.csMuscleProduct().SlMuscleSend(DateFrom, DateTo, "PL");
                    break;
                case "SalePlanTurning":
                    dt = new BLL.SalePlan.csSalePlanTurning().SlSalePlan(DateFrom, DateTo, "");
                    break;
                case "SlStockPieces":
                    dt = new BLL.csInventory().SlStockPieces(DateFrom, DateFrom, Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "SlMusclePlan":
                    dt = new BLL.MuscleProduct.csMuscleProduct().SlMusclePlan(DateFrom, DateTo, Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "SlMucsleSendReport":
                    dt = new BLL.MuscleProduct.csMuscleProduct().SlMucsleSendReport(DateFrom, DateTo);
                    break;
                case "PruductInspectionByMonthTotal":
                    dt = new BLL.csQualityControl().SlPruductInspectionByMonthTotal(Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "MoldingDownTime_EXCEL":
                    dt = new BLL.MoldingDownTime.MoldingDownTime().SlMoldingDownTimeByDetial(DateFrom, DateTo, (int)CS.csEnum.Factory.Site1);
                    break;
                case "PiecesProuductTime":
                    dt = new BLL.csInventory().SlPiecesProuductTime(DateFrom, DateTo);
                    break;
                case "MoldingSpeed":
                    dt = new BLL.csInventory().SlMoldingSpeed(DateFrom, DateTo);
                    break;
                case "PruductInspectionCompare":
                    dt = new BLL.csDefect().SlPruductInspectionCompare(DateFrom, DateTo);
                    break;
                case "FoundryMaterialUsageCheck":
                    dt = new BLL.csFoundry().SlFoundryMaterialUsageCheck(DateFrom, DateTo);
                    break;
                //case "PerFoodStatus":
                //    dt = new BLL.PerFoodStatus.csPerFoodStatus().SlPerFoodStatus(DateFrom, DateTo);
                //    break;
                //case "PerFoodCenterPrice":
                //    dt = new BLL.PerFoodStatus.csPerFoodStatus().SlPerFoodCenterPrice(DateFrom, DateTo);
                //    break;
                case "InventoryScrab":
                    dt = new BLL.Inventory.csInventoryScrab().SlInventoryScrab(DateFrom, DateTo, Payazob.Properties.Settings.Default.WorkYear);
                    break;
                case "ProcurmentScrabSuStu":
                    dt = new BLL.Procurement.csProcurmentScarbTest().SlProcurmentScrabSuStu(DateFrom, DateTo);
                    break;
                case "ProcurmentMaterialSuStu":
                    dt = new BLL.Procurement.csProcurmentMaterialTest().SlProcurmentMaterialSuStu(DateFrom, DateTo);
                    break;
                case "InvMaterialInput_Report":
                    dt = new BLL.FIFO.csInvMaterial().SlInvMaterialInput(DateFrom, DateTo);
                    break;
                case "SendProduct_Report":
                    dt = new BLL.csInventory().SelectSendProduct(DateFrom, DateTo);
                    break;
                case "Pieces_Report":
                    dt = new BLL.csPieces().SelectPiecesByName("", (int)CS.csEnum.GenFactoryGroupPieces.Site1);
                    break;
                case "FoundryDetailsTotalMeltByZint_Report":
                    dt = new BLL.csFoundry().SelectFoundryDetailsTotalMeltByZinter(DateFrom, DateTo);
                    break;
                case "ProductInspection_Report":
                    dt = new BLL.csDefect().SelectDefectByDate(DateFrom, DateTo);
                    break;
                case "SandMaterialUsage_Report":
                    dt = new BLL.csSand().SelectSandMaterialUsageSumAVGByDate(DateFrom, DateTo);
                    break;
                case "SandDailyReport_Report":
                    dt = new BLL.csSand().SelectSandDailyReport(DateFrom, DateTo);
                    break;

                case "InventoryTotal_Report":
                    dt = new BLL.csInventory().SelectInventoryGroupByPieces(DateFrom, DateTo, Properties.Settings.Default.WorkYear);
                    break;

                case "PruductInspectionDefectDetials_Report":
                    dt = new BLL.csDefect().SelectPruductInspectionDefectDetials(DateFrom, DateTo);
                    break;
                case "PiecesProuductAndDetial_Report":
                    dt = new BLL.csInventory().SelectPiecesProuductAndDetial(DateFrom, DateTo, Properties.Settings.Default.WorkYear);
                    break;

                case "SlPiecesProductByShift":
                    dt = new BLL.csInventory().SlPiecesProductByShift(DateFrom, DateTo, Properties.Settings.Default.WorkYear);
                    break;
                case "PiecesProuductAndDetialAll_Report":
                    dt = new BLL.csInventory().SelectPiecesProuductAndDetialAll(DateFrom, DateTo);
                    break;
                case "SandDailyReportAndRptEqu_Report":
                    dt = new BLL.csSand().SelectSandDailyReportAndReportEquipment(DateFrom, DateTo);
                    break;
                case "SalePlan":
                    dt = new BLL.SalePlan.csSalePlan().SlSalePlan(DateFrom, DateTo, "");
                    break;
                default:
                    dt = new System.Data.DataTable();
                    break;
            }
            return dt;
        }
        public string DateFrom;
        public string DateTo;

    }
}
