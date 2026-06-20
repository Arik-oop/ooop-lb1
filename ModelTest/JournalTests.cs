using Model;
using NUnit.Framework;

namespace ModelTest
{
    /// <summary>
    /// Класс для проведения тестов класса Journal
    /// </summary>
    [TestFixture]
    public class JournalTests : PublicationBaseChildTests<Journal>
    {
        /// <summary>
        /// Проверка корректных данных для свойства Frequency
        /// </summary>
        [TestCase("Ежедневный", TestName = "Ежедневный")]
        [TestCase("Еженедельный", TestName = "Еженедельный")]
        [TestCase("Ежемесячный", TestName = "Ежемесячный")]
        [TestCase("Ежеквартальный", TestName = "Ежеквартальный")]
        [TestCase("Полугодовой", TestName = "Полугодовой")]
        [TestCase("Годовой", TestName = "Годовой")]
        [TestCase("С прочей периодичностью", TestName = "С прочей периодичностью")]
        [TestCase("С неопределенной периодичностью", TestName = "С неопределенной периодичностью")]
        [TestCase("Любая другая частота", TestName = "Произвольная частота")]
        public void FrequencyAssertionTest(string frequency)
        {
            var journal = new Journal();
            journal.Frequency = frequency;
            Assert.That(journal.Frequency, Is.EqualTo(frequency));
        }

        /// <summary>
        /// Проверка некорректных данных для свойства Frequency
        /// </summary>
        [TestCase("", TestName = "Пустая строка")]
        [TestCase("   ", TestName = "Строка из пробелов")]
        [TestCase(null, TestName = "Null значение")]
        public void FrequencyNegativeTest(string? invalidFrequency)
        {
            var journal = new Journal();
            Assert.Throws<ArgumentException>(
                () => journal.Frequency = invalidFrequency);
        }

        /// <summary>
        /// Проверка метода GetGOST() с полными данными
        /// </summary>
        [TestCase(TestName = "Проверка метода GetGOST() с полными данными")]
        public void GetGOSTFullDataTest()
        {
            var journal = new Journal
            {
                Title = "Наука и жизнь",
                TitleInformation = "научно-популярный журнал",
                Publisher = "Наука",
                Place = "Москва",
                Year = 2023,
                TotalPages = 96,
                Frequency = "Ежемесячный"
            };
            string result = journal.GetGOST();
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.Contain("Наука и жизнь"), "Заголовок не найден");
                Assert.That(result, Does.Contain("научно-популярный журнал"), "Подзаголовок не найден");
                Assert.That(result, Does.Contain("Наука"), "Издательство не найдено");
                Assert.That(result, Does.Contain("Москва"), "Место не найдено");
                Assert.That(result, Does.Contain("2023"), "Год не найден");
                Assert.That(result, Does.Contain("96 с."), "Страницы не найдены");
                Assert.That(result, Does.Contain("Ежемесячный"), "Частота не найдена");
            });
        }

        /// <summary>
        /// Проверка метода GetGOST() с минимальными данными
        /// </summary>
        [TestCase(TestName = "Проверка метода GetGOST() с минимальными данными")]
        public void GetGOSTMinimalDataTest()
        {
            var journal = new Journal
            {
                Title = "Минимальный журнал",
                Publisher = "МинИздат",
                Place = "Минск",
                Year = 2025,
                TotalPages = 30
            };
            string result = journal.GetGOST();
            Assert.Multiple(() =>
            {
                Assert.That(result, Does.Contain("Минимальный журнал"), "Заголовок не найден");
                Assert.That(result, Does.Contain("МинИздат"), "Издательство не найдено");
                Assert.That(result, Does.Contain("Минск"), "Место не найдено");
                Assert.That(result, Does.Contain("2025"), "Год не найден");
                Assert.That(result, Does.Contain("30 с."), "Страницы не найдены");
            });
        }
    }
}