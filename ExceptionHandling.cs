using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_CupCoffee
{
    public class ExceptionHandling : ApplicationException
    {
        public ExceptionHandling(string message) : base(message)
        {

        }
    }
    public class Age
    {
        public int age;
        public Age(int a)
        {
            age = a;
        }
        public void showAge()
        {
            if(age < 18)
            {
                throw (new ExceptionHandling("Yaşı 18 den küçük olmamalı"));
            }
            

        }
    }
}
