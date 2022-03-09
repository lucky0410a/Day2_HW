using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_HW
{
    class SwitchExercise
    {
        public static bool switchExercise(string exercise)
        {
            bool switchFlag;
            switch (exercise)
            {
                // printPyramid
                case "01":
                    Exercise01.printPyramid();
                    switchFlag = true;
                    break;

                case "02":
                    Exercise01.print9x9();
                    switchFlag = true;
                    break;

                // 離開
                case "exit":
                    switchFlag = false;
                    break;

                // 輸入錯誤的輸入
                default:
                    Console.WriteLine("請輸入正確的題號!!");
                    switchFlag = true;
                    break;
            }
            return switchFlag;
        }
    }
}
