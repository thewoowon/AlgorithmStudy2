// No_1_ShortOhPriceCpp.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>

int main()
{
    
}


long long solution(int price, int money, int count) {
    long long answer = -1;

    long long sum = (count * (count + 1)) / 2 * price;

    if (sum > money)
    {
        answer = sum - money;
    }
    else
    {
        answer = 0;
    }

    return answer;
}


