using System;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Эта программа поможет найти фильм, который будет вам по душе ");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();

            String text = "Здравствуйте, " + name;

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: Комедия, фантастика,  драмма, триллеры, боевики.?" );
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы:");

            if (genre == "комедия" )
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* Иван васильевич меняет свою профессию" );
                Console.WriteLine("* Операция <<Ы>> и другие преключения Шурика." );
                Console.WriteLine("* Назад в будущее" );
                Console.WriteLine("* В джазе только девушки" );
            }   
            else if(genre == "фантастика" )
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* Люди х" );
                Console.WriteLine("* Черепашки ниндзя" );
                Console.WriteLine("* Звёздные войны" );
            }
            else if (genre == "триллеры")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* Идеальный синий," );
                Console.WriteLine("* Птицы," );
                Console.WriteLine("* Малхоланд драйв." );
            }

            else if (genre == "боевики")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* Рембо," );
                Console.WriteLine("* Терминатор," );
                Console.WriteLine("* В бой идут одни старики." );
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* Зелёная миля" );
                Console.WriteLine("* Побег из Шоушенка" );
                Console.WriteLine("* Хороший." );
            }
              
            

            Console.ReadLine();
        }
    }
}
