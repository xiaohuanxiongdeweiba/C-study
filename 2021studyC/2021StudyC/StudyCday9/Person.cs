using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyCday9
{
    class Person
    {
        string _name;
        int _age;
        char _gender;

        public string Name { get => _name; set => _name = value; }



        public char Gender { get => _gender; set => _gender = value;  }
        public int Age { get => _age; set => _age = value-1; }

        //public int Age { get =>_age; }set => value; } 
        //public char Gender { get { return _gender; }set { _gender = value; } }

        public void JieShao()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，性别{2}", this.Name, this.Age, this.Gender);
        }
    }
}
