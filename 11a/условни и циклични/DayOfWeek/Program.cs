namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете ден (1-7): "); 
            int day = int.Parse(Console.ReadLine()); 
            switch (day) 
            { 
                case 1: Console.WriteLine("Понеделник"); break; 
                case 2: Console.WriteLine("Вторник"); break; 
                case 3: Console.WriteLine("Сряда"); break; 
                case 4: Console.WriteLine("Четвъртък"); break; 
                case 5: Console.WriteLine("Петък"); break; 
                case 6: Console.WriteLine("Събота"); break; 
                case 7: Console.WriteLine("Неделя"); break; 
                default: Console.WriteLine("Грешка: Невалиден ден!"); break; 
            }

        }
    }
}
