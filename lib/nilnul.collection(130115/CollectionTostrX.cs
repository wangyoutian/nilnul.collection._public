using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.element.collection
{

	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	static public partial class CollectionTostrX {

		/// <summary>
		/// s
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vector"></param>
		/// <returns></returns>
		/// 
///		[Obsolete("see collection.Collection")]
		static public string Tostr<T>(this IEnumerable<T> vector,string seperator)
		{

			bool isEmpty=true;
			return vector.Aggregate(
				"", 
				(w, c) =>{
					if (isEmpty) { isEmpty = false; return w + c;  }
					else{
						return w+seperator+c;
					}
				}
				
			);

		}


		static public string Tostr(this IEnumerable vector, string seperator)
		{

			string r="";
			foreach (var item in vector)
			{
				r += item.ToStr();


				
			}
			return r;
			

		}


		static public string Tostr(this IEnumerable enumerable)
		{
			return enumerable.Tostr(",");
		}

		static public string Tostr<T>(this IEnumerable<T> vector)
		{
			return vector.Tostr(",");
		}



		
		

	}


	
}
