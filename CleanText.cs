using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF
{
    partial class CleanText
    {
       
        internal string removeHead(string sutra)
        {
            string[] cleanParts = sutra.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
            return cleanParts[cleanParts.Length - 1];
        }
        internal string removeTail(string sutra)
        {
            string[] cleanParts = sutra.Split(new string[] {"**"}, StringSplitOptions.RemoveEmptyEntries);
            return cleanParts[0];
        }
        internal string removeNum(string sutra)
        {
            sutra = Regex.Replace(sutra, @"[\d]", string.Empty);
            return sutra;
        }
        internal string removeRoman(string sutra)
        {
            sutra = Regex.Replace(sutra, @"[IVXLCDM]+\.",string.Empty);
            return sutra;
        }
        internal string remvoePunc(string sutra)
        {
            var sb = new StringBuilder();
            foreach(char c in sutra)
            {
                if(!char.IsPunctuation(c))
                    sb.Append(c);
                else
                    sb.Append(' ');
            }
            return sb.ToString();
        }
        internal string removeSequn(string sutra, string[] symbels)
        {
            try
            {
                for (int i = 0; i < symbels.Length; i++)
                {
                    string[] sys = symbels[i].Split(' ');
                    string start = sys[0];
                    string end = sys[sys.Length - 1];
                    Regex reg = new Regex(string.Format("{0}(.*?){1}", Regex.Escape(start), Regex.Escape(end)));
                    sutra = reg.Replace(sutra, string.Empty);
                }
            }
            catch 
            {
                MessageBox.Show("Something wrong with the symbols input.");
            }
            return sutra;
        }
        internal string replaceSequn(string sutra, string[] symbels)
        {
            try
            {
                for (int i = 0; i < symbels.Length; i++)
                {
                    string[] sys = symbels[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string start = sys[0];
                    string end = sys[sys.Length - 1];
                    if(sys.Length <= 2)
                        sutra = Regex.Replace(sutra, end, string.Empty);
                    else
                        sutra = Regex.Replace(sutra,start, end);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong with the symbols input.");
            }
            return sutra;
        }
        internal string removeSpace(string sutra)
        {
            return Regex.Replace(sutra, @"\s+", " ");
        }
        internal string lowerCase(string sutra) 
        {
            return sutra.ToLower();
        }
        internal string removeSingle(string sutra)
        {
            var sb = new StringBuilder();
            string[] listWords = sutra.Split(' ');
            foreach (string s in listWords)
            {
                if (s.Length > 1)
                {
                    sb.Append(s);
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }
    }
}
