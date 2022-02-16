/*
Pointers:

types of variable:
1. data variable int x=10;
2. Address variable int *p (can't store data but the address of the variable)
initializing the pointer variable=> p=&x

by default programs can access only the code memory and the stack memory
pointers can help programs access the heap memory

Pointer can also help access the below:
    Accessing a file
    Access a network connection
    Accessing hardware peripherals like keyboard or monitors ex cin cout use pointers internally

    Languages like Java or C# don't have the concept of pointers
    Hence they can't directly access the above. they have to use jvm and
    CLR to access the above on runtime. hence, no system programming is possible using
    C and C++

    //Heap memory must be deallocated
*/

#include <iostream>
using namespace std;

int main(){
    int x=10;
    int *p; //declaration of pointer variable
    p=&x; //initialization of the pointer variable
    cout<<"Integer variable: "<<x<<endl; //10
    cout<<"address of the Integer variable: "<<&x<<endl;
    cout<<"pointer to an Integer: "<<p<<endl;
    cout<<"address of the pointer variable for the Integer: "<<&p<<endl;
    cout<<"value at the address contained in the pointer variable: "<<*p<<endl; //also called dereferencing of the pointer variable

    cout<<endl;
    int A[5]={1, 2, 3, 4, 5}; //inside the stack memory
    int *q; // this pointer variable is created inside the stack memory too
    q= new int[5]; //this array is created in a heap memory
    //new = memory allocated inside the heap memory

    q[0]=12;
    q[1]= 13;
    q[6]=122;
    cout<<q[0]<<" "<<q[1]<<" "<<q[2]<<" q[6]: "<<q[6]<<endl;//q[2] has garbage value
    //interestingly you can even assign the 6th variable and access it using the pointer. See above.
    //Heap memory must be deallocated, otherwise it cause memory leak
    delete []q;
    //q=nullptr;//don't do this because now we lost the address of the array q was holding before
    //before reinitializing the pointer variable, make sure to free up the memory


    //int *q=new int[5]


}
