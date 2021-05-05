using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    class Student
    {
        //fields
        private string _name;
        private int _age;

        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        //constructor
        public Student(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
    }
}
