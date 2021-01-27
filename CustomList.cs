using System;
using System.Collections;
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
            for (int i = 0; i < Count; i++)//i goes up to look at each index
            {
                //items[i]: is this the item?
                //if items[i] is item: do onething make new array
                //if not, do something else return null?
                
            }


            //items = name;
            T[] tempArray = new T[count];
            for (int i = 0; i < Count; i = +-1)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;
            

            //foreach ( int items in name)
            //{
            ////    T[] name = new T[count];
            //    name[count] = name[count];
            //    count = +-1;
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
       
        public void AddTwoListTogether(T item)
        {
            CustomList<int> oddNumbers = new CustomList<int>(); { 1, 3, 5};
            CustomList<int> evenNumbers = new CustomList<int>();{ 2, 4, 6};
            CustomList<int> result = oddNumbers.join(evenNumbers);

            if ( oddNumbers ==  evenNumbers)
            {
                return result = oddNumbers + evenNumbers;
            }
           
        }
        public void SubtractoneInstanceFromList()
        {
            CustomList<IEnumerable> oddNumbers = new CustomList<IEnumerable>();
            CustomList<IEnumerable> evenNumbers = new CustomList<IEnumerable>();
            CustomList<IEnumerable> result = oddNumbers.items + evenNumbers;
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
