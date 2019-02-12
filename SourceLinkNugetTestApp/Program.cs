using System;
using SourceLinkNuget;
using PrivateSourceLinkNuget;

namespace SourceLinkNugetTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestNugetFromPublicRepo();
            TestNugetFromPrivateRepo();
        }

        private static void TestNugetFromPrivateRepo()
        {
            var c = new PrivateClass1();
            c.PrivateRepoTest();
            try
            {
                c.PrivateRepoThrowException();
            }
            catch (Exception e)
            {
                var x = e.Data;
            }
        }

        private static void TestNugetFromPublicRepo()
        {
            var c = new Class1();
            c.Test();
            try
            {
                c.ThrowException();
            }
            catch (Exception e)
            {
                var x = e.Data;
            }
        }

    }
}
