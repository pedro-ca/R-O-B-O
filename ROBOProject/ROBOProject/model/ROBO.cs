using System;

namespace ROBOProject.model
{
    class ROBO
    {
        private Head head;
        private Arm rightArm = new Arm("Right");
        private Arm leftArm = new Arm("Left");


        public ROBO(Head head, Arm rightArm, Arm leftArm)
        {
            this.head = head;
            this.rightArm = rightArm;
            this.leftArm = leftArm;
        }


        public Arm GetRightArm()
        {
            return rightArm;
        }
        public void SetRightArm(Arm value)
        {
            rightArm = value;
        }
        public Arm GetLeftArm()
        {
            return leftArm;
        }
        public void SetLeftArm(Arm value)
        {
            leftArm = value;
        }
        public Head GetHead()
        {
            return head;
        }
        public void SetHead(Head value)
        {
            head = value;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
