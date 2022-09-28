using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


[SerializeField]
public class CircularLinkedList
{
    public Node head;
    public Node tail;
    public int length;
    public CircularLinkedList(int i)
    {
        Node newnode = new Node(i);
        this.head = newnode;
        this.tail = newnode;
        this.length = 1;
    }


    public void AppendFromHead(int i)
    {
        Node tmp = new Node(i);
        if (head == null)
        { 
            head = tmp;
            tail = tmp;
            length++;
            return; }
        tail.next = tmp;
        tmp.next = head;
        head = tmp;
        length++;
    }


    public void print_list()
    {
        if (head == null)
            return;
        Node tmp = head;
        
        while (tmp != tail)
        {
            Debug.Log(tmp.value);
            tmp = tmp.next;
        }
        Debug.Log(tmp.value);    
    }





}
