namespace session3_oop
{
    internal class Program
    {
        /*
        static void Print10Number(SeriesByTwo series)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"{series.current}");
                series.Next();

            }
            series.Reset();

            static void Print110Number(seriesByThree series)
            {
                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine($"{series.current}");
                    series.Next();

                }

                series.Reset();






        */
                static void Main(string[] args)
                {
            /*  #region interfaces
       // interfaces:reference type
       //code contract between the developer who write it and the developer who use it
       // IMyType myType =IMyType();

       //note:can't create object from any interfaces



       MyType myType = new MyType();
       myType.salary = 12000;
       Console.WriteLine(myType.salary);
       myType.MyFun();


       //ImyType mytype = new ImyType();
       ImyType iimyType;

       //iimyType = new ImyType();
       //MyType myType = new MyType();
       //myType.salary = 12000;
       //Console.WriteLine(myType.salary);
       //myType.MyFun();
       //



       #endregion



       #region V3

       SeriesByTwo seriesByTwo = new SeriesByTwo();
       Print10Number(seriesByTwo);
       seriesByThree seriesbyThree = new seriesByThree();
       //SeriesByFour seriesByFour = new SeriesByFour();
       // print10number(seriesByFour);

       int[] Numbers = { 7, 3, 4, 5, 6, 0, 2, 1 };
       Array.Sort(Numbers);

       //foreach (int i in Numbers)
       //{
       //    //Console.WriteLine($"{item}");
       //}







       #endregion
       #region v5
       // shallow copy vs deep copy

       int[] arr1 = { 1, 2, 3 };
       int[] arr2 = { 4, 5, 6 };



       Console.WriteLine($"arr01: {arr1.GetHashCode()}");
       Console.WriteLine($"arr02: {arr2.GetHashCode()}");

       arr2 = arr1;

       Console.WriteLine($"arr01: {arr1.GetHashCode()}");
       Console.WriteLine($"arr02: {arr2.GetHashCode()}");


       #endregion
       #region V6
       Employee E1 = new Employee() { Id = 1, Name = "ahmed", Age = 23, salary = 16000 };
       Employee E2 = new Employee() { Id = 1, Name = "ahmed", Age = 23, salary = 16000 };

       Console.WriteLine(E1.GetHashCode());
       Console.WriteLine(E2.GetHashCode());


       E1.salary = 59000;
       Console.WriteLine(E1);
       Console.WriteLine(E2);
       #endregion
       #region V7
       // Employee[] employees=new Employee[3]
       //{new Employee(){id=1,name="ahmed",age=30,salary=15999},
       //new Employee(){id=2,name="omar",age=48,salary=20099},
       //  }
       //
       //Array.sort(employees);

       //int X =employees[0].comparto(employees[1]);
       //
       #endregion*/

            #region part01
            /*
                        Question 1:
                  What is the primary purpose of an interface in C#?
                  a) To provide a way to implement multiple inheritance
                     b) To define a blueprint for a class
                     c) To declare abstract methods and properties
                     d) To create instances of object   s

                 answer is (b)

                        Question 2:
                 Which of the following is NOT a valid access modifier for interface members in C#?
                 a) private
                 b) protected
                 c) internal
                 d) public
                 
                  the answer is (a)
                 
                 Question 3:
                 Can an interface contain fields in C#?
                 a) Yes
                 b) No
                 c) Only if they are static
                 d) Only if they are read only
                 
                 the answer is (a)


                 Question 4:
                 In C#, can an interface inherit from another interface?
                 a) No, interfaces cannot inherit from each other
                 b) Yes, interfaces can inherit from multiple interfaces
                 c) Yes, but only if they have the same methods
                 d) Only if the interfaces are in the same namespace

                 the answer is (c)


                 Question 5:
                 Which keyword is used to implement an interface in a class in C#?
                 a) inherit
                 b) use
                 c) extends
                 d) implements
                 the answer is (d)
                 
                 Question 6:
                 Can an interface contain static methods in C#?
                 a) Yes
                 b) No
                 c) Only if the interface is sealed
                 d) Only if the methods are private
                 the answer is (a)


                 Question 7:
                 In C#, can an interface have explicit access modifiers for its members?
                 a) Yes, for all members
                 b) No, all members are implicitly public
                 c) Yes, but only for abstract members
                 d) Only if the interface is sealed
                 
                 the answer is (b)

                 Question 8:
                 What is the purpose of an explicit interface implementation in C#?
                 a) To hide the interface members from outside access
                 b) To provide a clear separation between interface and class members
                 c) To allow multiple classes to implement the same interface
                 d) To speed up method resolution
                 
                  the answer is (c)
                 
                 Question 9:
                 In C#, can an interface have a constructor?
                 a) Yes, but it must be private
                 b) No, interfaces cannot have constructors
                 c) Yes, but only if the interface is sealed
                 d) Only if the constructor is static
                 the answer is (B)


                 Question 10:
                 How can a C# class implement multiple interfaces?
                 a) By using the "implements" keyword
                 b) By using the "extends" keyword
                 c) By separating interface names with commas
                 d) A class cannot implement multiple interfaces
                 
                 the answer is (c)

             */


            #endregion



        }

    }
}
