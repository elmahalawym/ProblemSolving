#include <iostream>
#include <string>
#include <vector>

using namespace std;

int main()
{
    std::string s;
    std::cout << s << std::endl;
    //cout << std::stoi("2014") << endl;


    std::vector<int> v = {0, 1, 2, 3, 4, 5};

    for (const int& i : v) // access by const reference
        std::cout << i << ' ';
    std::cout << '\n';
    return 0;
}
