using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.ProductPiecesOnMolding
{
   public class csProductPiecesOnMolding
    {      
        public DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingListDataTable mProductPiecesOnMoldingList(int xProductPiecesOnMolding_)
        {
            DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingListTableAdapter adp
                = new DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingListTableAdapter();
                 return adp.GetData(xProductPiecesOnMolding_ );
        }
        public string UdProductPiecesOnMoldingList(DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingListDataTable dt)
        {
            try
            {
                DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingListTableAdapter adp
                    = new DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingListTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingDataTable ProductPiecesOnMolding(string DateFrom, string DateTo)
        {
            DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingTableAdapter adp
                = new DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingTableAdapter();
                 return adp.GetData(DateFrom, DateTo);
        }
        public string UdProductPiecesOnMolding(DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMolding.mProductPiecesOnMoldingDataTable dt)
        {
            try
            {
                DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingTableAdapter adp
                    = new DAL.ProductPiecesOnMolding.DataSet_ProductPiecesOnMoldingTableAdapters.mProductPiecesOnMoldingTableAdapter();
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
