#include <iostream>
using namespace std;





int main(){
int A[5]={2, 4, 5, 6, 7};
int *p=A;
/*
allowed operation in pointer arithmetic
p++ -> move one location ahead
p-- -> move one direction behind

p=p+2 -> move two location ahead
p=p-2 -> move two location behind

d=q-p -> give distance between two pointers i.e. how many elements between them
 =p-q this can be negative also
*/
 // move pointer to next location to print 4
    p++;
    cout<<*p<<endl;

    p=p+3; // pointer will be pointing on 7

    cout<< *(p-4)<<endl;   // complete this statement to print 2 without moving pointe77

    delete []p;
    p=A;
    int *q;
    q=&A[4];
    for(int i =0; i<5; i++){
        //cout<< A[i]<<" "; //prints value of the variable
        //cout<< i[A]<<" "; //prints value of the variable
        //cout<< A +i<<" "; //prints address of the elements of the array starting from the base address
        //cout<< *(A+i)<<" "; //prints value of the variable
        //cout<< p+i<<" "; //prints address of the elements of the array starting from the base address
        cout<< *(p+i)<<" "; //prints value of the variable
    }
    cout<<endl;
    cout<<"Difference between pointer p and q is: "<<q-p<<endl;
    cout<<"Difference between pointer q and p is: "<<p-q<<endl;

}
