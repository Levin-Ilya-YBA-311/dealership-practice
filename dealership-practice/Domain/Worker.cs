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
    public class Worker
    {
        public Worker(int id_worker, string fio, string function)
        {
            this.id_worker = id_worker;
            this.Fio = fio;
            this.function = function;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Worker"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Worker()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int id_worker { get; protected set; }

        /// <summary>
        /// ФИО.
        /// </summary>
        public virtual string Fio { get; protected set; }

        /// <summary>
        /// Роль.
        /// </summary>
        public virtual string function { get; protected set; }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.Fio} {this.function} ";
        }
    }
}
