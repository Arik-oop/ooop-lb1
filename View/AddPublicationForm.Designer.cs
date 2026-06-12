namespace View
{
    partial class AddPublicationForm
    {
        /// <summary>
        /// Контейнер компонентов.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождает ресурсы, используемые формой.
        /// </summary>
        /// <param name="disposing">
        /// true, если вызван управляемый ресурс.</param>
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
        /// Требуемый метод для поддержки конструктора.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(
                    typeof(AddPublicationForm));
            groupBoxType = new GroupBox();
            buttonRandomData = new Button();
            buttonCancel = new Button();
            buttonOk = new Button();
            groupBoxBook = new GroupBox();
            label9 = new Label();
            label5 = new Label();
            label1 = new Label();
            label7 = new Label();
            textBookPages = new TextBox();
            label6 = new Label();
            textBookYear = new TextBox();
            textBookPublisher = new TextBox();
            label4 = new Label();
            textBookPlace = new TextBox();
            textBookTitleInfo = new TextBox();
            label2 = new Label();
            textBookTitle = new TextBox();
            textBookAuthors = new TextBox();
            radioButtonDissertation = new RadioButton();
            radioButtonCollection = new RadioButton();
            radioButtonJournal = new RadioButton();
            radioButtonBook = new RadioButton();
            groupBoxJournal = new GroupBox();
            label29 = new Label();
            textJournalFrequency = new TextBox();
            label18 = new Label();
            label8 = new Label();
            textJournalPlace = new TextBox();
            textJournalPages = new TextBox();
            textJournalYear = new TextBox();
            textJournalTitle = new TextBox();
            textJournalPublisher = new TextBox();
            textJournalTitleInfo = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBoxCollection = new GroupBox();
            label30 = new Label();
            textCollectionResponsibleEditors = new TextBox();
            label21 = new Label();
            label31 = new Label();
            textCollectionEditorialBoard = new TextBox();
            textCollectionPlace = new TextBox();
            textCollectionPages = new TextBox();
            label15 = new Label();
            textCollectionYear = new TextBox();
            textCollectionTitle = new TextBox();
            label16 = new Label();
            textCollectionPublisher = new TextBox();
            label17 = new Label();
            textCollectionTitleInfo = new TextBox();
            label19 = new Label();
            label20 = new Label();
            groupBoxDissertation = new GroupBox();
            label32 = new Label();
            textDissertationDegree = new TextBox();
            textDissertationSpeciality = new TextBox();
            textDissertationAuthorFull = new TextBox();
            label33 = new Label();
            textDissertationTitleInfo = new TextBox();
            textDissertationPages = new TextBox();
            textDissertationYear = new TextBox();
            label34 = new Label();
            textDissertationTitle = new TextBox();
            label22 = new Label();
            label26 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label27 = new Label();
            textDissertationPublisher = new TextBox();
            textDissertationPlace = new TextBox();
            groupBoxType.SuspendLayout();
            groupBoxBook.SuspendLayout();
            groupBoxJournal.SuspendLayout();
            groupBoxCollection.SuspendLayout();
            groupBoxDissertation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxType
            // 
            groupBoxType.Controls.Add(buttonRandomData);
            groupBoxType.Controls.Add(buttonCancel);
            groupBoxType.Controls.Add(buttonOk);
            groupBoxType.Controls.Add(groupBoxBook);
            groupBoxType.Controls.Add(radioButtonDissertation);
            groupBoxType.Controls.Add(radioButtonCollection);
            groupBoxType.Controls.Add(radioButtonJournal);
            groupBoxType.Controls.Add(radioButtonBook);
            groupBoxType.Location = new Point(12, 12);
            groupBoxType.Name = "groupBoxType";
            groupBoxType.Size = new Size(423, 577);
            groupBoxType.TabIndex = 0;
            groupBoxType.TabStop = false;
            groupBoxType.Text = "Тип издания";
            // 
            // buttonRandomData
            // 
            buttonRandomData.Location = new Point(177, 546);
            buttonRandomData.Name = "buttonRandomData";
            buttonRandomData.Size = new Size(231, 23);
            buttonRandomData.TabIndex = 9;
            buttonRandomData.Text = "Заполнить случайными данными";
            buttonRandomData.UseVisualStyleBackColor = true;
            buttonRandomData.Click += ButtonRandomData_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(97, 546);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(74, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(18, 546);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(73, 23);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += ButtonOk_Click;
            // 
            // groupBoxBook
            // 
            groupBoxBook.Controls.Add(label9);
            groupBoxBook.Controls.Add(label5);
            groupBoxBook.Controls.Add(label1);
            groupBoxBook.Controls.Add(label7);
            groupBoxBook.Controls.Add(textBookPages);
            groupBoxBook.Controls.Add(label6);
            groupBoxBook.Controls.Add(textBookYear);
            groupBoxBook.Controls.Add(textBookPublisher);
            groupBoxBook.Controls.Add(label4);
            groupBoxBook.Controls.Add(textBookPlace);
            groupBoxBook.Controls.Add(textBookTitleInfo);
            groupBoxBook.Controls.Add(label2);
            groupBoxBook.Controls.Add(textBookTitle);
            groupBoxBook.Controls.Add(textBookAuthors);
            groupBoxBook.Location = new Point(18, 67);
            groupBoxBook.Name = "groupBoxBook";
            groupBoxBook.Size = new Size(390, 473);
            groupBoxBook.TabIndex = 4;
            groupBoxBook.TabStop = false;
            groupBoxBook.Text = "Данные книги";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 218);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 30;
            label9.Text = "Издательство";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 120);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 30;
            label5.Text = "Сведения о заглавии";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 30;
            label1.Text = "Авторы";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 320);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 13;
            label7.Text = "Страниц";
            // 
            // textBookPages
            // 
            textBookPages.Location = new Point(6, 338);
            textBookPages.Multiline = true;
            textBookPages.Name = "textBookPages";
            textBookPages.Size = new Size(378, 23);
            textBookPages.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 268);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 11;
            label6.Text = "Год";
            // 
            // textBookYear
            // 
            textBookYear.Location = new Point(6, 286);
            textBookYear.Multiline = true;
            textBookYear.Name = "textBookYear";
            textBookYear.Size = new Size(378, 23);
            textBookYear.TabIndex = 10;
            // 
            // textBookPublisher
            // 
            textBookPublisher.Location = new Point(6, 236);
            textBookPublisher.Multiline = true;
            textBookPublisher.Name = "textBookPublisher";
            textBookPublisher.Size = new Size(378, 23);
            textBookPublisher.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 169);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Место";
            // 
            // textBookPlace
            // 
            textBookPlace.Location = new Point(6, 187);
            textBookPlace.Multiline = true;
            textBookPlace.Name = "textBookPlace";
            textBookPlace.Size = new Size(378, 23);
            textBookPlace.TabIndex = 6;
            // 
            // textBookTitleInfo
            // 
            textBookTitleInfo.Location = new Point(6, 138);
            textBookTitleInfo.Multiline = true;
            textBookTitleInfo.Name = "textBookTitleInfo";
            textBookTitleInfo.Size = new Size(378, 23);
            textBookTitleInfo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Название";
            // 
            // textBookTitle
            // 
            textBookTitle.Location = new Point(6, 88);
            textBookTitle.Multiline = true;
            textBookTitle.Name = "textBookTitle";
            textBookTitle.Size = new Size(378, 23);
            textBookTitle.TabIndex = 2;
            // 
            // textBookAuthors
            // 
            textBookAuthors.Location = new Point(6, 42);
            textBookAuthors.Multiline = true;
            textBookAuthors.Name = "textBookAuthors";
            textBookAuthors.Size = new Size(378, 23);
            textBookAuthors.TabIndex = 0;
            // 
            // radioButtonDissertation
            // 
            radioButtonDissertation.AutoSize = true;
            radioButtonDissertation.Location = new Point(294, 33);
            radioButtonDissertation.Name = "radioButtonDissertation";
            radioButtonDissertation.Size = new Size(96, 19);
            radioButtonDissertation.TabIndex = 3;
            radioButtonDissertation.TabStop = true;
            radioButtonDissertation.Text = "Диссертация";
            radioButtonDissertation.UseVisualStyleBackColor = true;
            radioButtonDissertation.CheckedChanged +=
                RadioButton_CheckedChanged;
            // 
            // radioButtonCollection
            // 
            radioButtonCollection.AutoSize = true;
            radioButtonCollection.Location = new Point(197, 33);
            radioButtonCollection.Name = "radioButtonCollection";
            radioButtonCollection.Size = new Size(74, 19);
            radioButtonCollection.TabIndex = 2;
            radioButtonCollection.TabStop = true;
            radioButtonCollection.Text = "Сборник";
            radioButtonCollection.UseVisualStyleBackColor = true;
            radioButtonCollection.CheckedChanged +=
                RadioButton_CheckedChanged;
            // 
            // radioButtonJournal
            // 
            radioButtonJournal.AutoSize = true;
            radioButtonJournal.Location = new Point(109, 33);
            radioButtonJournal.Name = "radioButtonJournal";
            radioButtonJournal.Size = new Size(69, 19);
            radioButtonJournal.TabIndex = 1;
            radioButtonJournal.TabStop = true;
            radioButtonJournal.Text = "Журнал";
            radioButtonJournal.UseVisualStyleBackColor = true;
            radioButtonJournal.CheckedChanged +=
                RadioButton_CheckedChanged;
            // 
            // radioButtonBook
            // 
            radioButtonBook.AutoSize = true;
            radioButtonBook.Location = new Point(26, 33);
            radioButtonBook.Name = "radioButtonBook";
            radioButtonBook.Size = new Size(57, 19);
            radioButtonBook.TabIndex = 0;
            radioButtonBook.TabStop = true;
            radioButtonBook.Text = "Книга";
            radioButtonBook.UseVisualStyleBackColor = true;
            radioButtonBook.CheckedChanged +=
                RadioButton_CheckedChanged;
            // 
            // groupBoxJournal
            // 
            groupBoxJournal.Controls.Add(label29);
            groupBoxJournal.Controls.Add(textJournalFrequency);
            groupBoxJournal.Controls.Add(label18);
            groupBoxJournal.Controls.Add(label8);
            groupBoxJournal.Controls.Add(textJournalPlace);
            groupBoxJournal.Controls.Add(textJournalPages);
            groupBoxJournal.Controls.Add(textJournalYear);
            groupBoxJournal.Controls.Add(textJournalTitle);
            groupBoxJournal.Controls.Add(textJournalPublisher);
            groupBoxJournal.Controls.Add(textJournalTitleInfo);
            groupBoxJournal.Controls.Add(label10);
            groupBoxJournal.Controls.Add(label11);
            groupBoxJournal.Controls.Add(label12);
            groupBoxJournal.Controls.Add(label13);
            groupBoxJournal.Location = new Point(30, 79);
            groupBoxJournal.Name = "groupBoxJournal";
            groupBoxJournal.Size = new Size(390, 473);
            groupBoxJournal.TabIndex = 0;
            groupBoxJournal.TabStop = false;
            groupBoxJournal.Text = "Данные журнала";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 320);
            label29.Name = "label29";
            label29.Size = new Size(97, 15);
            label29.TabIndex = 29;
            label29.Text = "Частота издания";
            // 
            // textJournalFrequency
            // 
            textJournalFrequency.Location = new Point(6, 338);
            textJournalFrequency.Multiline = true;
            textJournalFrequency.Name = "textJournalFrequency";
            textJournalFrequency.Size = new Size(378, 23);
            textJournalFrequency.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 218);
            label18.Name = "label18";
            label18.Size = new Size(26, 15);
            label18.TabIndex = 31;
            label18.Text = "Год";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 268);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 27;
            label8.Text = "Страниц";
            // 
            // textJournalPlace
            // 
            textJournalPlace.Location = new Point(6, 138);
            textJournalPlace.Multiline = true;
            textJournalPlace.Name = "textJournalPlace";
            textJournalPlace.Size = new Size(378, 23);
            textJournalPlace.TabIndex = 20;
            // 
            // textJournalPages
            // 
            textJournalPages.Location = new Point(6, 286);
            textJournalPages.Multiline = true;
            textJournalPages.Name = "textJournalPages";
            textJournalPages.Size = new Size(378, 23);
            textJournalPages.TabIndex = 26;
            // 
            // textJournalYear
            // 
            textJournalYear.Location = new Point(6, 236);
            textJournalYear.Multiline = true;
            textJournalYear.Name = "textJournalYear";
            textJournalYear.Size = new Size(378, 23);
            textJournalYear.TabIndex = 24;
            // 
            // textJournalTitle
            // 
            textJournalTitle.Location = new Point(6, 42);
            textJournalTitle.Multiline = true;
            textJournalTitle.Name = "textJournalTitle";
            textJournalTitle.Size = new Size(378, 23);
            textJournalTitle.TabIndex = 16;
            // 
            // textJournalPublisher
            // 
            textJournalPublisher.Location = new Point(6, 187);
            textJournalPublisher.Multiline = true;
            textJournalPublisher.Name = "textJournalPublisher";
            textJournalPublisher.Size = new Size(378, 23);
            textJournalPublisher.TabIndex = 22;
            // 
            // textJournalTitleInfo
            // 
            textJournalTitleInfo.Location = new Point(6, 88);
            textJournalTitleInfo.Multiline = true;
            textJournalTitleInfo.Name = "textJournalTitleInfo";
            textJournalTitleInfo.Size = new Size(378, 23);
            textJournalTitleInfo.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 169);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 23;
            label10.Text = "Издательство";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 120);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 21;
            label11.Text = "Место";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 70);
            label12.Name = "label12";
            label12.Size = new Size(121, 15);
            label12.TabIndex = 19;
            label12.Text = "Сведения о заглавии";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 24);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 17;
            label13.Text = "Название";
            // 
            // groupBoxCollection
            // 
            groupBoxCollection.Controls.Add(label30);
            groupBoxCollection.Controls.Add(textCollectionResponsibleEditors);
            groupBoxCollection.Controls.Add(label21);
            groupBoxCollection.Controls.Add(label31);
            groupBoxCollection.Controls.Add(textCollectionEditorialBoard);
            groupBoxCollection.Controls.Add(textCollectionPlace);
            groupBoxCollection.Controls.Add(textCollectionPages);
            groupBoxCollection.Controls.Add(label15);
            groupBoxCollection.Controls.Add(textCollectionYear);
            groupBoxCollection.Controls.Add(textCollectionTitle);
            groupBoxCollection.Controls.Add(label16);
            groupBoxCollection.Controls.Add(textCollectionPublisher);
            groupBoxCollection.Controls.Add(label17);
            groupBoxCollection.Controls.Add(textCollectionTitleInfo);
            groupBoxCollection.Controls.Add(label19);
            groupBoxCollection.Controls.Add(label20);
            groupBoxCollection.Location = new Point(30, 79);
            groupBoxCollection.Name = "groupBoxCollection";
            groupBoxCollection.Size = new Size(390, 473);
            groupBoxCollection.TabIndex = 5;
            groupBoxCollection.TabStop = false;
            groupBoxCollection.Text = "Данные сборника";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(6, 369);
            label30.Name = "label30";
            label30.Size = new Size(147, 15);
            label30.TabIndex = 45;
            label30.Text = "Отвественные редакторы";
            // 
            // textCollectionResponsibleEditors
            // 
            textCollectionResponsibleEditors.Location = new Point(6, 387);
            textCollectionResponsibleEditors.Multiline = true;
            textCollectionResponsibleEditors.Name =
                "textCollectionResponsibleEditors";
            textCollectionResponsibleEditors.Size = new Size(378, 23);
            textCollectionResponsibleEditors.TabIndex = 44;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 120);
            label21.Name = "label21";
            label21.Size = new Size(42, 15);
            label21.TabIndex = 62;
            label21.Text = "Место";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(6, 320);
            label31.Name = "label31";
            label31.Size = new Size(139, 15);
            label31.TabIndex = 43;
            label31.Text = "Редакционная коллегия";
            // 
            // textCollectionEditorialBoard
            // 
            textCollectionEditorialBoard.Location = new Point(6, 338);
            textCollectionEditorialBoard.Multiline = true;
            textCollectionEditorialBoard.Name =
                "textCollectionEditorialBoard";
            textCollectionEditorialBoard.Size = new Size(378, 23);
            textCollectionEditorialBoard.TabIndex = 42;
            // 
            // textCollectionPlace
            // 
            textCollectionPlace.Location = new Point(6, 138);
            textCollectionPlace.Multiline = true;
            textCollectionPlace.Name = "textCollectionPlace";
            textCollectionPlace.Size = new Size(378, 23);
            textCollectionPlace.TabIndex = 34;
            // 
            // textCollectionPages
            // 
            textCollectionPages.Location = new Point(6, 286);
            textCollectionPages.Multiline = true;
            textCollectionPages.Name = "textCollectionPages";
            textCollectionPages.Size = new Size(378, 23);
            textCollectionPages.TabIndex = 40;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 268);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 41;
            label15.Text = "Страниц";
            // 
            // textCollectionYear
            // 
            textCollectionYear.Location = new Point(6, 236);
            textCollectionYear.Multiline = true;
            textCollectionYear.Name = "textCollectionYear";
            textCollectionYear.Size = new Size(378, 23);
            textCollectionYear.TabIndex = 38;
            // 
            // textCollectionTitle
            // 
            textCollectionTitle.Location = new Point(6, 42);
            textCollectionTitle.Multiline = true;
            textCollectionTitle.Name = "textCollectionTitle";
            textCollectionTitle.Size = new Size(378, 23);
            textCollectionTitle.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 218);
            label16.Name = "label16";
            label16.Size = new Size(26, 15);
            label16.TabIndex = 39;
            label16.Text = "Год";
            // 
            // textCollectionPublisher
            // 
            textCollectionPublisher.Location = new Point(6, 187);
            textCollectionPublisher.Multiline = true;
            textCollectionPublisher.Name = "textCollectionPublisher";
            textCollectionPublisher.Size = new Size(378, 23);
            textCollectionPublisher.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 169);
            label17.Name = "label17";
            label17.Size = new Size(81, 15);
            label17.TabIndex = 37;
            label17.Text = "Издательство";
            // 
            // textCollectionTitleInfo
            // 
            textCollectionTitleInfo.Location = new Point(6, 88);
            textCollectionTitleInfo.Multiline = true;
            textCollectionTitleInfo.Name = "textCollectionTitleInfo";
            textCollectionTitleInfo.Size = new Size(378, 23);
            textCollectionTitleInfo.TabIndex = 32;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 70);
            label19.Name = "label19";
            label19.Size = new Size(121, 15);
            label19.TabIndex = 33;
            label19.Text = "Сведения о заглавии";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 24);
            label20.Name = "label20";
            label20.Size = new Size(59, 15);
            label20.TabIndex = 31;
            label20.Text = "Название";
            // 
            // groupBoxDissertation
            // 
            groupBoxDissertation.Controls.Add(label32);
            groupBoxDissertation.Controls.Add(textDissertationDegree);
            groupBoxDissertation.Controls.Add(textDissertationSpeciality);
            groupBoxDissertation.Controls.Add(textDissertationAuthorFull);
            groupBoxDissertation.Controls.Add(label33);
            groupBoxDissertation.Controls.Add(textDissertationTitleInfo);
            groupBoxDissertation.Controls.Add(textDissertationPages);
            groupBoxDissertation.Controls.Add(textDissertationYear);
            groupBoxDissertation.Controls.Add(label34);
            groupBoxDissertation.Controls.Add(textDissertationTitle);
            groupBoxDissertation.Controls.Add(label22);
            groupBoxDissertation.Controls.Add(label26);
            groupBoxDissertation.Controls.Add(label23);
            groupBoxDissertation.Controls.Add(label24);
            groupBoxDissertation.Controls.Add(label25);
            groupBoxDissertation.Controls.Add(label27);
            groupBoxDissertation.Controls.Add(textDissertationPublisher);
            groupBoxDissertation.Controls.Add(textDissertationPlace);
            groupBoxDissertation.Location = new Point(30, 79);
            groupBoxDissertation.Name = "groupBoxDissertation";
            groupBoxDissertation.Size = new Size(390, 473);
            groupBoxDissertation.TabIndex = 6;
            groupBoxDissertation.TabStop = false;
            groupBoxDissertation.Text = "Данные диссертации";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(6, 416);
            label32.Name = "label32";
            label32.Size = new Size(92, 15);
            label32.TabIndex = 61;
            label32.Text = "Ученая степень";
            // 
            // textDissertationDegree
            // 
            textDissertationDegree.Location = new Point(6, 434);
            textDissertationDegree.Multiline = true;
            textDissertationDegree.Name = "textDissertationDegree";
            textDissertationDegree.Size = new Size(378, 23);
            textDissertationDegree.TabIndex = 60;
            // 
            // textDissertationSpeciality
            // 
            textDissertationSpeciality.Location = new Point(6, 387);
            textDissertationSpeciality.Multiline = true;
            textDissertationSpeciality.Name = "textDissertationSpeciality";
            textDissertationSpeciality.Size = new Size(378, 23);
            textDissertationSpeciality.TabIndex = 58;
            // 
            // textDissertationAuthorFull
            // 
            textDissertationAuthorFull.Location = new Point(6, 338);
            textDissertationAuthorFull.Multiline = true;
            textDissertationAuthorFull.Name = "textDissertationAuthorFull";
            textDissertationAuthorFull.Size = new Size(378, 23);
            textDissertationAuthorFull.TabIndex = 56;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 369);
            label33.Name = "label33";
            label33.Size = new Size(92, 15);
            label33.TabIndex = 59;
            label33.Text = "Специальность";
            // 
            // textDissertationTitleInfo
            // 
            textDissertationTitleInfo.Location = new Point(6, 88);
            textDissertationTitleInfo.Multiline = true;
            textDissertationTitleInfo.Name = "textDissertationTitleInfo";
            textDissertationTitleInfo.Size = new Size(378, 23);
            textDissertationTitleInfo.TabIndex = 46;
            // 
            // textDissertationPages
            // 
            textDissertationPages.Location = new Point(6, 286);
            textDissertationPages.Multiline = true;
            textDissertationPages.Name = "textDissertationPages";
            textDissertationPages.Size = new Size(378, 23);
            textDissertationPages.TabIndex = 54;
            // 
            // textDissertationYear
            // 
            textDissertationYear.Location = new Point(6, 236);
            textDissertationYear.Multiline = true;
            textDissertationYear.Name = "textDissertationYear";
            textDissertationYear.Size = new Size(378, 23);
            textDissertationYear.TabIndex = 52;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(6, 320);
            label34.Name = "label34";
            label34.Size = new Size(115, 15);
            label34.TabIndex = 57;
            label34.Text = "Полное имя автора";
            // 
            // textDissertationTitle
            // 
            textDissertationTitle.Location = new Point(6, 42);
            textDissertationTitle.Multiline = true;
            textDissertationTitle.Name = "textDissertationTitle";
            textDissertationTitle.Size = new Size(378, 23);
            textDissertationTitle.TabIndex = 44;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 268);
            label22.Name = "label22";
            label22.Size = new Size(54, 15);
            label22.TabIndex = 55;
            label22.Text = "Страниц";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 70);
            label26.Name = "label26";
            label26.Size = new Size(121, 15);
            label26.TabIndex = 47;
            label26.Text = "Сведения о заглавии";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 218);
            label23.Name = "label23";
            label23.Size = new Size(26, 15);
            label23.TabIndex = 53;
            label23.Text = "Год";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 169);
            label24.Name = "label24";
            label24.Size = new Size(81, 15);
            label24.TabIndex = 51;
            label24.Text = "Издательство";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 120);
            label25.Name = "label25";
            label25.Size = new Size(42, 15);
            label25.TabIndex = 49;
            label25.Text = "Место";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 24);
            label27.Name = "label27";
            label27.Size = new Size(59, 15);
            label27.TabIndex = 45;
            label27.Text = "Название";
            // 
            // textDissertationPublisher
            // 
            textDissertationPublisher.Location = new Point(6, 187);
            textDissertationPublisher.Multiline = true;
            textDissertationPublisher.Name = "textDissertationPublisher";
            textDissertationPublisher.Size = new Size(378, 23);
            textDissertationPublisher.TabIndex = 50;
            // 
            // textDissertationPlace
            // 
            textDissertationPlace.Location = new Point(6, 138);
            textDissertationPlace.Multiline = true;
            textDissertationPlace.Name = "textDissertationPlace";
            textDissertationPlace.Size = new Size(378, 23);
            textDissertationPlace.TabIndex = 48;
            // 
            // AddPublicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 601);
            Controls.Add(groupBoxDissertation);
            Controls.Add(groupBoxCollection);
            Controls.Add(groupBoxJournal);
            Controls.Add(groupBoxType);
            FormBorderStyle = FormBorderStyle.FixedDialog; 
            MaximizeBox = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPublicationForm";
            Text = "Добавить издание";
            groupBoxType.ResumeLayout(false);
            groupBoxType.PerformLayout();
            groupBoxBook.ResumeLayout(false);
            groupBoxBook.PerformLayout();
            groupBoxJournal.ResumeLayout(false);
            groupBoxJournal.PerformLayout();
            groupBoxCollection.ResumeLayout(false);
            groupBoxCollection.PerformLayout();
            groupBoxDissertation.ResumeLayout(false);
            groupBoxDissertation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxType;
        private RadioButton radioButtonCollection;
        private RadioButton radioButtonJournal;
        private RadioButton radioButtonBook;
        private GroupBox groupBoxDissertation;
        private GroupBox groupBoxCollection;
        private GroupBox groupBoxJournal;
        private GroupBox groupBoxBook;
        private TextBox textBookAuthors;
        private RadioButton radioButtonDissertation;
        private Label label4;
        private TextBox textBookPlace;
        private TextBox textBookTitleInfo;
        private Label label2;
        private TextBox textBookTitle;
        private Label label7;
        private TextBox textBookPages;
        private Label label6;
        private TextBox textBookYear;
        private TextBox textBookPublisher;
        private Label label22;
        private TextBox textDissertationTitleInfo;
        private TextBox textDissertationPages;
        private Label label23;
        private TextBox textDissertationYear;
        private TextBox textDissertationTitle;
        private Label label24;
        private Label label27;
        private TextBox textDissertationPublisher;
        private Label label26;
        private Label label25;
        private TextBox textDissertationPlace;
        private Label label15;
        private TextBox textCollectionPlace;
        private TextBox textCollectionPages;
        private Label label16;
        private TextBox textCollectionYear;
        private TextBox textCollectionTitle;
        private Label label17;
        private Label label20;
        private TextBox textCollectionPublisher;
        private TextBox textCollectionTitleInfo;
        private Label label19;
        private Label label8;
        private TextBox textJournalPlace;
        private TextBox textJournalPages;
        private TextBox textJournalYear;
        private TextBox textJournalTitle;
        private Label label10;
        private Label label13;
        private TextBox textJournalPublisher;
        private TextBox textJournalTitleInfo;
        private Label label11;
        private Label label12;
        private Label label32;
        private TextBox textDissertationDegree;
        private Label label33;
        private TextBox textDissertationSpeciality;
        private Label label34;
        private TextBox textDissertationAuthorFull;
        private Label label30;
        private TextBox textCollectionResponsibleEditors;
        private Label label31;
        private TextBox textCollectionEditorialBoard;
        private Label label29;
        private TextBox textJournalFrequency;
        private Button buttonCancel;
        private Button buttonOk;
        private Label label21;
        private Label label18;
        private Label label9;
        private Label label5;
        private Label label1;
        private Button buttonRandomData;
    }
}