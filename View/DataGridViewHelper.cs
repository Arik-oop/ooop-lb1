using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Вспомогательный класс для настройки DataGridView.
    /// </summary>
    public static class DataGridViewHelper
    {
        /// <summary>
        /// Настраивает колонки для отображения изданий.
        /// </summary>
        /// <param name="dataGridView">DataGridView для настройки.</param>
        public static void SetupPublicationColumns(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Название",
                Width = 250
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Year",
                HeaderText = "Год",
                Width = 50
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Place",
                HeaderText = "Место",
                Width = 120
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Publisher",
                HeaderText = "Издательство",
                Width = 120
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPages",
                HeaderText = "Стр.",
                Width = 50
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GOST",
                HeaderText = "Описание по ГОСТ",
                Width = 450,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.RowTemplate.Height = 50;
        }
    }
}