using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gongchengshi.Collections.Test
{
   [TestClass]
   public class DelimitedStringTrieTest
   {
      [TestMethod]
      public void TestBasic()
      {
         var target = new DelimitedStringTrie('/')
         {
            "mimeo/job1/site1/",
            "mimeo/job1/site1/file1.html",
            "mimeo/job1/site1/file1.html",
            "mimeo/job1/site1/file2.html",
            "mimeo/job1/site1/path1/",
            "mimeo/job1/site1/path1/file1.html",
            "mimeo/job1/site1/path1/file2.html",
            "mimeo/job1/site1/path2/",
            "mimeo/job1/site1/path2/file1.html",
            "mimeo/job1/site1/path2/file2.html"
         };

         foreach (var item in target)
         {
            Console.WriteLine(item);
         }
      }
   }
}
