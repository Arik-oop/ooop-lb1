namespace View
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            groupBoxSearch = new GroupBox();
            groupBoxResults = new GroupBox();
            dataGridViewResults = new DataGridView();
            buttonClose = new Button();
            buttonSearch = new Button();
            textBoxSearchValue = new TextBox();
            comboBoxField = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxSearch.SuspendLayout();
            groupBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(groupBoxResults);
            groupBoxSearch.Controls.Add(buttonClose);
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Controls.Add(textBoxSearchValue);
            groupBoxSearch.Controls.Add(comboBoxField);
            groupBoxSearch.Controls.Add(label2);
            groupBoxSearch.Controls.Add(label1);
            groupBoxSearch.Location = new Point(12, 12);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(1052, 426);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Критерии поиска";
            // 
            // groupBoxResults
            // 
            groupBoxResults.Controls.Add(dataGridViewResults);
            groupBoxResults.Location = new Point(19, 129);
            groupBoxResults.Name = "groupBoxResults";
            groupBoxResults.Size = new Size(1014, 281);
            groupBoxResults.TabIndex = 6;
            groupBoxResults.TabStop = false;
            groupBoxResults.Text = "Результаты";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(16, 22);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(983, 242);
            dataGridViewResults.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(339, 86);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(258, 86);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.Location = new Point(258, 57);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(775, 23);
            textBoxSearchValue.TabIndex = 3;
            // 
            // comboBoxField
            // 
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Location = new Point(19, 57);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(177, 23);
            comboBoxField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 30);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Значение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Поле";
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1077, 450);
            Controls.Add(groupBoxSearch);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            MaximizeBox = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchForm";
            RightToLeft = RightToLeft.No;
            Text = "Поиск издания";
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSearch;
        private GroupBox groupBoxResults;
        private DataGridView dataGridViewResults;
        private Button buttonClose;
        private Button buttonSearch;
        private TextBox textBoxSearchValue;
        private ComboBox comboBoxField;
        private Label label2;
        private Label label1;
    }
}