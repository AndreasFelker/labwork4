using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        public int proba1 { get; set; }
        public int proba2 { get; set; }
        public int proba3 { get; set; }
        public int proba4 { get; set; }
        public int result { get; set; }

        public void Fn1()
        {
            //proba1 = proba2 - proba1-proba; //До изменения
			proba1 = proba2 -- proba1-probaa; //После изменения
			switch (proba1)
			{
				case 1: Console.WriteLine ("Hello, world!"); 
				break;
				case 2: Console.WriteLine ("Goodbye, world!");
				break;
				default: break;
        }
        public void Fn2()
        {
            if (proba2 <= 5)
            {
                proba2 = 2;
            }
            else 
            {
                proba2 = 1;
            }
        }
        public void Fn3()
        {
            if (proba3 == proba4)
            {
                proba1 = 1;
            }
            else if (proba3 > proba4)
            {
                proba1 = 2;
            }
            else
                proba1 = 1;

            switch (proba2)
            {
                case 1:
                    result = 54;
                    break;
                case 2:
                    result = 46;
                    break;
                case 3:
                    result = 666;
                    break;
            }
        }
        public void Fn4()
        {
            proba4 = proba3 / proba1;
        }
		 public void Fn5()
        {
			            if (proba2 <= 5)
            {
                proba2 = 2;
            }
            else 
            {
                proba2 = 1;
            }
			            if (proba2 <= 5)
            {
                proba2 = 2;
            }
            else 
            {
                proba2 = 1;
            }
			            if (proba2 <= 5)
            {
                proba2 = 2;
            }
            else 
            {
                proba2 = 1;
            }

            
        }
    }
}
