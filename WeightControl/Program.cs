using System;

namespace WeightControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пользовательский ввод веса
            Console.Write("Введите вес (кг): ");
            double weight = double.Parse(Console.ReadLine());

            // Пользовательский ввод роста
            Console.Write("Введите рост (м): ");
            double height = double.Parse(Console.ReadLine());

            // Вычисление индекса массы тела
            double index = Math.Round(weight / (height * height), 2);

            // Вывод индекса массы тела и расшифровки результата
            Console.WriteLine($"Ваш Индекс Массы Тела: {index} - {getWeightDecryption(index)}\n");
        }

        /// <summary>
        /// Возвращает сообщение, описывающее значение индекса массы тела.
        /// </summary>
        /// <param name="index">Индекс массы тела, для которого нужно получить описание.</param>
        /// <returns>Описание индекса массы тела.</returns>
        private static string getWeightDecryption(double index)
        {
            if (index < 15.99) return "Выраженный дефицит массы тела";
            if (index < 18.49) return "Недостаточная масса тела";
            if (index < 24.99) return "Норма";
            if (index < 29.99) return "Избыточная масса тела (предожирение)";
            if (index < 34.99) return "Ожирение первой степени";
            if (index < 39.99) return "Ожирение второй степени";
            return "Ожирение третьей степени (морбидное)";
        }
    }
}
