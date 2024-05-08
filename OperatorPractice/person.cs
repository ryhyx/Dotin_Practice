//using OperatorPractice;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;


//-----------if you want to Run this file .comment all person2.cs file .then uncomment this file-----------//
//namespace OperatorPractice
//{


//    #region [null Example]
//    public class Person
//    {

//        public string? fname { get; set; }
//        public string? lname { get; set; }
//        public int? age { get; set; }
//        public Person()
//        {

//        }
//        public Person(string firstName, string lastName, int personAge)
//        {
//            fname = firstName;
//            lname = lastName;
//            age = personAge;
//        }

//        public override bool Equals(object? obj)
//        {
//            var other = (Person?)obj;

//            return fname == other.fname &&
//                   lname == other.lname &&
//                   age == other.age;
//        }

//        public static bool operator ==(Person personLeft, Person personRight)
//        {
//            if (Equals(personLeft, personRight))
//            {
//                return true;
//            }
//            return false;
//        }
//        public static bool operator !=(Person personLeft, Person personRight)
//        {
//            return !(personLeft == personRight);
//        }



//        public override int GetHashCode()
//        {
//            var hashCode = HashCode.Combine(fname, lname);
//            hashCode = HashCode.Combine(hashCode, age);
//            return hashCode;
//        }
//    }
//}


//public class op_sample
//{

//    public void testnullinoop(Person person)
//    {
//        Console.WriteLine(person?.fname);
//    }
//}

//#endregion


