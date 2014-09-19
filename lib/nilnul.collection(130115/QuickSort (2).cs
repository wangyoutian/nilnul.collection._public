using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.element;

namespace nilnul.element.collection.quickSort
{
	class QuickSort
	{
		static void Main(string[] args)
		{
			List<int> a = nilnul.num.integer.collection.op.IntCollectionSampleX.Sample(Enumerable.Range(0,100),100);

			Console.WriteLine( (Sort(a) as IEnumerable<int>).Tostr());
			

		}

		static List<int> Sort(List<int> array) {

			if (array.Count<1)
			{
				return array;
				
			}
			List<int> less=new List<int>();
			List<int> greater=new List<int>();
			int pivot = array[0];
			array.RemoveAt(0);
			array.ForEach(x => { if (x <= pivot) less.Add(x); else greater.Add(x); });


			Parallel.Invoke(
				()=>less=Sort(less),

				()=>greater=Sort(greater)
				
				
				);
			less.Add(pivot);
			less.AddRange(greater);
			return less;
		}
	}
}
