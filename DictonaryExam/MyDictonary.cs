using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryExam
{
    class MyDictonary<T,Z>
    {
        T [] names;
        Z [] ages;
        public MyDictonary()
        {
            names = new T[0];
            ages = new Z[0];
        }
        public void Add(T name,Z age)
        {
            T [] tempArray = names;
            Z[] tempArray2 = ages;
            names = new T[names.Length + 1];
            ages = new Z[ages.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                names[i] = tempArray[i];
            }
            names[names.Length - 1] = name;
            for (int i = 0; i < tempArray2.Length; i++)
            {
                ages[i] = tempArray2[i];
            }
            ages[ages.Length - 1] = age;
            Console.WriteLine(name+" eklendi");
            Console.WriteLine(age+" eklendi");

        }
    }
}
