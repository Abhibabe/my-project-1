using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1 { 

    class Are
    {
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());


        int[] a = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int N = int.Parse(Console.ReadLine());
        a[n + 1] = N;
        for (int i = 0; i <= n; i++)
        {
            Console.Write(a[i]);
        }
    }

}





}
