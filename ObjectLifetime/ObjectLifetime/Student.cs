using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    internal class Student : IDisposable
    {
        public string Name { get; set; } = "Kabelo";
        /// <summary>
        /// Constructor to build a student object
        /// </summary>
        public Student()
        {
            Console.WriteLine($"Creating student object for {Name}");
        }
        public Student(string theName)
        {
            this.Name = theName;
            Console.WriteLine($"Creating student object for {Name}");
        }

        /// <summary>
        /// Desctructor to destroy the student object
        /// </summary>
        //~Student()
        //{
        //    Console.WriteLine($"Destroying student object for {Name}");
        //}

        public void Dispose()
        {
            Console.WriteLine($"Destroying student object for {Name}");
        }
    }
}
