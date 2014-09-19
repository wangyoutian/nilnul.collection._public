using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using nilnul.element.collection;

namespace nilnul.element
{
	static public partial class ToStrX
	{
		static public string ToStr(this object o) {
			if (o is IEnumerable)
			{
				//return nilnul.element.collection.CollectionTostrX.Tostr((IEnumerable)o);
				return nilnul.element.collection.CollectionTostrX.Tostr(o as IEnumerable);
			}
			else
			{
				return o.ToString();
			}
		
		}
	}
}
