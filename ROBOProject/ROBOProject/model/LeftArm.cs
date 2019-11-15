namespace ROBOProject.model
{
    class LeftArm
    {
        private int leftWrist;
        private int leftElbow;



        public LeftArm(int leftWrist, int leftElbow)
        {
            this.leftWrist = leftWrist;
            this.leftElbow = leftElbow;
        }

        public void UpdateLeftWrist()
        {
            //code here
        }
        public void UpdateLeftElbow()
        {
            //code here
        }



        //Getter e Setters
        public int GetLeftWrist()
        {
            return leftWrist;
        }

        public void SetLeftWrist(int value)
        {
            leftWrist = value;
        }

        public int GetLeftElbow()
        {
            return leftElbow;
        }

        public void SetLeftElbow(int value)
        {
            leftElbow = value;
        }



        //toString
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
