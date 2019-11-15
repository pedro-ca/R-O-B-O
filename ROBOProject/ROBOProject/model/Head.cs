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

        public void updateRotation()
        {
            //code here
        }
        public void updateInclination()
        {
            //code here
        }




        //Getter e Setters
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



        //toString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
