using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitaciones
{
    //se usa mucho para eventos
    public class MyDelegates
    {
        public delegate void Callback(string msg);

        public void Main()
        {
            Callback del = MethodA;
            Callback delC = MethodC;

            Callback allDelegates = del + delC;
            allDelegates += MethodD;

            //del.Invoke("Message that needs to be printed");
            allDelegates("Message that needs to be printed");




            /*if () {
                DelegateAsParameter(MethodA);
            } else {
                DelegateAsParameter(MethodC);
            }*/
            
            
            DelegateAsParameter(del);
        }

        public void DelegateAsParameter(Callback callback)
        {
            callback("From another method");
        }

        public void MethodA(string anotherThing)
        { 
            Console.WriteLine($"Print the message: {anotherThing}");
        }

        public void MethodC(string anotherThing)
        {
            Console.WriteLine($"Print the message from C: {anotherThing}");
        }

        public void MethodD(string anotherThing)
        {
            Console.WriteLine($"Print the message from D: {anotherThing}");
        }

        public void MethodB(int anotherInteger)
        {
            Console.WriteLine("anotherInteger");
        }
    }
}
