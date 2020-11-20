using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
   public interface IDataStructure
    {

        public void Add(int value);


        public void AddFirst(int value);


        public void AddByIndex(int index, int value);

        public void AddFirst(int[] arr);

        public void AddByIndex(int index, int[] arr);

        public void DeleteLast();

        public void DeleteFirst();

        public void DeleteByIndex(int index);


        public void DeleteFirstByValue(int value);

        public void DeleteAllByValue(int value);


        public int GetElement(int index);

        public int GetIndex(int element);

        public void ChangeElement(int index, int element);

        public void Reverse();

        public int FindMinElement();


        public int FindIndexOfMinElement();


        public int FindMaxElement();

        public int FindIndexOfMaxElement();

        public void SortDesc();

        public void SortAsc();

    }
}
