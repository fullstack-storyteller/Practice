#include <iostream>
using namespace std;
int main()
{
    cout<<"Hello World!"<<endl;
    //int A[2][3]={{1, 2, 3}, {4, 5, 6}}; //valid
    //int A[2][]={{1, 2, 3}, {4, 5, 6}}; //invalid
    //int A[][3]={{1, 2, 3}, {4, 5, 6}}; //valid
    //int A[2][3]={1, 2, 3, 4, 5, 6}; //valid
    int A[][3]={1, 2, 3, 4, 5, 6}; //valid
    //int A[2][]={1, 2, 3, 4, 5, 6}; //invalid


    //sum of matrices
    int B[][3]={6, 8, 3, 2, 4, 5}; //valid
    int C[][4]={4, 8, 3, 2, 9, 6, 7, 1, 8, 5, 3, 2}, D[2][4];
    cout<<"Matrix A:"<<endl;
    for(int i=0; i<2;i++){
        for(int j=0;j<3; j++){
            cout<<A[i][j]<<" ";
        }
        cout<<endl;
    }

    cout<<"Matrix B:"<<endl;
    for(int i=0; i<2;i++){
        for(int j=0;j<3; j++){
            cout<<B[i][j]<<" ";
        }
        cout<<endl;
    }

    cout<<"Matrix C=A+B:"<<endl;
    for(int i=0; i<2;i++){
        for(int j=0;j<3; j++){
            cout<<A[i][j]+B[i][j]<<" ";
        }
        cout<<endl;
    }

    cout<<"Matrix D=A-B:"<<endl;
    for(int i=0; i<2;i++){
        for(int j=0;j<3; j++){
            cout<<A[i][j]-B[i][j]<<" ";
        }
        cout<<endl;
    }

    cout<<"Matrix Multiplication:"<<endl;
    cout<<"Matrix A:"<<endl;
    for(int i=0; i<2;i++){
        for(int j=0;j<3; j++){
            cout<<A[i][j]<<" ";
        }
        cout<<endl;
    }
    cout<<"Matrix C:"<<endl;
    for(int i=0; i<3;i++){
        for(int j=0;j<4; j++){
            cout<<C[i][j]<<" ";
        }
        cout<<endl;
    }

    cout<<"Matrix M=A*C:"<<endl;
    int sum=0;
    for(int i=0; i<2; i++){ //traversing the rows of A
        //sum=0;
        for(int j=0; j<4; j++ ){ //traversing the columns of C
            //sum+=(A[i][j]*C[j][i]);
            sum=0;
            for(int k=0; k<3; k++){ //traversing the columns of A and rows of B together as they are equal in number
                sum+=(A[i][k]*C[k][j]); //taking product of each term then adding them
            }
            D[i][j]=sum;
        }
    }
    for(int i=0; i<2;i++){
        for(int j=0;j<4; j++){
            cout<<D[i][j]<<" ";
        }
        cout<<endl;
    }
}
