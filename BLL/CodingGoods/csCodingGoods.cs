using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.CodingGoods
{
  public  class csCodingGoods
    {

        public DAL.CodingGoods.DataSet_CodingGoods.mCodingGoodsDataTable mCodingGoods(string DateFrom, string DateTo,int xSupplier_)
        {
            DAL.CodingGoods.DataSet_CodingGoodsTableAdapters.mCodingGoodsTableAdapter
                adp = new DAL.CodingGoods.DataSet_CodingGoodsTableAdapters.mCodingGoodsTableAdapter();
            return adp.GetData(DateFrom, DateTo, xSupplier_);
        }
        public string UdCodingGoods(DAL.CodingGoods.DataSet_CodingGoods.mCodingGoodsDataTable dt)
        {
            try
            {
                DAL.CodingGoods.DataSet_CodingGoodsTableAdapters.mCodingGoodsTableAdapter
                    adp = new DAL.CodingGoods.DataSet_CodingGoodsTableAdapters.mCodingGoodsTableAdapter();
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
