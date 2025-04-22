// Example 1: Finding Length and Last Node
// Problem: Given a singly linked list, find its length and the value of the last node.
// Input:
// a->b
// b->c
// c->d

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

        string start = "a";

        int result1 = lengthNode(graph, start);
        string result2 = lastNode(graph, start);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }

    public static int lengthNode(Dictionary<string, string> graph, string start)
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

        return count;
    }

    public static string lastNode(Dictionary<string, string> graph, string start)
    {
        string? current = start;
        string last = start;

        while (current != null)
        {
            last = current;

            if (graph.ContainsKey(current))
            {
                current = graph[current];
            }
            else
            {
                current = null;
            }
        }

        return last;
    }
}