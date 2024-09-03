using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.SendPiecesToProduct
{
   public class csSendPiecesToProduct
    {
        public DAL.SendPiecesToProduct.DataSet_SendPiecesToProduct.mSendPiecesToProductDataTable SendPiecesToProduct(string xDateFrom, string xDateTo)
        {
            DAL.SendPiecesToProduct.DataSet_SendPiecesToProductTableAdapters.mSendPiecesToProductTableAdapter adp
                 = new DAL.SendPiecesToProduct.DataSet_SendPiecesToProductTableAdapters.mSendPiecesToProductTableAdapter();
            return adp.GetData(xDateFrom, xDateTo);
        }
        public string UdSendPiecesToProduct(DAL.SendPiecesToProduct.DataSet_SendPiecesToProduct.mSendPiecesToProductDataTable dt)
        {
            try
            {
                DAL.SendPiecesToProduct.DataSet_SendPiecesToProductTableAdapters.mSendPiecesToProductTableAdapter adp
                     = new DAL.SendPiecesToProduct.DataSet_SendPiecesToProductTableAdapters.mSendPiecesToProductTableAdapter();
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
