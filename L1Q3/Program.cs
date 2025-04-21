// Q3: Detect if a Linked List is Circular
// Problem: Given a singly linked list, determine if it contains a cycle (a node that points back to a previous node, creating a loop).
// Input:
// a->b
// b->c
// c->d
// d->b  This creates a cycle

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
        graph["d"] = "b";

        string start = "a";

        bool result = determineCycle(graph, start);

        Console.WriteLine($"Contain cycle: {result}");
    }

    public static bool determineCycle(Dictionary<string, string> graph, string start)
    {

        HashSet<string> visitedNodes = new HashSet<string>(); // Create empty set to track visited nodes

        string? current = start; // Start at node "a"

        while (current != null)
        {
            if (visitedNodes.Contains(current)) // Is current node already in our visited set? 
            {                                   // First iteration: Is "a" in visitedNodes? No.
                return true;    // This would execute if we found a cycle
            }

            visitedNodes.Add(current); // Add current node to visited set       // First iteration: Add "a", so visitedNodes = {"a"}

            if (graph.ContainsKey(current)) // Does current node point to another node?     // First iteration: Does "a" exist as a key? Yes

            {
                current = graph[current];  // Move to next node         // First iteration: current = graph["a"] = "b"
            }
            else
            {
                current = null;
            }
        }

        // Second iteration: current = "b"
        // Is "b" in visitedNodes? No.
        // Add "b", so visitedNodes = {"a", "b"}
        // current = graph["b"] = "c"

        // Third iteration: current = "c"
        // Is "c" in visitedNodes? No.
        // Add "c", so visitedNodes = {"a", "b", "c"}
        // current = graph["c"] = "d"

        // Fourth iteration: current = "d"
        // Is "d" in visitedNodes? No.
        // Add "d", so visitedNodes = {"a", "b", "c", "d"}
        // current = graph["d"] = "b"

        // Fifth iteration: current = "b"
        // Is "b" in visitedNodes? YES! We've seen "b" before
        // Return true - we found a cycle

        return false;
    }

}