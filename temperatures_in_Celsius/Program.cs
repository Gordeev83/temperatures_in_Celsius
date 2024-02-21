namespace temperatures_in_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Перевести температуру из Фаренгейта в Цельсий");
            Console.WriteLine("2. Перевести температуру из Цельсия в Фаренгейт");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите температуру в Фаренгейтах: ");
                double fahrenheit = double.Parse(Console.ReadLine());

                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Температура в Цельсиях: " + celsius);
            }
            else if (choice == 2)
            {
                Console.Write("Введите температуру в Цельсиях: ");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("Температура в Фаренгейтах: " + fahrenheit);
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
            }

            Console.ReadLine();
        }
    }
}
