using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Test
{
    public class csTest
    {
        public DAL.Test.DataSet_Test.mTest01DataTable mTest()
        {
            DAL.Test.DataSet_TestTableAdapters.mTest01TableAdapter adp =
                new DAL.Test.DataSet_TestTableAdapters.mTest01TableAdapter();
            return adp.GetData();
        }

        public string UdTest(DAL.Test.DataSet_Test.mTest01DataTable dt)
        {
            try
            {
                DAL.Test.DataSet_TestTableAdapters.mTest01TableAdapter adp =
                    new DAL.Test.DataSet_TestTableAdapters.mTest01TableAdapter();
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
