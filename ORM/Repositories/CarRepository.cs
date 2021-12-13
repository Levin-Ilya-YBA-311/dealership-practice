// <copyright file="IRepository.cs" company="МИИТ">
// Copyright (c) Кругов Ю.А. All rights reserved.
// </copyright>

namespace ORM.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using dealershippractice.Domain;
    using NHibernate;

    /// <summary>
    /// Репозиторий для Автомобиля.
    /// </summary>
    public class CarRepository : IRepository<Car>
    {
        private readonly ISession _session;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarRepository"/>.
        /// </summary>
        /// <param name="session">Сессия для Автомобиля.</param>
        public CarRepository(ISession session)
        {
            this._session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Car> Filter(Expression<Func<Car, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        /// <inheritdoc/>
        public Car Find(Expression<Func<Car, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public Car Get(int id)
        {
            return this._session.Get<Car>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Car> GetAll()
        {
            return this._session.Query<Car>();
        }

        /// <inheritdoc/>
        public bool TryGet(int id, out Car Car)
        {
            Car = this.GetAll().SingleOrDefault(d => d.id_car == id);
            return Car != null;
        }

        /// <inheritdoc/>
        public Car Create(Car Car)
        {
            var id = (int)this._session.Save(Car);
            this._session.Flush();
            return Car;
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            if (!this.TryGet(id, out var Car))
            {
                return;
            }

            this._session.Delete(Car);
            this._session.Flush();
        }

        /// <inheritdoc/>
        public void Update(Car Car)
        {
            this._session.Update(Car);
            this._session.Flush();
        }
    }
}