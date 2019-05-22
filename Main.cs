using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    LinkedList<int> linkList = new LinkedList<int>();
    bool hasDisplayed = false;
    bool hasFound = false;


    void Start()
    {
        AutoTestInsert();
    }

    void Update()
    {
        AutoTestDisplay();
        AutoFind();
        AutoTestRemove();
    }

    void AutoTestInsert()
    {
        for (int i = 5; i > 0; i--)
        {
            //i can be of any nullable type
            linkList.Insert(i); //Inserts New Node containing Data i
            Debug.Log("Inserted new Node containing Data: " + i); //Debugs the Node's Data that was inserted
        }
    }

    void AutoFind()
    {
        if (hasFound) return; //Returns if true
        for (int i = 1; i <= linkList.Size(); i++)
        {
            Node<int> findNode = linkList.Find(i);
            if (findNode.GetData().Equals(i)) //Checks if the data contained in the node equals i(can be of any data type)
            {
                Debug.Log("Found Node contaitning Data: " + i);
            }
            else
            {
                Debug.Log("FAIL - Could Not Find Node containing Data: " + i);
            }
            hasFound = true;
        }
    }

    void AutoTestDisplay()
    {
        if (hasDisplayed) return;//Returns if true
        
        if (linkList.Size() > 0 && !hasDisplayed)//If the Size function does not return 0, TestDisplay()
        {
            linkList.Display();//Test Display()
            hasDisplayed = true;
        }
    }

    void AutoTestRemove()
    {
        if (linkList.Size() > 0)//If the Size function does not return 0, TestRemove()
        {
            Debug.Log("Removing Node containing Data: " + linkList.Remove());
        }
    }

}
