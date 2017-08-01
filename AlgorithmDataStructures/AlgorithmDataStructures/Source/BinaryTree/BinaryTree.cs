/*
 * Developed by Mojtaba Hosseini, hmojtaba@live.com, www.gnegar.com
 * Feel free to change, edit, and reuse this application. :)
 */
using System;
using System.Drawing;

namespace BinaryTree
{
    public class BinaryTree
    {
        /// <summary>
        /// the root nod, it won't be seen on the graph!
        /// </summary>
        public Node RootNode { get; private set; }

        public BinaryTree()
        {
            RootNode = new Node(int.MinValue);
        }

        /// <summary>
        /// gets the count of nodes on the ttree
        /// </summary>
        public int Count { get { return RootNode.Right.Count; } }

        /// <summary>
        /// adds a node to the tree
        /// </summary>
        public bool Add(Node node)
        {
            return RootNode.Add(node);
        }
        /// <summary>
        /// Removes the node containing the inserted value.
        /// returns true if could find and remove the node.
        /// return false if the value does not exist on any of nodes. (except rootnode)
        /// </summary>
        public bool Remove(int value)
        {
            bool isRootNode;
            var res = RootNode.Remove(value, out isRootNode);
            return !isRootNode && res;// return false if the inserted value is on rootNode, or the value does not exist on any of nodes
        }
        // draw
        public Image Draw()
        {
            GC.Collect();// collects the unreffered locations on the memory
            int temp;
            return RootNode.Right == null ? null : RootNode.Right.Draw(out temp);
        }

        /// <summary>
        /// returns true if the current node or it's childs containd the inserted value
        /// </summary>
        public bool Exists(int item)
        {
            return RootNode.Exists(item);
        }
    }
}
