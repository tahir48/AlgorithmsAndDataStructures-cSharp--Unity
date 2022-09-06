using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue
{
    Node first; //tail of a linked list
    Node last;
    int length;

    public Queue(int i)
    {
        Node newnode = new Node(i);
        first = newnode;
        last = newnode;
        length = 1;
    }


    public void print_queue()
    {
        if (last == null)
        {
            return;
        }
        Node tmp = last;
        while (last.next != null)
        {
            Debug.Log(tmp.next);
            tmp = tmp.next;
        }


    }

    public void enqueue(int i)
    {
        Node newnode = new Node(i);
        if (last == null)
        {
            last = newnode;
            length++;
            return;
        }
        last.next = newnode;
        last = newnode;
        length++;
    }


    public void dequeue()
    {

    }


}
