﻿using System;
using System.Collections.Generic;
using System.Text;

namespace July29Examples
{
    public class Animal
    {

        //private string _color;

        //public string Color
        //{
        //    get { return _color; }
        //    set { _color = value; }
        //}

        public string Color { get; set; }

        protected int Age { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Size { get; set; }


        //public Animal(string color, string type, string name, int size = 1)
        //{
        //    Color = color;
        //    Type = type;
        //    Name = name;
        //    Size = size;
        //}
    }
}
