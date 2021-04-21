using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Sorting
{
    class SortingAlgos
    {
        //supply an array of length 20 with random variables
        #region Helper methods

        public static int[] GetArray(int limit)
        {
            //int limit = 25;
            Random r = new Random();
            int[] arr = new int[limit];
            for(int i =0; i<limit; i++)
            {
                arr[i] = r.Next(1, 1000);
            }
            return arr;
        }
        static void PrintArray(int[] a)
        {
            foreach (int i in a)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        
        static void SwapElements(ref int a, ref int b)
        {
            
            int temp = a;
            a = b;
            b = temp;
        }
        #endregion
        #region Bubble sort
        public static int[] BubbleSort(int[] a, out bool sorted)
        {
            Console.WriteLine("Performing Bubble Sort");
            /*
             * the basic idea behind bubble sort is that, the largest elment has to come out on the top after each iteration
             * So, the first loop will go from 0 to n-1-1
             *  meanwhile the internal loop goes from 0 to n-1-1(to avoid exception), and it only checks the adjacent elements
             *  comparison is done only in j and j+1 elements
             */

            for(int i = 0; i<a.Length-1; i++)//notice the limits
                //the limits may be n-1 or n, it doesn't matter
            {
                for(int j =0; j<a.Length-1; j++) //the limit here should be n-1, otherwise index out of bound exception will happen
                {
                    if (a[j] > a[j+1]) //only adjacent elements are compared
                        SwapElements(ref a[j], ref a[j+1]);
                }
            }

            sorted = true;
            return a;
        }
        #endregion 
        #region quick sort 
        //actual implementation of quick sort
        static void QS(int[] x, int l, int h)
        {
            
            if (l < h)//at least two elements are required for quick sort
            {
                //PrintArray(x);
                int partition_element_index=Partition(x, l, h);
                //in the above call of Partition method, both l and h are inclusive and lie within array
                //that's why when we call this next QS method recursively, we again supply low and high parameters inclusively
                QS(x, l, partition_element_index-1);
                
                QS(x, partition_element_index + 1, h);
            }
        }

        //implementation of quick sort partition method
        //case 1: Partitioning at first element -- this is complete and working
        //static int Partition(int[] x, int l, int h) //both l and h are inclusive
        //{

        //    int pivot = x[l];
        //    /*this implementation is for case where pivot is the first element*/
        //    int i = l;
        //    int j = h + 1;
        //    //why h+1?
        //    // because we are using do while loop and j will first decrease then condition will be checked

        //    while (i < j)
        //    {


        //        do
        //        {
        //            i++;
        //        } while (i < h + 1 && x[i] <= pivot);
        //        //the index should be checked first because it is a do while loop and there is chance of index getting out of bound
        //        //increment i until a item is found to be bigger than pivot
        //        do
        //        {
        //            j--;
        //        } while (j > 0 && x[j] > pivot);
        //        //the index should be checked first because it is a do while loop and there is chance of index getting out of bound
        //        //decrement j until an element is found to be smaller than pivot
        //        if (i < j)
        //        {
        //            SwapElements(ref x[i], ref x[j]);
        //        }

        //    }
        //    SwapElements(ref x[l], ref x[j]);
        //    return j;
        //}

        //case 2: Partitioning at last element --this is complete and working
        //static int Partition(int[] x, int l, int h) //both l and h are inclusive
        //{

        //    int pivot = x[h];
        //    /*this implementation is for case where pivot is the first element*/
        //    int i = l - 1;
        //    int j = h;
        //    //why l-1?
        //    // because we are using do while loop and i will first increase then condition will be checked
        //    //why not h+1
        //    //because we are taking the last element as the pivot

        //    while (i < j + 1) //notice change here
        //    {

        //        do
        //        {
        //            i++;
        //        } while (i < h + 1 && x[i] <= pivot);
        //        //the index should be checked first because it is a do while loop and there is chance of index getting out of bound
        //        //increment i until a item is found to be bigger than pivot

        //        do
        //        {
        //            j--;
        //        } while (j > 0 && x[j] > pivot);
        //        //the index should be checked first because it is a do while loop and there is chance of index getting out of bound
        //        //decrement j until an element is found to be smaller than pivot
        //        if (i < j + 1)
        //        {
        //            SwapElements(ref x[i], ref x[j]);
        //            //PrintArray(x);
        //        }

        //    }

        //    SwapElements(ref x[h], ref x[j + 1]);
        //    //PrintArray(x);
        //    return j + 1;
        //}

        //case 3: random element is pivot--this is complete and working 
        //when they say random element they mean it.
        static int Partition(int[] x, int l, int h) //both l and h are inclusive
        {
            Random r = new Random();

            int pivot_index = l+r.Next() % (h-l);//x[l];
            SwapElements(ref x[pivot_index], ref x[l]);
            int pivot = x[l];
            /*this implementation is for case where pivot is the first element*/
            int i = l;
            int j = h + 1;
            //why h+1?
            // because we are using do while loop and j will first decrease then condition will be checked

            while (i < j)
            {


                do
                {
                    i++;
                } while (i < h + 1 && x[i] <= pivot);
                //the index should be checked first because it is a do while loop and there is chance of index getting out of bound
                //increment i until a item is found to be bigger than pivot
                do
                {
                    j--;
                } while (j > 0 && x[j] > pivot);
                //the index should be checked first because it is a do while loop and there is chance of index getting out of bound
                //decrement j until an element is found to be smaller than pivot
                if (i < j)
                {
                    SwapElements(ref x[i], ref x[j]);
                }

            }
            SwapElements(ref x[l], ref x[j]);
            return j;
        }

        public static int[] QuickSort(int[] a, out bool sorted)
        {
            
            Console.WriteLine("Performing Quick Sort");
            int low = 0;
            int high = a.Length - 1;

            QS(a, low, high);

            sorted = true;
            return a;
        }
        #endregion
        #region Insertion sort
        public static int[] InsertionSort(int[] a, out bool sorted)
        {
            Console.WriteLine("Performing Bubble Sort");
            /*
             * the basic idea behind the insertion sort is to divide the array into two set where first one is sorted and starts as having only one element
             * and other one is unsorted but contains the rest of the array.
             * we start from the the element already next to sorted array and swap it with the elements of the sorted depending the unsorted /new element is greater
             * than or smaller than sorted element.
             * this is repeated for each element of the sorted array
             */
            for (int i =1; i<a.Length; i++)
            {
                //PrintArray(a);
                int value = a[i];
                int hole = i;

                while (hole>0 && value < a[hole - 1])
                {
                    a[hole] = a[hole - 1];
                    hole--;
                }
                a[hole] = value;

            }
            sorted = true;
            return a;
        }
        #endregion
        #region Selection Sort
        /*
         *This selection sort is kind of like linear search on steroids
         * 
         * First we assume the smallest element is on the first place itself, then we search the remaining array to find a replacement (if it exists)
         * if a replacement is found we swap the existing minimum in our hand.
         */
        public static int[] SelectionSort(int[] x, out bool sorted)
        {
            for(int i =0; i<x.Length; i++)
            {
                int index_of_minimum = i;
                for(int j =i+1; j<x.Length; j++)
                {
                    if (x[j] < x[index_of_minimum])
                        index_of_minimum = j;
                }
                if (index_of_minimum != i)// swap only when the index of minimum is changed from i
                {
                    SwapElements(ref x[index_of_minimum], ref x[i]);
                }


            }


            sorted = true;
            return x;
        }

        #endregion
        #region Heap Sort
        #endregion
        #region Merge Sort
        #endregion

    }
}
