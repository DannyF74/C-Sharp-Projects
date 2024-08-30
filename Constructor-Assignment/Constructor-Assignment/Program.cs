using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we are creating a const variable. This variable will not change during the
            // operation of our program so its important to use a const to always keep this variable the same.
            const string companyName = "The Tech Academy";

            // Setting up a first name variable and passing that in to our instantiation of our new person named
            // User. The arguments we choose to pass in to the instantiation of the "User" object will determine
            // whether or not the "User" object has generic values. This is handled by our chained constructors below.
            string fname = "Danny";
            string lname = "Firth";
            var User = new person(fname, lname);
            Console.WriteLine("Hello, {0} {1}. Welcome to {2}!", User.fname, User.lname, companyName);
            Console.ReadLine();
            
        }

        // Here we are defining our person class. This class has a first name property and a last name property.
        // Our chained constuctors handle what the values of the properties are depending on what is passed in
        // during the instantiation of an object from this class.
        //
        // If no arguments are passed in, the object will just receive a generic "First Name" as the fname and then move to the
        // next constructor and add a generic "Last Name' as the last name. Then finally construct the object with these
        // generic values.
        //
        // If only one argument is passed in, the first consructor will be skipped as the first argument will be assigned to
        // fname. Then the chain will add the generic "Last Name" and then construct the object with the passed in argument
        // and the generic addition.
        //
        // If two arguments are passed in, there is no need for any generic values to be added so the object will be created
        // with the arguments passed in.
        public class person
        {
            public string fname;
            public string lname;

            public person() : this("First Name")
            {
            }

            public person(string fname) : this(fname, "Last Name")
            {
            }

            public person(string fname, string lname)
            {
                this.fname = fname;
                this.lname = lname;
            }
        }
    }
}
