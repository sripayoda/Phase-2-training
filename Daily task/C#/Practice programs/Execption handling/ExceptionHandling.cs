using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class ExceptionHandling
    {
        private int num1, num2, res,age;
        //private int[] numbers;
        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Res { get => res; set => res = value; }

        public int Age { get => age; set => age = value; }
        //public int[] Numbers { get => numbers; set => numbers = value; }

        public ExceptionHandling(int num1, int num2, int res, int age) //int[] numbers)
        {
            Num1 = num1;
            Num2 = num2;
            Res = res;
            Age = age;
            //Numbers = numbers;
        }

        public int Add()
        {
            Res = Num1 + Num2;
            return Res;
        }

        public int Divide()
        {
           /* try
            {
               Res = Num1 / Num2;
                for (int i=0; i<4; i++)
                {
                    int quo = Numbers[i] / Num2;
                    Console.WriteLine(quo);
                }
            }
            *//*catch (ArithmeticException ec)
            {
                Console.WriteLine("You Have Given 0 as Denominator");
                Res = 0;
            }*/
            /*catch (IndexOutOfRangeException ec)
            {
                Console.WriteLine("Index is out of range");
            }*//*
            catch(Exception e)// always give common exoection in last because all exceptions will be catched in fisrt itself
            {
                Console.WriteLine(e.Message); //obj.Message is for printing the defined message
                Console.WriteLine(e.StackTrace);    
                Console.WriteLine(e.InnerException);
            } 
            
            finally
            {
                Console.WriteLine("Done");
            }*/
            if (Num2 != 0)
            {
                Res = Num1 / Num2;
            }
            else
            {
                throw new DivException("Denominator is O");
            }
            return Res;
        }

        public void CheckAge() 
        {
            if (Age < 18)
                throw new AgeException();
            else
                Console.WriteLine("OK");
        }

    }
}
