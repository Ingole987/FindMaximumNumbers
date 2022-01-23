using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    
    public class GenericMaximum<T> where T:IComparable//Icomparable gives constraints to T means it asks to read only values from IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)//ctor and type tab tab to create a constructor(shortcut key)
        {
            this.value = value;// "this" indicates calling from global variable  
           
        }
        public T[] Sort(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T MaxValue(params T[] value)
        {
            var sorted_values = Sort(value);//var sorted_values here sorted_values is only name can be changed
            return sorted_values[sorted_values.Length-1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max= MaxValue(this.value);
            Console.WriteLine(" Maximum value is: "+max);
        }

    }
    
}
