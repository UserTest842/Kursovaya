using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libman
{
    public static class Sorting<TData, TKey>
        where TKey: IComparable<TKey>
    {
        public static IEnumerable<TData> Count_search(IEnumerable<TData> source, Func<TData, TKey> key)
        {
            TData[] data = source.ToArray();
            TData[] data_final = new TData [source.ToArray().Length];

            for (int i = 0; i < data.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < data.Length; j++)
                {
                    if (key(data[i]).CompareTo(key(data[j])) > 0)
                    {
                        counter++;                        
                    }
                }
                if (data_final[counter] != null)
                {
                    for (int z = counter + 1; z < data_final.Length; z++)
                    {
                        if (data_final[z] == null)
                        {
                            data_final[z] = data[i];
                            break;
                        }
                    }                    
                }
                else
                {
                    data_final[counter] = data[i];
                }
                
            }

            return data_final;
        }
    }
}
