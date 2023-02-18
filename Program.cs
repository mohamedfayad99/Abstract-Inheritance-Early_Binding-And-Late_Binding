namespace day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Name
            Console.WriteLine("Directed By Mohamed Ibrahim Fayad Kandil");
            #endregion

            #region Abstract class
            ////Abstract class
            ////class we cannot create object[new] from it
            ////Perimeter p1 =new Perimeter();
            //Perimeter p1;  ///reference   //ZEROB   //null
            #endregion

            #region Early Binding [static]
            /////EARLY BINDING
            /////When Reference of parent
            /////references object from child
            /////when call overridden method
            /////Compiler WILL EARLY Retrieve copy of reference
            /////Not Copy of Object
            /////   Early binding NOT LOGIC
            //Console.WriteLine("In early binding");  //without ussing virtual && override
            //Perimeter p1 = new Circle();
            //Console.WriteLine(p1.perimet()); //111
            #endregion

            #region Late Binding [dynamic]
            /////Late BINDING
            /////When Reference of parent
            /////references object from child
            /////when call overridden method
            /////Compiler WILL LATER Retrieve copy of OBJECT
            /////Not Copy of Reference
            Console.WriteLine("In late binding"); //with ussing virtual && override
            Perimeter p2 = new Circle();
            Console.WriteLine(p2.perimet());
            #endregion

            #region Inheritance
            Console.WriteLine("Circle ********");
            Circle c1 = new Circle(50, 0, 0);
            Console.WriteLine(c1.perimet());

            Console.WriteLine("Squar *********");
            Square s1 = new Square();
            Console.WriteLine(s1.perimet());

            Console.WriteLine("Rectangle *********");
            Rectangle r1 = new Rectangle(50, 50, 0);
            Console.WriteLine(r1.perimet());

            Console.WriteLine("Tringle **********");
            Triangle t1 = new Triangle(10, 20, 30);
            Console.WriteLine(t1.perimet());
            #endregion
        }
    }
}