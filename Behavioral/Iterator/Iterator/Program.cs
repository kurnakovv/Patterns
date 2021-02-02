using Iterator.Collections;
using Iterator.Collections.Abstract;
using Iterator.Iterators;
using Iterator.Iterators.Abstract;
using Iterator.Models;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Commit commit1 = new Commit()
            { 
                Id = 1,
                Message = "This is my first commit",
            };

            Commit commit2 = new Commit()
            {
                Id = 2,
                Message = "Second commit",
            };

            Commit commit3 = new Commit()
            {
                Id = 3,
                Message = "Last commit",
            };


            IDefaultCollection defaultCollection = new DefaultRepoCollection();
            defaultCollection.CreateIterator();
            ICommitIterator commitIterator = new CommitIterator(defaultCollection);
            
            Console.WriteLine("$ git commit -m 'This is my first commit'");
            Console.WriteLine(defaultCollection.AddCommit(commit1));
            Console.WriteLine("$ git commit -m 'Second commit'");
            Console.WriteLine(defaultCollection.AddCommit(commit2));
            Console.WriteLine("$ git commit -m 'Last commit'");
            Console.WriteLine(defaultCollection.AddCommit(commit3));

            Console.WriteLine("\n$ git log");
            foreach (var item in commitIterator.GetCommits())
                Console.WriteLine(item.Hash + " " + item.Message);

            Console.WriteLine("\n$ git last 2");
            foreach (var item in commitIterator.GetLatest())
                Console.WriteLine(item.Hash + " " + item.Message);

            Console.WriteLine("\n$ git first");
            Console.WriteLine(commitIterator.First().Message);

            Console.WriteLine("\n$ git last");
            Console.WriteLine(commitIterator.Last().Message);

            commitIterator.SetPosition(2);
            Console.WriteLine("\n$ git previous");
            Console.WriteLine(commitIterator.Previous().Message);

            Console.ReadLine();
        }
    }
}
