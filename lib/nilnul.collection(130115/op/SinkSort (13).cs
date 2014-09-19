using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.collections
{

	/// <summary>
	/// the biggest will get down in the first loop.
	/// </summary>
	public class BubbleSort
	{
		
		static public IList<T> Sort<T>(IList<T> list,Func<T,T,bool> compare) {

			T temp;

			for (int i = 0; i <list.Count-1; i++)
			{
				for (int j = list.Count-1; j >i; j--)
				{
					if (compare(list[j], list[j - 1]))
					{
						temp = list[j];
						list[j] = list[j - 1];
						list[j -1] = temp;

					}

				}


			}
			return list;
 
		}
	}
}
