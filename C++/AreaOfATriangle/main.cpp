#include <iostream>

using namespace std;

int main()
{
    float base, height, limit;
//    cout << "Hello world!" << endl;
    cout<<"Enter the base and height"<<endl;
    cin>>base>>height;

    cout<<"The are of the triangle "<<base*height/2<<endl;

    cout<<"Enter the natural number limit: "<<endl;
    cin>>limit;

    cout<<"The sum till "<<limit<<" is: "<<limit*(limit+1)/2;
    return 0;

}
