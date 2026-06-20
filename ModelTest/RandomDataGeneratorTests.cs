using Model;
using NUnit.Framework;

namespace ModelTest
{
    /// <summary>
    /// Класс для проведения тестов класса RandomDataGenerator
    /// </summary>
    [TestFixture]
    public class RandomDataGeneratorTests
    {
        /// <summary>
        /// Проверка генерации случайной книги
        /// </summary>
        [TestCase(TestName = "Проверка генерации случайной книги")]
        public void GenerateRandomBookTest()
        {
            var book = RandomDataGenerator.GenerateRandomBook();

            Assert.Multiple(() =>
            {
                Assert.That(book, Is.Not.Null);
                Assert.That(book, Is.InstanceOf<Book>());
                Assert.That(book.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(book.Year, Is.GreaterThan(0));
                Assert.That(book.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка генерации нескольких случайных книг
        /// </summary>
        [TestCase(TestName = "Проверка генерации нескольких случайных книг")]
        public void GenerateMultipleRandomBooksTest()
        {
            var book1 = RandomDataGenerator.GenerateRandomBook();
            var book2 = RandomDataGenerator.GenerateRandomBook();

            Assert.Multiple(() =>
            {
                Assert.That(book1, Is.Not.Null);
                Assert.That(book2, Is.Not.Null);
            });
        }

        /// <summary>
        /// Проверка генерации случайного журнала
        /// </summary>
        [TestCase(TestName = "Проверка генерации случайного журнала")]
        public void GenerateRandomJournalTest()
        {
            var journal = RandomDataGenerator.GenerateRandomJournal();

            Assert.Multiple(() =>
            {
                Assert.That(journal, Is.Not.Null);
                Assert.That(journal, Is.InstanceOf<Journal>());
                Assert.That(journal.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(journal.Year, Is.GreaterThan(0));
                Assert.That(journal.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка генерации случайного сборника
        /// </summary>
        [TestCase(TestName = "Проверка генерации случайного сборника")]
        public void GenerateRandomCollectionTest()
        {
            var collection = RandomDataGenerator.GenerateRandomCollection();

            Assert.Multiple(() =>
            {
                Assert.That(collection, Is.Not.Null);
                Assert.That(collection, Is.InstanceOf<Collection>());
                Assert.That(collection.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(collection.Year, Is.GreaterThan(0));
                Assert.That(collection.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка генерации случайной диссертации
        /// </summary>
        [TestCase(TestName = "Проверка генерации случайной диссертации")]
        public void GenerateRandomDissertationTest()
        {
            var dissertation = RandomDataGenerator.GenerateRandomDissertation();

            Assert.Multiple(() =>
            {
                Assert.That(dissertation, Is.Not.Null);
                Assert.That(dissertation, Is.InstanceOf<Dissertation>());
                Assert.That(dissertation.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(dissertation.Year, Is.GreaterThan(0));
                Assert.That(dissertation.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка, что генерация дает результаты
        /// </summary>
        [TestCase(TestName = "Проверка, что генерация дает результаты")]
        public void GenerateRandomDifferentResultsTest()
        {
            var book = RandomDataGenerator.GenerateRandomBook();
            var journal = RandomDataGenerator.GenerateRandomJournal();
            var collection = RandomDataGenerator.GenerateRandomCollection();
            var dissertation = RandomDataGenerator.GenerateRandomDissertation();

            Assert.Multiple(() =>
            {
                Assert.That(book, Is.Not.Null);
                Assert.That(journal, Is.Not.Null);
                Assert.That(collection, Is.Not.Null);
                Assert.That(dissertation, Is.Not.Null);
            });
        }

        /// <summary>
        /// Проверка корректности данных сгенерированной книги
        /// </summary>
        [TestCase(TestName = "Проверка корректности данных сгенерированной книги")]
        public void GeneratedBookDataValidityTest()
        {
            var book = RandomDataGenerator.GenerateRandomBook();

            Assert.Multiple(() =>
            {
                Assert.That(book, Is.Not.Null);
                Assert.That(book.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(book.Publisher, Is.Not.Null.And.Not.Empty);
                Assert.That(book.Place, Is.Not.Null.And.Not.Empty);
                Assert.That(book.Year, Is.GreaterThan(0));
                Assert.That(book.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка корректности данных сгенерированного журнала
        /// </summary>
        [TestCase(TestName = "Проверка корректности данных сгенерированного журнала")]
        public void GeneratedJournalDataValidityTest()
        {
            var journal = RandomDataGenerator.GenerateRandomJournal();

            Assert.Multiple(() =>
            {
                Assert.That(journal, Is.Not.Null);
                Assert.That(journal.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(journal.Publisher, Is.Not.Null.And.Not.Empty);
                Assert.That(journal.Place, Is.Not.Null.And.Not.Empty);
                Assert.That(journal.Year, Is.GreaterThan(0));
                Assert.That(journal.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка корректности данных сгенерированного сборника
        /// </summary>
        [TestCase(TestName = "Проверка корректности данных сгенерированного сборника")]
        public void GeneratedCollectionDataValidityTest()
        {
            var collection = RandomDataGenerator.GenerateRandomCollection();

            Assert.Multiple(() =>
            {
                Assert.That(collection, Is.Not.Null);
                Assert.That(collection.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(collection.Publisher, Is.Not.Null.And.Not.Empty);
                Assert.That(collection.Place, Is.Not.Null.And.Not.Empty);
                Assert.That(collection.Year, Is.GreaterThan(0));
                Assert.That(collection.TotalPages, Is.GreaterThan(0));
            });
        }

        /// <summary>
        /// Проверка корректности данных сгенерированной диссертации
        /// </summary>
        [TestCase(TestName = "Проверка корректности данных сгенерированной диссертации")]
        public void GeneratedDissertationDataValidityTest()
        {
            var dissertation = RandomDataGenerator.GenerateRandomDissertation();

            Assert.Multiple(() =>
            {
                Assert.That(dissertation, Is.Not.Null);
                Assert.That(dissertation.Title, Is.Not.Null.And.Not.Empty);
                Assert.That(dissertation.Publisher, Is.Not.Null.And.Not.Empty);
                Assert.That(dissertation.Place, Is.Not.Null.And.Not.Empty);
                Assert.That(dissertation.Year, Is.GreaterThan(0));
                Assert.That(dissertation.TotalPages, Is.GreaterThan(0));
                Assert.That(dissertation.AuthorFull, Is.Not.Null.And.Not.Empty);
                Assert.That(dissertation.Speciality, Is.Not.Null.And.Not.Empty);
                Assert.That(dissertation.Degree, Is.Not.Null.And.Not.Empty);
            });
        }
    }
}