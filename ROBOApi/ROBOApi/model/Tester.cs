using ROBOProject.control;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ROBOProject.model
{
    //PARA DEBUG DE INPUTS E ATUALIZAÇÕES
    //nao sera utilizado no produto final
    class Tester
    {
        /*
        static void Main(string[] args)
        {
            int timeTick=0;           //Para simular a passagem de tempo (1 timeTick == 1 seg)
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
            ROBO roboGoal = new ROBO(headGoal, rArmGoal, lArmGoal);

            
            controller.MembersToConsole(robo,roboGoal);
            while(true)      //loop infinito de execução
            {
                controller.manualSet(roboGoal);
                isUpdated = controller.GetIsUpdated();

                //timeTick e isUpdated nao estao funcionando direito
                while (!isUpdated)
                {
                    Console.Clear();
                    controller.MembersToConsole(robo,roboGoal);
                    Console.WriteLine("Tempo = {0}\n", timeTick);
                    timeTick++;
                    Thread.Sleep(1000);
                    controller.CompleteUpdate(robo, roboGoal);
                    isUpdated = controller.GetIsUpdated();
                }
                
            }

        }*/
    }
}
