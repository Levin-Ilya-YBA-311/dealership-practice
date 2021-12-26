// <copyright file="IRepository.cs" company="МИИТ">
// Copyright (c) Кругов Ю.А. All rights reserved.
// </copyright>

namespace ORM.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Domain;
    using NHibernate;

    /// <summary>
    /// Репозиторий для Продажи автомобиля.
    /// </summary>
    public class CarsaleRepository : IRepository<Carsale>
    {
        private readonly ISession _session;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarsaleRepository"/>.
        /// </summary>
        /// <param name="session">Сессия для Продажи автомобиля.</param>
        public CarsaleRepository(ISession session)
        {
            this._session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Carsale> Filter(Expression<Func<Carsale, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        /// <inheritdoc/>
        public Carsale Find(Expression<Func<Carsale, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public Carsale Get(int id)
        {
            return this._session.Get<Carsale>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Carsale> GetAll()
        {
            return this._session.Query<Carsale>();
        }

        /// <inheritdoc/>
        public bool TryGet(int id, out Carsale Carsale)
        {
            Carsale = this.GetAll().SingleOrDefault(d => d.Id_carsale == id);
            return Carsale != null;
        }

        /// <inheritdoc/>
        public Carsale Create(Carsale Carsale)
        {
            var id = (int)this._session.Save(Carsale);
            this._session.Flush();
            return Carsale;
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            if (!this.TryGet(id, out var Carsale))
            {
                return;
            }

            this._session.Delete(Carsale);
            this._session.Flush();
        }

        /// <inheritdoc/>
        public void Update(Carsale Carsale)
        {
            this._session.Update(Carsale);
            this._session.Flush();
        }
    }
}