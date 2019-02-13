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
            TestNugetFromPublicRepoVer101();
            TestNugetFromPrivateRepo();
            TestNugetFromPrivateRepoVer101();
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

        private static void TestNugetFromPrivateRepoVer101()
        {
            var c = new PrivateClass1();
            // TODO: Ucomment the following line if nuget version 1.0.1
            c.PrivateRepoTestNew();            
        }

        private static void TestNugetFromPublicRepoVer101()
        {
            var c = new Class1();
            // TODO: Ucomment the following line if nuget version 1.0.1
            c.NewTest();            
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
