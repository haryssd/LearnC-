// Example 1: Basic Linked List Traversal
// Problem: Given a singly linked list representation, traverse the list and print all nodes in order.
// Input:
// x->y
// y->z

using System;
using System.Collections.Generic;

public class LinkedListApp
{
    public static void Main()
    {
        Dictionary<string, string> graph = new Dictionary<string, string>();
        graph["x"] = "y";
        graph["y"] = "z";

        string start = "x";

        string result = traverseList(graph, start);
        Console.WriteLine(result);

    }

    static string traverseList(Dictionary<string, string> graph, string start)
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

}