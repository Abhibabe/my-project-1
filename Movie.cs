using System;
using System.Collections.Generic;
using System.Text;

namespace my_project_1
{
    class Movie 
    {
        string moviename;
        string actorname;
        float rating;
        int releaseyear;
        
        public string MovieName
        {
            set

            { MovieName = value; }


            get

            { return moviename; }
        }
            
            public string ActorName
        {
            set
            {
                actorname = value;
            }
            get

            { return actorname; }
        }            
        
        public float Rating
        {
            set
            {
                Rating = value;
            }
            get
            {
                return rating;
            }
        }

        public int ReleaseYear
        {
            set { releaseyear = value; }
            get { return releaseyear; }
        }
        public void  MovieRating()
        {
            if (Rating <= 3)
            {
                Console.WriteLine("flop");
            }
            else if (Rating<=4)
            {
                Console.WriteLine("hit");
            }

            else
            {
                Console.WriteLine("super hit");
            }
        }
        public void Main (string[] args)
        {
            Movie M1 = new Movie();
            M1.MovieName = "Rajnibhai";
            M1.ActorName = "asurya";
            M1.Rating = 9.4f;
            M1.ReleaseYear = 2018;
            M1.MovieRating();
            Console.WriteLine(M1.ActorName);
            Console.WriteLine(M1.MovieName);
            Console.WriteLine(M1.Rating);
            Console.WriteLine(M1.ReleaseYear);


        }

    }
}
