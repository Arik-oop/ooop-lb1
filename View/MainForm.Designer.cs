namespace View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBoxPublications = new GroupBox();
            dataGridViewPublications = new DataGridView();
            buttonAddPublication = new Button();
            buttonRemovePublication = new Button();
            buttonSearch = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            groupBoxPublications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPublications).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPublications
            // 
            groupBoxPublications.Controls.Add(dataGridViewPublications);
            groupBoxPublications.Location = new Point(12, 12);
            groupBoxPublications.Name = "groupBoxPublications";
            groupBoxPublications.Size = new Size(1193, 296);
            groupBoxPublications.TabIndex = 0;
            groupBoxPublications.TabStop = false;
            groupBoxPublications.Text = "База изданий";
            // 
            // dataGridViewPublications
            // 
            dataGridViewPublications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPublications.Location = new Point(6, 22);
            dataGridViewPublications.Name = "dataGridViewPublications";
            dataGridViewPublications.Size = new Size(1181, 268);
            dataGridViewPublications.TabIndex = 0;
            // 
            // buttonAddPublication
            // 
            buttonAddPublication.Location = new Point(260, 314);
            buttonAddPublication.Name = "buttonAddPublication";
            buttonAddPublication.Size = new Size(195, 31);
            buttonAddPublication.TabIndex = 1;
            buttonAddPublication.Text = "Добавить издание";
            buttonAddPublication.UseVisualStyleBackColor = true;
            buttonAddPublication.Click += ButtonAddPublication_Click;
            // 
            // buttonRemovePublication
            // 
            buttonRemovePublication.Location = new Point(506, 314);
            buttonRemovePublication.Name = "buttonRemovePublication";
            buttonRemovePublication.Size = new Size(195, 31);
            buttonRemovePublication.TabIndex = 2;
            buttonRemovePublication.Text = "Удалить издание";
            buttonRemovePublication.UseVisualStyleBackColor = true;
            buttonRemovePublication.Click += ButtonRemovePublication_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(12, 314);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(195, 31);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Поиск издания";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1004, 314);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(195, 31);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(755, 314);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(195, 31);
            buttonLoad.TabIndex = 5;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += ButtonLoad_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 353);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonSearch);
            Controls.Add(buttonRemovePublication);
            Controls.Add(buttonAddPublication);
            Controls.Add(groupBoxPublications);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Электронная библиотека";
            groupBoxPublications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPublications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPublications;
        private DataGridView dataGridViewPublications;
        private Button buttonAddPublication;
        private Button buttonRemovePublication;
        private Button buttonSearch;
        private Button buttonSave;
        private Button buttonLoad;
    }
}