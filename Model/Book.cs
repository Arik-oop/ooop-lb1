using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// Класс, описывающий издание книги.
    /// </summary>
    public class Book : PublicationBase
    {
        /// <summary>
        /// Максимальное число авторов для отображения перед заголовком.
        /// </summary>
        private const int MaxAuthorsForTitle = 3;

        /// <summary>
        /// Минимальное число авторов для отображения перед заголовком.
        /// </summary>
        private const int MinAuthorsForTitle = 1;

        /// <summary>
        /// Константа для проверки единственного автора.
        /// </summary>
        private const int SingleAuthor = 1;

        /// <summary>
        /// Максимальное число авторов для полного перечисления.
        /// </summary>
        private const int MaxAuthorsForFullList = 3;

        /// <summary>
        /// Коллекция для хранения авторов.
        /// </summary>
        private readonly List<string> _authors = new();

        /// <summary>
        /// Свойство для получения списка авторов только для чтения.
        /// </summary>
        public IReadOnlyList<string> Authors => _authors;

        /// <summary>
        /// Метод для добавления одного или нескольких авторов.
        /// </summary>
        /// <param name="authors">Массив имён авторов для добавления.</param>
        public void AddAuthors
            (params string[] authors)
        {
            if (authors == null || authors.Length == 0)
            {
                throw new ArgumentException(
                    $"Значение параметра '{nameof(authors)}'" +
                    $" должно содержать минимум один элемент.");
            }

            foreach (var author in authors)
            {
                ValidateString(author, nameof(author));
                _authors.Add(author);
            }
        }

        /// <summary>
        /// Метод для получения информации о книге по ГОСТ.
        /// </summary>
        /// <returns>Строковое описание книги по ГОСТ.</returns>
        public override string GetGOST()
        {
            var bookInformation = new StringBuilder();

            int authorCount = _authors.Count;
            if (authorCount >= MinAuthorsForTitle
                && authorCount <= MaxAuthorsForTitle)
            {
                bookInformation.Append($"{_authors[0]} {Title}");
            }
            else
            {
                bookInformation.Append(Title);
            }

            AppendIfNotEmpty(bookInformation, " : ", TitleInformation);

            if (authorCount > 0)
            {
                bookInformation.Append(" / ");
                if (authorCount == SingleAuthor)
                {
                    bookInformation.Append(SwapAuthorFormat(_authors[0]));
                }
                else if (authorCount <= MaxAuthorsForFullList)
                {
                    var formattedAuthors = _authors.Select(SwapAuthorFormat);
                    bookInformation.Append(string.Join(", ",
                        formattedAuthors));
                }
                else
                {
                    var firstThree = _authors.Take(MaxAuthorsForFullList)
                        .Select(SwapAuthorFormat);
                    bookInformation.Append($"{string.Join(", ",
                        firstThree)} [и др.]");
                }
            }

            bookInformation.Append($" – {Place} : {Publisher}," +
                $" {Year} – {TotalPages} с.");

            return bookInformation.ToString();
        }

        /// <summary>
        /// Метод для преобразования формата имени автора.
        /// </summary>
        /// <param name="author">Имя автора в исходном формате.</param>
        /// <returns>Строковое представление автора в формате "Имя Фамилия".</returns>
        private string SwapAuthorFormat
            (string author)
        {
            var partsAuthor = author.Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            return $"{string.Join(" ", partsAuthor.Skip(1))}" +
                $" {partsAuthor[0]}";
        }
    }
}
