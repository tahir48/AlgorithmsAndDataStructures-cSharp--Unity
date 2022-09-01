using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAlgos : MonoBehaviour
{

    private LinkedList myLinkedList;


    void Start()
    {
        myLinkedList = new LinkedList(0);
        myLinkedList.append(1);
        myLinkedList.append(2);
        myLinkedList.append(3);
        myLinkedList.append(4);
        myLinkedList.append(5);
        myLinkedList.append(6);
        myLinkedList.append(7);
        myLinkedList.append(8);
        myLinkedList.append(9);
        myLinkedList.append(10);
        myLinkedList.append(11);
        myLinkedList.set_value(5, 500);
        myLinkedList.remove(6);
        myLinkedList.pop_first();
        myLinkedList.pop();
        myLinkedList.prepend(100);
        Debug.Log("Linkedlist length is    " + myLinkedList.length);
        myLinkedList.print_list();
    }

}

