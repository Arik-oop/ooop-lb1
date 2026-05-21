using System;
using System.Text;

namespace Model
{
    /// <summary>
    /// Базовый класс издания.
    /// </summary>
    public abstract class PublicationBase : IPublication
    {
        /// <summary>
        /// Заглавие.
        /// </summary>
        private string _title;

        /// <summary>
        /// Сведения о заглавии.
        /// </summary>
        private string _titleInformation;

        /// <summary>
        /// Год издания.
        /// </summary>
        private int _year;

        /// <summary>
        /// Место издания.
        /// </summary>
        private string _place;

        /// <summary>
        /// Издательство.
        /// </summary>
        private string _publisher;

        /// <summary>
        /// Количество страниц.
        /// </summary>
        private int _totalPages;

        /// <summary>
        /// Минимальный допустимый год издания.
        /// </summary>
        private const int MinYear = 868;

        /// <summary>
        /// Свойство заглавия.
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                ValidateString(value, nameof(Title));
                _title = value;
            }
        }

        //TODO: validation
        /// <summary>
        /// Свойство сведений о заглавии.
        /// </summary>
        public string TitleInformation { get; set; }

        /// <summary>
        /// Свойство года издания.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                ValidateYear(value, nameof(Year));
                _year = value;
            }
        }

        /// <summary>
        /// Свойство места издания.
        /// </summary>
        public string Place
        {
            get => _place;
            set
            {
                ValidateString(value, nameof(Place));
                _place = value;
            }
        }

        /// <summary>
        /// Свойство издательства.
        /// </summary>
        public string Publisher
        {
            get => _publisher;
            set
            {
                ValidateString(value, nameof(Publisher));
                _publisher = value;
            }
        }

        /// <summary>
        /// Свойство количества страниц.
        /// </summary>
        public int TotalPages
        {
            get => _totalPages;
            set
            {
                ValidatePositiveNumber(value, nameof(TotalPages));
                _totalPages = value;
            }
        }

        /// <summary>
        /// Абстрактный метод для описания издания по ГОСТ.
        /// </summary>
        /// <returns>Строковое описание издания по ГОСТ.</returns>
        public abstract string GetGOST();

        /// <summary>
        /// Метод валидации строкового значения.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="parameterName">Имя параметра для сообщения об ошибке.</param>
        protected void ValidateString
            (string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    $"Значение параметра '{parameterName}'" +
                    $" не может быть пустым.");
            }
        }

        /// <summary>
        /// Метод валидации года издания.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="parameterName">Имя параметра для сообщения об ошибке.</param>
        protected void ValidateYear
            (int value, string parameterName)
        {
            if (value < MinYear || value > DateTime.Now.Year)
            {
                throw new ArgumentException(
                    $"Значение параметра '{parameterName}'" +
                    $" должно быть в диапазоне от {MinYear}" +
                    $" до {DateTime.Now.Year}.");
            }
        }

        /// <summary>
        /// Метод валидации положительного числа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="parameterName">Имя параметра для сообщения об ошибке.</param>
        protected void ValidatePositiveNumber
            (int value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"Значение параметра '{parameterName}'" +
                    $" должно быть положительным числом.");
            }
        }

        /// <summary>
        /// Метод добавления значения в StringBuilder при условии его заполнения.
        /// </summary>
        /// <param name="stringBuilder">Целевой объект StringBuilder.</param>
        /// <param name="prefix">Префикс для добавляемого значения.</param>
        /// <param name="value">Проверяемое и добавляемое значение.</param>
        /// <param name="suffix">Суффикс для добавляемого значения.</param>
        protected static void AppendIfNotEmpty
            (StringBuilder stringBuilder, string prefix, string value, string suffix = "")
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                stringBuilder.Append($"{prefix}{value}{suffix}");
            }
        }
    }
}
