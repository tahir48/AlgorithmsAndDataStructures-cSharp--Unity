using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAlgos : MonoBehaviour
{

    public LinkedList myLinkedList;
    public LinkedList list1, list2, merged;

    public void Start()
    {
        list1 = new LinkedList(0);
        list1.append(2);
        list1.append(4);
        list1.append(6);
        list1.append(15);
        list1.append(22);

        list2 = new LinkedList(1);
        list2.append(3);
        list2.append(5);
        list2.append(7);
        list2.append(9);
        list2.append(11);
        list2.append(14);
        list2.append(24);
        list2.append(26);

        //list1.print_list();
        //list2.print_list();

        //myLinkedList = new LinkedList(0);
        //myLinkedList.append(5);
        //myLinkedList.append(2);
        //myLinkedList.append(8);
        //myLinkedList.append(4);

        //myLinkedList.append(10);
        //myLinkedList.append(11);
        //myLinkedList.set_value(5, 500);
        //myLinkedList.remove(6);
        //myLinkedList.pop_first();
        //myLinkedList.pop();
        //myLinkedList.prepend(100);
        //Debug.Log("Linkedlist length is    " + myLinkedList.length);





        //myLinkedList.print_list();
    }


    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //myLinkedList.bubble_sort();
            //myLinkedList.print_list();
            merged = merge(list1, list2);
            merged.print_list();
        }
    }



    public LinkedList merge(LinkedList sortedList1, LinkedList sortedList2)
    {

        //Edge cases are tested, method works well.

        LinkedList newlist;

        Node tmp1 = sortedList1.head;
        Node tmp2 = sortedList2.head;

        if(sortedList1.length == 0 | sortedList2.length == 0)
        {
            Debug.LogError("Nothing to return here");
        }

        if (tmp1.value < tmp2.value)
        {
            newlist = new LinkedList(tmp1.value);
            tmp1 = tmp1.next;
            sortedList1.pop_first();
        }
        else
        {
            newlist = new LinkedList(tmp2.value);
            tmp2 = tmp2.next;
            sortedList2.pop_first();
        }

        while(tmp1 != null && tmp2 != null)
        {

            if (tmp1.value > tmp2.value)
            {
                newlist.append(tmp2.value);
                tmp2 = tmp2.next;
                sortedList2.pop_first();

            }
            else
            {
                newlist.append(tmp1.value);
                tmp1 = tmp1.next;
                sortedList1.pop_first();
            }
        }


        if (sortedList1.length != 0)
        {
            while (tmp1 != null)
            {
                newlist.append(tmp1.value);
                tmp1 = tmp1.next;
            }

        }
        if (sortedList2.length != 0)
        {
            while (tmp2 != null)
            {
                newlist.append(tmp2.value);
                tmp2 = tmp2.next;
            }

        }

        return newlist;
    }



}

