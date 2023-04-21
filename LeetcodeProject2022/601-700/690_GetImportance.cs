using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
    }
    public class _690_GetImportance
    {
        public int GetImportance(IList<Employee> employees, int id)
        {
            Dictionary<int, Employee> dic = new Dictionary<int, Employee>();
            foreach (Employee em in employees)
            {
                dic.Add(em.id, em);
            }
            return dfs(id, dic);
        }
        int dfs(int id, Dictionary<int, Employee> dic)
        {
            Employee em = dic[id];
            int sum = em.importance;
            for (int i = 0; i < em.subordinates.Count; i++)
            {
                sum += dfs(em.subordinates[i], dic);
            }
            return sum;
        }
    }
}
