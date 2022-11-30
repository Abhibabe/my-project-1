using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Class45
    {
        enum Year
        {
            January,
            februrary,
            march,
            aprail,
            may,
            june,
        }
        static void Main(string[] args)
        {
            Year y = Year.January;
            switch (y)
            {
                case Year.January:
                    Console.WriteLine("INDEPENDENCE DAY");
                    break;
                case Year.februrary:
                    Console.WriteLine("JAI ho");
                    break;



            }

        }
    }
}
