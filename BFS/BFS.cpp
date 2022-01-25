#include <iostream>
#include <queue>
using namespace std;

int map[10][10] = { 0 }; // 배열 초기화
int visit[10] = { 0 }; // 배열 초기화
queue<int> q;
int num;

void bfs(int v)
{
	cout << v << " ";
	q.push(v); // 리어로 들어옴
	while (!q.empty()) // 현재 큐에 값이 있다면
	{
		int node = q.front(); // 현재 큐 가장 앞 부분 값의 참조를 반환
		q.pop(); // 프론트 값의 삭제
		for (int i = 0; i < num; i++)
		{
			if (map[node][i] == 1 && visit[i] == 0)
			{
				visit[node] = 1;
				cout << i << " ";
				q.push(i);
			}
		}
	}
}

vector<vector<int>> min_calc(int value, vector<int> coins) {
	int total = 0;
	vector<vector<int>> cnt_list;
	sort(coins.begin(), coins.end());
	reverse(coins.begin(),coins.end()); // 역순으로 바꾼다
	
	for (int i = 0; i < coins.size(); i++) // 입력 받은 코인들의 개수 만큼 반복문 실행
	{
		vector<int> temp;
		total = value / coins[i]; // 입력받은 값을 나눈 몫을 반환한다.
		temp.push_back(coins[i]); // 해당 코인의 값
		temp.push_back(total); // 해당 코인의 사용 개수
		cnt_list.push_back(temp); // 해당 벡터를 넣어주고
		value -= total * coins[i]; // 해당 나머지 금액으로 재할당
	}
}

int main()
{
	cin >> num;
	
	bfs(1);




	vector<vector<int>> temp = min_calc(4725, { 500,300,40,20,1 });

	for (int i = 0; i < temp.size(); i++)
	{
		cout << temp[i][0] << " ," << temp[i][1] << endl;
	}
	return 0;
}