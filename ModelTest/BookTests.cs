using Model;
using NUnit.Framework;

namespace ModelTest
{
    /// <summary>
    /// Класс для проведения тестов класса Book
    /// </summary>
    [TestFixture]
    public class BookTests : PublicationBaseChildTests<Book>
    {
        [TestCase(TestName = "Проверка метода AddAuthors() с одним автором")]
        public void AddAuthorsSingleAuthorAssertionTest()
        {
            var book = new Book();
            book.AddAuthors("Иванов И.И.");
            Assert.That(book.Authors.Count, Is.EqualTo(1));
            Assert.That(book.Authors[0], Is.EqualTo("Иванов И.И."));
        }

        [TestCase(TestName = "Проверка метода AddAuthors() с двумя авторами")]
        public void AddAuthorsTwoAuthorsAssertionTest()
        {
            var book = new Book();
            book.AddAuthors("Иванов И.И.", "Петров П.П.");
            Assert.That(book.Authors.Count, Is.EqualTo(2));
            Assert.That(book.Authors[0], Is.EqualTo("Иванов И.И."));
            Assert.That(book.Authors[1], Is.EqualTo("Петров П.П."));
        }

        [TestCase(TestName = "Проверка метода AddAuthors() с тремя авторами")]
        public void AddAuthorsThreeAuthorsAssertionTest()
        {
            var book = new Book();
            book.AddAuthors("Иванов И.И.", "Петров П.П.", "Сидоров С.С.");
            Assert.That(book.Authors.Count, Is.EqualTo(3));
            Assert.That(book.Authors[0], Is.EqualTo("Иванов И.И."));
            Assert.That(book.Authors[1], Is.EqualTo("Петров П.П."));
            Assert.That(book.Authors[2], Is.EqualTo("Сидоров С.С."));
        }

        [TestCase(TestName = 
            "Проверка метода AddAuthors() с некорректными данными")]
        public void AddAuthorsAssertionNegativeTest()
        {
            var book = new Book();
            Assert.Throws<ArgumentException>(() => book.AddAuthors(null));
            Assert.Throws<ArgumentException>(() 
                => book.AddAuthors(new string[0]));
        }

        [TestCase("", TestName = "Добавление пустого автора")]
        [TestCase("   ", TestName = "Добавление автора из пробелов")]
        [TestCase(null, TestName = "Добавление null автора")]
        public void AddAuthorsInvalidAuthorNegativeTest(string? invalidAuthor)
        {
            var book = new Book();
            Assert.Throws<ArgumentException>(() 
                => book.AddAuthors(invalidAuthor));
        }

        [TestCase(TestName = "Проверка метода GetGOST() с одним автором")]
        public void GetGOSTOneAuthorAssertionTest()
        {
            var book = new Book
            {
                Title = "Программирование на C#",
                TitleInformation = "учебное пособие",
                Place = "Москва",
                Publisher = "Питер",
                Year = 2023,
                TotalPages = 500
            };
            book.AddAuthors("Иванов Иван Иванович");
            string result = book.GetGOST();
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.Contain("Программирование на C#"),
                    "Заголовок не найден");
                Assert.That(result, Does.Contain("учебное пособие"),
                    "Подзаголовок не найден");
                Assert.That(result, Does.Contain("Москва"), 
                    "Место не найдено");
                Assert.That(result, Does.Contain("Питер"), 
                    "Издательство не найдено");
                Assert.That(result, Does.Contain("2023"), "Год не найден");
                Assert.That(result, Does.Contain("500 с."), 
                    "Страницы не найдены");
            });
        }


        [TestCase(TestName = "Проверка метода GetGOST() с двумя авторами")]
        public void GetGOSTTwoAuthorsAssertionTest()
        {
            var book = new Book
            {
                Title = "Программирование",
                Place = "Санкт-Петербург",
                Publisher = "БХВ",
                Year = 2022,
                TotalPages = 300
            };
            book.AddAuthors("Иванов Иван Иванович", "Петров Петр Петрович");
            string result = book.GetGOST();
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.Contain("Программирование"), 
                    "Заголовок не найден");
                Assert.That(result, Does.Contain("Санкт-Петербург"), 
                    "Место не найдено");
                Assert.That(result, Does.Contain("БХВ"), 
                    "Издательство не найдено");
                Assert.That(result, Does.Contain("2022"), "Год не найден");
            });
        }

        [TestCase(TestName = "Проверка метода GetGOST() с тремя авторами")]
        public void GetGOSTThreeAuthorsAssertionTest()
        {
            var book = new Book
            {
                Title = "Алгоритмы и структуры данных",
                Place = "Москва",
                Publisher = "Вильямс",
                Year = 2023,
                TotalPages = 400
            };
            book.AddAuthors("Иванов Иван Иванович", "Петров Петр Петрович", 
                "Сидоров Сидор Сидорович");
            string result = book.GetGOST();
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.Contain("Алгоритмы и структуры данных"), 
                    "Заголовок не найден");
                Assert.That(result, Does.Contain("Москва"), 
                    "Место не найдено");
            });
        }

        [TestCase(TestName = "Проверка метода GetGOST() с четырьмя и более авторами")]
        public void GetGOSTFourAuthorsAssertionTest()
        {
            var book = new Book
            {
                Title = "Современное программирование",
                Place = "Москва",
                Publisher = "Наука",
                Year = 2024,
                TotalPages = 400
            };
            book.AddAuthors("Иванов И.И.", "Петров П.П.", 
                "Сидоров С.С.", "Козлов К.К.");
            string result = book.GetGOST();
            Assert.That(result, Does.Contain("[и др.]"));
        }

        [TestCase(TestName = "Проверка метода GetGOST() без авторов")]
        public void GetGOSTNoAuthorsAssertionTest()
        {
            var book = new Book
            {
                Title = "Тестовая книга",
                Place = "Москва",
                Publisher = "Тест",
                Year = 2024,
                TotalPages = 100
            };
            string result = book.GetGOST();
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.StartWith("Тестовая книга"));
                Assert.That(result, Does.Not.Contain(" / "));
            });
        }

        [TestCase(TestName = "Проверка свойства Authors (только для чтения)")]
        public void AuthorsReadOnlyAssertionTest()
        {
            var book = new Book();
            book.AddAuthors("Иванов И.И.");
            Assert.Multiple(() =>
            {
                Assert.That(book.Authors, Is.Not.Null);
                Assert.That(book.Authors.Count, Is.EqualTo(1));
            });
        }
    }
}