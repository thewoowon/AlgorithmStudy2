using System;
using System.Collections.Generic;
using System.Text;

namespace No_1_ShortOfPrice
{
	class BinaryTree<T>
	{
		public BinaryTreeNode<T> Root { get; set; }

		public void PreOrderTraversal(BinaryTreeNode<T> node)
		{
			if (node == null)
				return;

			Console.WriteLine(node.Data); // 현재 노드의 데이터를 출력
			PreOrderTraversal(node.Left);
			PreOrderTraversal(node.Right);
		}

		public void PostOrderTraversal(BinaryTreeNode<T> node)
		{
			if (node == null)
				return;
			PostOrderTraversal(node.Left);
			PostOrderTraversal(node.Right);
			Console.WriteLine(node.Data);
		}

		public void InOrderTraversal(BinaryTreeNode<T> node)
		{
			if (node == null)
				return;

			InOrderTraversal(node.Left);
			Console.WriteLine(node.Data);
			InOrderTraversal(node.Right);
		}

	}
}
