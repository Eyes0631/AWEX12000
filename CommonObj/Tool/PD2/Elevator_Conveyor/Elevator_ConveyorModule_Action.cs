using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaeLibGeneral;
using CommonObj;

namespace PD2_SDK
{
    public partial class Elevator_ConveyorModule : ElevatorBaseModule
    {
        public int GetSlot(bool HasProduct, bool bUpper)
        {
            //Enumerable.Range(start, count)：
            //start：起始值（包含這個值）
            //count：要產生幾個數字（不是終點值）
            var indices = bUpper
                ? Enumerable.Range(0, Module_Conveyors.Length)
                : Enumerable.Range(0, Module_Conveyors.Length).Reverse();

            foreach (int i in indices)
            {
                if (Module_Conveyors[i].CheckPanelExist(HasProduct) == ThreeValued.TRUE)
                    return i + 1;
            }

            return -1;
        }
    }
}
