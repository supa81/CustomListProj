using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        //MEMBER VARIABLES

        private T[] items;
        int count; // number of items in customlist
        public int Count { get => count;}
        int capacity; //array length 
        public int Capacity { get => capacity;}
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
                T[] name = new T[capacity * 2];
                name[capacity] = name[capacity];
                capacity++;
            }

            // only "if" capacity is surpassed then make new array 
            //CustomList<T> name = new CustomList<T>();
            //for (int i = 0; i < count; i++)
            //{
            //    return name;
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
        public void Remove(T item)
        {//check to see if item is in list 
            //copy array without the element then make new array with out the item 

            
            
            items[count] = item;
            count = -1;
            if (count == capacity)
            {
                T[] name = new T[capacity];
                name[capacity] = name[capacity];
                capacity = + -1;
            }
        }
        public int AddTwoListTogether(T item)
        {
            CustomList<int> oddNumbers = new CustomList<int>();
            CustomList<int> evenNumbers = new CustomList<int>();
            int result;

            if (oddNumbers == evenNumbers)
            {
              return result = oddNumbers + evenNumbers;
            }
           
        }
        public void SubtractoneInstanceFromList()
        {
            CustomList<T> oddNumbers = new CustomList<T>() { 1, 3, 5 };
            CustomList<T> evenNumbers = new CustomList<T>() { 2, 4, 6 };
            CustomList<T> result = oddNumbers + evenNumbers;
            if (count == capacity)
            {
                T[] name = new T[capacity];
                name[capacity] = name[capacity];
                count = +-1;
                oddNumbers.count = capacity;
            }
        }
        public override string ConvertToString()
        {

            CustomList<int> oddNumbers = new CustomList<int>();
            oddNumbers.ConvertToString();
        }

    }
}
