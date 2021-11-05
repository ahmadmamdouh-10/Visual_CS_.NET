using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Lab1
{
    class MyList : IEnumerable
    {
        //#region Simple Use of Index
        //string[] nameList = new string[size];
        //static public int size = 10;

        //public MyList()
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        nameList[i] = "A. B.";
        //    }
        //}

        //public string this[int index]
        //{
        //    get
        //    {
        //        string temp;

        //        if (index >= 0 && index <= size - 1)
        //        {
        //            temp = nameList[index];
        //        }
        //        else
        //        {
        //            temp = "Not Found";
        //        }
        //        return temp;
        //    }

        //    set
        //    {
        //        if (index >= 0 && index <= size - 1)
        //        {
        //            nameList[index] = value;
        //        }
        //    }
        //} 
        //#endregion

        Employee[] arr;
        static public int index;

        public MyList()
        {
            arr = new Employee[10];
            index = -1;
        }

        public void Add(Employee obj)
        {
            ++index;

            if (index > arr.Length - 1)
                Extend();

            arr[index] = obj;
        }

        public Employee Get(int index)
        {
            return arr[index];
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        private void Extend()
        {
        }

        public Employee this[int index]
        {
            get
            {
                Employee temp= new Employee();

                if (index >= 0 && index <= MyList.index - 1)
                {
                    temp = arr[index];
                }
                else
                {
                    Console.WriteLine("NOT FOUND");
       
                }
                return temp;
            }

            set
            {
                if (index >= 0 && index <= MyList.index - 1)
                {
                    arr[index] = value;
                }
            }
        }


        class Iterator : IEnumerator
        {
            MyList myList;
            int currentIndex;

            public Iterator(MyList myList)
            {
                this.myList = myList;
                currentIndex = -1;
            }

            public object Current
            {
                get
                {
                    return myList.arr[currentIndex];
                }
            }

            public bool MoveNext()
            {
                currentIndex++;

                if (currentIndex > MyList.index)
                    return false;

                return true;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

        }
    }
}
