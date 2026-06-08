using System.Windows.Forms;

namespace View.Helper
{
    /// <summary>
    /// Класс-валидатор для проверки полей формы.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверяет, что все поля TextBox заполнены.
        /// </summary>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        /// <param name="textBoxes">Поля для проверки.</param>
        /// <returns>
        /// Возвращает true, если все поля заполнены;
        /// иначе false.
        /// </returns>
        internal static bool AreTextBoxesFilled(
            string errorMessage,
            params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox == null)
                {
                    continue;
                }

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show(
                        errorMessage,
                        "Ошибка ввода",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Проверяет, что поле содержит положительное целое число.
        /// </summary>
        /// <param name="textBox">Поле для проверки.</param>
        /// <param name="fieldName">Название поля для сообщения об ошибке.</param>
        /// <param name="result">Результат парсинга.</param>
        /// <returns>
        /// Возвращает true, если значение корректно;
        /// иначе false.
        /// </returns>
        internal static bool IsPositiveInteger(
            TextBox textBox,
            string fieldName,
            out int result)
        {
            result = 0;

            if (!int.TryParse(textBox.Text, out result) || result <= 0)
            {
                MessageBox.Show(
                    $"Поле '{fieldName}' должно быть положительным целым числом.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            return true;
        }
    }
}