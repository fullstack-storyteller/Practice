#include <iostream>


using namespace std;

int main()
{
//    cout << "Hello world!" << endl;
    int x=5, y=4, z;

    cout<<"x = "<<x<<", y = "<<y<<endl;
    cout<<"x & y = "<<(x&y)<<endl;
    cout<<"x | y = "<<(x|y)<<endl;
    cout<<"x ^ y = "<<(x^y)<<endl;
    cout<<"~x = "<<(~x)<<endl;
    x=INT_MAX;
    cout<<"x = "<<x<<", x << 1 = "<<(x<<1)<<endl;//multiply by two
    x=INT_MIN;
    cout<<"x = "<<x <<", x >> 1 = "<<(x>>1)<<endl;//divide by two

    return 0;
}
