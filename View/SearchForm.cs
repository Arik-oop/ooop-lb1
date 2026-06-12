using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма для поиска изданий.
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Список всех изданий для поиска.
        /// </summary>
        private List<PublicationBase> _allPublications;

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        /// <param name="publications">Список изданий для поиска.</param>
        public SearchForm(List<PublicationBase> publications)
        {
            InitializeComponent();
            _allPublications = publications;
            SetupSearchFields();
            DataGridViewHelper.SetupPublicationColumns(dataGridViewResults);
            dataGridViewResults.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Конструктор по умолчанию для дизайнера.
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Настраивает поля для поиска в ComboBox.
        /// </summary>
        private void SetupSearchFields()
        {
            comboBoxField.Items.Clear();
            comboBoxField.Items.Add("Название");
            comboBoxField.Items.Add("Сведения о заглавии");
            comboBoxField.Items.Add("Место издания");
            comboBoxField.Items.Add("Издательство");
            comboBoxField.Items.Add("Год");
            comboBoxField.Items.Add("Страницы");
            comboBoxField.Items.Add("Описание по ГОСТ");
            comboBoxField.Items.Add("Авторы (книги)");
            comboBoxField.Items.Add("Частота (журналы)");
            comboBoxField.Items.Add("Редколлегия (сборники)");
            comboBoxField.Items.Add("Автор диссертации");
            comboBoxField.Items.Add("Специальность (диссертации)");
            comboBoxField.SelectedIndex = 0;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Найти".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchValue.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show(
                    "Введите значение для поиска!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            dataGridViewResults.Rows.Clear();
            List<PublicationBase> found = new List<PublicationBase>();

            switch (comboBoxField.SelectedIndex)
            {
                //TODО: отступы +
                case 0:
                {
                    found = _allPublications
                        .Where(p => p.Title.ToLower().Contains(searchText))
                        .ToList();
                    break;
                }
                case 1:
                {
                    found = _allPublications
                        .Where(p => p.TitleInformation != null &&
                               p.TitleInformation.ToLower().Contains(searchText))
                        .ToList();
                    break;
                }
                case 2:
                {
                    found = _allPublications
                        .Where(p => p.Place.ToLower().Contains(searchText))
                        .ToList();
                    break;
                }
                case 3:
                {
                    found = _allPublications
                        .Where(p => p.Publisher.ToLower().Contains(searchText))
                        .ToList();
                    break;
                }
                case 4:
                {
                    if (int.TryParse(searchText, out int year))
                    {
                        found = _allPublications
                            .Where(p => p.Year == year)
                            .ToList();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Введите корректный год!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    break;
                }
                case 5:
                {
                    if (int.TryParse(searchText, out int pages))
                    {
                        found = _allPublications
                            .Where(p => p.TotalPages == pages)
                            .ToList();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Введите корректное количество страниц!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    break;
                }
                case 6:
                {
                    found = _allPublications
                        .Where(p => p.GetGOST().ToLower().Contains(searchText))
                        .ToList();
                    break;
                }
                case 7:
                {
                    found = _allPublications
                        .OfType<Book>()
                        .Where(b => b.Authors.Any(a =>
                            a.ToLower().Contains(searchText)))
                        .Cast<PublicationBase>()
                        .ToList();
                    break;
                }
                case 8:
                {
                    found = _allPublications
                        .OfType<Journal>()
                        .Where(j => j.Frequency.ToLower().Contains(searchText))
                        .Cast<PublicationBase>()
                        .ToList();
                    break;
                }
                case 9:
                {
                    found = _allPublications
                        .OfType<Collection>()
                        .Where(c => c.EditorialBoard.ToLower().Contains(searchText))
                        .Cast<PublicationBase>()
                        .ToList();
                    break;
                }
                case 10:
                {
                    found = _allPublications
                        .OfType<Dissertation>()
                        .Where(d => d.AuthorFull.ToLower().Contains(searchText))
                        .Cast<PublicationBase>()
                        .ToList();
                    break;
                }
                case 11:
                {
                    found = _allPublications
                        .OfType<Dissertation>()
                        .Where(d => d.Speciality.ToLower().Contains(searchText))
                        .Cast<PublicationBase>()
                        .ToList();
                    break;
                }
            }

            foreach (var pub in found)
            {
                dataGridViewResults.Rows.Add(
                    pub.Title,
                    pub.Year.ToString(),
                    pub.Place,
                    pub.Publisher,
                    pub.TotalPages.ToString(),
                    pub.GetGOST());
            }

            MessageBox.Show(
                $"Найдено изданий: {found.Count}",
                "Результаты",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Закрыть".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}