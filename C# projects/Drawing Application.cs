using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IDraw pencil = new Draw();
            IDraw brush = new Brush();
            IDraw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
    }

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : IDraw
    {
        //implement the StartDraw() method
      public virtual void StartDraw()
      {
           Console.WriteLine("Using brush");
      }
   }

    //inherit this class from the class Draw
    class Spray : IDraw {
        public virtual void StartDraw() {
           Console.WriteLine("Using spray");
      }
    }
}