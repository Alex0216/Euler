#include <vector>
#include <iostream>
#include <algorithm>
#include <numeric>

#include <ctime>

#define LIMIT 28123



using namespace std;

int getFactorSum(int num);
vector<int> getFactor(int num);

int main()
{
    auto init = clock();
    vector<bool> abundant_sum(LIMIT);
    
    vector<int> abundant;

    //find all abundant number
    for(int i = 1; i < LIMIT; ++i)
        if (getFactorSum(i) > i)
            abundant.push_back(i);

    //compute all the possible sum of two abundant number and remove from the list
    for (int i = 0; i < abundant.size(); ++i)
        for (int j = i; j < abundant.size(); ++j)
        {
            auto sum =  abundant[i] + abundant[j];
            abundant_sum[sum] = true;
        }

    
    auto sum = 0;
    for (auto i = 0; i < LIMIT; ++i)
    {
        if (!abundant_sum[i])
            sum += i;
    }

    auto time = clock() - init;
    cout << sum << " time: " << time/CLOCKS_PER_SEC << endl;
}

int getFactorSum(int num)
{
    auto factors = getFactor(num);
    return accumulate(begin(factors), end(factors), 0);
}

vector<int> getFactor(int num)
{
    vector<int> factor;

    for (int i = 1; i <= num / 2; ++i)
        if (num % i == 0)
            factor.push_back(i);
    return factor;
}