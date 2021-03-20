using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_ss
{
     abstract class Figure
    {
       protected double X, Y;
       public abstract void Show();
       public abstract double Area ();
       public abstract double Perimeter();
    }
}
