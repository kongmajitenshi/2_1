﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team();
            team1.Name = "SSG";
            team1.Coach = "이숭용";
            team1.Level = 9;
            team1.Home = "인천";
            // team1.LowerLevel = 8;
            // Team.LowerLevel = 8; // 스태틱 필드 수정 시엔 이런식으로.

            Team team2 = new Team();
            team2.Name = "삼성";
            team2.Coach = "박진만";
            team2.Level = 3;
            team2.Home = "대구";
            // team2.LowerLevel = 10;
            // Team.LowerLevel = 10;

            Console.WriteLine(team1.Name);
            Console.WriteLine(team1.CurrentStatus);

        }
    }
}
