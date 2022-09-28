using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularDoublyLinkedList
{
    // Start is called before the first frame update
    public DNode head;
    public DNode tail;
    public int length;

    public CircularDoublyLinkedList(int value)
    {
        DNode newnode = new DNode(value);
        head = newnode;
        tail = newnode;
        length = 1;
    }


    public void AppendFromHead(int value)
    {
        DNode tmp = new DNode(value);
        if (head == null)
        {
            head = tmp;
            tail = tmp;
        }
        tail.next = tmp;
        tmp.next = head;
        head.prev = tmp;
        tmp.prev = tail;
        head = tmp;
        length++;
    }



}


[SerializeField]
public class DNode
{
    public int value;
    public DNode next;
    public DNode prev;
    public DNode(int i)
    {
        value = i;
        next = null;
        prev = null;
    }
}