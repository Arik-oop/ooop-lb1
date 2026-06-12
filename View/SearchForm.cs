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
            comboBoxField.Items.Add("Место издания");
            comboBoxField.Items.Add("Издательство");
            comboBoxField.Items.Add("Год");
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
                //TODО: отступы
                case 0:
                    {
                        found = _allPublications.Where(p =>
                            p.Title.ToLower().Contains(searchText)).ToList();
                        break;
                    }
                case 1:
                    {
                        found = _allPublications.Where(p =>
                            p.Place.ToLower().Contains(searchText)).ToList();
                        break;
                    }
                case 2:
                    {
                        found = _allPublications.Where(p =>
                            p.Publisher.ToLower().Contains(searchText)).ToList();
                        break;
                    }
                case 3:
                    {
                        if (int.TryParse(searchText, out int year))
                        {
                            found = _allPublications.Where(p => p.Year == year).ToList();
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