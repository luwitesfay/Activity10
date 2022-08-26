using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10
{
    class Set
    {

        private List<int> elements;



        public Set()

        {

            elements = new List<int>();

        }

        public bool addElement(int val)

        {

            if (containsElement(val)) return false;

            else

            {

                elements.Add(val);

                return true;

            }

        }

        private bool containsElement(int val)

        {

            for (int i = 0; i < elements.Count; i++)

            {

                if (val == elements[i])

                    return true;

                /*
                There is no need for the else statement.becaue the false statment below will handle the invaid conditin, faving else condtion here will cause to fail.
                */
                // else
                // return false;

            }

            return false;

        }

        public override string ToString()

        {

            string str = "";

            foreach (int i in elements)

            {

                str += i + " ";

            }

            return str;

        }

        public void clearSet()

        {

            elements.Clear();

        }

        public Set union(Set rhs)
        {
            //create a new set to return
            Set s = new Set();

            for (int i = 0; i < elements.Count; i++)
            {
                s.addElement(elements[i]);
            }


            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //now add to set we created, s
                s.addElement(rhs.elements[i]);
            }
            //sort the elements
            s.elements.Sort();

            //instead of returning rhs, we would then return s;
            return s;
        }


    }

}
