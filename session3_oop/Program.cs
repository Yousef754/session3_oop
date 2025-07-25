namespace session3_oop
{
    internal class Program
    {

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







                static void Main(string[] args)
                {
                    #region interfaces
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
                }

            }
        }
    }
}
