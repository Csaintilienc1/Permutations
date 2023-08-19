using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public class Permutations
    {
        public List<List<int>> Permute(int[] arr)
        {

            List<int[]> permList = new();

            for (int i = 0;i<=arr.Length;i++)
            {
                //////
                if (i==arr.Length-1)
                {
                    //do something 
                    int temp = 0;
                    temp = arr[1];
                    arr[1] = arr[arr.Length-1];
                    arr[arr.Length-1] = temp;
                    permList.Add(arr);

                }


                else
                {
                    int temp = 0;
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    permList.Add(arr);
                }

            }
            return permList;
        }
    }
}
