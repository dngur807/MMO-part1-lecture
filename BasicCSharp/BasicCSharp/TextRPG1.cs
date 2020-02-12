using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    class TextRPG1
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        /*
         * 1. 메뉴 만들기
        */ 
        public static void My_Main()
        {
            ClassType choice = ClassType.None;

            while (true)
            {
                Console.WriteLine("직업을 선택하세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 궁수");
                Console.WriteLine("[3] 법사");

                string input = Console.ReadLine();
                // 스트링 형태가 아닌 Enum 형태로 변경해서 구현하자

                switch (input)
                {
                    case "1":
                        choice = ClassType.Knight;
                        break;
                    case "2":
                        choice = ClassType.Archer;
                        break;
                    case "3":
                        choice = ClassType.Mage;
                        break;
                }

                if (choice != ClassType.None)
                    break;
            }
        }
    }
}
