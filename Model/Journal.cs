using System.Text;

namespace Model
{
    /// <summary>
    /// Класс, описывающий издание журнала.
    /// </summary>
    public class Journal : PublicationBase
    {
        /// <summary>
        /// Частота издания.
        /// </summary>
        private string _frequency;

        /// <summary>
        /// Свойство частоты издания.
        /// </summary>
        public string Frequency
        {
            get => _frequency;
            set
            {
                ValidateString(value, nameof(Frequency));
                _frequency = value;
            }
        }

        /// <summary>
        /// Метод для получения информации о журнале по ГОСТ.
        /// </summary>
        /// <returns>Строковое описание журнала по ГОСТ.</returns>
        public override string GetGOST()
        {
            var journalInformation = new StringBuilder();

            journalInformation.Append(Title);

            AppendIfNotEmpty(journalInformation, " : ", TitleInformation);

            journalInformation.Append($" / {Publisher} – {Place}," +
                $" {Year}– . – {TotalPages} с.");

            AppendIfNotEmpty(journalInformation, " – ", Frequency, ".");

            return journalInformation.ToString();
        }
    }
}