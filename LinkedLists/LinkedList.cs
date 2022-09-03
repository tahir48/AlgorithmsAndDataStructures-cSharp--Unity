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
            Debug.Log("the item of LinkedList **********************       " + tmp.value);
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


    public void prepend(int value)
    {
        Node newnode = new Node(value);
        if (head == null)
        {
            head = newnode;
            tail = newnode;
        }
        else
        {
            newnode.next = head;
            head = newnode;
        }
        length++;
    }

    public void pop()
    {
        if (length == 0)
            return;
        else if (length == 1)
        {
            head = null;
            tail = null;
        }
        else
        {
            Node tmp = head;
            while (tmp.next != tail)
            {
                tmp = tmp.next;
            }
            tmp.next = null;
            tail = tmp;
        }
        length--;

    }

    public void pop_first()
    {
        if (head == null)
            return;
        else if (length == 1)
        {
            head = null;
            tail = null;
        } else
        {
            Node tmp = head;
            head = tmp.next;
            tmp.next = null;
        }
        length--;

    }


    public int get_value(int index)
    {
        Node tmp = head;
        int i = 0;
        while (i<index)
        {
            tmp = tmp.next;
            i++;
        }
        return tmp.value;
    }


    public Node get_node(int index)
    {
        Node tmp = head;
        int i = 0;
        while (i < index)
        {
            tmp = tmp.next;
            i++;
        }
        return tmp;
    }



    public void remove(int index)
    {
        if (index > length && index <0)
            return;
        if (head == null)
            return;
        if (index == 0)
        {
            this.pop_first();
        } else if (index == length)
        {
            this.pop();
        } else
        {
            Node before = get_node(index);
            Node tmp = before.next;
            before.next = tmp.next;
            tmp.next = null;
        }
        length--;
    }


    public void set_value(int index, int value)
    {
        if (index > length && index < 0)
            return;
        if (length == 0)
            return;
        Node tmp = get_node(index);
        tmp.value = value;
    }




    public void bubble_sort()
    {

        //ilk elemaný overwrite ediyor, tekrar üzerinden geç.
        // input {0,5,2,8,4,6,3,7,1}
        // output {1,1,2,3,4,5,6,7,8}

        Node tmp, tmp1, tmp2;


        for (int i = length; i >= 0; i--)
        {
            tmp = head;
            tmp1 = head;
            tmp2 = tmp1.next;
            for (int j = 0; j < i - 1; j++)
            {
                //Debug.Log("tmp1.value    " + tmp1.value);
                //Debug.Log("tmp2.value    " + tmp2.value);
                if (tmp1.value > tmp2.value)
                {
                    tmp.value = tmp1.value;
                    tmp1.value = tmp2.value;
                    tmp2.value = tmp.value;
                }
                tmp2 = tmp2.next;
                tmp1 = tmp1.next;
            }
            }
        }
   


    public void swap(Node node1, Node node2)
    {

    }

}



//[SerializeField]
public class Node
{
    public int value;
    public Node next;

    public Node(int i) 
    {
        value = i;
        next = null;
    }
}