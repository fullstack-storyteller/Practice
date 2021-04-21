#include <iostream>
#include <cmath>

using namespace std;

int main()
{
//    cout << "Hello world!" << endl;

    char x=127;
    cout<<++x<<endl;
    int a,b,c;
    cout<<"Enter coefficient a, b, and c: ";
    cin>>a>>b>>c;
    float r1, r2;

    r1=(-b+sqrt(b*b-4*a*c))/(2*a);
    r2=(-b-sqrt(b*b-4*a*c))/(2*a);

    cout<<"The roots are "<<r1<<", "<<r2<<endl;
    return 0;

}

//float sqrt(float x)
//{
//
//}
