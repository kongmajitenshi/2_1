using System;

namespace Proj5
{
    internal class Team
    {
        public string Name;
        public string Coach;
        public int Level;
        public string Home;

        public string CurrentStatus
        {
            get {
                string stt;
                if (Level >= 5) {
                    stt = "가능";
                } else {
                    stt = "불가능";
                }
                return $"{Name}은 현재 가을야구 {stt}";
            }
        }
        public void IncreaseLevel(int value)
        {
            if(Level - value >= 1)
            {
                Level -= value;
            }
            else
            {
                Level = 1;
            }
        }
        // public int LowerLevel = 10; // 인스턴스 필드
        public static int LowerLevel = 10; // 정적 필드
        public void DecreaseLevel(int value)
        {
            if(Level + value <= LowerLevel)
            {
                Level += value;
            }
            else
            {
                Level = LowerLevel;
            }
        }

    }
}