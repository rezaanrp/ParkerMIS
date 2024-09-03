﻿using System;

namespace BLL.RequestItService
{
    public class csRequestItService
    {
        public DAL.RequestITService.DataSet_RequestItService.mRequestITPrinterDataTable mRequestITPrinter(string xDateFrom, string xDateTo, int x_)
        {
            DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestITPrinterTableAdapter adp
                 = new DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestITPrinterTableAdapter();
            return adp.GetData(xDateFrom, xDateTo, x_);
        }
        public string UdRequestITPrinter(DAL.RequestITService.DataSet_RequestItService.mRequestITPrinterDataTable dt)
        {
            try
            {
                DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestITPrinterTableAdapter adp
                     = new DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestITPrinterTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
        public DAL.RequestITService.DataSet_RequestItService.mRequestItServiceDataTable RequestItService(string xDateFrom, string xDateTo,int x_ )
       {
           DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestItServiceTableAdapter adp
                = new DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestItServiceTableAdapter();
           return adp.GetData(xDateFrom, xDateTo, x_);
       }
       public string UdRequestITService(DAL.RequestITService.DataSet_RequestItService.mRequestItServiceDataTable dt)
       {
           try
           {
               DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestItServiceTableAdapter adp
                    = new DAL.RequestITService.DataSet_RequestItServiceTableAdapters.mRequestItServiceTableAdapter();
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