﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibleTyper
{
    public class General
    {
        private BibleTyper BT;

        public General(BibleTyper BT)
        {
            this.BT = BT;
        }

        public int BookIndex(string BookName)
        {
            int index = 1;
            List<string> AllBooks = new List<string>();
            AllBooks.AddRange(new string[] {
            "창세기",
            "출애굽기",
            "레위기",
            "민수기",
            "신명기",
            "여호수아",
            "사사기",
            "룻기",
            "사무엘상",
            "사무엘하",
            "열왕기상",
            "열왕기하",
            "역대상",
            "역대하",
            "에스라",
            "느헤미야",
            "에스더",
            "욥기",
            "시편",
            "잠언",
            "전도",
            "아사",
            "이사야",
            "예레미야",
            "예레미야애가",
            "에스겔",
            "다니엘",
            "호세아",
            "요엘",
            "아모스",
            "오바댜",
            "요나",
            "미가",
            "나훔",
            "하박국",
            "스바냐",
            "학개",
            "스가랴",
            "말라기",
            "마태복음",
            "마가복음",
            "누가복음",
            "요한복음",
            "사도행전",
            "로마서",
            "고린도전서",
            "고린도후서",
            "갈라디아서",
            "에베소서",
            "빌립보서",
            "골로새서",
            "데살로니가전서",
            "데살로니가후서",
            "디모데전서",
            "디모데후서",
            "디도서",
            "빌레몬서",
            "히브리서",
            "야고보서",
            "베드로전서",
            "베드로후서",
            "요한1서",
            "요한2서",
            "요한3서",
            "유다서",
            "요한계시록"});

            foreach (string s in AllBooks)
            {
                if (BookName.Equals(s))
                {
                    break;
                }
                index++;
            }

            return index;
        }
    }
}
