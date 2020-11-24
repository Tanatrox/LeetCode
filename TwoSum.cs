using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_sum
{
    class Brute
    {        
        public void Metodo ()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            
            for (int n1 = 0; n1 < nums.Length; n1++)
            {                
                for (int n2 = 1; n2 < nums.Length; n2++)
                {                   
                    if (nums[n2] == target - nums[n1])
                    {
                        Console.WriteLine("["+n1+","+n2+"]");                       
                    }

                }
            }
            

        }
        
        static void Main(string[] args)
        {
            Brute b = new Brute();            
            b.Metodo();
            
            Console.ReadKey();
        }
        
    }
}
