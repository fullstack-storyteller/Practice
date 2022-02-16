#include <iostream>

using namespace std;

int main(){

    int x=10;
    int &y=x; //x and y are same thing here, but y must be assigned some value when its is declared

    cout<<"x: "<<x<<endl;
    x++;
    y++;
    int a=20;
    //y=&a; //invalid

    cout<<"x: "<<x<<endl;

    cout<<"&x: "<<&x<<" &y: "<<&y<<endl;
    return 5;
}
