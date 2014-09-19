using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.set
{
	/// <summary>
	/// the set of all subsets of the given set.
	/// </summary>
	public class PowerSet:Set
	{
		public Set set;
		public PowerSet(Set set) {
			this.set = set;
		}

		public override Order order {
			get {
				return 2 ^ set.order;
			}
		}

		public override string ToString()
		{
			return "2^"+set;
		}

	}
}
