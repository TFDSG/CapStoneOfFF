using System.Drawing;
using System.Windows.Forms;

namespace FF
{
    partial class FF
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FF));
            this.ShowAreaPanle = new System.Windows.Forms.Panel();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.panelOfFormula = new System.Windows.Forms.Panel();
            this.richTextBoxForHighlight = new System.Windows.Forms.RichTextBox();
            this.treeView1ForResults = new System.Windows.Forms.TreeView();
            this.comboBoxOfChooseText = new System.Windows.Forms.ComboBox();
            this.textBoxOfMinSize = new System.Windows.Forms.TextBox();
            this.labelOfDropDown = new System.Windows.Forms.Label();
            this.labelOfFormulaSize = new System.Windows.Forms.Label();
            this.listBoxOfCompareText = new System.Windows.Forms.ListBox();
            this.CleanText = new System.Windows.Forms.RichTextBox();
            this.panelForReplacingSymbols = new System.Windows.Forms.Panel();
            this.button_deleteReplace = new System.Windows.Forms.Button();
            this.checkedListBox1_replaceSymbos = new System.Windows.Forms.CheckedListBox();
            this.button_addReplace = new System.Windows.Forms.Button();
            this.textBox3_newSymbols = new System.Windows.Forms.TextBox();
            this.label1_replaceOld = new System.Windows.Forms.Label();
            this.textBox2_oldSysmbol = new System.Windows.Forms.TextBox();
            this.label2_replaceNew = new System.Windows.Forms.Label();
            this.panelForRemoveSymbols = new System.Windows.Forms.Panel();
            this.DeleteSymbols = new System.Windows.Forms.Button();
            this.AddSymbols = new System.Windows.Forms.Button();
            this.textBox1_endSysmbols = new System.Windows.Forms.TextBox();
            this.textBox1_startSymbol = new System.Windows.Forms.TextBox();
            this.label_EndSymbol = new System.Windows.Forms.Label();
            this.labelForAddFrontSymbols = new System.Windows.Forms.Label();
            this.checkedListBoxForRemoveSymbols = new System.Windows.Forms.CheckedListBox();
            this.checkBox1_replaceSequence = new System.Windows.Forms.CheckBox();
            this.checkBox1_removeSequence = new System.Windows.Forms.CheckBox();
            this.checkBox5_lowerCase = new System.Windows.Forms.CheckBox();
            this.checkBox4_removeExtraSpace = new System.Windows.Forms.CheckBox();
            this.checkBox3_RemovePunctuation = new System.Windows.Forms.CheckBox();
            this.checkBox2_removeRomanNumerals = new System.Windows.Forms.CheckBox();
            this.checkBox1_Number = new System.Windows.Forms.CheckBox();
            this.checkBox1_removeFooter = new System.Windows.Forms.CheckBox();
            this.checkBox_removeHeader = new System.Windows.Forms.CheckBox();
            this.ContextOftxt = new System.Windows.Forms.RichTextBox();
            this.BookList = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTheSutraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTheSutraToFormulasFindTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LibraryFunction = new System.Windows.Forms.Panel();
            this.labelForFormulasNum = new System.Windows.Forms.Label();
            this.InitialVersion = new System.Windows.Forms.Button();
            this.buttonOfFindFormulas = new System.Windows.Forms.Button();
            this.buttonForbackToList = new System.Windows.Forms.Button();
            this.buttonForNextone = new System.Windows.Forms.Button();
            this.buttonForLastOne = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.GetCleanTextButton = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.MunePanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Formula = new System.Windows.Forms.Button();
            this.CleanSetting = new System.Windows.Forms.Button();
            this.Library = new System.Windows.Forms.Button();
            this.LeftTopIntroduction = new System.Windows.Forms.Label();
            this.BaseTable = new System.Windows.Forms.TableLayoutPanel();
            this.UploadFiles = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripForCompareList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAreaPanle.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.panelOfFormula.SuspendLayout();
            this.panelForReplacingSymbols.SuspendLayout();
            this.panelForRemoveSymbols.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.LibraryFunction.SuspendLayout();
            this.MunePanel.SuspendLayout();
            this.BaseTable.SuspendLayout();
            this.contextMenuStripForCompareList.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowAreaPanle
            // 
            this.ShowAreaPanle.BackColor = System.Drawing.Color.Transparent;
            this.ShowAreaPanle.Controls.Add(this.SettingPanel);
            this.ShowAreaPanle.Controls.Add(this.ContextOftxt);
            this.ShowAreaPanle.Controls.Add(this.BookList);
            this.ShowAreaPanle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowAreaPanle.Location = new System.Drawing.Point(149, 86);
            this.ShowAreaPanle.Name = "ShowAreaPanle";
            this.ShowAreaPanle.Size = new System.Drawing.Size(827, 466);
            this.ShowAreaPanle.TabIndex = 3;
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.panelOfFormula);
            this.SettingPanel.Controls.Add(this.CleanText);
            this.SettingPanel.Controls.Add(this.panelForReplacingSymbols);
            this.SettingPanel.Controls.Add(this.panelForRemoveSymbols);
            this.SettingPanel.Controls.Add(this.checkBox1_replaceSequence);
            this.SettingPanel.Controls.Add(this.checkBox1_removeSequence);
            this.SettingPanel.Controls.Add(this.checkBox5_lowerCase);
            this.SettingPanel.Controls.Add(this.checkBox4_removeExtraSpace);
            this.SettingPanel.Controls.Add(this.checkBox3_RemovePunctuation);
            this.SettingPanel.Controls.Add(this.checkBox2_removeRomanNumerals);
            this.SettingPanel.Controls.Add(this.checkBox1_Number);
            this.SettingPanel.Controls.Add(this.checkBox1_removeFooter);
            this.SettingPanel.Controls.Add(this.checkBox_removeHeader);
            this.SettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(827, 466);
            this.SettingPanel.TabIndex = 2;
            this.SettingPanel.Visible = false;
            // 
            // panelOfFormula
            // 
            this.panelOfFormula.Controls.Add(this.richTextBoxForHighlight);
            this.panelOfFormula.Controls.Add(this.treeView1ForResults);
            this.panelOfFormula.Controls.Add(this.comboBoxOfChooseText);
            this.panelOfFormula.Controls.Add(this.textBoxOfMinSize);
            this.panelOfFormula.Controls.Add(this.labelOfDropDown);
            this.panelOfFormula.Controls.Add(this.labelOfFormulaSize);
            this.panelOfFormula.Controls.Add(this.listBoxOfCompareText);
            this.panelOfFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfFormula.Location = new System.Drawing.Point(0, 0);
            this.panelOfFormula.Name = "panelOfFormula";
            this.panelOfFormula.Size = new System.Drawing.Size(827, 466);
            this.panelOfFormula.TabIndex = 5;
            this.panelOfFormula.Visible = false;
            // 
            // richTextBoxForHighlight
            // 
            this.richTextBoxForHighlight.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxForHighlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxForHighlight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxForHighlight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.richTextBoxForHighlight.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxForHighlight.Name = "richTextBoxForHighlight";
            this.richTextBoxForHighlight.Size = new System.Drawing.Size(827, 466);
            this.richTextBoxForHighlight.TabIndex = 5;
            this.richTextBoxForHighlight.Text = "";
            this.richTextBoxForHighlight.Visible = false;
            // 
            // treeView1ForResults
            // 
            this.treeView1ForResults.BackColor = System.Drawing.Color.LightGray;
            this.treeView1ForResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1ForResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1ForResults.ForeColor = System.Drawing.Color.DodgerBlue;
            this.treeView1ForResults.Location = new System.Drawing.Point(0, 0);
            this.treeView1ForResults.Name = "treeView1ForResults";
            this.treeView1ForResults.Size = new System.Drawing.Size(827, 466);
            this.treeView1ForResults.TabIndex = 4;
            this.treeView1ForResults.Visible = false;
            this.treeView1ForResults.DoubleClick += new System.EventHandler(this.treeView1ForResults_DoubleClick);
            // 
            // comboBoxOfChooseText
            // 
            this.comboBoxOfChooseText.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxOfChooseText.DropDownHeight = 200;
            this.comboBoxOfChooseText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOfChooseText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBoxOfChooseText.FormattingEnabled = true;
            this.comboBoxOfChooseText.IntegralHeight = false;
            this.comboBoxOfChooseText.Location = new System.Drawing.Point(496, 84);
            this.comboBoxOfChooseText.Name = "comboBoxOfChooseText";
            this.comboBoxOfChooseText.Size = new System.Drawing.Size(289, 24);
            this.comboBoxOfChooseText.TabIndex = 3;
            this.comboBoxOfChooseText.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfChooseText_SelectedIndexChanged);
            // 
            // textBoxOfMinSize
            // 
            this.textBoxOfMinSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOfMinSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBoxOfMinSize.Location = new System.Drawing.Point(696, 362);
            this.textBoxOfMinSize.Name = "textBoxOfMinSize";
            this.textBoxOfMinSize.Size = new System.Drawing.Size(67, 26);
            this.textBoxOfMinSize.TabIndex = 2;
            this.textBoxOfMinSize.Text = "2";
            // 
            // labelOfDropDown
            // 
            this.labelOfDropDown.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfDropDown.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelOfDropDown.Location = new System.Drawing.Point(481, 28);
            this.labelOfDropDown.Name = "labelOfDropDown";
            this.labelOfDropDown.Size = new System.Drawing.Size(312, 30);
            this.labelOfDropDown.TabIndex = 1;
            this.labelOfDropDown.Text = "Choose your sutra from your library";
            // 
            // labelOfFormulaSize
            // 
            this.labelOfFormulaSize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfFormulaSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelOfFormulaSize.Location = new System.Drawing.Point(491, 360);
            this.labelOfFormulaSize.Name = "labelOfFormulaSize";
            this.labelOfFormulaSize.Size = new System.Drawing.Size(191, 32);
            this.labelOfFormulaSize.TabIndex = 1;
            this.labelOfFormulaSize.Text = "Min Size: (at least 2):";
            // 
            // listBoxOfCompareText
            // 
            this.listBoxOfCompareText.BackColor = System.Drawing.Color.LightGray;
            this.listBoxOfCompareText.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOfCompareText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBoxOfCompareText.FormattingEnabled = true;
            this.listBoxOfCompareText.ItemHeight = 23;
            this.listBoxOfCompareText.Location = new System.Drawing.Point(0, 1);
            this.listBoxOfCompareText.Name = "listBoxOfCompareText";
            this.listBoxOfCompareText.Size = new System.Drawing.Size(428, 441);
            this.listBoxOfCompareText.TabIndex = 0;
            this.listBoxOfCompareText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxOfCompareText_MouseDown);
            // 
            // CleanText
            // 
            this.CleanText.BackColor = System.Drawing.Color.LightGray;
            this.CleanText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CleanText.Location = new System.Drawing.Point(0, 0);
            this.CleanText.Name = "CleanText";
            this.CleanText.Size = new System.Drawing.Size(827, 466);
            this.CleanText.TabIndex = 4;
            this.CleanText.Text = "";
            this.CleanText.Visible = false;
            // 
            // panelForReplacingSymbols
            // 
            this.panelForReplacingSymbols.Controls.Add(this.button_deleteReplace);
            this.panelForReplacingSymbols.Controls.Add(this.checkedListBox1_replaceSymbos);
            this.panelForReplacingSymbols.Controls.Add(this.button_addReplace);
            this.panelForReplacingSymbols.Controls.Add(this.textBox3_newSymbols);
            this.panelForReplacingSymbols.Controls.Add(this.label1_replaceOld);
            this.panelForReplacingSymbols.Controls.Add(this.textBox2_oldSysmbol);
            this.panelForReplacingSymbols.Controls.Add(this.label2_replaceNew);
            this.panelForReplacingSymbols.Location = new System.Drawing.Point(563, 98);
            this.panelForReplacingSymbols.Name = "panelForReplacingSymbols";
            this.panelForReplacingSymbols.Size = new System.Drawing.Size(200, 287);
            this.panelForReplacingSymbols.TabIndex = 3;
            this.panelForReplacingSymbols.Visible = false;
            // 
            // button_deleteReplace
            // 
            this.button_deleteReplace.BackColor = System.Drawing.Color.Transparent;
            this.button_deleteReplace.FlatAppearance.BorderSize = 0;
            this.button_deleteReplace.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_deleteReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_deleteReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_deleteReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_deleteReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteReplace.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_deleteReplace.Location = new System.Drawing.Point(143, 260);
            this.button_deleteReplace.Name = "button_deleteReplace";
            this.button_deleteReplace.Size = new System.Drawing.Size(50, 20);
            this.button_deleteReplace.TabIndex = 4;
            this.button_deleteReplace.Text = "Delete";
            this.button_deleteReplace.UseVisualStyleBackColor = true;
            this.button_deleteReplace.Click += new System.EventHandler(this.button_deleteReplace_Click);
            // 
            // checkedListBox1_replaceSymbos
            // 
            this.checkedListBox1_replaceSymbos.BackColor = System.Drawing.Color.LightGray;
            this.checkedListBox1_replaceSymbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1_replaceSymbos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkedListBox1_replaceSymbos.FormattingEnabled = true;
            this.checkedListBox1_replaceSymbos.Items.AddRange(new object[] {
            "ṉ   switch to   n",
            "Ś   switch to   S",
            "Ḍ   switch to   D",
            "remove   n\'"});
            this.checkedListBox1_replaceSymbos.Location = new System.Drawing.Point(14, 3);
            this.checkedListBox1_replaceSymbos.Name = "checkedListBox1_replaceSymbos";
            this.checkedListBox1_replaceSymbos.Size = new System.Drawing.Size(157, 214);
            this.checkedListBox1_replaceSymbos.TabIndex = 1;
            // 
            // button_addReplace
            // 
            this.button_addReplace.BackColor = System.Drawing.Color.Transparent;
            this.button_addReplace.FlatAppearance.BorderSize = 0;
            this.button_addReplace.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_addReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_addReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_addReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addReplace.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_addReplace.Location = new System.Drawing.Point(143, 237);
            this.button_addReplace.Name = "button_addReplace";
            this.button_addReplace.Size = new System.Drawing.Size(50, 20);
            this.button_addReplace.TabIndex = 4;
            this.button_addReplace.Text = "Add";
            this.button_addReplace.UseVisualStyleBackColor = true;
            this.button_addReplace.Click += new System.EventHandler(this.button_addReplace_Click);
            // 
            // textBox3_newSymbols
            // 
            this.textBox3_newSymbols.Location = new System.Drawing.Point(72, 263);
            this.textBox3_newSymbols.Name = "textBox3_newSymbols";
            this.textBox3_newSymbols.Size = new System.Drawing.Size(59, 20);
            this.textBox3_newSymbols.TabIndex = 3;
            // 
            // label1_replaceOld
            // 
            this.label1_replaceOld.AutoSize = true;
            this.label1_replaceOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_replaceOld.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1_replaceOld.Location = new System.Drawing.Point(25, 241);
            this.label1_replaceOld.Name = "label1_replaceOld";
            this.label1_replaceOld.Size = new System.Drawing.Size(26, 13);
            this.label1_replaceOld.TabIndex = 2;
            this.label1_replaceOld.Text = "Old:";
            // 
            // textBox2_oldSysmbol
            // 
            this.textBox2_oldSysmbol.Location = new System.Drawing.Point(72, 239);
            this.textBox2_oldSysmbol.Name = "textBox2_oldSysmbol";
            this.textBox2_oldSysmbol.Size = new System.Drawing.Size(59, 20);
            this.textBox2_oldSysmbol.TabIndex = 3;
            // 
            // label2_replaceNew
            // 
            this.label2_replaceNew.AutoSize = true;
            this.label2_replaceNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_replaceNew.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2_replaceNew.Location = new System.Drawing.Point(25, 266);
            this.label2_replaceNew.Name = "label2_replaceNew";
            this.label2_replaceNew.Size = new System.Drawing.Size(32, 13);
            this.label2_replaceNew.TabIndex = 2;
            this.label2_replaceNew.Text = "New:";
            // 
            // panelForRemoveSymbols
            // 
            this.panelForRemoveSymbols.Controls.Add(this.DeleteSymbols);
            this.panelForRemoveSymbols.Controls.Add(this.AddSymbols);
            this.panelForRemoveSymbols.Controls.Add(this.textBox1_endSysmbols);
            this.panelForRemoveSymbols.Controls.Add(this.textBox1_startSymbol);
            this.panelForRemoveSymbols.Controls.Add(this.label_EndSymbol);
            this.panelForRemoveSymbols.Controls.Add(this.labelForAddFrontSymbols);
            this.panelForRemoveSymbols.Controls.Add(this.checkedListBoxForRemoveSymbols);
            this.panelForRemoveSymbols.Location = new System.Drawing.Point(304, 98);
            this.panelForRemoveSymbols.Name = "panelForRemoveSymbols";
            this.panelForRemoveSymbols.Size = new System.Drawing.Size(200, 287);
            this.panelForRemoveSymbols.TabIndex = 2;
            this.panelForRemoveSymbols.Visible = false;
            // 
            // DeleteSymbols
            // 
            this.DeleteSymbols.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSymbols.FlatAppearance.BorderSize = 0;
            this.DeleteSymbols.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DeleteSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSymbols.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSymbols.Location = new System.Drawing.Point(142, 263);
            this.DeleteSymbols.Name = "DeleteSymbols";
            this.DeleteSymbols.Size = new System.Drawing.Size(50, 20);
            this.DeleteSymbols.TabIndex = 4;
            this.DeleteSymbols.Text = "Delete";
            this.DeleteSymbols.UseVisualStyleBackColor = true;
            this.DeleteSymbols.Click += new System.EventHandler(this.DeleteSymbols_Click);
            // 
            // AddSymbols
            // 
            this.AddSymbols.BackColor = System.Drawing.Color.Transparent;
            this.AddSymbols.FlatAppearance.BorderSize = 0;
            this.AddSymbols.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AddSymbols.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddSymbols.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddSymbols.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSymbols.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddSymbols.Location = new System.Drawing.Point(142, 236);
            this.AddSymbols.Name = "AddSymbols";
            this.AddSymbols.Size = new System.Drawing.Size(50, 20);
            this.AddSymbols.TabIndex = 4;
            this.AddSymbols.Text = "Add";
            this.AddSymbols.UseVisualStyleBackColor = true;
            this.AddSymbols.Click += new System.EventHandler(this.AddSymbols_Click);
            // 
            // textBox1_endSysmbols
            // 
            this.textBox1_endSysmbols.Location = new System.Drawing.Point(77, 262);
            this.textBox1_endSysmbols.Name = "textBox1_endSysmbols";
            this.textBox1_endSysmbols.Size = new System.Drawing.Size(59, 20);
            this.textBox1_endSysmbols.TabIndex = 3;
            // 
            // textBox1_startSymbol
            // 
            this.textBox1_startSymbol.Location = new System.Drawing.Point(77, 238);
            this.textBox1_startSymbol.Name = "textBox1_startSymbol";
            this.textBox1_startSymbol.Size = new System.Drawing.Size(59, 20);
            this.textBox1_startSymbol.TabIndex = 3;
            // 
            // label_EndSymbol
            // 
            this.label_EndSymbol.AutoSize = true;
            this.label_EndSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EndSymbol.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_EndSymbol.Location = new System.Drawing.Point(14, 265);
            this.label_EndSymbol.Name = "label_EndSymbol";
            this.label_EndSymbol.Size = new System.Drawing.Size(54, 13);
            this.label_EndSymbol.TabIndex = 2;
            this.label_EndSymbol.Text = "End With:";
            // 
            // labelForAddFrontSymbols
            // 
            this.labelForAddFrontSymbols.AutoSize = true;
            this.labelForAddFrontSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForAddFrontSymbols.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelForAddFrontSymbols.Location = new System.Drawing.Point(14, 241);
            this.labelForAddFrontSymbols.Name = "labelForAddFrontSymbols";
            this.labelForAddFrontSymbols.Size = new System.Drawing.Size(57, 13);
            this.labelForAddFrontSymbols.TabIndex = 2;
            this.labelForAddFrontSymbols.Text = "Start With:";
            // 
            // checkedListBoxForRemoveSymbols
            // 
            this.checkedListBoxForRemoveSymbols.BackColor = System.Drawing.Color.LightGray;
            this.checkedListBoxForRemoveSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxForRemoveSymbols.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkedListBoxForRemoveSymbols.FormattingEnabled = true;
            this.checkedListBoxForRemoveSymbols.Items.AddRange(new object[] {
            "*[   and   ]*",
            "[   and   ]",
            "/   and   /",
            "(   and   )"});
            this.checkedListBoxForRemoveSymbols.Location = new System.Drawing.Point(14, 3);
            this.checkedListBoxForRemoveSymbols.Name = "checkedListBoxForRemoveSymbols";
            this.checkedListBoxForRemoveSymbols.Size = new System.Drawing.Size(157, 214);
            this.checkedListBoxForRemoveSymbols.TabIndex = 1;
            // 
            // checkBox1_replaceSequence
            // 
            this.checkBox1_replaceSequence.AutoSize = true;
            this.checkBox1_replaceSequence.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_replaceSequence.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1_replaceSequence.Location = new System.Drawing.Point(577, 51);
            this.checkBox1_replaceSequence.Name = "checkBox1_replaceSequence";
            this.checkBox1_replaceSequence.Size = new System.Drawing.Size(144, 27);
            this.checkBox1_replaceSequence.TabIndex = 0;
            this.checkBox1_replaceSequence.Text = "Replace Sequence";
            this.checkBox1_replaceSequence.UseVisualStyleBackColor = true;
            this.checkBox1_replaceSequence.CheckedChanged += new System.EventHandler(this.checkBox1_replaceSequence_CheckedChanged);
            // 
            // checkBox1_removeSequence
            // 
            this.checkBox1_removeSequence.AutoSize = true;
            this.checkBox1_removeSequence.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_removeSequence.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1_removeSequence.Location = new System.Drawing.Point(318, 51);
            this.checkBox1_removeSequence.Name = "checkBox1_removeSequence";
            this.checkBox1_removeSequence.Size = new System.Drawing.Size(144, 27);
            this.checkBox1_removeSequence.TabIndex = 0;
            this.checkBox1_removeSequence.Text = "Remove Sequence";
            this.checkBox1_removeSequence.UseVisualStyleBackColor = true;
            this.checkBox1_removeSequence.CheckedChanged += new System.EventHandler(this.checkBox1_removeSequence_CheckedChanged);
            // 
            // checkBox5_lowerCase
            // 
            this.checkBox5_lowerCase.AutoSize = true;
            this.checkBox5_lowerCase.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5_lowerCase.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox5_lowerCase.Location = new System.Drawing.Point(53, 339);
            this.checkBox5_lowerCase.Name = "checkBox5_lowerCase";
            this.checkBox5_lowerCase.Size = new System.Drawing.Size(102, 27);
            this.checkBox5_lowerCase.TabIndex = 0;
            this.checkBox5_lowerCase.Text = "Lower case";
            this.checkBox5_lowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBox4_removeExtraSpace
            // 
            this.checkBox4_removeExtraSpace.AutoSize = true;
            this.checkBox4_removeExtraSpace.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4_removeExtraSpace.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox4_removeExtraSpace.Location = new System.Drawing.Point(53, 291);
            this.checkBox4_removeExtraSpace.Name = "checkBox4_removeExtraSpace";
            this.checkBox4_removeExtraSpace.Size = new System.Drawing.Size(205, 27);
            this.checkBox4_removeExtraSpace.TabIndex = 0;
            this.checkBox4_removeExtraSpace.Text = "Remove  Extra Whitespace";
            this.checkBox4_removeExtraSpace.UseVisualStyleBackColor = true;
            // 
            // checkBox3_RemovePunctuation
            // 
            this.checkBox3_RemovePunctuation.AutoSize = true;
            this.checkBox3_RemovePunctuation.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3_RemovePunctuation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox3_RemovePunctuation.Location = new System.Drawing.Point(53, 243);
            this.checkBox3_RemovePunctuation.Name = "checkBox3_RemovePunctuation";
            this.checkBox3_RemovePunctuation.Size = new System.Drawing.Size(165, 27);
            this.checkBox3_RemovePunctuation.TabIndex = 0;
            this.checkBox3_RemovePunctuation.Text = "Remove Punctuation";
            this.checkBox3_RemovePunctuation.UseVisualStyleBackColor = true;
            // 
            // checkBox2_removeRomanNumerals
            // 
            this.checkBox2_removeRomanNumerals.AutoSize = true;
            this.checkBox2_removeRomanNumerals.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2_removeRomanNumerals.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox2_removeRomanNumerals.Location = new System.Drawing.Point(53, 195);
            this.checkBox2_removeRomanNumerals.Name = "checkBox2_removeRomanNumerals";
            this.checkBox2_removeRomanNumerals.Size = new System.Drawing.Size(199, 27);
            this.checkBox2_removeRomanNumerals.TabIndex = 0;
            this.checkBox2_removeRomanNumerals.Text = "Remove Roman Numerals";
            this.checkBox2_removeRomanNumerals.UseVisualStyleBackColor = true;
            // 
            // checkBox1_Number
            // 
            this.checkBox1_Number.AutoSize = true;
            this.checkBox1_Number.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_Number.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1_Number.Location = new System.Drawing.Point(53, 147);
            this.checkBox1_Number.Name = "checkBox1_Number";
            this.checkBox1_Number.Size = new System.Drawing.Size(138, 27);
            this.checkBox1_Number.TabIndex = 0;
            this.checkBox1_Number.Text = "Remove Number";
            this.checkBox1_Number.UseVisualStyleBackColor = true;
            // 
            // checkBox1_removeFooter
            // 
            this.checkBox1_removeFooter.AutoSize = true;
            this.checkBox1_removeFooter.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_removeFooter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox1_removeFooter.Location = new System.Drawing.Point(53, 99);
            this.checkBox1_removeFooter.Name = "checkBox1_removeFooter";
            this.checkBox1_removeFooter.Size = new System.Drawing.Size(126, 27);
            this.checkBox1_removeFooter.TabIndex = 0;
            this.checkBox1_removeFooter.Text = "Remove Footer";
            this.checkBox1_removeFooter.UseVisualStyleBackColor = true;
            // 
            // checkBox_removeHeader
            // 
            this.checkBox_removeHeader.AutoSize = true;
            this.checkBox_removeHeader.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_removeHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkBox_removeHeader.Location = new System.Drawing.Point(53, 51);
            this.checkBox_removeHeader.Name = "checkBox_removeHeader";
            this.checkBox_removeHeader.Size = new System.Drawing.Size(132, 27);
            this.checkBox_removeHeader.TabIndex = 0;
            this.checkBox_removeHeader.Text = "Remove Header";
            this.checkBox_removeHeader.UseVisualStyleBackColor = true;
            // 
            // ContextOftxt
            // 
            this.ContextOftxt.BackColor = System.Drawing.Color.LightGray;
            this.ContextOftxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContextOftxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextOftxt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ContextOftxt.Location = new System.Drawing.Point(0, 0);
            this.ContextOftxt.Name = "ContextOftxt";
            this.ContextOftxt.Size = new System.Drawing.Size(827, 466);
            this.ContextOftxt.TabIndex = 1;
            this.ContextOftxt.Text = "";
            this.ContextOftxt.Visible = false;
            // 
            // BookList
            // 
            this.BookList.BackColor = System.Drawing.Color.LightGray;
            this.BookList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookList.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BookList.HideSelection = false;
            this.BookList.Location = new System.Drawing.Point(0, 0);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(827, 466);
            this.BookList.TabIndex = 0;
            this.BookList.UseCompatibleStateImageBehavior = false;
            this.BookList.View = System.Windows.Forms.View.List;
            this.BookList.Visible = false;
            this.BookList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookList_MouseClick);
            this.BookList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookList_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTheSutraToolStripMenuItem,
            this.addTheSutraToFormulasFindTableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(286, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteTheSutraToolStripMenuItem
            // 
            this.deleteTheSutraToolStripMenuItem.Name = "deleteTheSutraToolStripMenuItem";
            this.deleteTheSutraToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.deleteTheSutraToolStripMenuItem.Text = "Delete the sutra?";
            this.deleteTheSutraToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deleteTheSutraToolStripMenuItem_MouseDown);
            // 
            // addTheSutraToFormulasFindTableToolStripMenuItem
            // 
            this.addTheSutraToFormulasFindTableToolStripMenuItem.Name = "addTheSutraToFormulasFindTableToolStripMenuItem";
            this.addTheSutraToFormulasFindTableToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.addTheSutraToFormulasFindTableToolStripMenuItem.Text = "Add the sutra to formulas find table";
            this.addTheSutraToFormulasFindTableToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addTheSutraToFormulasFindTableToolStripMenuItem_MouseDown);
            // 
            // LibraryFunction
            // 
            this.LibraryFunction.BackColor = System.Drawing.Color.Transparent;
            this.LibraryFunction.Controls.Add(this.labelForFormulasNum);
            this.LibraryFunction.Controls.Add(this.InitialVersion);
            this.LibraryFunction.Controls.Add(this.buttonOfFindFormulas);
            this.LibraryFunction.Controls.Add(this.buttonForbackToList);
            this.LibraryFunction.Controls.Add(this.buttonForNextone);
            this.LibraryFunction.Controls.Add(this.buttonForLastOne);
            this.LibraryFunction.Controls.Add(this.Save);
            this.LibraryFunction.Controls.Add(this.GetCleanTextButton);
            this.LibraryFunction.Controls.Add(this.Upload);
            this.LibraryFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryFunction.Location = new System.Drawing.Point(149, 3);
            this.LibraryFunction.Name = "LibraryFunction";
            this.LibraryFunction.Size = new System.Drawing.Size(827, 77);
            this.LibraryFunction.TabIndex = 2;
            // 
            // labelForFormulasNum
            // 
            this.labelForFormulasNum.AutoSize = true;
            this.labelForFormulasNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForFormulasNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelForFormulasNum.Location = new System.Drawing.Point(275, 48);
            this.labelForFormulasNum.Name = "labelForFormulasNum";
            this.labelForFormulasNum.Size = new System.Drawing.Size(0, 18);
            this.labelForFormulasNum.TabIndex = 1;
            this.labelForFormulasNum.Visible = false;
            // 
            // InitialVersion
            // 
            this.InitialVersion.BackColor = System.Drawing.Color.Transparent;
            this.InitialVersion.FlatAppearance.BorderSize = 0;
            this.InitialVersion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.InitialVersion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.InitialVersion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.InitialVersion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InitialVersion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialVersion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.InitialVersion.Location = new System.Drawing.Point(0, 3);
            this.InitialVersion.Name = "InitialVersion";
            this.InitialVersion.Size = new System.Drawing.Size(120, 71);
            this.InitialVersion.TabIndex = 0;
            this.InitialVersion.Text = "Back to initial";
            this.InitialVersion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InitialVersion.UseVisualStyleBackColor = true;
            this.InitialVersion.Visible = false;
            this.InitialVersion.Click += new System.EventHandler(this.InitialVersion_Click);
            // 
            // buttonOfFindFormulas
            // 
            this.buttonOfFindFormulas.BackColor = System.Drawing.Color.Transparent;
            this.buttonOfFindFormulas.FlatAppearance.BorderSize = 0;
            this.buttonOfFindFormulas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonOfFindFormulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOfFindFormulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOfFindFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOfFindFormulas.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOfFindFormulas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonOfFindFormulas.Location = new System.Drawing.Point(0, 3);
            this.buttonOfFindFormulas.Name = "buttonOfFindFormulas";
            this.buttonOfFindFormulas.Size = new System.Drawing.Size(120, 71);
            this.buttonOfFindFormulas.TabIndex = 0;
            this.buttonOfFindFormulas.Text = "Get Formulas";
            this.buttonOfFindFormulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOfFindFormulas.UseVisualStyleBackColor = true;
            this.buttonOfFindFormulas.Visible = false;
            this.buttonOfFindFormulas.Click += new System.EventHandler(this.buttonOfFindFormulas_Click);
            // 
            // buttonForbackToList
            // 
            this.buttonForbackToList.BackColor = System.Drawing.Color.Transparent;
            this.buttonForbackToList.FlatAppearance.BorderSize = 0;
            this.buttonForbackToList.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonForbackToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonForbackToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForbackToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonForbackToList.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForbackToList.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonForbackToList.Location = new System.Drawing.Point(263, 9);
            this.buttonForbackToList.Name = "buttonForbackToList";
            this.buttonForbackToList.Size = new System.Drawing.Size(95, 28);
            this.buttonForbackToList.TabIndex = 0;
            this.buttonForbackToList.Text = "Back to List";
            this.buttonForbackToList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonForbackToList.UseVisualStyleBackColor = true;
            this.buttonForbackToList.Visible = false;
            this.buttonForbackToList.Click += new System.EventHandler(this.buttonForbackToList_Click);
            // 
            // buttonForNextone
            // 
            this.buttonForNextone.BackColor = System.Drawing.Color.Transparent;
            this.buttonForNextone.FlatAppearance.BorderSize = 0;
            this.buttonForNextone.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonForNextone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonForNextone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForNextone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonForNextone.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForNextone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonForNextone.Location = new System.Drawing.Point(126, 3);
            this.buttonForNextone.Name = "buttonForNextone";
            this.buttonForNextone.Size = new System.Drawing.Size(120, 71);
            this.buttonForNextone.TabIndex = 0;
            this.buttonForNextone.Text = "Next One";
            this.buttonForNextone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonForNextone.UseVisualStyleBackColor = true;
            this.buttonForNextone.Visible = false;
            this.buttonForNextone.Click += new System.EventHandler(this.buttonForNextone_Click);
            // 
            // buttonForLastOne
            // 
            this.buttonForLastOne.BackColor = System.Drawing.Color.Transparent;
            this.buttonForLastOne.FlatAppearance.BorderSize = 0;
            this.buttonForLastOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonForLastOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonForLastOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonForLastOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonForLastOne.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForLastOne.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonForLastOne.Location = new System.Drawing.Point(0, 3);
            this.buttonForLastOne.Name = "buttonForLastOne";
            this.buttonForLastOne.Size = new System.Drawing.Size(120, 71);
            this.buttonForLastOne.TabIndex = 0;
            this.buttonForLastOne.Text = "Last One";
            this.buttonForLastOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonForLastOne.UseVisualStyleBackColor = true;
            this.buttonForLastOne.Visible = false;
            this.buttonForLastOne.Click += new System.EventHandler(this.buttonForLastOne_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Save.Location = new System.Drawing.Point(126, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 71);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // GetCleanTextButton
            // 
            this.GetCleanTextButton.BackColor = System.Drawing.Color.Transparent;
            this.GetCleanTextButton.FlatAppearance.BorderSize = 0;
            this.GetCleanTextButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.GetCleanTextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GetCleanTextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GetCleanTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetCleanTextButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetCleanTextButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GetCleanTextButton.Location = new System.Drawing.Point(0, 3);
            this.GetCleanTextButton.Name = "GetCleanTextButton";
            this.GetCleanTextButton.Size = new System.Drawing.Size(120, 71);
            this.GetCleanTextButton.TabIndex = 0;
            this.GetCleanTextButton.Text = "Clean Version";
            this.GetCleanTextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GetCleanTextButton.UseVisualStyleBackColor = true;
            this.GetCleanTextButton.Visible = false;
            this.GetCleanTextButton.Click += new System.EventHandler(this.GetCleanTextButton_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Transparent;
            this.Upload.FlatAppearance.BorderSize = 0;
            this.Upload.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Upload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upload.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Upload.Location = new System.Drawing.Point(0, 3);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(120, 71);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Visible = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // MunePanel
            // 
            this.MunePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MunePanel.BackColor = System.Drawing.Color.Transparent;
            this.MunePanel.Controls.Add(this.Exit);
            this.MunePanel.Controls.Add(this.Formula);
            this.MunePanel.Controls.Add(this.CleanSetting);
            this.MunePanel.Controls.Add(this.Library);
            this.MunePanel.Location = new System.Drawing.Point(3, 86);
            this.MunePanel.Name = "MunePanel";
            this.MunePanel.Size = new System.Drawing.Size(140, 466);
            this.MunePanel.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Exit.Location = new System.Drawing.Point(18, 381);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 64);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Formula
            // 
            this.Formula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Formula.BackColor = System.Drawing.Color.Transparent;
            this.Formula.FlatAppearance.BorderSize = 0;
            this.Formula.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Formula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Formula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Formula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Formula.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formula.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Formula.Location = new System.Drawing.Point(18, 177);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(90, 36);
            this.Formula.TabIndex = 0;
            this.Formula.Text = "Formulas";
            this.Formula.UseVisualStyleBackColor = true;
            this.Formula.Click += new System.EventHandler(this.Formula_Click);
            // 
            // CleanSetting
            // 
            this.CleanSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanSetting.BackColor = System.Drawing.Color.Transparent;
            this.CleanSetting.FlatAppearance.BorderSize = 0;
            this.CleanSetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CleanSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CleanSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CleanSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanSetting.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanSetting.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CleanSetting.Location = new System.Drawing.Point(18, 110);
            this.CleanSetting.Name = "CleanSetting";
            this.CleanSetting.Size = new System.Drawing.Size(90, 36);
            this.CleanSetting.TabIndex = 0;
            this.CleanSetting.Text = "Setting";
            this.CleanSetting.UseVisualStyleBackColor = true;
            this.CleanSetting.Click += new System.EventHandler(this.cleanSetButton_click);
            // 
            // Library
            // 
            this.Library.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Library.BackColor = System.Drawing.Color.Transparent;
            this.Library.FlatAppearance.BorderSize = 0;
            this.Library.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Library.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Library.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Library.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Library.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Library.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Library.Location = new System.Drawing.Point(18, 45);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(90, 36);
            this.Library.TabIndex = 0;
            this.Library.Text = "Library";
            this.Library.UseVisualStyleBackColor = true;
            this.Library.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // LeftTopIntroduction
            // 
            this.LeftTopIntroduction.AutoSize = true;
            this.LeftTopIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.LeftTopIntroduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftTopIntroduction.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTopIntroduction.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LeftTopIntroduction.Location = new System.Drawing.Point(3, 0);
            this.LeftTopIntroduction.Name = "LeftTopIntroduction";
            this.LeftTopIntroduction.Size = new System.Drawing.Size(140, 83);
            this.LeftTopIntroduction.TabIndex = 0;
            this.LeftTopIntroduction.Text = "Welcome to Formulas Finder\r\nAuthor: Dan Zhao\r\nVersion: 1.0\r\n";
            this.LeftTopIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseTable
            // 
            this.BaseTable.BackgroundImage = global::FF.Properties.Resources.FF_backgroud_blackandwhite;
            this.BaseTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BaseTable.ColumnCount = 2;
            this.BaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BaseTable.Controls.Add(this.LeftTopIntroduction, 0, 0);
            this.BaseTable.Controls.Add(this.MunePanel, 0, 1);
            this.BaseTable.Controls.Add(this.LibraryFunction, 1, 0);
            this.BaseTable.Controls.Add(this.ShowAreaPanle, 1, 1);
            this.BaseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseTable.Location = new System.Drawing.Point(0, 0);
            this.BaseTable.Name = "BaseTable";
            this.BaseTable.RowCount = 2;
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BaseTable.Size = new System.Drawing.Size(979, 555);
            this.BaseTable.TabIndex = 0;
            // 
            // contextMenuStripForCompareList
            // 
            this.contextMenuStripForCompareList.BackColor = System.Drawing.Color.LightGray;
            this.contextMenuStripForCompareList.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripForCompareList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.contextMenuStripForCompareList.Name = "contextMenuStripForCompareList";
            this.contextMenuStripForCompareList.Size = new System.Drawing.Size(146, 32);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 28);
            this.Delete.Text = "Delete it?";
            this.Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Delete_MouseDown);
            // 
            // FF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::FF.Properties.Resources.FF_backgroud_blackandwhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 555);
            this.Controls.Add(this.BaseTable);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FF";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Formula Finder";
            this.ShowAreaPanle.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.panelOfFormula.ResumeLayout(false);
            this.panelOfFormula.PerformLayout();
            this.panelForReplacingSymbols.ResumeLayout(false);
            this.panelForReplacingSymbols.PerformLayout();
            this.panelForRemoveSymbols.ResumeLayout(false);
            this.panelForRemoveSymbols.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.LibraryFunction.ResumeLayout(false);
            this.LibraryFunction.PerformLayout();
            this.MunePanel.ResumeLayout(false);
            this.BaseTable.ResumeLayout(false);
            this.BaseTable.PerformLayout();
            this.contextMenuStripForCompareList.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel ShowAreaPanle;
        private Panel LibraryFunction;
        private Button GetCleanTextButton;
        private Button Upload;
        private Panel MunePanel;
        private Button Exit;
        private Button Formula;
        private Button Library;
        private Label LeftTopIntroduction;
        private TableLayoutPanel BaseTable;
        private OpenFileDialog UploadFiles;
        private ListView BookList;
        private RichTextBox ContextOftxt;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteTheSutraToolStripMenuItem;
        private ToolStripMenuItem addTheSutraToFormulasFindTableToolStripMenuItem;
        private Button CleanSetting;
        private Panel SettingPanel;
        private CheckBox checkBox_removeHeader;
        private CheckBox checkBox1_removeSequence;
        private CheckBox checkBox1_replaceSequence;
        private CheckBox checkBox5_lowerCase;
        private CheckBox checkBox4_removeExtraSpace;
        private CheckBox checkBox3_RemovePunctuation;
        private CheckBox checkBox2_removeRomanNumerals;
        private CheckBox checkBox1_Number;
        private CheckBox checkBox1_removeFooter;
        private Panel panelForReplacingSymbols;
        private Button button_deleteReplace;
        private CheckedListBox checkedListBox1_replaceSymbos;
        private Button button_addReplace;
        private TextBox textBox3_newSymbols;
        private Label label1_replaceOld;
        private TextBox textBox2_oldSysmbol;
        private Label label2_replaceNew;
        private Panel panelForRemoveSymbols;
        private Button DeleteSymbols;
        private Button AddSymbols;
        private TextBox textBox1_endSysmbols;
        private TextBox textBox1_startSymbol;
        private Label label_EndSymbol;
        private Label labelForAddFrontSymbols;
        private CheckedListBox checkedListBoxForRemoveSymbols;
        private RichTextBox CleanText;
        private Button InitialVersion;
        private Button Save;
        private SaveFileDialog saveFileDialog1;
        private Panel panelOfFormula;
        private ComboBox comboBoxOfChooseText;
        private TextBox textBoxOfMinSize;
        private Label labelOfDropDown;
        private Label labelOfFormulaSize;
        private ListBox listBoxOfCompareText;
        private Button buttonOfFindFormulas;
        private ContextMenuStrip contextMenuStripForCompareList;
        private ToolStripMenuItem Delete;
        private RichTextBox richTextBoxForHighlight;
        private TreeView treeView1ForResults;
        private Button buttonForNextone;
        private Button buttonForLastOne;
        private Label labelForFormulasNum;
        private Button buttonForbackToList;
    }
}

