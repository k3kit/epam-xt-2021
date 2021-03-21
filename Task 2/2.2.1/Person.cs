using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1
{
    abstract class Person
    {
        protected int positionX;
        protected int positionY;

        public abstract void Move(int height, int width);
    }
}
