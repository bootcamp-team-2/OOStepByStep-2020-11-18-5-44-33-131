﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
