using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagerCSharp.Models
{

    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public List<Person> People = new List<Person>()
        {
            new Person("Sam Bender", "123 Main Street NY, NY", "716-123-4567", "https://scontent-a-ord.xx.fbcdn.net/hphotos-ash2/t1.0-9/217041_645075686432_2724300_n.jpg", 0),
            new Person("Samuel Bender", "123 Main Street NY, NY", "716-123-4567", "https://scontent-a-ord.xx.fbcdn.net/hphotos-prn2/t1.0-9/1425754_10100207677554752_1556355_n.jpg", 1),
            new Person("Nicole Bender", "123 Main Street NY, NY", "716-123-4567", "https://scontent-b-ord.xx.fbcdn.net/hphotos-frc3/t1.0-9/197453_1916777116361_2667303_n.jpg", 2),
            new Person("Kim Kardashian", "704 Miami Street Miami Beach, FL", "206-128-4567", "http://i.dailymail.co.uk/i/pix/2013/07/04/article-2356152-189355F6000005DC-662_306x423.jpg", 3),
            new Person("Jessica Alba", "123 Harvard Ave. Cambridge, MA", "704-897-1236", "http://portiafreno.com/wp-content/uploads/2014/02/Jessica-Alba-2-beautiful-female-celebrities-35406279-1680-1050.jpg", 4),
            new Person("Mike Krzyzewski", "917 Krzyzewskiville Durham, NC", "919-123-4567", "http://media2.newsobserver.com/smedia/2013/03/28/19/38/UOsvh.AuSt.156.jpeg", 5),
        };
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}




