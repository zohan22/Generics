using System;
using System.Collections.Generic;
using Activity;

class Program
{
    static void Main(string[] args)
    {
        //Part 1: Lists
        //Declare and initialize a List<int> to store a collection of integers.
        ListIntegers list = new ListIntegers();

        //Add 10 integers to the list.
        list.AddNumbers();

        //Print the list elements to the console.
        list.PrintList();

        //Remove the first and last elements from the list.
        list.RemoveFirstandLast();

        //Print the updated list to the console.
        list.PrintList();


    }
}
