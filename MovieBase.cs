using System;
namespace my_project_1
{
    internal class MovieBase
    {
       
            static void Main(string[] args)
            {
                Movie M1 = new Movie();
                M1.MovieName = "Rajnibhai";
                M1.ActorName = "asurya";
                M1.Rating = 9.4f;
                M1.ReleaseYear = 2018;
                Console.WriteLine(M1.ActorName);
                Console.WriteLine(M1.MovieName);
                Console.WriteLine(M1.Rating);
                Console.WriteLine(M1.ReleaseYear);


            }


        }
    }
