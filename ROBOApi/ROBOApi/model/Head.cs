using System;

namespace ROBOProject.model
{
    class Head
    {
        private int rotation;          
        private int inclination;    


        public Head(int rotation, int inclination)
        {
            this.rotation = rotation;
            this.inclination = inclination;
        }

        public Head()       //Construtor Default com membros "Em repouso"
        {
            rotation = 3;
            inclination = 2; 
        }


        public int GetRotation()
        {
            return rotation;
        }
        public void SetRotation(int value)
        {
            rotation = value;
        }
        public int GetInclination()
        {
            return inclination;
        }
        public void SetInclination(int value)
        {
            inclination = value;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
