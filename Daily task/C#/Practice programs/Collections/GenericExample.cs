using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class GenericExample
    {
        List<int> numbers = new List<int>();

        public void AddElement()
        {
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        public int Find()
        {
            return numbers.ElementAt(2);
        }

        public int SumElements()
        {
            return numbers.Sum(x=>x);
        }

        //ArrayList<int> numbers= new ArrayList<int>(); 
    }
}
