using ROBOProject.controller;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ROBOProject.model
{
    class Tester
    {
        static void Main(string[] args)
        {
            int timeTick;           //Para simular a passagem de tempo (1 timeTick == 1 seg)
            Boolean isUpdated = false;

            //Declaracao do ROBO atual
            ROBOControl controller = new ROBOControl();
            Arm lArm = new Arm("Left");
            Arm rArm = new Arm("Right");
            Head head = new Head();
            ROBO robo = new ROBO(head, rArm, lArm);

            //Declaracao do ROBO alvo, com estados que se deseja chegar
            Arm lArmGoal = new Arm("Left");
            Arm rArmGoal = new Arm("Right");
            Head headGoal = new Head();
            ROBO roboGoal = new ROBO(head, rArm, lArm);


            controller.MembersToString(robo);
            for (timeTick = 0; true; timeTick++)        //loop infinito de execução
            {
                controller.manualSet(roboGoal);
                
                //timeTick e isUpdated nao estao funcionando direito
                while(!isUpdated)
                {
                    controller.CompleteUpdate(robo, roboGoal);
                    Thread.Sleep(1000);
                    isUpdated = robo.Equals(roboGoal);
                    timeTick++;
                }
            }

        }
    }
}
