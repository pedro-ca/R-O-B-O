using ROBOProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOProject.controller
{
    class ROBOControl 
    {
        //Metodos Update (Adiciona ou subrai 1, se estado != valor)
        public Arm UpdateWrist(Arm arm, int value)
        {
            if(arm.GetWrist() > value)
            {
                arm.SetWrist( arm.GetWrist() - 1 );
            }
            else if(arm.GetWrist() < value)
            {
                arm.SetWrist( arm.GetWrist() + 1 );
            }
            //só ocorre mudança se o cotovelo esteja "fortemente contraido"
            //arm.GetElbow() = 3;
            return arm;
        }
        
        public Arm UpdateElbow(Arm arm, int value)
        {
            if (arm.GetElbow() > value)
            {
                arm.SetElbow( arm.GetElbow() - 1 );
            }
            else if (arm.GetElbow() < value)
            {
                arm.SetElbow( arm.GetElbow() + 1 );
            }
            return arm;
        }

        public Head UpdateHeadInclination(Head head, int value)
        {
            if (head.GetInclination() > value)
            {
                head.SetInclination( head.GetInclination() - 1 );
            }
            if (head.GetInclination() < value)
            {
                head.SetInclination( head.GetInclination() + 1 );
            }
            return head;
        }

        public Head UpdateHeadRotation(Head head, int value)
        {
            if (head.GetRotation() > value)
            {
                head.SetRotation( head.GetRotation() - 1 );
            }
            if (head.GetRotation() < value)
            {
                head.SetRotation( head.GetRotation() + 1 );
            }
            //nao pode ocorrer mudança se a inclinacao esteja "para baixo"
            //head.GetInclination != 3
            return head;
        }


        //Member to String (p/ debug)
        public void MemberToString(ROBO robo)
        {
            //Deve interagir com o dicionario
            Console.WriteLine("Head rotation: {0}", robo.GetHead().GetRotation());
            Console.WriteLine("Head Inclination: {0}", robo.GetHead().GetInclination());
            Console.WriteLine("Right Wrist : {0}", robo.GetRightArm().GetWrist());
            Console.WriteLine("Right Elbow : {0}", robo.GetRightArm().GetElbow());
            Console.WriteLine("Left Wrist : {0}", robo.GetLeftArm().GetWrist());
            Console.WriteLine("Left Elbow : {0}", robo.GetLeftArm().GetElbow());
        }
       
    }
}
