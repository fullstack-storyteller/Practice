#include <iostream>
#include<cstring>
using namespace std;
int main()
{

    char s1[]="Programming";
    char s2[]="gram";
    char s3[]="kl";

    cout<<"strstr(s1, s2): "<<strstr(s1, s2)<<endl;
    cout<<"strstr(s2, s3): "<<((strstr( s2, s3)!=NULL)?(strstr(s2, s3)):"Not found")<<endl;
    cout<<"This is the end."<<endl;

    return 0;
}
