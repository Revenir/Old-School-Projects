//
//	Program:		Set Program
//
//	Description:	Creates a class for sets
//
//	Program history:
//
//		Date	Programmer	        Change
//		-------	------------------	-----------
//	02/25/14	  Sebastian Rock	Program written
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Set_Program
{
    public class Set<T>
    {
        private List<T> theSetList = new List<T>();

        public List<T> SetList
        {
            get
            {
                return theSetList;
            }
        }

        public void PrintSet()
        {
            int count = 1;

            Console.Write("{");
            foreach (T item in SetList)
            {
                if (count >= SetList.Count)
                    Console.Write("{0}", item);
                else
                {
                    Console.Write("{0},", item);
                    count += 1;
                }
            }
            Console.Write("}");
        }

        public int Cardinality()
        {
            return SetList.Count;
        }

        public bool MemberOf(T item)
        {
            return SetList.Contains(item);
        }

        public bool SubsetOf(Set<T> List1)
        {
            bool elementInCommon = false;

            foreach (T firstItem in SetList)
            {
                foreach (T secondItem in List1.SetList)
                {
                    if (firstItem.Equals(secondItem))
                    {
                        elementInCommon = true;
                        break;
                    }
                    else
                        elementInCommon = false;
                }

                // If, after going through every element in List1, none are the same...
                // then the set is not a subset of List1
                if (elementInCommon == false)
                {
                    return false;
                }
            }

            return true;
        }

        // Since sets don't have multiple instances of an element, we only have to
        // remove the first.
        public void Remove(T item)
        {
            SetList.Remove(item);
        }

        // Sets don't have an order, so we can just add it to the end
        public void Insert(T item)
        {
            // Sets don't have duplicates.
            if (!(SetList.Contains(item)))
                SetList.Add(item);
        }

        public bool Equal(Set<T> Set1, Set<T> Set2)
        {
            if (Set1.SubsetOf(Set2) && Set2.SubsetOf(Set1))
                return true;
            else
                return false;
        }

        static public Set<T> operator +(Set<T> Set1, Set<T> Set2)
        {
            Set<T> unionOfSets = new Set<T>();
            foreach (T item in Set1.SetList)
            {
                unionOfSets.Insert(item);
            }
            foreach (T item in Set2.SetList)
            {
                unionOfSets.Insert(item);
            }

            return unionOfSets;
        }

        static public Set<T> operator *(Set<T> Set1, Set<T> Set2)
        {
            Set<T> intersectionOfSets = new Set<T>();
            foreach(T item in Set1.SetList)
            {
                if (Set2.SetList.Contains(item))
                    intersectionOfSets.Insert(item);
            }

            return intersectionOfSets;
        }

        static public Set<T> operator -(Set<T> Set1, Set<T> Set2)
        {
            Set<T> subtractionOfSets = new Set<T>();
            foreach (T item in Set1.SetList)
            {
                if (!(Set2.SetList.Contains(item)))
                    subtractionOfSets.Insert(item);
            }

            return subtractionOfSets;
        }
    }
}
