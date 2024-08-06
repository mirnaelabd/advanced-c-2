using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_c__2
{
    public class FixedSizeList<T>
    {
     private  List<T> list;

        public int Count => list.Count;
        
        public FixedSizeList(int cacity )
        {
           list = new List<T>(cacity);
           
            
          
        }
        public void Add_element(T item)
        {

           if (list.Capacity >= list.Count)
                list.Add(item);
            else
                Console.WriteLine("can't add a element list is full");

       }
        public void get( int index)
        {
            if(index < 0 || index >= list.Count)
            {
                Console.WriteLine("out of range ");
            }
            else

                Console.WriteLine($"{list[index]}");
            


        }



    }
}
