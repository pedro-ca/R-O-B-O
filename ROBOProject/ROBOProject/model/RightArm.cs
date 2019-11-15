namespace ROBOProject.model
{
    class RightArm
    {
        private int rightWrist;
        private int rightElbow;



        public RightArm(int rightWrist, int rightElbow)
        {
            this.rightWrist = rightWrist;
            this.rightElbow = rightElbow;
        }

        public void UpdateRightWrist()
        {
            //code here
        }
        public void UpdateRightElbow()
        {
            //code here
        }



        //Getter e Setters
        public int GetRightWrist()
        {
            return rightWrist;
        }

        public void SetRightWrist(int value)
        {
            rightWrist = value;
        }

        public int GetRightElbow()
        {
            return rightElbow;
        }

        public void SetRightElbow(int value)
        {
            rightElbow = value;
        }



        //toString
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
