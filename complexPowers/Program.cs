using System;


namespace complexPowers
{
    class MainClass
    {
        public struct complex  
        {  
            public double r;  
            public double j; 
        }  
        public static void Main(string[] args)
        {
            complex c1 = new complex();

            c1.r = 0.0;
            c1.j = 0.0;

            Console.WriteLine("r={0:N},j={1:N}",c1.r,c1.j);
        }
    }
}
