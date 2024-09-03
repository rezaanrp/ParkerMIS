using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BLL.Inventory
{
  public  class csInventory
    {
        public DataTable SlInventoryPiecesAllSite(string WorkYear,string DateFrom, string DateTo)
        {
            string con = new DAL.csConnection().GetConeectionPaya;
            using (SqlConnection sqlcon = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("SlInventoryPiecesAllSite", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@WorkYear", WorkYear));
                    cmd.Parameters.Add(new SqlParameter("@datefrom", DateFrom));
                    cmd.Parameters.Add(new SqlParameter("@dateto", DateTo));
                    cmd.CommandTimeout = 200;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        return dt;
                    }
                }
            }

        }
    }
}
