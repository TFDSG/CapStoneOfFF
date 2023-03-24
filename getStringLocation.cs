using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF
{
    partial class getStringLocation
    {
        string initialText;
        string formula;
        const double difference = 0.1; 
        internal getStringLocation(string text, string formula)
        {
            this.initialText = text;
            this.formula = formula;
        }
        internal ArrayList getIndex()
        {
            ArrayList res = new ArrayList();
            int start = 0;
            string beginWord = formula.Substring(0, formula.IndexOf(' '));
            int lenOfFormula = formula.Length;
            while (start < this.initialText.Length)
            {
                int beginIndex = this.initialText.IndexOf(beginWord, start);
                if(beginIndex >= 0)
                {
                    string temp = "";
                    if(beginIndex + lenOfFormula> this.initialText.Length)
                    {
                        temp = this.initialText.Substring(beginIndex);
                    }
                    else
                        temp = this.initialText.Substring(beginIndex, lenOfFormula);
                    if(similar(this.formula, temp))
                        res.Add(beginIndex);
                }
                if (beginIndex == -1) break;
                start = beginIndex + lenOfFormula;
            }
            return res;
        }
        private bool similar(string formula, string temp) 
        {
            Hashtable check = new Hashtable();
            foreach (char c in formula)
            {
                if (check.ContainsKey(c))
                {
                    check[c] = (int)check[c] + 1;
                }
                else
                {
                    check.Add(c, 1);
                }
            }
            foreach (char c in temp)
            {
                if (check.ContainsKey(c))
                {
                    check[c] =(int)check[c] - 1;
                    if ((int)check[c] == 0) check.Remove(c);    
                }
            }
            int sum = 0;
            foreach (char c in check.Keys)
            {
                sum = sum + (int)check[c];   
            }
            if ((double)sum / formula.Length < difference) return true; 
            else return false;
        }
    }
}
