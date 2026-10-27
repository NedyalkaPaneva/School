namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // x1, y1 и x2, y2 са два срещуположни върха
            double x1 = 1, y1 = 1;
            double x2 = 8, y2 = 5;
            double x = 4, y = 3; 
            // Точка за проверка
            bool isInside =    (x >= x1 && x <= x2) &&    (y >= y1 && y <= y2);
            if (isInside)    
                Console.WriteLine("Точката е вътре в правоъгълника");
                else    Console.WriteLine("Точката е отвън");

        }
    }
}
