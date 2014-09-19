using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collections
{
	public class Program_SinkSort
	{
		static public void Main() {
			List<double> a = new List<double>(
				new double[]{

			    1.99
			    ,1.93
			    , 92.7
			//,0
			//, 1.982

			//, 0.82, 0, 2.3,93, 13.3,8, 33,0, 9.3,0.83, 4.4, 5.8, 6,.83 ,97, 8, 9,2.3 
			 }
			);
			
			Console.WriteLine(a.ToString());
			Console.WriteLine("---------------------");
			//Console.WriteLine(
			BubbleSort.Sort(
				a,
				(x, y) => x <y ? true :false
			).toString(",---\n").ToConsoleLine();
			//);
			Console.Read();
		}
	}
}
