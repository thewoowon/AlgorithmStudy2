using System;
using System.Collections.Generic;
using System.Text;

namespace No_1_ShortOfPrice
{
	public class bst<T> //서치 엔진 -> 여기서 탐색 함수 선언
	{
		private BinaryTreeNode<T> root = null;
		private Comparer<T> comparer = Comparer<T>.Default; // 비교자이고

		public void Insert(T val)
		{
			BinaryTreeNode<T> node = root; //참조형 변수 생성
			if (node == null) // 값을 확인
			{
				root = new BinaryTreeNode<T>(val); // 새로운값 주입-> 생성자로
				return;
			}
			while(node !=null)
			{
				int result = comparer.Compare(node.Data, val);
				if (result == 0) // 값이 같
				{
					return;
				}
				else if(result > 0) // node.Data가 더 크다 -> 왼쪽으로 이동해야함 -> 이진트리 특성
				{
					if (node.Left == null) // 없다면 삽입해주고 리턴
					{
						node.Left = new BinaryTreeNode<T>(val);
						return;
					}
					node = node.Left; // 현재 노드 이동
				}
				else
				{
					if (node.Right == null)
					{
						node.Right = new BinaryTreeNode<T>(val);
						return;
					}
					node = node.Right;
				}
			}
		}

		 // 전위 순회자
		public void PreOrderTranversal() //
		{
			PreOrderRecursive(root); // 실행자 선언
		}

		private void PreOrderRecursive(BinaryTreeNode<T> node)
		{
			if (node == null)
				return;

			Console.WriteLine(node.Data);
			PreOrderRecursive(node.Left);
			PreOrderRecursive(node.Right);
		}
	}
}
