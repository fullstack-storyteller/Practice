#include <iostream>

using namespace std;

int main()
{
    /*
    signed range of n bytes(i.e. 8*n bits) will be: -2**(8*n-1) to 2**(8*n-1)-1
    int: 2 or 4 bytes, 2 in turbo c++
    char: 1 bytes,
    bool: true/false
    float: 4 bytes
    double: 8 bytes

    A-Z ASCII 65-90
    a-z ASCII 97-122
    0-9 ASCII 48-57

    modifiers: unsigned and long
    > unsigned: for n bytes- 0 to 2**(8*n)-1
        int: 0-65535
        char: 0-255
    > long: increase the capacity
        int: 4 or 8 bytes
        double: 10 bytes
    *long float is double so its meaningless
    */

    int a;
    long double b;
    cout<<sizeof(a)<<endl;
    cout<<sizeof(b)<<endl;
    cout<<INT_MAX<<endl;
    return 0;
}
