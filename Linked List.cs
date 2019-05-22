using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedList<T>
{

    //public static L template<T?>();
    Node<T> rootNode;
    T data = default(T);
    int size;

    public LinkedList()
    {
        rootNode = new Node<T>(data);//Create a new Root Node that stores null value
    }

    public void Display()
    { 
        Node<T> currentNode = rootNode.previous; //Temporary Instance is used as reference to store the previous node

        while (currentNode != rootNode)//While the current node does not equal the root node
        {
            Debug.Log("Displaying Node containing Data: "+currentNode.GetData()); //Debugs the next node's data
            currentNode = currentNode.previous; //Sets the instance to the previous node
        }
    }

    public int Size()
    {
        return this.size;//Returns the size value of this Linked List
    }

    public T Remove()
    {
        if (size <= 0) { return data; } //Return Null

        T nextData = rootNode.next.GetData(); //Sets the returned next object's data to "nextData"
        rootNode.next.Remove(); //Removes the next data
        size--; //Size of the link list decreased
        return nextData; //Returns the data remaining
    }

    public Node<T> Find(T data)
    {
        Node<T> currentNode = rootNode.next; //Initialize temporary curent node as reference to the root node's next reference
        while (currentNode != rootNode)//While the current node does not equal the root node
        {
            if (currentNode.GetData().Equals(data))//If the current node contains data equal to the requested data reference, Do:
                return currentNode; //Return the node with the equal data value as the requested data reference
            currentNode = currentNode.next; //Current node reference is set to the current node's next reference
        }
        return null; //Return when null
    }

    public T Remove(T data)
    {
        return data;  //Remove node with matching data
    }

    public void Insert(T data) //Inserts new data
    {
        rootNode.Insert(data);
        size++; //Size of link list increased
    }
}
