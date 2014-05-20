using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagerCSharp.Models
{
    public class Person
    {
        public string Name 
            {
            get;
            set;
        } 
        public string Address
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string Picture
        {
            get;
            set;
        }
        public int ID
        {
            get;
            set;
        }

        public Person( string name, string phoneNumber, string address, string picture, int id)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Picture = picture;
            this.ID = id;
        }
        //This is where our constructor is called when we add a person 
        public Person()
        {
        }
    }
}