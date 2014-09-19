using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collections
{
	static public class RecurSort_Extension
	{
		static public T[] RecurSort<T>(this T[] array, Func<T, T, bool> compare)
		{
			//
			if (array.Length < 2)
			{
				return array;
			}
			else {
				return RecurSort(list, compare,1);
			}
			


		}
		static public T[] RecurSort<T>(this T[] array,Func<T,T,bool> compare,int start) {
			if (array.Length - start > 1)
			{
				RecurSort(array, compare, start + 1);
			}
			else { 

			}
		}
	}
}
