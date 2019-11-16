using ROBOProject.controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOProject.model
{
    class Tester
    {
        static void Main(string[] args)
        {
            ROBOControl controller = new ROBOControl();

            Arm lArm = new Arm("Left");
            Arm rArm = new Arm("Right");
            Head head = new Head();
            ROBO robo = new ROBO(head, rArm, lArm);

            controller.MemberToString(robo);
        }
    }
}
