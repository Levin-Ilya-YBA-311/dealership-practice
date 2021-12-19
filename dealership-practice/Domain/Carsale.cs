using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealershippractice.Domain
{
    /// <summary>
    /// класс Продажа автомобиля.
    /// </summary>
    public class Carsale
    {
        public Carsale(int id_carsale, int id_car, int id_worker, DateTime sale_date, double total_price)
        {
            this.id_carsale = id_carsale;
            this.id_car = id_car;
            this.id_worker = id_worker;
            this.sale_date = sale_date;
            this.total_price = total_price;
            
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Carsale"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Carsale()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int id_carsale { get; protected set; }

        /// <summary>
        /// Автомобиль (уникальный ключ).
        /// </summary>
        public virtual int  id_car { get; protected set; }

        /// <summary>
        /// Сотрудник (уникальный ключ).
        /// </summary>
        public virtual int id_worker { get; protected set; }

        /// <summary>
        /// Дата продажи.
        /// </summary>
        public virtual DateTime sale_date { get; protected set; }

        /// <summary>
        /// итоговая стоимость.
        /// </summary>
        public virtual double total_price { get; protected set; }

       
        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.sale_date} {this.total_price} ";
        }


    }
}


