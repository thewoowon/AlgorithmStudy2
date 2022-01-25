using System;
using System.Numerics;

namespace No_1_ShortOfPrice
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("<Binary Tree>");
			BinaryTree<int> btree = new BinaryTree<int>(); //내부에 비어 있는 루트 노드를 생성
			btree.Root = new BinaryTreeNode<int>(1);
			btree.Root.Left = new BinaryTreeNode<int>(2);
			btree.Root.Right = new BinaryTreeNode<int>(3);
			btree.Root.Left.Left = new BinaryTreeNode<int>(4);

			btree.PreOrderTraversal(btree.Root); // 내부의 private함수 recursive를 실행시키는 public

			Console.WriteLine("InOrder");
			btree.InOrderTraversal(btree.Root);
			Console.WriteLine("PreOrder");
			btree.PreOrderTraversal(btree.Root);
			Console.WriteLine("PostOrder");
			btree.PostOrderTraversal(btree.Root);

			Console.WriteLine("<Binary Search Tree>");
			bst<int> bst = new bst<int>();
			bst.Insert(4); // insert 시에 기본적으로 이진트리 법칙을 만족하는 트리를 형성
			bst.Insert(2);
			bst.Insert(6);
			bst.Insert(1);
			bst.Insert(7);

			bst.PreOrderTranversal(); // 전위 순회를 하면서 트리를 반환


			Solution solution = new Solution();
			long result = solution.GCD_impl(78696, 19332);
			Console.WriteLine(result); //보호수준
			
		}

		public partial class Solution
		{
			public long GCD_impl(long x,long y)
			{
				return GCD(x,y);
			}
			private long GCD(long x, long y)
			{
				long c = 0;
				long max = Math.Max(x, y);
				long min = Math.Min(x, y);
				// 최대공약수를 구하는 방법 -> 유클리드 호제법
				// 작은 수로 큰수를 나눈다 -> 만약 나누어 떨어진다면 즉 나머지가 0이라면 나눈 수는 최대공약수가 된다.
				// 나누어지지 않고 즉 나머지가 있다면 그 나머지로 나눈 수를 다시 나누어주고 
				// 이는 나머지가 0이 될 때까지 반복한다.

				while (min != 0) // 큰 값을 작은 값으로 나눈 나머지
				{
					c = max % min;
					max = min;
					min = c;
				}


				return min;
			}
		}

		
	}
}
