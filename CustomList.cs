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
        int capacity; //array length 
        
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
                T[] name = new T[4];
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
        public void Remove(T item)
        {
            
            items[count] =  item;
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
            CustomList<int> oddNumbers = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> evenNumbers = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = oddNumbers + evenNumbers;
            if (count == capacity)
            {
                T[] name = new T[capacity];
                name[capacity] = name[capacity];
                count = +-1;
                oddNumbers.count = capacity;
                
            }
            
               
            
        }

    }  
}
