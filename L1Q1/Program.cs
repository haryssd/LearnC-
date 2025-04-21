// Q1: Linked List Creation and Traversal
// Problem: You are given a series of nodes and connections that form a singly linked list. Your task is to:
// Build the linked list from the input. Traverse the list and output the values in order
// Count the total number of nodes in the list
// Input:
// a->b
// b->c
// c->d
// d->e

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, string> graph = new Dictionary<string, string>();

        graph["a"] = "b";
        graph["b"] = "c";
        graph["c"] = "d";
        graph["d"] = "e";

        string start = "a";

        string result1 = displayList(graph, start);


        Console.WriteLine($"Traversal: {result1}");
        displayCount(graph, start);
    }

    public static string displayList(Dictionary<string, string> graph, string start)
    {
        List<string> nodes = new List<string>();

        string? current = start;

        while (current != null)
        {
            nodes.Add(current);

            if (graph.ContainsKey(current))
            {
                current = graph[current];
            }
            else
            {
                current = null;
            }
        }

        return string.Join(",", nodes);
    }

    public static void displayCount(Dictionary<string, string> graph, string start)
    {
        int count = 0;
        string? current = start;

        while (current != null)
        {
            count++;

            if (graph.ContainsKey(current))
            {
                current = graph[current];
            }
            else
            {
                current = null;
            }
        }

        Console.WriteLine($"Count: {count}");
    }
}