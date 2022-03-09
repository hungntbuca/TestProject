using Microsoft.Extensions.DependencyInjection;
using System;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var serivce = new ServiceCollection();
            serivce.AddTransient<IRoot,Node2>();
           var node1 = serivce.BuildServiceProvider().GetService<IRoot>();
        }

    }
    public class ParentAbtract 
    {
        public ParentAbtract(Node1Abtract node1, Node2Abtract node2)
        {
            Node1 = node1;
            Node2 = node2;
        }

        public Node1Abtract Node1 { get; }
        public Node2Abtract Node2 { get; }
    }
    public  class Node1Abtract 
    {
        private readonly Node2Abtract node2;

        public Node1Abtract(Node2Abtract node2)
        {
            this.node2 = node2;
            Console.WriteLine("Node 1 created");
        }
    }
    public  class Node2Abtract
    {
        public Node2Abtract()
        {
            Console.WriteLine("Node 2 created");
        }
    }
    public interface IRoot 
    {
        
    }
    public  class IRootAbstract : IRoot
    { 
    
    }
    public class Node1 : IRootAbstract
    { 
    
    }
    public class Node2 : Node1 
    {
    
    }
}
