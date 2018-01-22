using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class NBFS
    {
        private bool[] marked;
        private int[] edgeTo;
        private readonly int s;
        public NBFS(NGraph g, int s)
        {
            marked = new bool[g.V];
            edgeTo = new int[g.V];
            this.s = s;

        }
        private void bfs(NGraph g, int s)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            while (queue.Any())
            {
                int v = queue.Dequeue();
                int[] adj = g.Adj(v);
                for (int i = 0; i < adj.Length; i++)
                {
                    int w = adj[i];
                    if (!marked[w])
                    {
                        marked[w] = true;
                        edgeTo[w] = v;
                        queue.Enqueue(w);
                    }
                }
            }
        }
        public bool HasPathTo(int v)
        {
            return marked[v];
        }
        public Stack<int> PathTo(int v)
        {
            if (!HasPathTo(v)) return null;
            Stack<int> pathStack = new Stack<int>();
            for (int x = v; x != s; x = edgeTo[x])
            {
                pathStack.Push(x);
            }
            return pathStack;
        }
    }
}
