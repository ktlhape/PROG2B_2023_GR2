using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Student
    {
        public string StNumber { get; set; }
        public string Name { get; set; }
        public double TestMark { get; set; }
        private List<Student> stList = new List<Student>();

        public Student(string stNumber, string name, double testMark)
        {
            StNumber = stNumber;
            Name = name;
            TestMark = testMark;
        }
        public Student()
        {
            stList.Add(new Student("ST100","Roger",89));
            stList.Add(new Student("ST101","Caroline",44));
            stList.Add(new Student("ST102","Jonathan",50));
            stList.Add(new Student("ST103","James",63));
            stList.Add(new Student("ST104","Lesego",90));
            stList.Add(new Student("ST105","Thabo",75));

            this.StNumber = "0000";
            this.Name = "No Name";
            this.TestMark = 0;
        }

        public Student this[string x]
        {
            get
            {
                foreach (Student st in stList)
                {
                    if (st.StNumber.Equals(x))
                    {
                        return st;
                    }
                }
                return new Student();
            }
        }

        public List<Student> this[double mark]
        {
            get
            {
                List<Student> markList = new List<Student>();
                foreach (Student st in stList)
                {
                    if (st.TestMark >= mark)
                    {
                        markList.Add(st);
                    }
                }
                return markList;
            } 
        }

        public override string ToString()
        {
            return $"{StNumber} - {Name} : ({TestMark})";
        }


    }
}
