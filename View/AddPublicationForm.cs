using Model;
using View.Helper;
using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма для добавления нового издания.
    /// </summary>
    public partial class AddPublicationForm : Form
    {
        /// <summary>
        /// Созданное издание, передаётся в главную форму.
        /// </summary>
        public PublicationBase CreatedPublication { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        public AddPublicationForm()
        {
            InitializeComponent();
            groupBoxBook.Visible = false;
            groupBoxJournal.Visible = false;
            groupBoxCollection.Visible = false;
            groupBoxDissertation.Visible = false;

#if DEBUG
            CreateDebugButton();
#endif
        }

#if DEBUG
        /// <summary>
        /// Создаёт и добавляет отладочную кнопку
        /// "Заполнить случайными данными".
        /// </summary>
        private void CreateDebugButton()
        {
            Button buttonRandomData = new Button();
            buttonRandomData.Location = new Point(12, 380);
            buttonRandomData.Name = "buttonRandomData";
            buttonRandomData.Size = new Size(380, 23);
            buttonRandomData.TabIndex = 100;
            buttonRandomData.Text = "Заполнить случайными данными";
            buttonRandomData.UseVisualStyleBackColor = true;
            buttonRandomData.Click += ButtonRandomData_Click;
            Controls.Add(buttonRandomData);
        }
#endif

        /// <summary>
        /// Обработчик события изменения состояния RadioButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxBook.Visible = radioButtonBook.Checked;
            groupBoxJournal.Visible = radioButtonJournal.Checked;
            groupBoxCollection.Visible = radioButtonCollection.Checked;
            groupBoxDissertation.Visible = radioButtonDissertation.Checked;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "ОК".
        /// Создаёт издание и закрывает форму с результатом
        /// <see cref="DialogResult.OK"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonBook.Checked)
                {
                    CreatedPublication = CreateBook();
                }
                else if (radioButtonJournal.Checked)
                {
                    CreatedPublication = CreateJournal();
                }
                else if (radioButtonCollection.Checked)
                {
                    CreatedPublication = CreateCollection();
                }
                else if (radioButtonDissertation.Checked)
                {
                    CreatedPublication = CreateDissertation();
                }
                else
                {
                    MessageBox.Show(
                        "Выберите тип издания!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (CreatedPublication != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка валидации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отмена".
        /// Закрывает форму с результатом
        /// <see cref="DialogResult.Cancel"/> без создания издания.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Создаёт объект книги на основе данных формы.
        /// </summary>
        /// <returns>Созданная книга.</returns>
        private Book CreateBook()
        {
            if (!Validator.AreTextBoxesFilled(
                "Заполните название книги!",
                textBookTitle,
                textBookPlace,
                textBookPublisher,
                textBookYear,
                textBookPages))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textBookYear, "Год", out int year))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textBookPages, "Страницы", out int pages))
            {
                return null;
            }

            var book = new Book
            {
                Title = textBookTitle.Text.Trim(),
                TitleInformation = textBookTitleInfo.Text.Trim(),
                Place = textBookPlace.Text.Trim(),
                Publisher = textBookPublisher.Text.Trim(),
                Year = year,
                TotalPages = pages
            };

            string[] authors = textBookAuthors.Text.Split(
                new[] { "\r\n", "\n" },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string author in authors)
            {
                string trimmed = author.Trim();

                if (!string.IsNullOrWhiteSpace(trimmed))
                {
                    book.AddAuthors(trimmed);
                }
            }

            return book;
        }

        /// <summary>
        /// Создаёт объект журнала на основе данных формы.
        /// </summary>
        /// <returns>Созданный журнал.</returns>
        private Journal CreateJournal()
        {
            if (!Validator.AreTextBoxesFilled(
                "Заполните все поля журнала!",
                textJournalTitle,
                textJournalPlace,
                textJournalPublisher,
                textJournalYear,
                textJournalPages))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textJournalYear, "Год", out int year))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textJournalPages, "Страницы", out int pages))
            {
                return null;
            }

            return new Journal
            {
                Title = textJournalTitle.Text.Trim(),
                TitleInformation = textJournalTitleInfo.Text.Trim(),
                Place = textJournalPlace.Text.Trim(),
                Publisher = textJournalPublisher.Text.Trim(),
                Year = year,
                TotalPages = pages,
                Frequency = textJournalFrequency.Text.Trim()
            };
        }

        /// <summary>
        /// Создаёт объект сборника на основе данных формы.
        /// </summary>
        /// <returns>Созданный сборник.</returns>
        private Collection CreateCollection()
        {
            if (!Validator.AreTextBoxesFilled(
                "Заполните все поля сборника!",
                textCollectionTitle,
                textCollectionPlace,
                textCollectionPublisher,
                textCollectionYear,
                textCollectionPages,
                textCollectionEditorialBoard,
                textCollectionResponsibleEditors))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textCollectionYear, "Год", out int year))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textCollectionPages, "Страницы", out int pages))
            {
                return null;
            }

            return new Collection
            {
                Title = textCollectionTitle.Text.Trim(),
                TitleInformation = textCollectionTitleInfo.Text.Trim(),
                Place = textCollectionPlace.Text.Trim(),
                Publisher = textCollectionPublisher.Text.Trim(),
                Year = year,
                TotalPages = pages,
                EditorialBoard = textCollectionEditorialBoard.Text.Trim(),
                ResponsibleEditors = textCollectionResponsibleEditors.Text.Trim()
            };
        }

        /// <summary>
        /// Создаёт объект диссертации на основе данных формы.
        /// </summary>
        /// <returns>Созданная диссертация.</returns>
        private Dissertation CreateDissertation()
        {
            if (!Validator.AreTextBoxesFilled(
                "Заполните все поля диссертации!",
                textDissertationTitle,
                textDissertationPlace,
                textDissertationPublisher,
                textDissertationYear,
                textDissertationPages,
                textDissertationAuthorFull,
                textDissertationSpeciality,
                textDissertationDegree))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textDissertationYear, "Год", out int year))
            {
                return null;
            }

            if (!Validator.IsPositiveInteger(
                textDissertationPages, "Страницы", out int pages))
            {
                return null;
            }

            return new Dissertation
            {
                Title = textDissertationTitle.Text.Trim(),
                TitleInformation = textDissertationTitleInfo.Text.Trim(),
                Place = textDissertationPlace.Text.Trim(),
                Publisher = textDissertationPublisher.Text.Trim(),
                Year = year,
                TotalPages = pages,
                AuthorFull = textDissertationAuthorFull.Text.Trim(),
                Speciality = textDissertationSpeciality.Text.Trim(),
                Degree = textDissertationDegree.Text.Trim()
            };
        }

