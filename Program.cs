using System;

namespace Day02_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            bool switchVar = true;
            string input;

            while (switchVar)
            {
                // 輸入1.題號 或 2.exit
                Console.Write("請輸入題號or輸入 exit 離開: ");
                input = Console.ReadLine();

                switchVar = SwitchExercise.switchExercise(input); // 選擇題目
            }
            

        }
    }
}
