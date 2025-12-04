using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProVLib;
using PaeLibGeneral;

namespace CommonObj
{
    //public interface Interface_MainFlow
    //{
    //    void LoadPackageData();
    //    void LoadOptionData();
    //    void DataReset();
    //    void Initial();
    //    void AlwaysRun();
    //    void ScanIO();
    //    void HomeReset();
    //    bool Home();
    //    void RunReset();
    //    void Run();
    //    void ManualReset();
    //    void ManualRun();
    //    void MaintenanceReset();
    //    void MaintenanceRun();
    //    void DisposeTH();
    //    void FlowChartRecord();
    //}

    public interface Interface_Module
    {
        void LoadBasicData();
        void DataReset();
        void FlowChartRecord();
        bool IsAxisZSafe();
        bool CheckSimulationOrNoUseModule();
        bool CheckDryRun();
        void AfterSaveParam();
        ThreeValued SetActionCommand(CommandClass CommClass);
        ThreeValued GetActionResult(CommandClass CommClass);
    }
}
