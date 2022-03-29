﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Drive();
        }

        public void Drive()
        {
            Console.WriteLine("I am driving!");
        }
    }

    class Airplane : Vehicle
    {
        public  void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public override void Move()
        {
            Fly();
        }
    }
}
