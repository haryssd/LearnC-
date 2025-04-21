// Q2: Find the Middle Node
// Problem: Given a singly linked list, find the middle node. If the list has an even number of nodes, return the second middle node (the one closer to the end).
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

        string result = displayMiddleNote(graph, start);

        Console.WriteLine($"Middle Note: {result}");
    }

    public static string displayMiddleNote(Dictionary<string, string> graph, string start)
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

        string middle = nodes[nodes.Count / 2];

        return middle;
    }
}
