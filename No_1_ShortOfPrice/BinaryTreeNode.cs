using System;
using System.Collections.Generic;
using System.Text;

namespace No_1_ShortOfPrice
{
	public class BinaryTreeNode<T>
	{
		public T Data { get;set; }
		public BinaryTreeNode<T> Left { get; set; } 

		public BinaryTreeNode<T> Right { get; set; }

		public BinaryTreeNode(T data)
		{
			this.Data = data;
		}

	}
}
