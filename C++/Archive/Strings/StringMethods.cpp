#include <iostream>
#include <cstring>

using namespace std;

int strLength(char *str)
{

//    char *s=str;
    int length=0;
    while(*str!='\0')
    {
        length++;
        str++;
    }
    return length;
}

char* strConcat(char x[], char y[], int n)
{
    if(n==0)
        return x;
    int i=0, l=strLength(x);
    //cout<<"x"<<x<<endl;
    while( i<n && *(y+i)!='\0')
    {
        //*(x+l+i)=*(y+i);
        x[l+i]=y[i];
        //cout<<"x"<<i<<": "<<x<<endl;
        i++;
    }
    //*(x+strLength(x)+1)='\0';
    x[l+n]='\0';

    return x;

}
int main()
{
    //get length
    cout<<"Length of Hello: "<<strLength("Hello")<<endl;
    cout<<"Length of Hello: "<<strlen("Hello")<<endl;

    //string concat
    char s1[]="Manish", s2[]=" Kumar";
    char s3[]="test", s4[]="mytestjhgjhgjhgjhg" ;
    strcat(s1, s2); //won't work with pointers
    //strncat(s1, s2, n); will coopy n characters
    cout<<"Concatenate of s1 and s2: "<<s1<<endl;
    cout<<"Concatenate s3 and s4: "<<strConcat(s3, s4,15)<<endl;

    //string copy
    char s5[]="Manishiiiiiiiii", s6[]="Kumar";
    strcpy(s6, s5);
    //strncpy(s5, s6,10);
    cout<<"copy of s5 to s6: "<<s6<<endl;

    return 0;
}
