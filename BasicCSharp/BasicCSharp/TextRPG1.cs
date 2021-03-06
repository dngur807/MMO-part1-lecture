﻿using System;
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

        struct Player
        {
            public int hp;
            public int attack;
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }




        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType classtype = ClassType.None;
            string input = Console.ReadLine();
            // 스트링 형태가 아닌 Enum 형태로 변경해서 구현하자
            switch (input)
            {
                case "1":
                    classtype = ClassType.Knight;
                    break;
                case "2":
                    classtype = ClassType.Archer;
                    break;
                case "3":
                    classtype = ClassType.Mage;
                    break;
            }
            return classtype;
        }

        static void CreatePlayer(ClassType choice , out Player player)
        {
            // 기사 (100 / 10)
            // 궁수 (75 / 7)
            // 법사 (50 / 15)

            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 7;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            // 랜덤으로 1 ~ 3 몬스터 하나 리스폰
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch ((MonsterType)randMonster)
            {
                case MonsterType.Slime:
                    Console.WriteLine("슬라임 스폰되었습니다.");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case MonsterType.Orc:
                    Console.WriteLine("오크 스폰되었습니다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤 스폰되었습니다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }

        static void Fight (ref Player player , ref Monster monster)
        {
            while (true)
            {
                // 플레이어가 몬스터 공격
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다!");
                    Console.WriteLine($"남은 체력 : {player.hp}");
                    break;
                }

                // 몬스터 반격
                player.hp -= monster.attack;
                if (player.hp <= 0 )
                {
                    Console.WriteLine("패배했습니다!");
                    break;
                }
            }
        }

        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다.");

                // 몬스터 생성
                Monster monster;
                CreateRandomMonster(out monster);

                // 전투모드 모
                Console.WriteLine("[1] 전투 모드 돌입");
                Console.WriteLine("[2] 일정확률로 마을로 도망");

                string input = Console.ReadLine();

                if (input == "1")
                {
                   Fight(ref player , ref monster);
                }
                else if (input == "2")
                {
                    // 일정확률로 마을로 돌아옴
                    // 33%
                    Random rand = new Random();
                    int randVal = rand.Next(0, 101);// 0 에서 100사이 숫자 뽑아옴
                    if (randVal <= 33)
                    {
                        Console.WriteLine("도망치는데 성공했습니다.");
                        break;
                    }

                   
                }
            }
        }

        static void EnterGame(ref Player player)
        {
            Console.WriteLine("마을에 접속했습니다!");
            Console.WriteLine("[1] 필드로 간다");
            Console.WriteLine("[2] 로비로 돌아가기");

            string input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        return;
                    case "2":
                        return; // 함수에 대한 리턴문
                }
            }
        }

        /*
         * 1. 메뉴 만들기
        */
        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();
                if (choice != ClassType.None)
                {
                    // 캐릭터 생성
                    // 구조체
                    // hp, attack 이렇게 두개 변수를 추가했는데,
                    // 나중에 10개가 들어갈 수 있다.

                    // 캐릭터 생성
                    Player player;
                    CreatePlayer(choice, out player);
                    //Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                    EnterGame(ref player);

                }
            }
        }


        // 절차(procedure) 지향 => 함수를 기반으로 뭔가 만들 겠다는 것이다.
        // 이전에 만든 텍스트 RPG 가 그 예이다.


    }
}
