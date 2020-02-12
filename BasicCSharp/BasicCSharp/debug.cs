using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp
{
    // 메소드 호출 => 인셉션(보면 도움됨)
    // 주인공 꿈을 꾸는데 꿈에서 또 꿈을 꿀 수 있음..
    // 현실 -> 1차 꿈 -> 2차 꿈 -> 3차 꿈
    // 3차꿈에서 깨면 2차로 2차에서 깨면 1차로
    // 매소드를 할 때도 현재 위치를 기억할 일이 생긴다.
    // Main을 현실이라고하면 
    // F11은 꿈안으로 들어가는거임

    // 호출 스택살펴보자
    // 조건을 걸어서 디버깅할 수 있다.
    // MMORPG 에서 몬스터가 엄청많은데, 몬스터에 id에 브레이크 포인트를 걸어서 써볼 수 있다.


    // 브레이크 포인트 남기지 않고 로그를 확인해볼 수 있는데.
    // 프린트를 찍어서 확인할 수 있는데,
    // 코드에 추가되서 부담됨...


    // 브레이크 포인트 잡혔는데 실행순서를 바꿀 수 있다.
    // 클릭 후 이동하면 됨
    class debug
    {

        // 프로시저는 메소드라고 볼 수 있다.
        // F10 함수단위 실행
        // 조사식으로 값변경할 수도 있고, 
        static void Print(int a)
        {
            Console.WriteLine(a);
        }

        static int AddAndPrint(int a ,int b)
        {
            int ret = a + b;
            Print(ret);
            return ret;
        }

        public static void My_Main()
        {
            // 디버깅 의사가 환자 진료하는
         /* int ret = debug.AddAndPrint(10, 20);
            ret = ret + 1;

            Console.WriteLine(ret);*/

            debug.AddAndPrint(10, 20);


        }
    }
}
