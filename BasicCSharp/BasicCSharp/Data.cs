using System;

namespace BasicCSharp
{
    class Data
    {
        public static void My_Main()
        {
            int num = 8;
            // << >> &(and) | (or) ^(xor) ~(not)
            num = num >> 5;

            // 게임 응용 하나의 int 32비트에 각 비트에 정보를 넣을 수 있다.
            // | (or) , &(and)
            int id = 0;

            // xor 자주 사용하는 케이스가 암호화이다.

            // id는 서버 클라에서 알아야하는데
            // 123을 네트워크 로 그냥 보내면 해킹 위험이 있어서,
            // 암호화 해서 숨겨보낼 필요가 있다.
            // 그래서 중간에 암호키를 모르면 알 수 없음. 

            id = 123; 
            int key = 401;
            int a = id ^ key;
            int b = a ^ key;



            Console.WriteLine(a);
            Console.WriteLine(b);


            int c;
            // 복사라고 이해
            c = 100;

            int d;
            d = c;

            a = a + 1;
            a = a - 1;
            a = a * 1;
            a = a % 1;
            a = a << 1;


            // 우선순위 외우지 말고 조금 헷갈리면 괄호 넣자!
            // 1. ++ --
            // 2. * / %
            // 3. + - 
            // 4. << >>
            // 5.  < > 
            // 6. == !=
            // 7. &
            // 8. ^
            // 9. |


            // 명시적으로 타입을 쓰지 않고,
            // 컴파일러가 타입을 정해준다.
            // var를 납용하지 않는 것 좋다.
            // C# 장점이 타입을 잡아준다는 장점이 있느데,
            // 읽는 사람도 명확히 코드가 읽기지 않는다.
           // var num = 3;

        }
    }
}
