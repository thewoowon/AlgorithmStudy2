#include <vector>
#include <stdio.h>
#include <iostream>
#include <algorithm>

using namespace std;

void dfs(int start, vector<int> graph[], bool check[]) // 시작하는 값, 각각의 노드, 방문 확인
{
	check[start] = true; // n까지의 자연수가 저장되기 때문에 해당 노드 또한 n안의 자연수를 가진다
	printf("%d", start);

	for (int i = 0; i < graph[start].size(); i++) // 해당 그래프의 에지들을 탐색하고 -> 해당 노드들은 오름차순으로 정렬되어 있고
	{											  // 가장 작은 값부터 찾아 들어가야 되기 때문에 -> 해당 노드 입장 
		int next = graph[start][i];

		if (check[next] == false)
		{
			dfs(next, graph, check);
		}
	}
}

int main()
{
	const int n = 10;
	const int m = 10;
	const int start = 10;

	vector<int> graph[n + 1]; // 벡터 배열을 선언 // 그래프 배열의 길이를 n + 1로 나타내는 이유는
	// from 1 to n까지 사용하기 위해서


	bool check[n + 1]; // 방문유무를 체크하는 함수 // 같은 크기의 불린 배열을 선언
	fill(check, check + n + 1, false); // fill은 리스트 내부를 초기화 시켜주는 api 
	//모두 false로 초기화 -> 이는 방문 노드는 true로 초기화 한다는 말

	//모든 불린 배열을 초기화

	graph[1].push_back(2);
	graph[1].push_back(3);
	graph[1].push_back(4);

	graph[2].push_back(1); // 1과 연결되어 있긴 때문에
	graph[2].push_back(5);
	graph[2].push_back(6);
	graph[2].push_back(7);

	graph[3].push_back(1);
	graph[4].push_back(1);

	graph[5].push_back(2);
	graph[5].push_back(8);
	graph[5].push_back(9);
	graph[5].push_back(10);

	graph[6].push_back(2);
	graph[7].push_back(2);

	graph[8].push_back(5);
	graph[9].push_back(5);
	graph[10].push_back(5);

	

	for (int i = 0; i <= n; i++)
	{
		sort(graph[i].begin(), graph[i].end());  // 오름차순으로 내부 그래프 정렬
	}

	dfs(start, graph, check); // Depth First Search 시작
	printf("\n"); // 줄바꿈

	return 0;
}