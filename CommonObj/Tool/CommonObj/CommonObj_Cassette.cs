using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonObj
{
    public class CCassette
    {
        public string sID;
        public string sRunCard;
        public int Production_Quantity;
        public string RecipeName;
        public string OPID;
        public string ROW_COL;

        public void Reset()
        {
            sID = "";
            sRunCard = "";
            RecipeName = "";
            OPID = "";
            ROW_COL = "";
            Production_Quantity = -1;
        }
    }
}
