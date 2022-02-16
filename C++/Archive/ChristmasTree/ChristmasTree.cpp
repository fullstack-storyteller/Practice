
#include <iostream>

using namespace std;

// build me a Christmas tree

/*

        *
       * *
      * * *
     * * * *
    * * * * *
   * * * * * *
     * * * *
    * * * * *
   * * * * * *
  * * * * * * *
    * * * * *
   * * * * * *
  * * * * * * *
 * * * * * * * *
     * * * *
     * * * *
     * * * *
     * * * *

*/

int main()
{
    int lengthOfTheHelm;
    cout<<"Building a Christmas Tree."<<endl;
    cout<<"Enter the length of the helm: ";
    cin>>lengthOfTheHelm;

    cout<<"The helm length will be rounded off to an even number smaller than or equal to the length provided"<<endl;;
    int actualLengthOfHelm=((lengthOfTheHelm%2==0)?lengthOfTheHelm:(lengthOfTheHelm-1));
    cout<<"Below is your Christmas Tree of helm length:  "<<actualLengthOfHelm<<endl;

    //make the helm
    for(int i=0; i<actualLengthOfHelm; i++){
        for(int j=0; j<2*actualLengthOfHelm-i+1; j++){
            cout<<" ";
        }
        for(int k=0; k<i+1; k++){
            cout<<" *";
        }
        cout<<endl;
    }

    //the middle part
    for(int i=0; i<actualLengthOfHelm; i++){
        for(int j=0; j<actualLengthOfHelm-i+4; j++){
            cout<<" ";
        }
        for(int k=0; k<actualLengthOfHelm-2+i; k++){
            cout<<" *";
        }
        cout<<endl;
    }

    //the bottom leafy part
    for(int i=0; i<actualLengthOfHelm; i++){
        for(int j=0; j<4-i-1+actualLengthOfHelm; j++){
            cout<<" ";
        }
        for(int k=0; k<actualLengthOfHelm-1+i; k++){
            cout<<" *";
        }
        cout<<endl;
    }

    //the bottom trunck part
    for(int i=0; i<2*actualLengthOfHelm/3; i++){
        for(int j=0; j<actualLengthOfHelm; j++){
            cout<<"  ";
        }
        for(int k=0; k<actualLengthOfHelm; k++){
            cout<<"*";
        }
        cout<<endl;
    }




    return 0;
}
