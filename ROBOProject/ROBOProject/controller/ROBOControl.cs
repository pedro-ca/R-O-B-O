using ROBOProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOProject.controller
{
    class ROBOControl 
    {
        //Metodo que atualiza todos os membros do robo
        public ROBO CompleteUpdate(ROBO robo,ROBO roboGoal)
        {

            UpdateHeadInclination(robo.GetHead(), roboGoal.GetHead().GetInclination());
            UpdateHeadRotation(robo.GetHead(), roboGoal.GetHead().GetRotation());
            UpdateWrist(robo.GetRightArm(), roboGoal.GetRightArm().GetWrist());
            UpdateElbow(robo.GetRightArm(), roboGoal.GetRightArm().GetElbow());
            UpdateWrist(robo.GetLeftArm(), roboGoal.GetLeftArm().GetWrist());
            UpdateElbow(robo.GetLeftArm(), roboGoal.GetLeftArm().GetElbow());

            MembersToString(robo);
            return robo;
        }

        //Metodos Update (Adiciona ou subrai 1, se estado != valor)
        public Arm UpdateWrist(Arm arm, int value)
        {
            //if (arm.GetElbow() == 3)    //só ocorre mudança se o cotovelo esteja "fortemente contraido"
            //{
                if (arm.GetWrist() > value)
                {
                    arm.SetWrist(arm.GetWrist() - 1);
                }
                else if (arm.GetWrist() < value)
                {
                    arm.SetWrist(arm.GetWrist() + 1);
                }
            //}
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
            //if (head.GetInclination() != 3)     //nao pode ocorrer mudança se a inclinacao esteja "para baixo"
            //{

                if (head.GetRotation() > value)
                {
                    head.SetRotation(head.GetRotation() - 1);
                }
                if (head.GetRotation() < value)
                {
                    head.SetRotation(head.GetRotation() + 1);
                }
            //}
            return head;
        }


        //Membro para String (p/ debug)
        public void MembersToString(ROBO robo)
        {
            //Deve interagir com o dicionario
            Console.WriteLine("===============================================");
            Console.WriteLine("Head rotation: {0}", robo.GetHead().GetRotation());
            Console.WriteLine("Head Inclination: {0}", robo.GetHead().GetInclination());
            Console.WriteLine("Right Wrist : {0}", robo.GetRightArm().GetWrist());
            Console.WriteLine("Right Elbow : {0}", robo.GetRightArm().GetElbow());
            Console.WriteLine("Left Wrist : {0}", robo.GetLeftArm().GetWrist());
            Console.WriteLine("Left Elbow : {0}", robo.GetLeftArm().GetElbow());
            Console.WriteLine("===============================================");
        }


        //Utilizado para setar atributos de um ROBO pelo console (p/ debug)
        public ROBO manualSet(ROBO roboGoal)
        {
            string memberInput;     //membro que sera modificado (Head, RArm ou LArm)
            string stateInput;      //qual atributo do membro será modificado
            int valueInput;         //para qual valor o atributo ira
            string answer;

            Console.WriteLine("Deseja atualizar algum atributo do ROBO resultante?\n -y\n -n");
            answer = Console.ReadLine();
            while (answer == "y")
            {
                Console.WriteLine("Membro que modificará o estado (String):");
                Console.WriteLine(" -Head \n -RArm \n -LArm \n -none");
                memberInput = Console.ReadLine();
                Console.WriteLine("Atributo a ser modificado (String):");
                if (memberInput == "Head")
                    Console.WriteLine(" -Rota \n -Incli \n -none");
                else if (memberInput == "RArm" || memberInput == "LArm")
                    Console.WriteLine(" -Wrist \n -Elbow \n -none");
                stateInput = Console.ReadLine();
                Console.WriteLine("Valor designado para o atributo (int):");
                valueInput = Convert.ToInt32(Console.ReadLine());
                switch (memberInput)

                {
                    case "Head":
                        if (stateInput == "Rota")
                        {
                            roboGoal.GetHead().SetRotation(valueInput);
                        }
                        else if (stateInput == "Incli")
                        {
                            roboGoal.GetHead().SetInclination(valueInput);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum atributo da cabeca sera atualizado \n");
                        }
                        break;

                    case "RArm":
                        if (stateInput == "Wrist")
                        {
                            roboGoal.GetRightArm().SetWrist(valueInput);
                        }
                        else if (stateInput == "Elbow")
                        {
                            roboGoal.GetRightArm().SetElbow(valueInput);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum atributo do braço direito sera atualizado \n");
                        }
                        break;

                    case "LArm":
                        if (stateInput == "Wrist")
                        {
                            roboGoal.GetLeftArm().SetWrist(valueInput);
                        }
                        else if (stateInput == "Elbow")
                        {
                            roboGoal.GetLeftArm().SetElbow(valueInput);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum atributo do braço direito sera atualizado \n");
                        }
                        break;

                    default:
                        Console.WriteLine("Nenhum membro sera atualizado \n");
                        break;
                }

                Console.WriteLine("Deseja atualizar algum atributo do ROBO alvo?\n -y\n -n");
                answer = Console.ReadLine();
            }

            return roboGoal;
        }
       
    }
}
