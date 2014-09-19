using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection
{
	/// <summary>
	/// A collection, a group of objects; there might be duplicate objects; there might be order or not.
	/// A set, whose same elements are ignored, and order is not important.
	/// A list, whose order is important, so every element has an order attribute.
	/// 
	/// In mathematics, the term "collection" is generally used to mean a multiset, i.e., a set in which order is ignored but multiplicity is significant. 
	/// 
	///But how to specify the element in the collection? The answer, it has to be keyed, or more specificly, indexed. Index is a special kind of key.
	///
	///todo: in the table: table:Ilist{id, name}, in the table:IColleciton{Ilist.id, IElement.id}
	/// or directly store an object as a table, e.g., prime numbers.
	/// all in all store by type, diversified by situation.



	/// </summary>
	public partial interface CollectionI
	{
		
	}
}
