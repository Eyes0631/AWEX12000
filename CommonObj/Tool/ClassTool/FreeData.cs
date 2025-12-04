using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeDataJ;

namespace CommonObj
{
    public class FreeDataLib
    {

        //private IFreeData fdInfo;
        //private IFreeData fdPara;
        private IFreeData fdRecoverData;

        /// <summary>
        /// 有無安裝資料庫
        /// </summary>
        public FreeDataLib(bool SW)
        {
            FreeDataBuilder builder = new FreeDataBuilder(SW);

            if (builder != null)
            {
                fdRecoverData = builder.GetTable<MotionRecord>();
            }

        }

        public void Write(string STR)
        {
            var Record = new MotionRecord
            {
                ModuleNmae = STR,

                iAxis_1 = 11,
                iAxis_2 = 21,
                iAxis_3 = 31,
            };
            fdRecoverData.Write(Record);
        }

        public void Read(string STR)
        {
            var Record = fdRecoverData.Read<MotionRecord>(cp=>cp.ModuleNmae == STR);            
        }



    }
}
