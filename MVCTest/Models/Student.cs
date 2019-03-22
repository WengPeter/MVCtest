using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public Student()
        {
            id = string.Empty;
            name = string.Empty;
            score = 0;
        }
        public Student(string _id, string _name, int _score)
        {
            new Student("1", "小明", 80);
            new Student("2", "小華", 70);
            new Student("3", "小英", 60);
            new Student("4", "小李", 50);
            new Student("5", "小張", 90);
        }
        public override string ToString()
        {
            return $"學號:{id}, 姓名:{name}, 分數:{score}.";
        }
    }
}