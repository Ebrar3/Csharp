using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            Add(a, b);
            Add1();
            int a2 = Add2(a, b); 

            Console.WriteLine("sonuc ={0}", a2);
            Add1();
            int a3 = Add3(a, b);
            Console.WriteLine(a3);
            Console.WriteLine(a); //number1 olarak çekilen değişken değeri main scobe da değişmez
            Add1();
            int a4 = Add4(ref a, b); //should use ref here too
            Console.WriteLine(a4);
            Console.WriteLine(a);//number has changed
            Console.ReadLine();
        }
        static void Add1()
        {
            Console.WriteLine("Added!");
        }
        static void Add(int a = 0, int b = 10)//b=10 default value but it must be in from the end of method 
        {
            Console.WriteLine("{0}+{1}={2} \n", a, b, a + b);
        }
        static int Add2(int a, int b)
        {
            int c = a + b;
            return c;
        }
        //methodlarda değişkeni değiştirmek istiyorsak ref keyword ünü kullanmalıyız aksi halde değişken değişmez fonksiyon içinde aynı pointer kullanmak gibi (referance)
        static int Add3(int number1,int number2)
        {
            number1 = 30;
            return number1 + number2; 
        }
        static int Add4(ref int number1,int number2)
        {
            number1 = 9; //number1 in main scobe is changed
            return number1 + number2;
        }



    }
}
