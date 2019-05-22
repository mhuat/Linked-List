using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node<T>
{
    //C# does not have pointers but can reference other objects
    public Node<T> next;
    public Node<T> previous;
    T data;

    public Node(T data) //Set Node references
    {
        next = this; //Set next node to this 
        previous = this; //Set previous node to this
        this.data = data; //Set this node's data to set parameter data of new Node
    }

    public void Insert(T data)//Creates new node with generic type data
    {
        Node<T> newNode = new Node<T>(data);
        newNode.next = this.next; //Set the the new node's next reference to this node's next reference
        newNode.previous = this; //Set new node's previous reference to this node 
        next.previous = newNode; //Set the next node's previous reference to the new node
        next = newNode; //Set the next reference node to the new Node
    }

    public T GetData()
    {
        return this.data; //Returns data of this node
    }

    public void Remove()//Sets the references of the next and previous's references upon removal 
    {
        next.previous = previous; //Sets next's previous reference to this node's previous reference
        previous.next = next; //set previous's next reference to this node's next reference
    }

    public void SetData(T data)
    {
        this.data = data; //Set this node's data to the data passed in the parameter
    }
}
