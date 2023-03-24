using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FF
{
    public partial class FF : Form
    {
        public FF()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Upload_Click(object sender, EventArgs e)
        {
            UploadFiles.Filter = "Only txt files|*.txt";
            UploadFiles.ShowDialog();
            if (File.Exists(Application.StartupPath + "\\files\\" + UploadFiles.SafeFileName))
            {
                MessageBox.Show("You already have the book in your library.");
            }
            else
            {
                if (UploadFiles.FileName != "")
                {
                    DirectoryInfo folder = new DirectoryInfo(Application.StartupPath + "\\files");              
                    FileInfo[] fojing = folder.GetFiles();
                    BookList.Items.Add((fojing.Length+1) +" "+ UploadFiles.SafeFileName);
                    File.Copy(UploadFiles.FileName, Application.StartupPath + "\\files\\" + UploadFiles.SafeFileName);
                }
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Upload.Visible = true;
            Save.Visible = false;
            InitialVersion.Visible = false;
            CleanText.Visible = false;
            SettingPanel.Visible = false;
            ContextOftxt.Visible = false;
            GetCleanTextButton.Visible = false;
            buttonOfFindFormulas.Visible = false;
            panelOfFormula.Visible = false;
            treeView1ForResults.Visible = false;
            buttonForNextone.Visible = false;
            buttonForLastOne.Visible = false;
            richTextBoxForHighlight.Visible = false;
            labelForFormulasNum.Visible = false;
            buttonForbackToList.Visible = false;
            BookList.Clear();
            BookList.Visible = true;
            DirectoryInfo folder = new DirectoryInfo(Application.StartupPath + "\\files");
            BookList.Items.Add("           Book List");
            FileInfo[] fojing = folder.GetFiles(); 
            for(int i=0; i<folder.GetFiles().Length; i++)
            {
                BookList.Items.Add((i+1) +" "+ fojing[i].Name);
            }
        }

        private void cleanSetButton_click(object sender, EventArgs e)
        {
            SettingPanel.Visible= true;
            Save.Visible = false;
            InitialVersion.Visible = false;
            CleanText.Visible = false;
            BookList.Visible= false;
            ContextOftxt.Visible= false;
            Upload.Visible = false;
            GetCleanTextButton.Visible = false;
            buttonOfFindFormulas.Visible = false;
            panelOfFormula.Visible = false;
            treeView1ForResults.Visible = false;
            buttonForNextone.Visible = false;
            buttonForLastOne.Visible = false;
            richTextBoxForHighlight.Visible = false;
            labelForFormulasNum.Visible = false;
            buttonForbackToList.Visible = false;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.ForeColor = Color.DodgerBlue;
            
        }


        private void deleteTheSutraToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if(BookList.SelectedItems.Count == 1 )
            {
                String bookName = BookList.Items[BookList.SelectedIndices[0]].Text;
                if (!bookName.Contains("   Book") && e.Button == MouseButtons.Left)
                {
                    bookName = bookName.Substring(bookName.IndexOf(' ') + 1);
                    if(File.Exists(Application.StartupPath + "\\files\\" +bookName))
                    {
                        File.Delete(Application.StartupPath + "\\files\\" + bookName);
                        BookList.Clear();
                        DirectoryInfo folder = new DirectoryInfo(Application.StartupPath + "\\files");
                        BookList.Items.Add("           Book List");
                        FileInfo[] fojing = folder.GetFiles();
                        for (int i = 0; i < folder.GetFiles().Length; i++)
                        {
                            BookList.Items.Add((i + 1) + " " + fojing[i].Name);
                        }
                        contextMenuStrip1.Close();
                    }
                    else
                    {
                        
                        MessageBox.Show("Not found "+bookName);
                        contextMenuStrip1.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose one book please!");
                contextMenuStrip1.Close();
            }
        }

        private void BookList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (BookList.SelectedItems.Count == 1)
            {
                
                String bookName = BookList.Items[BookList.SelectedIndices[0]].Text;
                if (!bookName.Contains("   Book"))// && e.Button == MouseButtons.Left)
                {
                    bookName = bookName.Substring(bookName.IndexOf(' ') + 1);
                    StreamReader readBook = new StreamReader(Application.StartupPath+"\\files\\" + bookName, System.Text.Encoding.UTF8);
                    ContextOftxt.Text = readBook.ReadToEnd();
                    readBook.Close();
                    ContextOftxt.Visible = true;
                    GetCleanTextButton.Visible= true;
                    Save.Visible = false;
                    InitialVersion.Visible = false;
                    CleanText.Visible = false;
                    BookList.Visible = false;
                    SettingPanel.Visible = false;
                    buttonOfFindFormulas.Visible = false;
                    panelOfFormula.Visible = false;
                }
                else
                    MessageBox.Show("Please choose a book!");
            }
            else
            {
                MessageBox.Show("Please choose only one book name!");
            }
        }

        private void checkBox1_removeSequence_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1_removeSequence.Checked == false)
                panelForRemoveSymbols.Visible = false;
            else
                panelForRemoveSymbols.Visible = true;
            
        }

        private void checkBox1_replaceSequence_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1_replaceSequence.Checked == false)
                panelForReplacingSymbols.Visible = false;
            else
                panelForReplacingSymbols.Visible = true;
        }

        private void AddSymbols_Click(object sender, EventArgs e)
        {
            String start = textBox1_startSymbol.Text;
            String end = textBox1_endSysmbols.Text;
            if (start == "" || end == "") 
                MessageBox.Show("Please enter pair of symbols");
            else
            {
                String addToItems = start + "   and   " + end;
                bool isThere = false;
                for (int i = 0; i < checkedListBoxForRemoveSymbols.Items.Count; i++)
                {
                    if (addToItems == Convert.ToString(checkedListBoxForRemoveSymbols.Items[i]))
                    {
                        isThere = true;
                        MessageBox.Show("Already there!");
                    }
                }
                if (!isThere)
                    checkedListBoxForRemoveSymbols.Items.Add(addToItems);
            }
        }

        private void DeleteSymbols_Click(object sender, EventArgs e)
        {
            if (checkedListBoxForRemoveSymbols.CheckedItems.Count == 0)
                MessageBox.Show("Please choose items to delete!");
            else
            {
                int size = checkedListBoxForRemoveSymbols.CheckedItems.Count;
                for (int i = 0; i < size; i++)
                    checkedListBoxForRemoveSymbols.Items.Remove(checkedListBoxForRemoveSymbols.CheckedItems[0]);
            }
        }

        private void button_addReplace_Click(object sender, EventArgs e)
        {
            String old = textBox2_oldSysmbol.Text;
            String current = textBox3_newSymbols.Text;
            if (old == "")
                MessageBox.Show("Please choose an exist symbols");
            else
            {
                String addToItems = "";
                if(current == "")
                    addToItems = "remove   " + old;
                else
                    addToItems = old + "   switch to   " + current;
                bool isThere = false;
                for (int i = 0; i < checkedListBox1_replaceSymbos.Items.Count; i++)
                {
                    if (addToItems == Convert.ToString(checkedListBox1_replaceSymbos.Items[i]))
                    {
                        isThere = true;
                        MessageBox.Show("Already there!");
                    }
                }
                if (!isThere)
                    checkedListBox1_replaceSymbos.Items.Add(addToItems);
            }
        }

        private void button_deleteReplace_Click(object sender, EventArgs e)
        {
            if (checkedListBox1_replaceSymbos.CheckedItems.Count == 0)
                MessageBox.Show("Please choose items to delete!");
            else
            {
                int size = checkedListBox1_replaceSymbos.CheckedItems.Count;
                for (int i = 0; i < size; i++)
                    checkedListBox1_replaceSymbos.Items.Remove(checkedListBox1_replaceSymbos.CheckedItems[0]);
            }
        }

        private void BookList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && BookList.SelectedItems.Count == 1)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void GetCleanTextButton_Click(object sender, EventArgs e)
        {
            string initialVersion = "";
            if (ContextOftxt.Text != null && ContextOftxt.Text.Length > 0)
                initialVersion = ContextOftxt.Text;
            else
                return;

            CleanText cleanversion = new CleanText();
            if(checkBox_removeHeader.Checked)
                initialVersion  = cleanversion.removeHead(initialVersion);
            
            if(checkBox1_removeFooter.Checked)
                initialVersion = cleanversion.removeTail(initialVersion);
           
            if(checkBox1_Number.Checked)
                initialVersion = cleanversion.removeNum(initialVersion);
            
            if(checkBox2_removeRomanNumerals.Checked)
                initialVersion = cleanversion.removeRoman(initialVersion);
            
            if(checkBox1_removeSequence.Checked)
            {
                string[] chosen = checkedListBoxForRemoveSymbols.Items.OfType<Object>().Select(x => x.ToString()).ToArray();
                initialVersion = cleanversion.removeSequn(initialVersion, chosen);
            }

            if(checkBox1_replaceSequence.Checked)
            {
                string[] chosen = checkedListBox1_replaceSymbos.Items.OfType<Object>().Select(x => x.ToString()).ToArray();
                initialVersion = cleanversion.replaceSequn(initialVersion, chosen);
            }

            if(checkBox3_RemovePunctuation.Checked)
                initialVersion = cleanversion.remvoePunc(initialVersion);

            if(checkBox4_removeExtraSpace.Checked)
                initialVersion = cleanversion.removeSpace(initialVersion);

            if(checkBox5_lowerCase.Checked)
                initialVersion = cleanversion.lowerCase(initialVersion);

            if (initialVersion != null && initialVersion.Length > 0)
            {
                CleanText.Parent = ShowAreaPanle;
                CleanText.Text = initialVersion;
                CleanText.Visible = true;
                ContextOftxt.Visible= false;
                BookList.Visible= false;
                GetCleanTextButton.Visible = false;
                Save.Visible = true;
                InitialVersion.Visible = true;
            }
        }

        private void InitialVersion_Click(object sender, EventArgs e)
        {
            ContextOftxt.Visible= true;
            InitialVersion.Visible = false;
            CleanText.Visible= false;
            Save.Visible= false;
            Upload.Visible= false;
            GetCleanTextButton.Visible = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(CleanText.Text != null && CleanText.Text.Length > 0)
            {
                saveFileDialog1.Filter = "Only txt files|*.txt";
                saveFileDialog1.AddExtension = true;
                String nameOfFile = saveFileDialog1.FileName; 
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.RestoreDirectory= true;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;
                    using(StreamWriter saveText = new StreamWriter(path))
                    {
                        saveText.WriteLine(CleanText.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a clean version first.");
            }
        }

        private void Formula_Click(object sender, EventArgs e)
        {
            panelOfFormula.Parent = ShowAreaPanle;
            buttonOfFindFormulas.Visible= true;
            panelOfFormula.Visible = true;
            if(comboBoxOfChooseText.Items.Count == 0)
            { 
                DirectoryInfo folder = new DirectoryInfo(Application.StartupPath + "\\files");
                FileInfo[] sutra = folder.GetFiles();
                if(sutra.Length> 0 )
                {
                    comboBoxOfChooseText.Text = sutra[0].Name;
                }
                foreach( FileInfo fi in sutra )
                {
                    comboBoxOfChooseText.Items.Add(fi.Name);
                }
            }
            BookList.Visible = false;
            CleanText.Visible= false;
            ContextOftxt.Visible= false;
            GetCleanTextButton.Visible= false;
            InitialVersion.Visible= false;
            Save.Visible= false;
            SettingPanel.Visible= false;
            Upload.Visible= false;
            treeView1ForResults.Visible = false;
            buttonForNextone.Visible = false;
            buttonForLastOne.Visible = false;
            richTextBoxForHighlight.Visible = false;
            labelForFormulasNum.Visible = false;
            buttonForbackToList.Visible = false;
        }

        private void comboBoxOfChooseText_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = comboBoxOfChooseText.SelectedIndex;
            if (ind != -1)
            {
                string sutra = comboBoxOfChooseText.Items[ind].ToString();
                if (listBoxOfCompareText.Items.Contains(sutra))
                {
                    MessageBox.Show("You has already added this sutra.");
                }
                else
                    listBoxOfCompareText.Items.Add(sutra);
            }
        }

        private void listBoxOfCompareText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int posindex = listBoxOfCompareText.IndexFromPoint(e.Location);
                if(posindex != -1)
                {
                    listBoxOfCompareText.SelectedIndex = posindex;
                    contextMenuStripForCompareList.Show(Cursor.Position);
                }
            }
        }

        private void Delete_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int ind = listBoxOfCompareText.SelectedIndex;
                if(ind != -1)
                {
                    listBoxOfCompareText.Items.RemoveAt(ind);
                    contextMenuStripForCompareList.Close();
                }
            }
        }

        private void addTheSutraToFormulasFindTableToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (BookList.SelectedItems.Count == 1)
            {
                String bookName = BookList.Items[BookList.SelectedIndices[0]].Text;
                if (!bookName.Contains("   Book") && e.Button == MouseButtons.Left)
                {
                    bookName = bookName.Substring(bookName.IndexOf(' ') + 1);
                    if (listBoxOfCompareText.Items.Contains(bookName))
                    {
                        contextMenuStrip1.Close();
                        MessageBox.Show("You have already added this sutra.");
                    }
                    else
                    {
                        listBoxOfCompareText.Items.Add(bookName);
                        contextMenuStrip1.Close();
                        MessageBox.Show("Done!");
                    }
                }
            }
            else
            {
                contextMenuStrip1.Close();
                MessageBox.Show("Choose one book please!");
            }
        }
        Hashtable formulaList = new Hashtable();
        private void buttonOfFindFormulas_Click(object sender, EventArgs e)
        {
            int minFormulaLength;
            bool isMin = int.TryParse(textBoxOfMinSize.Text, out minFormulaLength);
            if (listBoxOfCompareText.Items.Count < 2)
                MessageBox.Show("Please choose at least 2 sutras to compare!");
            else if(!isMin)
                MessageBox.Show("Please enter a valid number for minimum formula length.");
            else if(minFormulaLength < 2)
                MessageBox.Show("Formula length is at least 2.");
            else
            {
                // call find formulas function and give value to treeview
                string[] sutrasName = listBoxOfCompareText.Items.OfType<string>().ToArray();
                treeView1ForResults.Nodes.Clear();
                var watch = new System.Diagnostics.Stopwatch();
                try
                {
                    watch.Start();
                    SearchFormula ff = new SearchFormula(sutrasName, minFormulaLength);
                    ff.fillTreeNodes();
                    formulaList = ff.TreeNodes;
                    watch.Stop();
                    //labelForFormulasNum.Text = formulaList.Count + "   " + watch.ElapsedMilliseconds + "ms ";
                }
                catch
                {
                    MessageBox.Show("Confirm the sutras name and check your library for them!");
                    return;
                }
                if (this.formulaList.Count == 0)
                {
                    MessageBox.Show("There is no such long common formulas in these sutras!");
                }
                else
                {
                    foreach (string form in formulaList.Keys)
                    {
                        TreeNode root = new TreeNode(form);
                        List<string> bookNames = (List<string>)formulaList[form];
                        foreach (string bookName in bookNames)
                            root.Nodes.Add(new TreeNode(bookName));
                        treeView1ForResults.Nodes.Add(root);
                    }
                    treeView1ForResults.Parent = ShowAreaPanle;
                    treeView1ForResults.TreeViewNodeSorter = new NodeSorter();
                    treeView1ForResults.Sort();
                    
                    buttonOfFindFormulas.Visible = false;
                    BookList.Visible = false;
                    CleanText.Visible = false;
                    ContextOftxt.Visible = false;
                    GetCleanTextButton.Visible = false;
                    InitialVersion.Visible = false;
                    Save.Visible = false;
                    SettingPanel.Visible = false;
                    Upload.Visible = false;
                    panelOfFormula.Visible = false;

                    
                    treeView1ForResults.Visible = true;
                    buttonForNextone.Visible = false;
                    buttonForLastOne.Visible = false;
                    richTextBoxForHighlight.Visible = false;
                    labelForFormulasNum.Visible = false;
                    buttonForbackToList.Visible = false;
                }
            }
        }
        public class NodeSorter : IComparer
        {
            // Compare the length of the strings, or the strings
            // themselves, if they are the same length.
            public int Compare(object x, object y)
            {
                TreeNode tx = x as TreeNode;
                TreeNode ty = y as TreeNode;

                // Compare the length of the strings, returning the difference.
                if (tx.Text.Length != ty.Text.Length)
                    return tx.Text.Length - ty.Text.Length;

                // If they are the same length, call Compare.
                return string.Compare(tx.Text, ty.Text);
            }
        }
        //locate the string in initial text
        ArrayList formulasOrder;
        int indOfFormulas;
        int formulaLen = 0;
        private void treeView1ForResults_DoubleClick(object sender, EventArgs e)
        {
            this.indOfFormulas = -1;
            string bookName = treeView1ForResults.SelectedNode.Text;
            string formula = "";
            if (treeView1ForResults.SelectedNode.Parent != null)
            {
                formula = treeView1ForResults.SelectedNode.Parent.Text;
                this.formulaLen = formula.Length;
            }
            if (listBoxOfCompareText.Items.Contains(bookName))
            {
                treeView1ForResults.Visible = false;
                buttonForNextone.Visible = true;
                buttonForLastOne.Visible = true;
                richTextBoxForHighlight.Parent = ShowAreaPanle;
                //fill richTextBox with the initial airticle and highlights the first found formula
                if (File.Exists(Application.StartupPath + "\\files\\" + bookName))
                {
                    StreamReader readBook = new StreamReader(Application.StartupPath + "\\files\\" + bookName, System.Text.Encoding.UTF8);
                    richTextBoxForHighlight.Text = readBook.ReadToEnd();

                    // initial the formulas index as a list
                    getStringLocation getInd = new getStringLocation(richTextBoxForHighlight.Text,formula);
                    formulasOrder = getInd.getIndex();
                    labelForFormulasNum.Text = "Total is " + formulasOrder.Count + " in the file.";
                    if (formulasOrder.Count > 0)
                    {
                        indOfFormulas = 0;
                        
                        int lineOfWord = richTextBoxForHighlight.GetLineFromCharIndex((int)formulasOrder[0]);
                        richTextBoxForHighlight.SelectionStart = richTextBoxForHighlight.GetFirstCharIndexFromLine(lineOfWord);
                        richTextBoxForHighlight.SelectionLength = 0;
                        richTextBoxForHighlight.Focus();
                        richTextBoxForHighlight.ScrollToCaret();
                        richTextBoxForHighlight.Select((int)formulasOrder[0], formula.Length);
                        richTextBoxForHighlight.SelectionColor = Color.Red;
                    }
                }
                else
                {
                    richTextBoxForHighlight.Text = "Something wrong with this book in your library, check it.";
                }
                richTextBoxForHighlight.Visible = true;
                labelForFormulasNum.Visible = true;
                buttonForbackToList.Visible = true;
            }
        }

        private void buttonForbackToList_Click(object sender, EventArgs e)
        {
            treeView1ForResults.Visible = true;
            buttonForNextone.Visible = false;
            buttonForLastOne.Visible = false;
            richTextBoxForHighlight.Visible = false;
            labelForFormulasNum.Visible = false;
            buttonForbackToList.Visible = false;
        }

        private void buttonForNextone_Click(object sender, EventArgs e)
        {
            if(indOfFormulas >= 0)
            {
                indOfFormulas++;
                if(indOfFormulas == formulasOrder.Count)
                {
                    indOfFormulas = formulasOrder.Count - 1;
                    MessageBox.Show("This is the last one.");
                }
                else
                {
                    //jump to the next formula
                    int lineOfWord = richTextBoxForHighlight.GetLineFromCharIndex((int)formulasOrder[indOfFormulas]);
                    richTextBoxForHighlight.SelectionStart = richTextBoxForHighlight.GetFirstCharIndexFromLine(lineOfWord);
                    richTextBoxForHighlight.SelectionLength = 0;
                    richTextBoxForHighlight.Focus();
                    richTextBoxForHighlight.ScrollToCaret();
                    richTextBoxForHighlight.Select((int)formulasOrder[indOfFormulas], this.formulaLen);
                    richTextBoxForHighlight.SelectionColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("There is no such formulas in the initial file because of clean problem");
            }
        }

        private void buttonForLastOne_Click(object sender, EventArgs e)
        {
            if (indOfFormulas >= 0)
            {
                indOfFormulas--;
                if (indOfFormulas < 0)
                {
                    indOfFormulas = 0;
                    MessageBox.Show("This is the first one.");
                }
                else
                {
                    //jump to the next formula
                    int lineOfWord = richTextBoxForHighlight.GetLineFromCharIndex((int)formulasOrder[indOfFormulas]);
                    richTextBoxForHighlight.SelectionStart = richTextBoxForHighlight.GetFirstCharIndexFromLine(lineOfWord);
                    richTextBoxForHighlight.SelectionLength = 0;
                    richTextBoxForHighlight.Focus();
                    richTextBoxForHighlight.ScrollToCaret();
                    richTextBoxForHighlight.Select((int)formulasOrder[indOfFormulas], this.formulaLen);
                    richTextBoxForHighlight.SelectionColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("There is no such formulas in the initial file because of clean problem");
            }
        }
    }
}
