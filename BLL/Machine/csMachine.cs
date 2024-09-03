using System;

namespace BLL.Machine
{
    public class csMachine
    {
        public DAL.Machine.DataSet_Machine.mMachineByLineNameDataTable mMachineByLineName(int? xGenLineName_, int xGenFact_)
        {
            DAL.Machine.DataSet_MachineTableAdapters.mMachineByLineNameTableAdapter
                adp = new DAL.Machine.DataSet_MachineTableAdapters.mMachineByLineNameTableAdapter();
            return adp.GetData(xGenLineName_, xGenFact_);
        }
        public DAL.Machine.DataSet_Machine.mMachineBySTMACHINEDataTable mMachineBySTMACHINE(int? xGenSTMACHINE_ , int xGenFact_)
        {
            DAL.Machine.DataSet_MachineTableAdapters.mMachineBySTMACHINETableAdapter
                adp = new DAL.Machine.DataSet_MachineTableAdapters.mMachineBySTMACHINETableAdapter();
            return adp.GetData(xGenSTMACHINE_, xGenFact_ );
        }
        public DAL.Machine.DataSet_Machine.mMachineDataTable mMachine(int xGenFact_)
       {
           DAL.Machine.DataSet_MachineTableAdapters.mMachineTableAdapter 
               adp = new DAL.Machine.DataSet_MachineTableAdapters.mMachineTableAdapter();
           return adp.GetData(xGenFact_);
       }
       public string UdMachine(DAL.Machine.DataSet_Machine.mMachineDataTable dt)
       {
           try
           {
               DAL.Machine.DataSet_MachineTableAdapters.mMachineTableAdapter adp
                    = new DAL.Machine.DataSet_MachineTableAdapters.mMachineTableAdapter();
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
