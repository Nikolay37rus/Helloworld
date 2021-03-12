using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TortlGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();

            GraphicsWindow.BrushColor = "Black";
            GraphicsWindow.BackgroundColor = "Red";
            var eat = Shapes.AddRectangle(10, 10);
            int x = 200;
            int y = 200;
            Shapes.Move(eat, x, y);

            Random rand = new Random();

            while (true)
            {
                Turtle.Move(10);

                if (Turtle.X <= 0) //Делаем так, чтобы невозможно было выйти за пределы окна.
                { Turtle.X = GraphicsWindow.Width - 1; }
                if (Turtle.X >= GraphicsWindow.Width)
                { Turtle.X = 0; }
                if (Turtle.Y <= 0)
                { Turtle.Y = GraphicsWindow.Height - 1; }
                if (Turtle.Y >= GraphicsWindow.Height)
                { Turtle.Y = 0; } //Сделано

                if (Turtle.X >= x && Turtle.X <= x + 10 && Turtle.Y >= y && Turtle.Y <= y + 10)
                {
                    x = rand.Next( 0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                    Turtle.Speed++;
                }
            }
        }
        private static void GraphicsWindow_KeyDown()
        {
            if(GraphicsWindow.LastKey == "Up") 
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
