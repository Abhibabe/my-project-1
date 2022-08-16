using System;
using System.Diagnostics;

namespace my_project_1
{
    // [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hollow world!");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
    
    
