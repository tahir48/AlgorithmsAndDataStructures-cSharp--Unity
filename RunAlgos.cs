using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAlgos : MonoBehaviour
{

    private LinkedList myLinkedList;


    void Start()
    {
        myLinkedList = new LinkedList(1);
        myLinkedList.append(2);
        myLinkedList.append(3);
        myLinkedList.append(4);
        Debug.Log("Linkedlist length is    " + myLinkedList.length);
        myLinkedList.print_list();
    }







    // Update is called once per frame
    //void Update()
    //{
        

    //}
}
