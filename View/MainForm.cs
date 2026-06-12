using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace View
{
    /// <summary>
    /// Главная форма приложения для управления изданиями.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список хранящихся изданий.
        /// </summary>
        private List<PublicationBase> _publications;

        /// <summary>
        /// Путь к текущему файлу данных.
        /// </summary>
        private string _currentFilePath = "";

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _publications = new List<PublicationBase>();
            dataGridViewPublications.AutoGenerateColumns = false;
            dataGridViewPublications.ReadOnly = true;
            dataGridViewPublications.AllowUserToAddRows = false;
            dataGridViewPublications.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            DataGridViewHelper.SetupPublicationColumns(dataGridViewPublications);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить издание".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonAddPublication_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddPublicationForm())
            {
                DialogResult result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PublicationBase newPublication = addForm.CreatedPublication;
                    if (newPublication != null)
                    {
                        _publications.Add(newPublication);
                        RefreshDataGridView();
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Удалить издание".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonRemovePublication_Click(object sender, EventArgs e)
        {
            if (dataGridViewPublications.SelectedRows.Count > 0)
            {
                var indicesToDelete = new List<int>();
                //TODO: RSDN +
                foreach (DataGridViewRow row in 
                    dataGridViewPublications.SelectedRows)
                {
                    indicesToDelete.Add(row.Index);
                }

                indicesToDelete.Sort((a, b) => b.CompareTo(a));

                foreach (int idx in indicesToDelete)
                {
                    if (idx >= 0 && idx < _publications.Count)
                    {
                        _publications.RemoveAt(idx);
                    }
                }

                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show(
                    "Выберите одно или несколько изданий для удаления!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Поиск".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchForm(_publications))
            {
                searchForm.ShowDialog();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_publications.Count == 0)
            {
                MessageBox.Show(
                    "Список изданий пуст! Нечего сохранять.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Файлы библиотеки " +
                    "(*.library)|*.library|Все файлы (*.*)|*.*";
                saveDialog.Title = "Сохранить библиотеку";
                saveDialog.FileName = "library.library";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _currentFilePath = saveDialog.FileName;
                        SerializePublications(_currentFilePath);
                        MessageBox.Show(
                            $"Данные успешно сохранены в файл: " +
                            $"{_currentFilePath}",
                            "Успех",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Ошибка при сохранении: {ex.Message}",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Загрузить".
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Файлы библиотеки " +
                    "(*.library)|*.library|Все файлы (*.*)|*.*";
                openDialog.Title = "Загрузить библиотеку";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var loaded = DeserializePublications(openDialog.FileName);
                        _currentFilePath = openDialog.FileName;
                        _publications = loaded;
                        RefreshDataGridView();
                        MessageBox.Show(
                            $"Загружено изданий: " +
                            $"{_publications.Count}",
                            "Успех",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Ошибка при загрузке: {ex.Message}",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет DataGridView.
        /// </summary>
        private void RefreshDataGridView()
        {
            dataGridViewPublications.Rows.Clear();
            foreach (var pub in _publications)
            {
                dataGridViewPublications.Rows.Add(
                    pub.Title,
                    pub.Year.ToString(),
                    pub.Place,
                    pub.Publisher,
                    pub.TotalPages.ToString(),
                    pub.GetGOST());
            }
        }

        /// <summary>
        /// Сериализует список изданий в XML.
        /// </summary>
        /// <param name="filePath">Путь к файлу для сохранения.</param>
        private void SerializePublications(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<PublicationData>));
            var dataList = new List<PublicationData>();

            foreach (var pub in _publications)
            {
                dataList.Add(PublicationData.FromPublication(pub));
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, dataList);
            }
        }

        /// <summary>
        /// Десериализует список изданий из XML.
        /// </summary>
        /// <param name="filePath">Путь к файлу для загрузки.</param>
        /// <returns>Список загруженных изданий.</returns>
        private List<PublicationBase> DeserializePublications(string filePath)
        {
            var serializer = new XmlSerializer(typeof(List<PublicationData>));
            List<PublicationData> dataList;

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                dataList = (List<PublicationData>)serializer.Deserialize(fs);
            }

            var result = new List<PublicationBase>();
            foreach (var data in dataList)
            {
                result.Add(data.ToPublication());
            }

            return result;
        }
    }
}