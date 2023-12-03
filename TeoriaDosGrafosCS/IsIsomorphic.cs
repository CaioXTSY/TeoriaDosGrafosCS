using System;
using System.Collections.Generic;
using System.Linq;

class IsIsomorphic
{
    static void Main()
    {
        var grafo1 = new Dictionary<int, List<int>> {
            {1, new List<int> {2, 3}},
            {2, new List<int> {1, 3}},
            {3, new List<int> {1, 2, 4}},
            {4, new List<int> {3}}
        };

        var grafo2 = new Dictionary<char, List<char>> {
            {'A', new List<char> {'B', 'C'}},
            {'B', new List<char> {'A', 'C'}},
            {'C', new List<char> {'A', 'B', 'D'}},
            {'D', new List<char> {'C'}}
        };

        bool resultado = IsIsomorphic(grafo1, grafo2);
        Console.WriteLine(resultado);
    }

    static bool IsIsomorphic<T1, T2>(Dictionary<T1, List<T1>> grafo1, Dictionary<T2, List<T2>> grafo2)
    {
        if (grafo1.Count != grafo2.Count)
            return false;

        var grauGrafo1 = grafo1.Values.Select(x => x.Count).OrderBy(x => x).ToList();
        var grauGrafo2 = grafo2.Values.Select(x => x.Count).OrderBy(x => x).ToList();

        return grauGrafo1.SequenceEqual(grauGrafo2);
    }
}
