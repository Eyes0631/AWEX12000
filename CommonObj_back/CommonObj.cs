using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KCSDK;

namespace CommonObj
{
    public class CommonObj
    {
    }

    //By Max, 20220418
    public class VIDDS
    {
        private static readonly object Mutex = new object();
        private static volatile KCSDK.DataManagement _instance;

        private VIDDS()
        {
            _instance = new DataManagement();
        }

        public static KCSDK.DataManagement DS
        {
            get
            {
                if (_instance == null)
                {
                    lock (Mutex)
                    {
                        if (_instance == null)
                        {
                            _instance = new KCSDK.DataManagement();
                            _instance.ModifiedLog = false;
                            _instance.ModifiedLogToDB = false;
                        }
                    }
                }
                return _instance;
            }
        }

        public static DataTransfer ReadValue(String DataName)
        {
            return DS.ReadValue(DataName);
        }

        public static void SetValue(string FieldName, object value)
        {
            DS.SetData(FieldName, "String", value);
        }
    }
}
