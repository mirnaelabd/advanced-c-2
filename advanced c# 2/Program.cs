using System.Collections;
using System.Collections.Generic;

namespace advanced_c__2
{
    internal class Program
    {
        public static void Reverse(ArrayList list)
        {
            int num1 = 0;
            int num2 = list.Count - 1;
            if ( list is not null )
            while (num1 < num2)
            {

                object temp = list[num1];
                list[num1] = list[num2];
                list[num2] = temp;
                num1++;
                num2--;

            }

        }
        static void Main(string[] args)
        {

            #region 11111
            /*     ArrayList numbers = new ArrayList();
                 numbers.Add(1);
                 numbers.Add(2);
                 numbers.Add(3);
                 numbers.Add(4);
                 Console.WriteLine("Original list:");
                 foreach (int number in numbers)
                 {
                     Console.Write(number + " ");
                 }
                 Console.WriteLine();

                 Reverse(numbers);

                 Console.WriteLine("Reversed list:");
                 foreach (int number in numbers)
                 {
                     Console.Write(number + " ");
                 }
                 Console.WriteLine(); */
            #endregion

            #region 22222222
            /*       List<int> list = new List<int>() { 1,2 ,3 , 4 ,5 ,6 };
                   List<int> newlist = new List<int>(); 
                   for (int i = 0; i < list.Count; i++)
                   {
                       if (list[i] % 2 == 0)
                           newlist.Add(list[i]);

                   }
                   Console.WriteLine("the orginal list ");
                   foreach (int i in list)
                   {
                       Console.WriteLine(i);

                   }
                   Console.WriteLine("the new list ");
                   foreach (int i in newlist)
                   {
                       Console.WriteLine(i);

                   }*/

            #endregion

            #region 3333333333333
      /*      FixedSizeList<int> list = new FixedSizeList<int>(3);
            list.Add_element(0);
            list.Add_element(2);   
            list.Add_element(4);
            list.Add_element(6);
            list.get(6);
            */


            #endregion


        }



    }
    }




