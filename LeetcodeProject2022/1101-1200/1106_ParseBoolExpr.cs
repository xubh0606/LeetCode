using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1106_ParseBoolExpr
    {
        int m_index;
        char[] m_charArr;
        public enum subExper { InAddSubExper = 2, InOrSubExper = 3, InNotSubExper }
        public bool ParseBoolExpr(string expression)
        {
            m_index = 0;
            m_charArr = expression.ToArray(); 
            return GetResult(expression, subExper.InNotSubExper);
        }
        bool GetResult(string expression, subExper isInSubExper)
        {
            if (isInSubExper == subExper.InNotSubExper)
            {
                if (expression[m_index] == 'f')
                {
                    m_index += 2;
                    return false;
                }
                if (expression[m_index] == 't')
                {
                    m_index += 2;
                    return true;
                }
                if (expression[m_index] == '&')
                {
                    m_index += 2;
                    if(GetResult(expression, subExper.InAddSubExper))
                    {
                        m_index += 2;
                        return true;
                    }
                    else
                    {
                        m_index += 2;
                        return false;
                    }
                }
                if (expression[m_index] == '!')
                {
                    m_index += 2;
                    if (GetResult(expression, subExper.InNotSubExper))
                    {
                        m_index += 2;
                        return true;
                    }
                    else
                    {
                        m_index += 2;
                        return false;
                    }
                }
                if (expression[m_index] == '|')
                {
                    m_index += 2;
                    if (GetResult(expression, subExper.InOrSubExper))
                    {
                        m_index += 2;
                        return true;
                    }
                    else
                    {
                        m_index += 2;
                        return false;
                    }
                }
            }
            else if (isInSubExper == subExper.InAddSubExper)
            {
                while (m_index < expression.Length && expression[m_index] != ')')
                {
                    if (expression[m_index] == '!')
                    {
                        m_index += 2;
                        if (!GetResult(expression, subExper.InNotSubExper))
                        {
                            continue;
                        }
                        else
                        {
                            FindNext(expression);
                            return false;
                        }
                    }
                    else if (expression[m_index] == '&')
                    {
                        m_index += 2;
                        if (GetResult(expression, subExper.InAddSubExper))
                        {
                            continue;
                        }
                        else
                        {
                            FindNext(expression);
                            return false;
                        }
                    }
                    if (expression[m_index] == '|')
                    {
                        m_index += 2;
                        if (GetResult(expression, subExper.InOrSubExper))
                        {
                            continue;
                        }
                        else
                        {
                            FindNext(expression);
                            return false;
                        }
                    }
                    if (expression[m_index] == 'f')
                    {
                        m_index++;
                        FindNext(expression);
                        return false;
                    }
                    if (expression[m_index] == 't' || expression[m_index] == ',')
                    {
                        m_index++;
                    }
                }
                m_index++;
                return true;
            }
            else
            {
                while (m_index < expression.Length && expression[m_index] != ')')
                {
                    if (expression[m_index] == '!')
                    {
                        m_index += 2;
                        if (!GetResult(expression, subExper.InNotSubExper))
                        {
                            FindNext(expression);
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (expression[m_index] == '&')
                    {
                        m_index += 2;
                        if (GetResult(expression, subExper.InAddSubExper))
                        {
                            FindNext(expression);
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (expression[m_index] == '|')
                    {
                        m_index += 2;
                        if (GetResult(expression, subExper.InOrSubExper))
                        {
                            FindNext(expression);
                            return true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (expression[m_index] == 't')
                    {
                        FindNext(expression);
                        return true;
                    }
                    if (expression[m_index] == 'f' || expression[m_index] == ',')
                    {
                        m_index++;
                    }
                }
                m_index++;
                return false;
            }
            throw new Exception();
        }
        void FindNext(string expression)
        {
            int count = 1;
            while (m_index < expression.Length && count > 0)
            {
                if (expression[m_index] == '(')
                {
                    count++;
                }
                if (expression[m_index] == ')')
                {
                    count--;
                }
                m_index++;
            }
        }
    }
}