#if DEBUG
        /// <summary>
        /// Обработчик нажатия кнопки "Заполнить случайными данными".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonRandomData_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonBook.Checked)
                {
                    FillBookRandomData();
                }
                else if (radioButtonJournal.Checked)
                {
                    FillJournalRandomData();
                }
                else if (radioButtonCollection.Checked)
                {
                    FillCollectionRandomData();
                }
                else if (radioButtonDissertation.Checked)
                {
                    FillDissertationRandomData();
                }
                else
                {
                    MessageBox.Show(
                        "Сначала выберите тип издания!",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при генерации случайных данных: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Заполняет поля книги случайными данными.
        /// </summary>
        private void FillBookRandomData()
        {
            var book = RandomDataGenerator.GenerateRandomBook();
            textBookTitle.Text = book.Title;
            textBookTitleInfo.Text = book.TitleInformation;
            textBookPlace.Text = book.Place;
            textBookPublisher.Text = book.Publisher;
            textBookYear.Text = book.Year.ToString();
            textBookPages.Text = book.TotalPages.ToString();
            textBookAuthors.Text = string.Join(", ", book.Authors);
        }

        /// <summary>
        /// Заполняет поля журнала случайными данными.
        /// </summary>
        private void FillJournalRandomData()
        {
            var journal = RandomDataGenerator.GenerateRandomJournal();
            textJournalTitle.Text = journal.Title;
            textJournalTitleInfo.Text = journal.TitleInformation;
            textJournalPlace.Text = journal.Place;
            textJournalPublisher.Text = journal.Publisher;
            textJournalYear.Text = journal.Year.ToString();
            textJournalPages.Text = journal.TotalPages.ToString();
            textJournalFrequency.Text = journal.Frequency;
        }

        /// <summary>
        /// Заполняет поля сборника случайными данными.
        /// </summary>
        private void FillCollectionRandomData()
        {
            var collection = RandomDataGenerator.GenerateRandomCollection();
            textCollectionTitle.Text = collection.Title;
            textCollectionTitleInfo.Text = collection.TitleInformation;
            textCollectionPlace.Text = collection.Place;
            textCollectionPublisher.Text = collection.Publisher;
            textCollectionYear.Text = collection.Year.ToString();
            textCollectionPages.Text = collection.TotalPages.ToString();
            textCollectionEditorialBoard.Text = collection.EditorialBoard;
            textCollectionResponsibleEditors.Text = collection.ResponsibleEditors;
        }

        /// <summary>
        /// Заполняет поля диссертации случайными данными.
        /// </summary>
        private void FillDissertationRandomData()
        {
            var dissertation = RandomDataGenerator.GenerateRandomDissertation();
            textDissertationTitle.Text = dissertation.Title;
            textDissertationTitleInfo.Text = dissertation.TitleInformation;
            textDissertationPlace.Text = dissertation.Place;
            textDissertationPublisher.Text = dissertation.Publisher;
            textDissertationYear.Text = dissertation.Year.ToString();
            textDissertationPages.Text = dissertation.TotalPages.ToString();
            textDissertationAuthorFull.Text = dissertation.AuthorFull;
            textDissertationSpeciality.Text = dissertation.Speciality;
            textDissertationDegree.Text = dissertation.Degree;
        }
#endif
    }
}