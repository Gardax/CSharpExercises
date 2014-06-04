using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeOfNNodes
{
    class TreeOfNNodesMain
    {
        static Node<int> FindRoot(Node<int>[] nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.HasParent)
                {
                    return node;
                }
            }
            throw new ArgumentException("The input is not valid");
        }

        static List<Node<int>> FindLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();
            foreach (var node in nodes)
            {
                if (node.Children.Count() == 0)
                {
                    leafs.Add(node);
                }
            }
            return leafs;
        }

        static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();
            foreach (var node in nodes)
            {
                if (node.Children.Count() > 0 && node.HasParent)
                {
                    middleNodes.Add(node);
                }
            }
            return middleNodes;
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }
            return maxPath + 1;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            //Find root
            Console.WriteLine(FindRoot(nodes).Value);

            //Find leafs
            Console.Write("Leafs:");
            foreach (var leaf in FindLeafs(nodes))
            {
                Console.Write(" "+leaf.Value);
            }
            Console.WriteLine();

            //Find middle nodes
            Console.Write("Middle nodes:");
            foreach (var middleNode in FindMiddleNodes(nodes))
            {
                Console.Write(" " + middleNode.Value);
            }
            Console.WriteLine();

            //Find longest path in tree
            var root = FindRoot(nodes);
            Console.WriteLine(FindLongestPath(root));
        }
    }
}
