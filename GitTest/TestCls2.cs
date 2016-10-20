using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class TestCls2
    {
        public void TestBranchA()
        {
            Console.WriteLine("aaa");
        }

        public void TestBranchA4()
        {
            Console.WriteLine("aabb");
        }

        public void TestMerge()
        {
            Console.WriteLine("this is branch master");
            Console.WriteLine("this is branch mergetest");
        }

        public void TestRebase()
        {
            Console.WriteLine("this is branch rebasetest");
            Console.WriteLine("this is branch master");
        }

        public void TestRebase2()
        {
            Console.WriteLine("this is branch master");
            Console.WriteLine("this is branch rebase2");
        }

        public void TestRebase3()
        {
            Console.WriteLine("this is branch rebase3");
            Console.WriteLine("this is branch master");
        }

        public void C3()
        {

        }
        
        private void C4()
        {


        }
        
    }
}
