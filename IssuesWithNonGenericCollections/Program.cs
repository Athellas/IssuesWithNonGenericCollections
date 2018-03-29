using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)

        {
            SimpleBoxUnboxOperation();
            
        }

        static void SimpleBoxUnboxOperation()
        {
            // make ValueType (int) variable
            int myInt = 25;

            object boxedInt = myInt;

            //int unboxedInt = (int) boxedInt;

            try
            {
                long unboxedInt = (long) boxedInt;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            int i = (int)myInts[0];

            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}
