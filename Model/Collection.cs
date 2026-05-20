using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    /// Класс, описывающий издание сборника.
    /// </summary>
    public class Collection : PublicationBase
    {
        /// <summary>
        /// Список редакционной коллегии.
        /// </summary>
        private string _editorialBoard;

        /// <summary>
        /// Список ответственных редакторов.
        /// </summary>
        private string _responsibleEditors;

        /// <summary>
        /// Свойство редакционной коллегии.
        /// </summary>
        public string EditorialBoard
        {
            get => _editorialBoard;
            set
            {
                ValidateString(value, nameof(EditorialBoard));
                _editorialBoard = value;
            }
        }

        /// <summary>
        /// Свойство ответственных редакторов.
        /// </summary>
        public string ResponsibleEditors
        {
            get => _responsibleEditors;
            set
            {
                ValidateString(value, nameof(ResponsibleEditors));
                _responsibleEditors = value;
            }
        }

        /// <summary>
        /// Метод для получения информации о сборнике по ГОСТ.
        /// </summary>
        /// <returns>Строковое описание сборника по ГОСТ.</returns>
        public override string GetGOST()
        {
            var collectionInformation = new StringBuilder();

            collectionInformation.Append($"{Title}");

            AppendIfNotEmpty(collectionInformation, " : ", TitleInformation);

            collectionInformation.Append($" / редкол : {EditorialBoard}," +
                $" отв. ред. {ResponsibleEditors} - {Place} " +
                $": Изд-во {Publisher}, {Year}. - {TotalPages} с.");

            return collectionInformation.ToString();
        }
    }
}
