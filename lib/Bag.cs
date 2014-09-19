using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{

	/// <summary>
	/// a multiset defined by its elements
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Bag<T>
		: Dictionary<T, uint>
		,
		IEnumerable<KeyValuePair<T, uint>>
	{



		public Bag()
		{
		}


		public Bag(Dictionary<T,uint> bags):
			base(bags)
		{


			

			
		}

		public Bag(Bag<T> bag):
			base(bag)
		{
		}
					
					
		public Bag(params T[] values)
			:this(values.AsEnumerable())
		{
			//increase(values);
		}
				
		public Bag(IEnumerable<T> values)
		{
			increase(values);
		}

		/// <summary>
		/// remove those which count is 0
		/// </summary>
		public void pack() {

			foreach (var item in this.Where(c=>c.Value==0))
			{
				this.Remove(item.Key);
				
			}
			
		}

	

		public void increase(IEnumerable<T> value)
		{
			foreach (var item in value)
			{
				this.increase(item);
			}


		}

		/// <summary>
		/// elements difference. unsymmetric.
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		public Bag<T> subtract(Bag<T> b)
		{
			Bag<T> r = new Bag<T>(this);
		
			r.decrease(b);
			return r;
		}


		public Bag<T> subtract(List<T> b)
		{
			Bag<T> r = new Bag<T>(this);

			
			r.decrease(b);
			return r;
		}


		/// <summary>
		/// the number of keys
		/// </summary>
		public virtual uint count
		{
			get
			{
				return (uint)(this.Sum(c => c.Value));

			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public virtual uint countElement(T key)
		{
			if (this.ContainsKey(key))
			{
				return (uint)(this[key]);

			}
			else
			{
				return 0;
			}
		}

		public void decrease(T key)
		{

			vary(key, -1);
		}




		public IEnumerable<T> toEnumerable()
		{
			foreach (var item in this)
			{
				for (int i = 0; i < item.Value; i++)
				{
					yield return item.Key;

				}

			}

		}


		public virtual void increase(T key)
		{
			vary(key, 1);

		}

		public virtual void increaseRange(Bag<T> keyValues)
		{
			vary(keyValues);
		}






		#region FiniteMultisetI<T> Members

		public void vary(KeyValuePair<T, uint> keyValues)
		{
			vary(keyValues.Key, (int)keyValues.Value);
		}

		public void decrease(KeyValuePair<T, uint> keyValues)
		{
			vary(keyValues.Key, -(int)keyValues.Value);
		}



		public void vary(T key, int value)
		{
			if (this.ContainsKey(key))
			{
				if (this[key] + value < 0)
				{
					throw new Exception();

				}

				else if (this[key] + value == 0)
				{
					Remove(key);

				}

				else
				{
					this[key] = (uint)(this[key] + value);

				}

			}
			else
			{

				this.Add(key, (uint)value);

			}

		}

		public uint elementCount(T key)
		{
			if (ContainsKey(key))
			{
				return this[key];

			}
			else
			{
				return 0;
			}
		}


		public void vary(IEnumerable<KeyValuePair<T, uint>> batch)
		{
			foreach (var item in batch)
			{
				if (elementCount(item.Key) + item.Value < 0)
				{
					throw new Exception();

				}

			}
			foreach (var item in batch)
			{
				vary(item.Key, (int)item.Value);
			}

		}

		public void decrease(IEnumerable<KeyValuePair<T, uint>> batch)
		{

			foreach (var item in batch)
			{
				vary(item.Key, -(int)item.Value);
			}

		}


		public void decrease(List<T> batch)
		{
			

			foreach (var item in batch)
			{
				decrease(item);
			}

		}

		#endregion

		public override string ToString()
		{
			string r = "{";
			foreach (var item in this)
			{
				r += "(";
				r += item.Key.ToString();
				r += ","
				;
				r += item.Value;
				r += ")";

			}
			r += "}";
			return r;
			//return r.ToStr();
		}
	}//class
}
