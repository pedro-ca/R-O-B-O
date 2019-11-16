using ROBOProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOProject.controller
{
    class ROBOControl
    {
        public Arm UpdateWrist(Arm arm, int value)
        {
            arm.SetWrist(value);
            return arm;
        }
        
        public Arm UpdateElbow(Arm arm, int value)
        {
            arm.SetElbow(value);
            return arm;
        }

        public Head UpdateHeadInclination(Head head, int value)
        {
            head.SetInclination(value);
            return head;
        }

        public Head UpdateHeadRotation(Head head, int value)
        {
            head.SetRotation(value);
            return head;
        }

        public void MemberToString(ROBO robo)
        {
            Console.WriteLine("Head rotation: {0}", robo.GetHead().GetRotation());
            Console.WriteLine("Head Inclination: {0}", robo.GetHead().GetInclination());
            Console.WriteLine("Right Wrist : {0}", robo.GetRightArm().GetWrist());
            Console.WriteLine("Right Elbow : {0}", robo.GetRightArm().GetElbow());
            Console.WriteLine("Left Wrist : {0}", robo.GetLeftArm().GetWrist());
            Console.WriteLine("Left Elbow : {0}", robo.GetLeftArm().GetElbow());
        }
       
    }
}
