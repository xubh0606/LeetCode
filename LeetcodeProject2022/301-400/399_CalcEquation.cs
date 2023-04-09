using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _399_CalcEquation
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            IList<Dictionary<string, double>> map = new List<Dictionary<string, double>>();
            for (int i = 0; i < equations.Count; i++)
            {
                dfs(map, i, equations, values, 0);
            }
            double[] res = new double[queries.Count];
            for (int k = 0; k < queries.Count; k++)
            {
                res[k] = Div(map, queries[k][0], queries[k][1]);
            }
            return res;
        }

        bool NotExist(IList<Dictionary<string, double>> map, string str)
        {
            for (int i = 0; i < map.Count; i++)
            {
                if (map[i].ContainsKey(str))
                {
                    return false;
                }
            }
            return true;
        }

        double Div(IList<Dictionary<string, double>> map, string str1, string str2)
        {
            for (int i = 0; i < map.Count; i++)
            {
                if (map[i].ContainsKey(str1) && map[i].ContainsKey(str2))
                {
                    double dividend = map[i][str1];
                    double dividor = map[i][str2];
                    return dividend / dividor;
                }
            }
            return -1;
        }

        void dfs(IList<Dictionary<string, double>> map, int i, IList<IList<string>> equations, double[] values, int count)
        {
            if (count == 0)
            {
                if (NotExist(map, equations[i][0]) && NotExist(map, equations[i][1]))
                {
                    map.Add(new Dictionary<string, double>());
                    map[map.Count - 1].Add(equations[i][1], 1);
                    map[map.Count - 1].Add(equations[i][0], values[i]);
                    for (int j = 0; j < equations.Count; j++)
                    {
                        dfs(map, j, equations, values, 1);
                    }
                }
            }
            else
            {
                if (map[map.Count - 1].ContainsKey(equations[i][0]) && map[map.Count - 1].ContainsKey(equations[i][1]))
                {
                    return;
                }
                if (map[map.Count - 1].ContainsKey(equations[i][0]) || map[map.Count - 1].ContainsKey(equations[i][1]))
                {
                    if (map[map.Count - 1].ContainsKey(equations[i][0]))
                    {
                        map[map.Count - 1].Add(equations[i][1], (map[map.Count - 1][equations[i][0]]) / values[i]);
                        for (int j = 0; j < equations.Count; j++)
                        {
                            dfs(map, j, equations, values, 1);
                        }
                    }
                    else if (map[map.Count - 1].ContainsKey(equations[i][1]))
                    {
                        map[map.Count - 1].Add(equations[i][0], map[map.Count - 1][equations[i][1]] * values[i]);
                        for (int j = 0; j < equations.Count; j++)
                        {
                            dfs(map, j, equations, values, 1);
                        }
                    }
                }
            }
        }
    }
}
