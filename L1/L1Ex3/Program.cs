// Example 3: Reverse List Representation
// Problem: Given a singly linked list representation, output the list in reverse order.
// Input:
// p->q
// q->r
// r->s

using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Dictionary<string, string> graph = new Dictionary<string, string>();

        graph["p"] = "q";
        graph["q"] = "r";
        graph["r"] = "s";

        string start = "p";

        string result = reverseList(graph, start);

        Console.WriteLine(result);
    }

    public static string reverseList(Dictionary<string, string> graph, string start)
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

        nodes.Reverse();

        return string.Join(",", using System;nodes);

    }
}