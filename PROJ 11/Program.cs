//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PROJ_11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IntegersVector vec = new IntegersVector();
//            vec.Add(2);
//            vec.Add(4);
//            vec.Add(6);
//            vec.Add(7);
//            Console.WriteLine(vec.IsEmpty());
//            Console.WriteLine(vec.Size());
//            for (int i = 0; i < vec.Size(); i++)
//            {
//                Console.Write(vec.Get(i)+ ",");

//            }
//            Console.WriteLine();
//            Console.WriteLine(vec.Get(3));
//        }
//    }

//    public class IntegersVector
//    {
//        private int[] integers;
//        private int position;

//        public IntegersVector()
//        {
//            integers = new int[1];
//            position = -1;
//        }
//        public void Add(int newInteger)
//        {
//            if (integers.Length == position + 1)
//            {
//                EnlargeVector();
//            }
//            integers[++position] = newInteger;
            
//        }
//        public int Get(int index)
//        {
//            return integers[index];
//        }
//        public bool IsEmpty()
//        {

//            return position == -1;

//        }
//        public int Size()
//        {
//            return position + 1;
//        }
//        private void EnlargeVector()
//        {
//            int[] temparr = new int[integers.Length * 2];
//            //opt 1
//            integers.CopyTo(temparr, 0);
//            ////opt2
//            //Array.Copy(integers,temparr,integers.Length);
//            integers = temparr;

//        }
//        //public void printArray()
//        //{
//        //    for (int i = 0; i < integers.Length; i++)
//        //    {
//        //        Console.Write(integers[i]);

//        //    }
//        //    Console.WriteLine();

//        //}
//    }
//}
