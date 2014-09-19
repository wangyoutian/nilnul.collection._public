using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	public partial class Square<T>
		:Matrix<T>
		
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		/// <exception cref=""> null reference</exception>
		static public bool Is(T[,] a) {
			if (a==null)
			{
				return true;
				
			}
			if (a.GetLength(0)==a.GetLength(1))
			{
				return true;
				
			}
			return false;
		}

	

		public int n {
			get {
				if (_val==null)
				{
					return 0;
					
				}
				return _val.GetLength(0);
			}
		}


		private T[,] _val;

		public T[,] val
		{
			get { return _val; }
			set {
				if (Not(value))
				{
					throw new ArgumentException();
					
				}
				_val = value; }
		}
		

		public Square(T[,] a)
			:base(a)
		{
			this.val = a;

		}
					


		static public bool Not(T[,] a)
		{
			return !Is(a);
		}
		static public void Assert(T[,] a) {

			if (Not(a))
			{
				throw new ArgumentException();
				
			}
		
		}

		public override string ToString()
		{
			return Matrix_Extension.ToStr(_val);
		}
	}
}
