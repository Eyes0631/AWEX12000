using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ProVSocketLib;
using PaeLibGeneral;
using ProVLib;

namespace CommonObj.Tool.SMEMA
{
    public enum SmemaRole
    {
        Upstream,   // 送板設備
        Downstream  // 接板設備
    }

    public class Smema_IO
    {
        public InBit ib_MachineReady;      // 下游 MR or 上游提供給我用的 MR
        public InBit ib_BoardAvailable;    // 上游 BA or 我自己發出的 BA
        public InBit ib_ExitSensor;        // 板子是否已離開出口（Upstream）
        public InBit ib_EntrySensor;       // 板子是否已到達入口（Downstream）
        public InBit ib_NG;       // NG板（Downstream）
        public InBit ib_OK;       // OK板（Downstream）

        public OutBit ob_MachineReady;     // 我可以接收板子（Downstream）
        public OutBit ob_BoardAvailable;   // 我有板子要送（Upstream）
        public OutBit ob_NG;       // NG板（Upstream）
        public OutBit ob_OK;       // OK板（Upstream）

    }

    public class SmemaController
    {
        private readonly SmemaRole role;

        private Smema_IO MyIO;

        public SmemaController(SmemaRole role, Smema_IO mIO)
        {
            MyIO = mIO;
            this.role = role;
        }

        #region UpStream
        public bool CanSendBoard()
        {
            if (role != SmemaRole.Upstream) return false;
            return MyIO.ib_MachineReady.Value; // 下游已準備好接收
        }

        public void SetBoardAvailable(bool state)
        {
            if (role != SmemaRole.Upstream) return;
            MyIO.ob_BoardAvailable.Value = state;
        }

        public void SignalOKBoard()
        {
            if (role != SmemaRole.Upstream) return;
            MyIO.ob_OK.Value = true;
            MyIO.ob_NG.Value = false;
        }

        public void SignalNGBoard()
        {
            if (role != SmemaRole.Upstream) return;
            MyIO.ob_OK.Value = false;
            MyIO.ob_NG.Value = true;
        }
        #endregion UpStream

        #region DownStream
        public bool CanReceiveBoard()
        {
            if (role != SmemaRole.Downstream) return false;
            return MyIO.ib_BoardAvailable.Value; // 上游有板子送出
        }

        public void SetMachineReady(bool state)
        {
            if (role != SmemaRole.Downstream) return;
            MyIO.ob_MachineReady.Value = state;
        }

        public bool IsOKBoard()
        {
            return MyIO.ib_OK.Value;
        }

        public bool IsNGBoard()
        {
            return MyIO.ib_NG.Value;
        }
        #endregion DownStream

        #region 共用方法
        public void ResetResultSignals()
        {
            MyIO.ob_OK.Value = false;
            MyIO.ob_NG.Value = false;
        }

        public void ResetOutputs()
        {
            MyIO.ob_BoardAvailable.Value = false;
            MyIO.ob_MachineReady.Value = false;
            ResetResultSignals();
        }
        #endregion 共用方法
    }
}
