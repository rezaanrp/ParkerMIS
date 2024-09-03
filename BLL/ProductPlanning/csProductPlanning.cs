using System;

namespace BLL.ProductPlanning
{
    public class csProductPlanning
    {

        //
        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanMachiningReportTotalDataTable SlProductPlanMachiningReportTotal(string DateFrom, string DateTo)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanMachiningReportTotalTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanMachiningReportTotalTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanMachiningReportDataTable SlProductPlanMachiningReport(string DateFrom, string DateTo)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanMachiningReportTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanMachiningReportTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningVsPieceProductDataTable SlProductPlanningVsPieceProduct(string DateFrom, string DateTo)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningVsPieceProductTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningVsPieceProductTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningMachinig_ReportDataTable SlProductPlanningMachinig_Report(string DateFrom, string DateTo)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningMachinig_ReportTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningMachinig_ReportTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningTotal_reportDataTable SlProductPlanningTotal_Report(string DateFrom, string DateTo, int GenFactory_)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningTotal_reportTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningTotal_reportTableAdapter();
            return adp.GetData(DateFrom, DateTo, GenFactory_);
        }

        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanning_reportDataTable SlProductPlanning_Report(string DateFrom, string DateTo,int GenFactory_)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanning_reportTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanning_reportTableAdapter();
            return adp.GetData(DateFrom, DateTo,GenFactory_);
        }

        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDataTable SlProductPlanning(string DateFrom, string DateTo, int xGenFactory_)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningTableAdapter();
            return adp.GetData(DateFrom, DateTo, xGenFactory_);
        }

        public string UdProductPlanning(DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDataTable dt)
        {
            try
            {
                DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningTableAdapter adp =
                     new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningTableAdapter(); 
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }


        public DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDetialsDataTable SlProductPlanningDetials(int? x_)
        {
            DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningDetialsTableAdapter adp =
                 new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningDetialsTableAdapter();
            return adp.GetData(x_);
        }

        public string UdProductPlanningDetials(DAL.ProductPlanning.DataSet_ProductPlanning.SlProductPlanningDetialsDataTable dt)
        {
            try
            {
                DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningDetialsTableAdapter adp =
                     new DAL.ProductPlanning.DataSet_ProductPlanningTableAdapters.SlProductPlanningDetialsTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }




    }
}
