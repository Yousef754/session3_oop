namespace session3_oop
{
    internal class Program
    {
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

        }
    }
}
