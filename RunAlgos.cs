using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAlgos : MonoBehaviour
{

    public LinkedList myLinkedList;
    public LinkedList list1, list2, merged;
    public Stack stack1;
    public CircularLinkedList circularLinkedList;
    public CircularDoublyLinkedList CircularDoublyLinkedList;

    public void Start()
    {
        // stack1 = new Stack(4);
        // stack1.push(3);
        // stack1.push(2);
        // stack1.push(1);
        // stack1.push(0);
        //stack1 = new Stack(4);
        //stack1.push(3);
        //stack1.push(2);
        //stack1.push(1);
        //stack1.push(0);
        //circularLinkedList = new CircularLinkedList(1);
        //circularLinkedList.AppendFromHead(2);
        //circularLinkedList.AppendFromHead(3);
        //circularLinkedList.AppendFromHead(4);
        //circularLinkedList.AppendFromHead(5);


        CircularDoublyLinkedList = new CircularDoublyLinkedList(0);
        CircularDoublyLinkedList.AppendFromHead(1);
        CircularDoublyLinkedList.AppendFromHead(2);
        CircularDoublyLinkedList.AppendFromHead(3);
        CircularDoublyLinkedList.AppendFromHead(4);
       

        //list1 = new LinkedList(0);
        //list1.append(14);
        //list1.append(2);
        //list1.append(22); 
        //list1.append(4);
        //list1.append(6);
        //list1.append(15);
        //list1.append(3);
        //list1.append(24);
        //list1.append(5);
        //list1.append(26);
        //list1.append(7);
        //list1.append(9);
        //list1.append(11);




        //list1.print_list();
        //list2.print_list();

        //myLinkedList = new LinkedList(0);
        //myLinkedList.append(5);
        //myLinkedList.append(2);
        //myLinkedList.append(8);
        //myLinkedList.append(4);
        //myLinkedList.append(10);
        //myLinkedList.append(11);

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
            //merged = merge(list1, list2);
            //merged.print_list();
            // merged = merge_sort(list1);
            // merged.print_list();

            //myLinkedList.print_list();
            //merged = merge(list1, list2);
            //merged.print_list();
            //merged = merge_sort(list1);
            //merged.print_list();
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.next.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.next.next.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.next.next.next.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.next.next.next.next.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.next.next.next.next.next.value);
            //Debug.Log("Circular Linked List  " + circularLinkedList.head.next.next.next.next.next.next.next.value);
            //Debug.Log("All List with print method  ");
            //circularLinkedList.print_list();


            Debug.Log(CircularDoublyLinkedList.head.value);
            Debug.Log(CircularDoublyLinkedList.head.next.value);
            Debug.Log(CircularDoublyLinkedList.head.next.next.value);
            Debug.Log(CircularDoublyLinkedList.head.next.next.next.value);
            Debug.Log(CircularDoublyLinkedList.head.next.next.next.next.value);
            Debug.Log(CircularDoublyLinkedList.head.next.next.next.next.next.value);
            Debug.Log("********");
            Debug.Log(CircularDoublyLinkedList.tail.value);
            Debug.Log(CircularDoublyLinkedList.tail.prev.value);
            Debug.Log(CircularDoublyLinkedList.tail.prev.prev.value);
            Debug.Log(CircularDoublyLinkedList.tail.prev.prev.prev.value);
            Debug.Log(CircularDoublyLinkedList.tail.prev.prev.prev.prev.value);
            Debug.Log(CircularDoublyLinkedList.tail.prev.prev.prev.prev.prev.value);





        }


        if (Input.GetMouseButtonDown(1))
        {
            reverseWRecursion(myLinkedList);
            //myLinkedList.reverse();
            //List<int> newList = AddToList(myLinkedList);
            // List<int> newList = LinkedListToListWRecursion(myLinkedList);             
            // foreach(var i in newList){
            //     Debug.Log("i   "+ i);
            // }
            // stack1.pop();
            // stack1.print_stack();   
            //Debug.Log("sum of the values in Linked List      " + LinkedListSum(myLinkedList));
            //Debug.Log("sum of the values in Linked List      " + LinkedListSumWRecursion(myLinkedList));
            //Debug.Log("is the value exists in the list?   " + LinkedListFindWRecursion(myLinkedList, 10));
            //Debug.Log("is the value exists in the list?   " + LinkedListFindWRecursion(myLinkedList, 8));
            //Debug.Log("is the value exists in the list?   " + LinkedListFindWRecursion(myLinkedList, 11));
            //Debug.Log("is the value exists in the list?   " + LinkedListFindWRecursion(myLinkedList, 22));
            //stack1.pop();
            //stack1.print_stack();
        }


    }



    public LinkedList merge(LinkedList sortedList1, LinkedList sortedList2)
    {

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





    public LinkedList merge_sort(LinkedList UnsortedList)

    {
        if (UnsortedList.length == 1)
        {
            return UnsortedList;
        }


        LinkedList first_half = new LinkedList(UnsortedList.head.value);
        Node tmp = UnsortedList.head.next;


        for (int i = 0; i < Mathf.RoundToInt(UnsortedList.length/2)-1; i++)
        {
            first_half.append(tmp.value);
            tmp = tmp.next;
        }

        LinkedList second_half = new LinkedList(tmp.value);
        tmp = tmp.next;
        while (tmp != null)
        {
            second_half.append(tmp.value);
            tmp = tmp.next;
            
        }
        

        return merge(merge_sort(first_half), merge_sort(second_half));
    }





    public List<int> LinkedListToList(LinkedList list){
        List<int> myList = new List<int>();
        Node tmp;
        if(list.head == null){
        return null;
        } else {
            tmp = list.head;
        }
        while(tmp != null){
            myList.Add(tmp.value);
            tmp = tmp.next;
        }
        return myList;
    }


    public List<int> LinkedListToListWRecursion(LinkedList linkedList){
        List<int> myList = new List<int>();
        if(linkedList.head == null)
            return null;

        Node tmp = linkedList.head;
        myList = LinkedListToListWRecursion_helper(myList,tmp);
        return myList;
    }


    public List<int> LinkedListToListWRecursion_helper(List<int> list , Node node){
    if(node == null)
    {
        return list;
    };
    list.Add(node.value);
    return LinkedListToListWRecursion_helper(list, node.next);
    }


    int LinkedListSum(LinkedList list){
        int listSum = 0;
        if(list.head == null)
            {return 0;}
        Node tmp = list.head;
        while(tmp != null)
        {
            listSum = listSum + tmp.value;
            tmp = tmp.next;
        }
        return listSum;
    }


    public int LinkedListSumWRecursion(LinkedList list){
        int listSum = 0;
        if(list.head == null)
            {return listSum;}
        Node tmp = list.head;
        listSum = LinkedListSumWRecursion_helper(list, listSum, tmp);
        return listSum;
    }

    public int LinkedListSumWRecursion_helper(LinkedList list, int sum, Node node)
    {
        if(node == null)
            return sum;
        sum = sum + node.value;
        return LinkedListSumWRecursion_helper(list, sum, node.next);
    }



    public bool LinkedListFindWRecursion(LinkedList list, int value)
    {
        if (list.head == null)
            return false;
        Node tmp = list.head;
        return LinkedListFindWRecursion_helper(list, tmp, value);
    }

    private bool LinkedListFindWRecursion_helper(LinkedList list, Node node, int value)
    {
        if (node == null)
            return false;
        if (node.value == value)
            return true;
        

        return LinkedListFindWRecursion_helper(list, node.next, value);

    }


    public LinkedList reverseWRecursion(LinkedList list)
    {
        Node before = null;
        Node tmp = list.head;
        reverseWRecursion_helper(tmp, before);
        return list;
    }
    public Node reverseWRecursion_helper(Node node_tmp, Node node_before)
    {
        if (node_tmp == null)
            return node_before;
        Node after = node_tmp.next;
        return reverseWRecursion_helper(after, node_tmp);
    }






}

