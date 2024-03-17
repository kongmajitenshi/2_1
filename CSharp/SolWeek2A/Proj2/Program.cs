using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score score1 = new Score();
            score1.Kor = 10;
            score1.Eng = 10;
            score1.Mat = 10;

            Score score2 = new Score();
            score2.Kor = 20;
            score2.Eng = 20;
            score2.Mat = 20;

            System.Console.WriteLine(score1.Kor);
            //System.Console.WriteLine("평균:" + score1.Average());
            //System.Console.WriteLine(score2.Average());
            System.Console.WriteLine("평균:" + score1.Average);
            System.Console.WriteLine(score2.Average);
        }
    }
}
