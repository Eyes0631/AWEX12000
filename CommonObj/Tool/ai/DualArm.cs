using System;
using System.Threading;

class DualArmController
{
    //// 機械手臂當前 X 位置
    //public double Arm1Position { get; set; }
    //public double Arm2Position { get; set; }

    //// 機械手臂的寬度
    //public double Arm1Width { get; set; }
    //public double Arm2Width { get; set; }

    //// 基本安全距離，避免兩隻手臂碰撞
    //public double BaseSafeDistance { get; set; }

    //// 目標位置
    //public double Arm1Target { get; set; }
    //public double Arm2Target { get; set; }

    //// 移動速度
    //public double Arm1Speed { get; set; }
    //public double Arm2Speed { get; set; }

    //// 是否仍在移動
    //private bool arm1Moving = true;
    //private bool arm2Moving = true;

    //// 手臂優先級（高優先級的手臂優先移動）
    //public enum Priority { High, Low }
    //public Priority Arm1Priority { get; set; }
    //public Priority Arm2Priority { get; set; }

    //// 構造函數：初始化手臂參數
    //public DualArmController(
    //    double arm1Start, double arm2Start, double arm1Width, double arm2Width,
    //    double baseSafeDistance, double arm1Target, double arm2Target,
    //    double arm1Speed, double arm2Speed, Priority arm1Priority, Priority arm2Priority)
    //{
    //    Arm1Position = arm1Start;
    //    Arm2Position = arm2Start;
    //    Arm1Width = arm1Width;
    //    Arm2Width = arm2Width;
    //    BaseSafeDistance = baseSafeDistance;
    //    Arm1Target = arm1Target;
    //    Arm2Target = arm2Target;
    //    Arm1Speed = arm1Speed;
    //    Arm2Speed = arm2Speed;
    //    Arm1Priority = arm1Priority;
    //    Arm2Priority = arm2Priority;
    //}

    //// 主運行函數，控制手臂移動
    //public void Run()
    //{
    //    while (arm1Moving || arm2Moving)
    //    {
    //        // 計算手臂寬度影響後的安全距離
    //        double safeDistance = BaseSafeDistance + (Arm1Width + Arm2Width) / 2;

    //        // 預測下一步移動後的距離，避免碰撞
    //        double predictedArm1Pos = MoveTowards(Arm1Position, Arm1Target, Arm1Speed);
    //        double predictedArm2Pos = MoveTowards(Arm2Position, Arm2Target, Arm2Speed);
    //        double predictedDistance = Math.Abs(predictedArm1Pos - predictedArm2Pos);

    //        // 若預測會碰撞，低優先級手臂進行調整
    //        if (predictedDistance < safeDistance)
    //        {
    //            if (Arm1Priority == Priority.Low)
    //            {
    //                //Console.WriteLine("Arm1 adjusting movement to avoid collision.");
    //                AdjustArmMovement(ref Arm1Speed, ref Arm1Position, Arm1Target, Arm2Position);
    //            }
    //            else if (Arm2Priority == Priority.Low)
    //            {
    //                //Console.WriteLine("Arm2 adjusting movement to avoid collision.");
    //                AdjustArmMovement(ref Arm2Speed, ref Arm2Position, Arm2Target, Arm1Position);
    //            }
    //        }

    //        // 移動手臂 1
    //        if (arm1Moving)
    //        {
    //            Arm1Position = MoveTowards(Arm1Position, Arm1Target, Arm1Speed);
    //            //Console.WriteLine($"Arm1 Position: {Arm1Position}");
    //            if (Arm1Position == Arm1Target) { arm1Moving = false; Console.WriteLine("Arm1 reached target."); }
    //        }

    //        // 移動手臂 2
    //        if (arm2Moving)
    //        {
    //            Arm2Position = MoveTowards(Arm2Position, Arm2Target, Arm2Speed);
    //            //Console.WriteLine($"Arm2 Position: {Arm2Position}");
    //            if (Arm2Position == Arm2Target) { arm2Moving = false; Console.WriteLine("Arm2 reached target."); }
    //        }

    //        Thread.Sleep(200); // 控制程式運行速度
    //    }

    //    Console.WriteLine("Both arms completed their tasks.");
    //}

    //// 讓座標朝目標方向移動
    //private double MoveTowards(double current, double target, double step)
    //{
    //    return current < target ? Math.Min(current + step, target) : Math.Max(current - step, target);
    //}

    //// 調整手臂的移動方式，避免碰撞
    //private void AdjustArmMovement(ref double armSpeed, ref double armPosition, double target, double otherArmPosition)
    //{
    //    // 減速至 50%，但不低於 0.5
    //    armSpeed = Math.Max(armSpeed * 0.5, 0.5);
        
    //    // 若仍然可能碰撞，則短暫往相反方向移動
    //    if (Math.Abs((armPosition + armSpeed) - otherArmPosition) < BaseSafeDistance)
    //    {
    //        armPosition += (armPosition < otherArmPosition) ? -0.5 : 0.5;
    //    }
    //}
}

class Program
{
    static void Main(string[] args)
    {
        //// 初始化手臂控制器，設置手臂初始位置、目標、速度、寬度和優先級
        //var controller = new DualArmController(
        //    arm1Start: 0, arm2Start: 0,
        //    arm1Width: 3.0, arm2Width: 5.0,
        //    baseSafeDistance: 10.0,
        //    arm1Target: 20, arm2Target: 30,
        //    arm1Speed: 1.5, arm2Speed: 1.0,
        //    arm1Priority: DualArmController.Priority.High,
        //    arm2Priority: DualArmController.Priority.Low
        //);

        //controller.Run();
    }
}
