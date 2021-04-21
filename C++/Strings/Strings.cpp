#include <iostream>

using namespace std;

/*
string is an array of charaters
C++ has two ways of representing strings:
1. array of characters (available in both c and c++)
2. class string (preferred in c++; not present in C)

*/

int main()
{
    char x='A'; //A
    char s[10]="Hello"; // H e l l o \0(null character or string delimiter or string terminator) rest blank or are ignored
    char s1[]="Hello"; //automatically create an character array
    char s2[]={'H', 'e', 'l', 'l', 'o', '\0'}; // store in stack memory
    char s3[]={65, 66, 67, 68, 69, '\0'}; //can use ascii code - ABCDE\0
    char *s4="Hello"; //stores in Heap memory

    cout<<"x: "<<x<<endl;
    cout<<"s: "<<s<<endl;
    cout<<"s1: "<<s1<<endl;
    cout<<"s2: "<<s2<<endl;
    cout<<"s3: "<<s3<<endl;
    cout<<"s4: "<<s4<<endl; //Hello
    cout<<"*s4: "<<*s4<<endl; //H

//
    cout<<"Enter your name: ";
//    cin>>s; //takes space / tab character to identify a different string
    cin.get(s, 15);
    cout<<endl;
    cout<<"Your name is "<<s<<endl;
    cin.ignore();
    char str[50];
    cout<<"Enter your name with space: ";
    cin.get(str, 15); //14 character and one null characters
//    cin.getline(str, 15); //14 character and one null characters
    cout<<endl;
    cout<<"Your name is "<<str<<endl;

    /*
    cin.get() -> this will not read enter character. hence a couple of cin.get() back to back will not read values properly. string will be read by 1st get() and enter will be read the remaining enter character
    use cin.ignore() to clear the keyboard buffer
    cin.getline() -> reads an entire line
    */
    return 0;
}
