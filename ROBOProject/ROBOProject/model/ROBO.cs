using System;
using System.Collections.Generic;
using System.Text;

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

        public override bool Equals(object obj)
        {
            return obj is ROBO rOBO &&
                   EqualityComparer<Head>.Default.Equals(head, rOBO.head) &&
                   EqualityComparer<Arm>.Default.Equals(rightArm, rOBO.rightArm) &&
                   EqualityComparer<Arm>.Default.Equals(leftArm, rOBO.leftArm);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(head, rightArm, leftArm);
        }
    }
}
