using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTrening
{
    class Program
    {
        static void WriteT(int size)
        {
            // Буква "Т"  начало

            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);
            // Буква "Т" конец
        }

        static void WriteО(int size)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
                Turtle.TurnRight();
            }
        }

        static void WriteR()
        {
            Turtle.Angle = 0;

            Turtle.Move(30);
            Turtle.TurnRight();
            Turtle.Move(15);
            Turtle.TurnRight();
            Turtle.Move(15);
            Turtle.TurnRight();
            Turtle.Move(15);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;
            // Turtle.Speed = 9;

            //  for(int i = 0; i < 4; i++)
            //  {

            //      Turtle.Move(20);
            //      Turtle.TurnRight();
            //      Turtle.Move(20);
            //      Turtle.TurnRight();
            //      Turtle.Move(20);
            //      Turtle.TurnLeft();
            //      Turtle.Move(20);
            //      Turtle.TurnLeft();
            //      Turtle.Turn(90);
            //      Turtle.TurnLeft();            
            //  }

            //    int i = 0;
            //    while (i < 6)
            //{
            //    Turtle.Move(100);
            //    Turtle.Turn(60);
            //    i ++;
            //}


            // Торт
            Turtle.Angle = 0;
            Turtle.Move(60);
            Turtle.Angle = 270;
            Turtle.Move(20);
            Turtle.Angle = 90;
            Turtle.Move(40);

            Turtle.X = 260;
            Turtle.Y = 200;

            WriteО(30);

            Turtle.X = 340;
            Turtle.Y = 200;

            WriteR();




            Turtle.X = 400;
            Turtle.Y = 200;

            WriteT(30);







        }
    }
}
