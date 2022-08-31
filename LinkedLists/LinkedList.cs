using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[System.Serializable]
public class LinkedList
{
    private Node head;
    private Node tail;
    public int length;

    public LinkedList(int i) {
        Node newnode = new Node(i);
        head = newnode;
        tail = newnode;
        length = 1;
    }



    public void print_list() {
        if (head == null)
        {
            return;
        }
        Node tmp = head;
        while (tmp != null)
        {
            Debug.Log("the item of LinkedList                     " + tmp.value);
            tmp = tmp.next;
        }
    }



    public void append(int value)
    {
        Node newnode = new Node(value);
        if (head == null)
        {
            head = newnode;
            tail = newnode;
        }
        else { 

        tail.next = newnode;
        tail = newnode;

        }
        length++;
    }







}



[SerializeField]
class Node
{
    public int value;
    public Node next;

    public Node(int i)  //constructor
    {
        value = i;
        next = null;
    }
}