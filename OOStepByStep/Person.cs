﻿namespace OOStepByStep
{
    using System;
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string SelfIntroduce()
        {
            return $"My name is {this.name}. I am {this.age} years old.";
        }
    }
}
