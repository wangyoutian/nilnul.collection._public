using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	static public partial class CountX
	{
		static public uint Count(this IEnumerable a) {
			uint i = 0;
			foreach (var item in a)
			{
				i++;
				
			}

			return i;
		}
	}
}
