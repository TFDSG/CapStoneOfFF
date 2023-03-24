using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FF
{
    partial class SearchFormula
    {
        private string[] bookName = null;
        private string[] bookContext = null;
        private string[] cleanedBook = null;
        private int sutraLen = 0;
        private Hashtable treeNodes;
        private int maxlen = 0;

        internal SearchFormula(string[] title, int len) 
        { 
            bookName = title;
            sutraLen = len;
            bookContext = new string[title.Length];
            cleanedBook = new string[title.Length];
            
            CleanText wash = new CleanText();
            string[] symbols = new string[] { "*[   and   ]*", "[   and   ]", "(   and   )", "/   and   /" };
            for (int i=0; i<title.Length; i++)
            {
                StreamReader readBook = new StreamReader(Application.StartupPath + "\\files\\" + this.bookName[i], System.Text.Encoding.UTF8);
                bookContext[i] = readBook.ReadToEnd();
                readBook.Close();
                string tempContext = bookContext[i];
                tempContext = wash.removeHead(tempContext);
                tempContext = wash.removeTail(tempContext);
                tempContext = wash.removeSequn(tempContext, symbols);
                tempContext = wash.removeNum(tempContext);
                tempContext = wash.removeRoman(tempContext);
                tempContext = wash.remvoePunc(tempContext);
                tempContext = wash.removeSpace(tempContext);
                tempContext = wash.lowerCase(tempContext);
                //remove single letters
                tempContext = wash.removeSingle(tempContext);
                this.cleanedBook[i] = tempContext; 
            }
            maxlen = cleanedBook[0].Length;
            foreach (string s in cleanedBook)
            {
                maxlen = Math.Min(maxlen, s.Length);
            }
        }
        public string[] CleanedBook
        {
            get => this.cleanedBook; 
        }
        public string[] InitialBook 
        {
            get => this.bookContext;
        }
        public void fillTreeNodes()
        {
            treeNodes = new Hashtable();
            
            for (int m = sutraLen; m <= maxlen; m++)
            {
                Hashtable record = new Hashtable();
                bool check = false;
                for (int i = 0; i < this.bookName.Length; i++)
                {
                    List<string> fileI = getMin(this.cleanedBook[i], m);
                    for (int j = 0; j < fileI.Count; j++)
                    {
                        if (record.Contains(fileI[j]))
                        {
                            List<string> title = (List<string>)record[fileI[j]];
                            if (!title.Contains(this.bookName[i]))
                            {
                                title.Add(this.bookName[i]);
                                record[fileI[j]] = title;
                            }
                        }
                        else
                        {
                            List<string> title = new List<string>();
                            title.Add(this.bookName[i]);
                            record.Add(fileI[j], title);
                        }
                    }
                }
                foreach (string s in record.Keys)
                {
                    List<string> temp = (List<string>)record[s];
                    string getPrevious = s.Substring(0, s.LastIndexOf(' '));
                    if (temp.Count >= 2)
                    {
                        // test the string s exit in every book  of temp(book name)
                        /* int checkexsit = 1;
                        foreach (string s2 in temp)
                        {
                            int index = Array.IndexOf(this.bookName, s2);
                            string initialContext = this.bookContext[index];
                            getStringLocation findLot = new getStringLocation(initialContext,s);
                            ArrayList l = findLot.getIndex();
                            checkexsit *= l.Count;
                        }
                        
                        if (checkexsit == 0) continue;*/
                        
                        if (treeNodes.Contains(getPrevious))
                        {
                            if(listEqual(temp, (List<string>)treeNodes[getPrevious]))
                                treeNodes.Remove(getPrevious);
                        }  
                        treeNodes.Add(s, temp);
                        check = true;
                    }
                }
                if (!check) break;
            }
        }
        private List<string> getMin(string s, int len)
        {
            List<string> res = new List<string>();
            string[] arr = s.Split(' ');
            if(arr.Length < len) { return res; }
            for(int i=0; i<=arr.Length-len ; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < len; j++)
                {
                    sb.Append(arr[i + j]);
                    sb.Append(' ');
                }
                res.Add(sb.ToString().Substring(0, sb.ToString().Length-1));
            }
            return res;
        }

        private bool listEqual(List<string> first, List<string> second)
        {
            if(first.Count != second.Count) return false;
            for(int i=0; i<first.Count;i++) 
            {
                if (first[i]!= second[i]) return false;
            }
            return true;
        }
        public Hashtable TreeNodes { get { return treeNodes; } }
    }
}
