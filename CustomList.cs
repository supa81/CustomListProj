using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass 
{
    public class CustomList<T> : IEnumerable
    {
        //MEMBER VARIABLES

        private T[] items;
        int count; // number of items in customlist
        public int Count { get => count; }
        int capacity; //array length 
        public int Capacity { get => capacity; }
        string name;

        //CONSTRUCTOR
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }
        //MEMBER METHODS
        public void Add(T item)
        {
            items[count] = item;
            count++;
            //work on the condition listed below

            if (count == capacity)
            {

                DoubledArrayCapacity();
            }
            // only "if" capacity is surpassed then make new array 
            //CustomList<T> name = new CustomList<T>();
            //for (int i = 0; i < count; i++)
            //{
            //    return name;
            //}
        }
        public void Remove(T item)
        {   //check to see if item is in list 
            //copy array without the element then make new array with out the item 
            //items[count] = item;
            //count = -1;
            //T[] name = new T[count];
            bool hasItem = false;
            T[] tempArray = new T[capacity];
            for (int i = 0; i < Count; i++)//i goes up to look at each index
            {
                //items[i]: is this the item?
                //if items[i] is item: do onething make new array
                //if not, do something else return null?

                if (items[i].Equals(item) && hasItem == false )
                {//if item
                    hasItem = true;
                    count--;
                   
                    
                    
                   // not include it in new list 
                   
                }
                else if (!items[i].Equals(item) && hasItem == true)
                {
                    tempArray[i] = items[i];
                    //keep on list 
                }
                // look at bool "hasitem" = true we have already encountered and removed that value 
                //add the second instance.
            }
            //foreach ( int items in name)
            //{
            ////    T[] name = new T[count];
            //    name[count] = name[count];
            //    count--
            //    T[] tempArray = new T[capacity];
            //}
        }
        public void DoubledArrayCapacity()
        {
            capacity = capacity * 2;
            T[] tempArray = new T[capacity];
            for (int i = 0; i < Count; i++)
            {
                tempArray[i] = items[i];
                //set temp array = to items array index by index
                //dont wana hard code the number
                //outside for loop items = temp array 
            }
            items = tempArray;
        }
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)

        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < listOne.Count; i++)
            {
                newList.Add(listOne[i]);
                
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                newList.Add(listTwo[i]);
            }
            return newList;
        }
        public static CustomList<T> operator -(CustomList<T> listOne, T listTwo) //fix!!!

        {
            var listOneItems = new CustomList<int>();

            var listTwoItems = new CustomList<int>(); 

            var resultList = listOne - listTwo; 
            for (int i = 0; i < listOneItems.Count; i++)
            {
                resultList.Add(listTwo);
            }
            return resultList;

        }

        public T this[int i]
        {
            set { items[i] = value; }
            get { return items[i]; }
        }
        public void SubtractoneInstanceFromList(T item)
        {
            CustomList<int> oddNumbers = new CustomList<int>();
            CustomList<int> evenNumbers = new CustomList<int>();
            //CustomList<int> result = oddNumbers + evenNumbers;
            bool hasItem = false;
            T[] tempArray = new T[capacity];
            oddNumbers.count = count;

            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    hasItem = true;
                    count--;
                    //removes one instance off list
                }
                else if (!items[i].Equals(item) && hasItem == true)
                {
                    tempArray[i] = items[i];
                    //keep same list 
            
                }  
            }
        }
        public override string ToString()
        {
            string result = "";
            string capture = "";
            
            for (int i = 0; i < items.Length ; i++) 
            {
                capture = items[i].ToString();
                capture = capture + result;

            }
            return capture;
            // we need to take all of items (the array) and turn it into one string

            // declare a string variable that captures all of our items?
            // then return that string?

            // go one by one through the array and add it to the result
        }
        public IEnumerator GetEnumerator()
        {//for loop cycle through list utilize yeild return current index [i]
            return items.GetEnumerator();
        }
    }
}
