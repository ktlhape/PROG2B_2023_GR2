namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Anonymous Type : 
             * var - Data type will be determined at compile time.
             Data type is static*/
            var variableName = "Jessica";
            //variableName = 5; Compile error
            Console.WriteLine($"var - {variableName.ToUpper()}");

            /*dynamic - Data type will be determined at runtime.
             Data type is dynamic*/
            dynamic variableName2 = "Jessica";
            variableName2 = "David";
            Console.WriteLine($"dynamic - {variableName2.Length}");

            Console.WriteLine("=======================");
            //Anonymous objects

            var student = new { 
                StudentId = "ST1234",
                Firstname = "Kabelo",
                TestMark = 87,
                Address = new { HouseNo = "021",
                StreeName = "Cassandra", PostalCode = "1971"}
            };
            //student.Firstname = "David"; cannot change
            /*Properties of anonymous objects are readonly*/
            Console.WriteLine(student.StudentId);
            Console.WriteLine(student.Address.StreeName);
            Console.Read();
        }
    }
}