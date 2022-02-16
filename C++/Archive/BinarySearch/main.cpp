#include <iostream>

using namespace std;

int BinarySearch(int arr[], int left, int right, int k) //left and right are the indexes
{
    //return 0;
    int pos=-1, mid;


    while(left<=right)
    {
        mid=(left+right)/2;
        if(arr[mid]==k)
        {
            pos= mid;
            break;
        }
        if(arr[mid]<k)
        {
            left=mid+1;//exclude as much as you can
        }
        else
        {
            right=mid-1;
        }
    }

    return pos;


}

int BinarySearchRecursive(int arr[], int left, int right, int key)
{
    if(left<=right)
    {

        int mid=(left+right)/2;
        if(key==arr[mid])
            return mid;

        if(key<arr[mid])
            return BinarySearchRecursive(arr, left, mid-1, key);

        return BinarySearchRecursive(arr, mid+1, right, key);

    }
    return -1;
}

int main()
{
    cout << "Hello world!" << endl;

    int searchInThis[10]= {2,4,5,6, 21,34,45,56,61, 301};
    cout<<"The array to be searched: "<<endl;
    for(int x:searchInThis)
        cout<<x<<" ";
    cout<<endl;
    int key, pos;
    cout<<"Enter the key to search: "<<endl;

    cin>>key;
//    pos=BinarySearch(searchInThis, 0, 9, key);
    pos=BinarySearchRecursive(searchInThis, 0, 9, key);
    if(pos<0)
    {
        cout<<key<<" not found!";
    }
    else
    {
        cout<<key<<" found at "<<pos<<endl;
    }

    return 0;
}


