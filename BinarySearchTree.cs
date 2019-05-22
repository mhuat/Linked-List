using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchTree : MonoBehaviour
{
    public class Node
    {
        public string Data;
        public List<Node> Children = new List<Node>();
    }

    public List<Node> GetTraversal(Node root)
    {
        List<Node> toReturn = new List<Node>();
        var list = new List<string>();
        foreach (var child in root.Children)
        {
            GetTraversal(child, "", list);
        }
        return toReturn;
    }

    public void GetTraversal(Node node, string path, List<string> list)
    {
        path = path == "" ? node.Data : path + " " + node.Data;
        if (node.Children.Count == 0)
        {
            list.Add(path);
        }
        else
        {
            foreach (var child in node.Children)
            {
                GetTraversal(child, path, list);
            }
        }
    }
}

