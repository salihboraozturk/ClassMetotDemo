using System;

namespace DictonaryExam
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string, int> kayıtlar = new MyDictonary<string, int>();
            kayıtlar.Add("Ali",15);
        }
    }
}
