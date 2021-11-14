using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealershippractice.Domain
{
    /// <summary>
    ///  класс Сотрудник.
    /// </summary>
    class Woker
    {
        public Woker(int id_woker, string fio, string function)
        {
            this.id_woker = id_woker;
            this.fio = fio;
            this.function = function;
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public int id_woker { get; protected set; }

        /// <summary>
        /// ФИО.
        /// </summary>
        public string fio { get; protected set; }

        /// <summary>
        /// Роль.
        /// </summary>
        public string function { get; protected set; }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.fio} {this.function} ";
        }
    }
}
