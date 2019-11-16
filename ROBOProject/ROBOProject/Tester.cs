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

            int time;       //para simular um intervalo de tempo
            //LEMBRE-SE: vc deve fazer um loop, onde as mudanças serao feitas a cada intervalo de tempo...
            //          ...com no maximo um estado por vez
            //System.Threading.Thread.Sleep(1000); <-- Sleep

            controller.MemberToString(robo);

            
        }
    }
}
