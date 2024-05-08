//using System.IO.Pipes;


////-------------------------------------------- Chapter 6 Presentation-----------------------------------------//
//namespace OperatorPractice
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            #region [null example]

//            int? a = null;
//            int b = a == null ? 0 : a.Value;
//            int c = a ?? 0;
//            //  Person person1 = new Person();
//            // op_sample opsample = new op_sample();
//            // opsample.testnullinoop(null);
//            #endregion
//            #region[logic]
//            //Logic_Gate example1 = new Logic_Gate();
//            //example1.Logic_Gates();



//            //int signedNumber = -5; //two comlemetaion  

//            //Console.WriteLine(Convert.ToString(signedNumber ,2));
//            //sbyte leftShifted = (sbyte)((signedNumber << 2) ); 
//            //Console.WriteLine($"Left shifted result: {Convert.ToString(leftShifted, 2) }"); 


//            //sbyte rightShifted = (sbyte)((signedNumber >> 2)); 
//            //Console.WriteLine($"Right shifted result: {Convert.ToString(rightShifted, 2)}");
//            //#endregion

//            //#region[type safety]
//            //byte a = 1;
//            //byte b = 0;
//            //var c = a + b;
//            //Console.WriteLine(c.GetType().Name);
//            #endregion
//            #region[operator overloading]
//            Vector v1 = new Vector(1, 2);
//            Vector v2 = new Vector(3, 4);

//            Vector result = v1 + v2;

//            Console.WriteLine($"Vector 1: {v1}");
//            Console.WriteLine($"Vector 2: {v2}");
//            Console.WriteLine($"Result: {result}");
//            #endregion
//            #region [compre objects]


//            //var person2 = new Person("Alice", "Smith", 255);
//            //var person3 = new Person("Alice", "Smith", 25);
//            ////Console.WriteLine(person2.GetHashCode());

//            //Console.WriteLine($"Person 2: Name  {person2.fname},{person2.lname}, Age  {person2.age}");
//            //Console.WriteLine($"Person 3: Name {person3.fname},{person3.lname}, Age {person3.age}");

//            ////  equality comparison
//            //Console.WriteLine($"Are person1 and person2 equal? {person2 == person3}");


//            #endregion
//        }
//    }
//}




////senario 2
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create instances of Person class
            Person person1 = new Person("Doe", "123456789");
            Person person2 = new Person("Doe", "123456789");

            // Display SSN and last name of each person
            Console.WriteLine($"Person 1 SSN: {person1.SSN}, Last Name: {person1.LastName}");
            Console.WriteLine($"Person 2 SSN: {person2.SSN}, Last Name: {person2.LastName}");

            // Check if two persons are equal
            Console.WriteLine($"Are person1 and person2 equal? {person1 == person2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
