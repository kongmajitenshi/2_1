using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatement
{
    class Program
    {

        static void Test1() // 정적 메소드
        {
            string input = Console.ReadLine();

            //type1
            //int number = int.Parse(input);

            //type2
            //int number;
            //out 변수를 사용하는 것은 일종의 call-by-reference를 이용.
            //bool result = int.TryParse(input, out number); //출력 전용 변수 number. number는 포인터와 유사. 프로그램이 죽지 않음. 
            //if (result == false) {
            //    return;
            //}

            //type3
            bool result = int.TryParse(input, out int number); //int number 변수 선언과 동시에 출력까지.
            if (result == false) {
                return;
            }

            Console.WriteLine(number * 2);

            if (number > 0)
            {
                Console.WriteLine("양수");
                if (number % 100 == 0)
                {
                    Console.WriteLine("100의 배수");
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("음수가 아님");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        static void Test2() // 정적 메소드
        {
            while(true) // 무한루프
            {
                string input = Console.ReadLine();
                switch (input)
            {
                case "Y":
                case "y":
                    Console.WriteLine("YES");
                    break; // Test2() 자체를 빠져나가고 싶다면 return. return 만나자마자 메소드 종료.
                case "N":
                    //Console.WriteLine("Big N");
                case "n":
                    Console.WriteLine("NO");
                    break;
                default: // if문의 else 같은 존재임. 없어도 에러는 발생x. 
                    Console.WriteLine("UNKNOWN");
                    break;
            } //goto 쓰면 편함.

            }
        }
        void Test3() // instance 메소드
        {
            //for, foreach
            //int arr[10]; 은 C언어 스타일의 배열 선언.
            // int[] arr; // C#스타일의 배열 선언. arr은 int배열의 관리대행자 느낌.
            int[] arr = new int[3] {0, 0, 0};
            
            for(int i=0; i<arr.Length; i++) //Length는 배열class의 프로퍼티임.
            {
                Console.WriteLine(arr[i]);
            }

            foreach(var i in arr) // foreach에서 var로 많이 사용함. 배열의 타입은 정해져 있으니 컴파일러가 알아서 i의 형태 정해서 씀.
            { //처음~끝 까지 무조건 반복. 중간에 배열 길이가 변하는 경우에는 절대 사용 금지.
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Test1();
        }


    }
}
