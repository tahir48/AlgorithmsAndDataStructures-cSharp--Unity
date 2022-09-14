using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack
{

    Node top;
    int length;

    public Stack(int i)
    {
        Node newnode = new Node(i);
        top = newnode;
        length = 1;
    }


    public void print_stack()
    {
        if (top == null)
        {
            return;
        }
        Node tmp = top;
        while (tmp.next != null)
        {
            Debug.Log("value of stack" + tmp.value);
            tmp = tmp.next;
        }
    }



    public void push(int i)
    {
        Node tmp = new Node(i);
        if (top == null)
        {
            top = tmp;
            length++;
            return;
        }
        tmp.next = top;
        top = tmp;
        length++;
    }



    public void pop()
    {
        if (top == null)
        {
            return;
        }
        Node tmp = top;
        top = tmp.next;
        tmp.next = null;
        length--;
        


    }











}
