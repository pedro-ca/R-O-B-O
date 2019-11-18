using ROBOProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOProject.control
{
    class ROBOControl 
    {
        private bool isUpdated;

        public bool GetIsUpdated()
        {
            return isUpdated;
        }

        public void SetIsUpdated(bool value)
        {
            isUpdated = value;
        }

        //Metodo que atualiza todos os membros do robo
        public ROBO CompleteUpdate(ROBO robo,ROBO roboGoal)
        {
            this.isUpdated = true;
            UpdateHeadInclination(robo.GetHead(), roboGoal.GetHead().GetInclination());
            UpdateHeadRotation(robo.GetHead(), roboGoal.GetHead().GetRotation());
            UpdateElbow(robo.GetRightArm(), roboGoal.GetRightArm().GetElbow());
            UpdateElbow(robo.GetLeftArm(), roboGoal.GetLeftArm().GetElbow());
            UpdateWrist(robo.GetLeftArm(), roboGoal.GetLeftArm().GetWrist());
            UpdateWrist(robo.GetRightArm(), roboGoal.GetRightArm().GetWrist());

            return robo;
        }

        //Metodos Update (Adiciona ou subrai 1, se estado != valor)
        public Arm UpdateWrist(Arm arm, int value)
        {
            if (value < 1 || value > 7)
            {
                Console.WriteLine("!! Para o pulso, Valor = {0} é invalido. Tente um valor entre 1 e 7",value);
                return arm;
            }
            if (arm.GetElbow() == 3)    //só ocorre mudança se o cotovelo esteja "fortemente contraido"
            {
                if (arm.GetWrist() > value)
                {
                    this.isUpdated = false;
                    arm.SetWrist(arm.GetWrist() - 1);
                }
                else if (arm.GetWrist() < value)
                {
                    this.isUpdated = false;
                    arm.SetWrist(arm.GetWrist() + 1);
                }
            }
            else
            {
                Console.WriteLine("* Rotação do Pulso atualmente bloqueada, pois Cotovelo != 3");
            }
            return arm;
        }
        
        public Arm UpdateElbow(Arm arm, int value)
        {
            if (value < 1 || value > 3)
            {
                Console.WriteLine("!! Para o cotovelo, Valor = {0} é invalido. Tente um valor entre 1 e 3",value);
                return arm;
            }
            if (arm.GetElbow() > value)
            {
                this.isUpdated = false;
                arm.SetElbow( arm.GetElbow() - 1 );
            }
            else if (arm.GetElbow() < value)
            {
                this.isUpdated = false;
                arm.SetElbow( arm.GetElbow() + 1 );
            }
            return arm;
        }

        public Head UpdateHeadInclination(Head head, int value)
        {
            if (value < 1 || value > 3)
            {
                Console.WriteLine("!! Para a Inclinação da Cabeça, Valor = {0} é invalido. Tente um valor entre 1 e 3", value);
                return head;
            }
            if (head.GetInclination() > value)
            {
                this.isUpdated = false;
                head.SetInclination( head.GetInclination() - 1 );
            }
            if (head.GetInclination() < value)
            {
                this.isUpdated = false;
                head.SetInclination( head.GetInclination() + 1 );
            }
            return head;
        }

        public Head UpdateHeadRotation(Head head, int value)
        {
            if (value < 1 || value > 5)
            {
                Console.WriteLine("!! Para a Rotação da Cabeça, Valor = {0} é invalido. Tente um valor entre 1 e 5", value);
                return head;
            }
            if (head.GetInclination() != 3)     //nao pode ocorrer mudança se a inclinacao esteja "para baixo"
            {

                if (head.GetRotation() > value)
                {
                    this.isUpdated = false;
                    head.SetRotation(head.GetRotation() - 1);
                }
                if (head.GetRotation() < value)
                {
                    this.isUpdated = false;
                    head.SetRotation(head.GetRotation() + 1);
                }
            }
            else
            {
                Console.WriteLine("* Rotação da Cabeça atualmente bloqueada, pois Inclinação == 3");
            }
            return head;
        }


        //Membro para String (p/ debug)
        public void MembersToConsole(ROBO robo, ROBO roboGoal)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("R.O.B.O Atual --> R.O.B.O Desejado");
            Console.WriteLine("===============================================");
            Console.WriteLine("Cabeça:");
            Console.WriteLine(" Rotação = {0} --> {1}", robo.GetHead().GetRotation(), roboGoal.GetHead().GetRotation());
            Console.WriteLine(" Inclinação = {0} --> {1} \n", robo.GetHead().GetInclination(), roboGoal.GetHead().GetInclination());
            Console.WriteLine("Braço Direito:");
            Console.WriteLine(" Rotação do Pulso = {0} --> {1}", robo.GetRightArm().GetWrist(), roboGoal.GetRightArm().GetWrist());
            Console.WriteLine(" Contração do Cotovelo = {0} --> {1} \n", robo.GetRightArm().GetElbow(), roboGoal.GetRightArm().GetElbow());
            Console.WriteLine("Braço Esquerdo:");
            Console.WriteLine(" Rotação do Pulso = {0} --> {1}", robo.GetLeftArm().GetWrist(), roboGoal.GetLeftArm().GetWrist());
            Console.WriteLine(" Contração do Cotovelo = {0} --> {1}", robo.GetLeftArm().GetElbow(), roboGoal.GetLeftArm().GetElbow());
            Console.WriteLine("===============================================");
        }


        //Utilizado para setar atributos de um ROBO pelo console (p/ debug)
        public ROBO manualSet(ROBO roboGoal)
        {
            string memberInput;     //membro que sera modificado (Head, RArm ou LArm)
            string stateInput;      //qual atributo do membro será modificado
            int valueInput;         //para qual valor o atributo ira
            string answer;

            Console.WriteLine("\nDeseja atualizar algum atributo do ROBO resultante?\n -y\n -n");
            answer = Console.ReadLine();
            while (answer == "y")
            {
                Console.WriteLine("Membro que modificará o estado (String):");
                Console.WriteLine(" -head \n -rarm \n -larm");
                memberInput = Console.ReadLine();


                Console.WriteLine("Atributo a ser modificado (String):");
                switch (memberInput)
                {
                    
                    case "head":
                        Console.WriteLine(" -rota \n -incli \n");
                        stateInput = Console.ReadLine();
                        Console.WriteLine("Valor designado para o atributo (int):");
                        valueInput = Convert.ToInt32(Console.ReadLine());
                        if (stateInput == "rota")
                        {
                            roboGoal.GetHead().SetRotation(valueInput);
                        }
                        else if (stateInput == "incli")
                        {
                            roboGoal.GetHead().SetInclination(valueInput);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum atributo sera atualizado (opc invalida)\n");
                        }
                        break;

                    case "rarm":
                        Console.WriteLine(" -wrist \n -elbow \n");
                        stateInput = Console.ReadLine();
                        Console.WriteLine("Valor designado para o atributo (int):");
                        valueInput = Convert.ToInt32(Console.ReadLine());
                        if (stateInput == "wrist")
                        {
                            roboGoal.GetRightArm().SetWrist(valueInput);
                        }
                        else if (stateInput == "elbow")
                        {
                            roboGoal.GetRightArm().SetElbow(valueInput);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum sera atualizado (opc invalida)\n");
                        }
                        break;

                    case "larm":
                        Console.WriteLine(" -wrist \n -elbow \n -none");
                        stateInput = Console.ReadLine();
                        Console.WriteLine("Valor designado para o atributo (int):");
                        valueInput = Convert.ToInt32(Console.ReadLine());
                        if (stateInput == "wrist")
                        {
                            roboGoal.GetLeftArm().SetWrist(valueInput);
                        }
                        else if (stateInput == "elbow")
                        {
                            roboGoal.GetLeftArm().SetElbow(valueInput);
                        }
                        else
                        {
                            Console.WriteLine("Nenhum atributo sera atualizado (opc invalida) \n");
                        }
                        break;

                    default:
                        Console.WriteLine("Nenhum membro sera atualizado (opc invalida) \n");
                        break;
                }

                Console.WriteLine("Deseja atualizar algum atributo do ROBO alvo?\n -y\n -n");
                answer = Console.ReadLine();
            }
            isUpdated = false;
            return roboGoal;
        }
       
    }
}
