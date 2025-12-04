using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CommonObj
{

    /// <summary>
    /// 從AWEX11002LM 抓過來用，不確定是否有重複
    /// </summary>
    public enum WOI_ActionMode
    {
        None,
        Connect,
        Inspection,
        SetInch8,
        SetInch12,
        TeachAngle,
    }

    /// <summary>
    /// 從AWEX11002LM 抓過來用，不確定是否有重複
    /// </summary>
    public enum WAS_ActionMode
    {
        None,
        Align,
        VaccumSW,
        PreAction,
        CheckHasWafer,//v1.0.0.4
    }

    /// <summary>
    /// 從AWEX11002LM 抓過來用，不確定是否有重複
    /// </summary>
    public enum WTR_ActionMode
    {
        None,
        Get,
        Put,
        Mapping,
        Home,
        PreAction,
        CheckArmHasWafer,
    }

    /// <summary>
    /// 從AWEX11002LM 抓過來用，不確定是否有重複
    /// </summary>
    public enum FLP_ActionMode
    {
        None,
        Lock,
        Unlock,
        Open,
        Close,
        InputID,
        Convex_Cylinder,
    }

    /// <summary>
    /// PPM(e04 誰知道PPM是什麼)
    /// </summary>
    /// 
    [Flags]
    public enum enum_PPM_ActionMode
    {
        [Description("Default")]
        None,
        //動作
        [Description("取料板")]
        Pick = 1 << 0,
        [Description("放料板")]
        Place = 1 << 1,
        [Description("預備取放料板")]
        PreAction = 1 << 2,
        [Description("U軸移動")]
        MoveU = 1 << 3,
        /// <summary>
        /// 位置
        /// </summary>
        [Description("入料站")]
        PTI = 1 << 5,
        [Description("Plasma")]
        Plasma = 1 << 6,
        [Description("出料站")]
        PTO = 1 << 7,
        [Description("儲存槽")]
        Buffer = 1 << 8,
        [Description("單模組復歸")]
        ModuleHome = 1 << 10,

        [Description("上手臂")]
        UpperArm = 1 << 11,
        [Description("下手臂")]
        LowerArm = 1 << 12,
    }
    /// <summary>
    /// PTI
    /// </summary>
    [Flags]
    public enum enum_PTI_ActionMode
    {
        //PVD是指物理氣相沉積（Physical Vapor Deposition），是一種在真空環境下，利用物理方法將材料蒸發後，在基材表面形成薄膜的技術。 
        [Description("Default")]
        None = 0,
        //動作
        [Description("進料板")]
        INPUT = 1 << 0,
        [Description("出料板")]
        OUTPUT = 1 << 1,
        [Description("預備取放料板")]
        PreAction = 1 << 2,
        [Description("單模組復歸")]
        ModuleHome = 1 << 10,
    }
    /// <summary>
    /// PTO
    /// </summary>
    [Flags]
    public enum enum_PTO_ActionMode
    {
        [Description("Default")]
        None = 0,
        //動作
        [Description("進料板")]
        INPUT = 1 << 0,
        [Description("出料板")]
        OUTPUT = 1 << 1,
        [Description("預備取放料板")]
        PreAction = 1 << 2,
        [Description("單模組復歸")]
        ModuleHome = 1 << 10,
    }
    //end


}
