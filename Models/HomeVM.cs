using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagerCSharp.Models
{
    public class HomeVM
    {
        public Person Person
        {
            get;
            set;
        }
        public List<Person> People
        {
            get;
            set;
        }
    }
}