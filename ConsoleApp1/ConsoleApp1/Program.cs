using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch문
            /*int day =3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                case 6:
                    Console.WriteLine("토요일");
                    break;
                case 7:
                    Console.WriteLine("일요일");
                    break;
                default:
                    Console.WriteLine("연관없는 날입니다.");
                    break;
            }*/
            //캐릭터를 선택하세요 : (1. 검사 2. 마법사 3. 도적)
            //스위치문 사용
            /*Console.WriteLine("당신의 캐릭터 번호를 선택하세요.");
            Console.WriteLine("1. 검사 2. 마법사 3. 도적");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("당신의 캐릭터 : 검사 \n공격력 : 100 \n방어력 : 90");
                    break;
                case 2:
                    Console.WriteLine("당신의 캐릭터 : 마법사 \n공격력 : 110 \n방어력 : 80");
                    break;
                case 3:
                    Console.WriteLine("당신의 캐릭터 : 도적 \n공격력 : 115 \n방어력 : 70");
                    break;
                default:
                    Console.WriteLine("캐릭터 번호가 틀립니다.");
                    break;
            }*/

            //for문
            /*for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("숫자 : "+i);
            }*/
            /*for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine(i);
            }*/
            /*int sum=0;
            for (int i = 1; i<=10; i++)
            {
                sum += i;
            }
            Console.WriteLine("합 :" + sum);*/

            //while문
            /*int count = 1;
            while (count <= 5)
            {
                Console.WriteLine("Count : " + count);
                count++;
            }*/
            /*int count = 0;
            while (true)
            {
                Console.WriteLine("무한루프 실행");
                count++;
                if (count == 3) break;
            }*/

            /*Random rand = new Random(); //Random 객체 생성
            for(int i = 0; i<10; i++)
            {
                int randomNumber = rand.Next(0, 10);
                Console.WriteLine("0이상 10 미만의 랜덤 정수 : " + randomNumber);
            }*/
            //대장장이 키우기
            //도끼 등급SSS 10%
            //도끼 등급SS  40%
            //도끼 등급S   50%
            /*Random rand = new Random();//랜덤값을 뽑는 문장
            int rnd = 0;

            for(int i = 0; i <20; i++)
            {
                rnd = rand.Next(1, 101);
                if (rnd >= 1 && rnd <= 10) Console.WriteLine("도끼등급 SSS");
                else if (rnd >= 11 && rnd <= 40) Console.WriteLine("도끼등급 SS");
                else Console.WriteLine("도끼등급 S");
                Thread.Sleep(500);
            }*/

            //do while문
            //1회는 무조건 실행하고  while문과 같이 조건 진행
            /*int x = 5;
            do
            {
                Console.WriteLine("최소한번은 실행됩니다.");
                x--;
            } while (x > 0);*/

            //break문
            //반복문 탈출/중단 가능
            /*for(int i=1; i<=10; i++)
            {
                Console.WriteLine("break 전 출력 : "+i);
                if (i == 5) break;
                Console.WriteLine("break 후 출력 : " +i);
            }*/
            //continue문
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            /*for(int i=1; i<=10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i);
            }*/
            //goto 문
            /*int n = 1;
            start:
            if(n<=5)
            {
                Console.WriteLine(n);
                n++;
                goto start;//레이블로 이동
            }*/
            
        }
    }
}
