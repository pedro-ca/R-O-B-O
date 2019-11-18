using System;

namespace ROBOProject.model
{
    class Arm
    {
        private int wrist;
        private int elbow;
        private string side;


        public Arm(int wrist, int elbow, string side)
        {
            this.wrist = wrist;
            this.elbow = elbow;
            this.side = side;
        }

        public Arm(string side)     //Construtor Default com membros "Em repouso"
        {
            wrist = 3;
            elbow = 1;
            this.side = side;
        }


        public int GetWrist()
        {
            return wrist;
        }
        public void SetWrist(int value)
        {
            wrist = value;
        }
        public int GetElbow()
        {
            return elbow;
        }
        public void SetElbow(int value)
        {
            elbow = value;
        }
        public string GetSide()
        {
            return side;
        }
        public void SetSide(string value)
        {
            side = value;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
