using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
  public  class Class2
    {
        public string testwebservice()
        {

            ServiceReferenceTest.FirstWebServiceClient ss = new ServiceReferenceTest.FirstWebServiceClient();
            return ss.Message();
        }
    }
}
