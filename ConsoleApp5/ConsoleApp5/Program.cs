using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Random rand = new Random();
            Console.WriteLine("-------------------------");
            Console.WriteLine("|                       |");
            Console.WriteLine("|      학생 키우기      |");
            Console.WriteLine("|                       |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("      press enter        ");
            Console.ReadLine();
            Console.Clear();

            int health = 100;
            int know = 0;
            int input;
            int rnd;
            int pmoney = 100;
            //무한반복
            while (true)
            {
                Console.Clear();
                Console.WriteLine($" 현재 상태 : 체력 {health} | 지식 {know} | 돈 {pmoney}");
                Console.WriteLine("1. 공부하러가기 ");
                Console.WriteLine("2. 알바하기 ");
                Console.WriteLine("3. 문제집사기 ");
                Console.WriteLine("4. 잠자기 ");
                Console.WriteLine("5. 종료 ");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //input에 키로 눌러 숫자 담기

                if (input == 1)
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("공부하러 가는길");
                        Console.SetCursorPosition(i, 2);
                        Console.WriteLine("  ◯");
                        Console.SetCursorPosition(i, 3);
                        Console.WriteLine("  ┃");
                        Console.SetCursorPosition(i, 4);
                        Console.WriteLine("━━┃━━");
                        Console.SetCursorPosition(i, 5);
                        Console.WriteLine("  ┃");
                        Console.SetCursorPosition(i, 6);
                        Console.WriteLine(" ━━━");
                        Console.SetCursorPosition(i, 7);
                        Console.WriteLine(" ┃ ┃");
                        Console.SetCursorPosition(i, 8);
                        Console.WriteLine(" ┃ ┃");
                        Console.SetCursorPosition(i, 9);
                        Console.WriteLine(" ┃ ┃");
                        Thread.Sleep(100);
                    }
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("공부하기 s");
                        Console.WriteLine("집가기 x");
                        string str = Console.ReadLine();
                        if(str == "s")
                        {
                            
                            rnd = rand.Next(10, 30);
                            health -= rnd;
                            know += rnd;
                            Console.WriteLine("현재 체력 : " + health+ "\n 현재 지식 : "+ know);
                            if(health < 0)
                            {
                                Console.WriteLine("열심히살던 학생이 과로사로 쓰러졌습니다....");
                                Console.WriteLine("             GAME OVER");
                                Environment.Exit(0);
                            }
                        }
                        else if (str == "x")
                        {
                            for (int i = 30; i >= 1; i--)
                            {
                                Console.Clear();
                                Console.WriteLine("집 가는길");
                                Console.SetCursorPosition(i, 2);
                                Console.WriteLine("  ◯");
                                Console.SetCursorPosition(i, 3);
                                Console.WriteLine("  ┃");
                                Console.SetCursorPosition(i, 4);
                                Console.WriteLine("━━┃━━");
                                Console.SetCursorPosition(i, 5);
                                Console.WriteLine("  ┃");
                                Console.SetCursorPosition(i, 6);
                                Console.WriteLine(" ━━━");
                                Console.SetCursorPosition(i, 7);
                                Console.WriteLine(" ┃ ┃");
                                Console.SetCursorPosition(i, 8);
                                Console.WriteLine(" ┃ ┃");
                                Console.SetCursorPosition(i, 9);
                                Console.WriteLine(" ┃ ┃");
                                Thread.Sleep(100);
                            }
                            Console.Clear();
                            break;
                        }
                    }
                }
                else if (input == 2)
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("알바하러 가는길");
                        Console.SetCursorPosition(i, 2);
                        Console.WriteLine("  ◯");
                        Console.SetCursorPosition(i, 3);
                        Console.WriteLine("  ┃");
                        Console.SetCursorPosition(i, 4);
                        Console.WriteLine("━━┃━━");
                        Console.SetCursorPosition(i, 5);
                        Console.WriteLine("  ┃");
                        Console.SetCursorPosition(i, 6);
                        Console.WriteLine(" ━━━");
                        Console.SetCursorPosition(i, 7);
                        Console.WriteLine(" ┃ ┃");
                        Console.SetCursorPosition(i, 8);
                        Console.WriteLine(" ┃ ┃");
                        Console.SetCursorPosition(i, 9);
                        Console.WriteLine(" ┃ ┃");
                        Thread.Sleep(100);
                    }
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("알바하기 w");
                        Console.WriteLine("집가기 x");
                        string str = Console.ReadLine();
                        if (str == "w")
                        {
                            rnd = rand.Next(10, 30);
                            pmoney += rnd;
                            health -= rnd;
                            Console.WriteLine("+"+rnd+" 획득!");
                            Console.WriteLine("현재 잔액 : " + pmoney);
                            Console.WriteLine("현재 체력 : " + health);
                            if (health < 0)
                            {
                                Console.WriteLine("열심히살던 학생이 과로사로 쓰러졌습니다....");
                                Console.WriteLine("             GAME OVER");
                                Environment.Exit(0);
                            }
                        }
                        else if (str == "x")
                        {
                            for (int i = 30; i >= 1; i--)
                            {
                                Console.Clear();
                                Console.WriteLine("집 가는길");
                                Console.SetCursorPosition(i, 2);
                                Console.WriteLine("  ◯");
                                Console.SetCursorPosition(i, 3);
                                Console.WriteLine("  ┃");
                                Console.SetCursorPosition(i, 4);
                                Console.WriteLine("━━┃━━");
                                Console.SetCursorPosition(i, 5);
                                Console.WriteLine("  ┃");
                                Console.SetCursorPosition(i, 6);
                                Console.WriteLine(" ━━━");
                                Console.SetCursorPosition(i, 7);
                                Console.WriteLine(" ┃ ┃");
                                Console.SetCursorPosition(i, 8);
                                Console.WriteLine(" ┃ ┃");
                                Console.SetCursorPosition(i, 9);
                                Console.WriteLine(" ┃ ┃");
                                Thread.Sleep(100);
                            }
                            Console.Clear();
                            break;
                        }
                    }
                }
                else if (input == 3)
                {
                    for (int i = 1; i <= 30; i++)
                    {
                        Console.Clear();
                        Console.WriteLine("문제집사러 가는길");
                        Console.SetCursorPosition(i, 2);
                        Console.WriteLine("  ◯");
                        Console.SetCursorPosition(i, 3);
                        Console.WriteLine("  ┃");
                        Console.SetCursorPosition(i, 4);
                        Console.WriteLine("━━┃━━");
                        Console.SetCursorPosition(i, 5);
                        Console.WriteLine("  ┃");
                        Console.SetCursorPosition(i, 6);
                        Console.WriteLine(" ━━━");
                        Console.SetCursorPosition(i, 7);
                        Console.WriteLine(" ┃ ┃");
                        Console.SetCursorPosition(i, 8);
                        Console.WriteLine(" ┃ ┃");
                        Console.SetCursorPosition(i, 9);
                        Console.WriteLine(" ┃ ┃");
                        Thread.Sleep(100);
                    }
                    Console.Clear();
                    if (pmoney >= 100)
                    {
                        pmoney -= 100;
                        Console.Clear();
                        Console.WriteLine(" 문제집을 뽑습니다");
                        Thread.Sleep(1000);

                        rnd = rand.Next(1, 101);
                        if (rnd == 1)
                        {
                            Console.WriteLine("대단한 교수진들의 지식이 합쳐져있는 문제집 (지식 + 50) 획득!");
                            know += 50;
                        }
                        else if (rnd < 10)
                        {
                            Console.WriteLine("고등학교 교과서 (지식 + 30) 획득!");
                            know += 30;
                        }
                        else if (rnd < 30)
                        {
                            Console.WriteLine("초등학교 교과서(지식 + 20) 획득!");
                            know += 20;
                        }
                        else
                        {
                            Console.WriteLine("구몬 (지식 + 5) 획득!");
                            know += 5;
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (100 골드 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if(input == 4)
                {
                    for (int b = 0; b <= 5; b++)
                    {
                        for (int a = 3; a > 0; a--)
                        {

                            Console.Clear();
                            Console.SetCursorPosition(a, a);
                            Console.WriteLine("Z");
                            Console.SetCursorPosition(4, 4);
                            Console.WriteLine("     ◯");
                            Console.SetCursorPosition(4, 5);
                            Console.WriteLine("━━━━━━━━━━━━");
                            Console.SetCursorPosition(4, 6);
                            Console.WriteLine("┃          ┃ ");
                            Console.SetCursorPosition(4, 7);
                            Console.WriteLine("┃          ┃ ");
                            Console.SetCursorPosition(4, 8);
                            Console.WriteLine("┃          ┃ ");
                            Console.SetCursorPosition(4, 9);
                            Console.WriteLine("┃          ┃ ");
                            Console.SetCursorPosition(4, 10);
                            Console.WriteLine("━━━━━━━━━━━━");
                            Thread.Sleep(300);
                        }
                    }
                    health += 20;
                    Console.WriteLine($"꿀잠후 현재 체력 : {health}");
                    Thread.Sleep(1000);
                }
                else if(input == 5)
                {
                    break;
                }
            }
            Console.WriteLine("게임을 종료 합니다. 감사합니다!");
        }
    }
}