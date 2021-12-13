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
    /// Репозиторий для Работника.
    /// </summary>
    public class WorkerRepository : IRepository<Worker>
    {
        private readonly ISession _session;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="WorkerRepository"/>.
        /// </summary>
        /// <param name="session">Сессия для Работника.</param>
        public WorkerRepository(ISession session)
        {
            this._session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Worker> Filter(Expression<Func<Worker, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        /// <inheritdoc/>
        public Worker Find(Expression<Func<Worker, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public Worker Get(int id)
        {
            return this._session.Get<Worker>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Worker> GetAll()
        {
            return this._session.Query<Worker>();
        }

        /// <inheritdoc/>
        public bool TryGet(int id, out Worker Worker)
        {
            Worker = this.GetAll().SingleOrDefault(d => d.id_worker == id);
            return Worker != null;
        }

        /// <inheritdoc/>
        public Worker Create(Worker Worker)
        {
            var id = (int)this._session.Save(Worker);
            this._session.Flush();
            return Worker;
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            if (!this.TryGet(id, out var Worker))
            {
                return;
            }

            this._session.Delete(Worker);
            this._session.Flush();
        }

        /// <inheritdoc/>
        public void Update(Worker Worker)
        {
            this._session.Update(Worker);
            this._session.Flush();
        }
    }
}