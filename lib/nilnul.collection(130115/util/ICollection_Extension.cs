using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection
{
	static public class ICollection_Extension
	{
		static public string toString<T>(this IEnumerable<T> list,string seperator) {
			bool hasElement=false;
			return list.Aggregate(
				"", 
				(w, c) =>{
					if (hasElement == false) { hasElement = true; return w + c;  }
					else{
						return w+seperator+c;
					}
				}
				//,r =>  r.Length>=seperator.Length?r.Remove(r.Length - seperator.Length):r
			);
			
			
		}
		static public string toString<T>(this IList<T> list)
		{
			return list.toString(",");
		}
		static public string ToString<T>(this IList<T> list) {
			return list.toString();
		}

	
	}
}
