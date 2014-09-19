using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element;
using System.Collections;

namespace nilnul.collection
{
	static public class IEnumerable_ToStrX
	{
		static public string ToStr<T>(this IEnumerable<T> list,string seperator) {
			bool hasElement=false;
			return list.Aggregate(
				"{", 
				(w, c) =>{
					if (hasElement == false) { hasElement = true; return w + c.ToStr();  }
					else{
						return w+seperator+c.ToStr();
					}
					
				}
				,r=>r+"}"
				//,r =>  r.Length>=seperator.Length?r.Remove(r.Length - seperator.Length):r
			);
			
			
		}

		static public string ToStr(this IEnumerable list, string seperator)
		{
			bool hasElement = false;
			return list.Cast<object>().Aggregate(
				"{",
				(w, c) =>
				{
					if (hasElement == false) { hasElement = true; return w + c.ToStr(); }
					else
					{
						return w + seperator + c.ToStr();
					}

				}
				, r => r + "}"
				//,r =>  r.Length>=seperator.Length?r.Remove(r.Length - seperator.Length):r
			);


		}


		static public string ToStr<T>(this IEnumerable<T> list)
		{
			return list.ToStr(",");
		}

		static public string ToStr(this IEnumerable list)
		{
			return list.Cast<object>().ToStr();
		}
	
	

	
	}
}
