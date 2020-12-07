using System;
using System.Collections;

namespace _119
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array1 = new ArrayList();
            int var1 = 10;
            int var2;
            array1.Add(var1);

            //var2 = ((List<int>) array1)[0];
            //var2 = array1[0] is int;
            var2 = Convert.ToInt32(array1[0]);
            //var2 = ((int[])array1)[0];

            Console.WriteLine(array1[0]);
        }
    }
}


/* Explanation: 
 * https://stackoverrun.com/es/q/1194691 
Convert.ToInt32 is basically the same as int.Parse With one difference: if you use int.Parse(null) an exception is thrown, while Convert.ToInt32 returns 0
*/