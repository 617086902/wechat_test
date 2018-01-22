using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class NGraph
    {
        private int _v, _e;
        private int[][] _adj;
        public NGraph(int v)
        {
            _v = v;
            _e = 0;
        }
        public void AddEdge(int v, int w)
        {
            _adj[v][_adj[v].Length] = w;
            _adj[w][_adj[w].Length] = v;
            _e++;
        }
        public int[] Adj(int v)
        {
            return _adj[v];
        }
        public int V { get { return _v; } }
        public int E { get { return _e; } }
    }
}
