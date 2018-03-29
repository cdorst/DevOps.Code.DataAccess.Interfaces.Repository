// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using DevOps.Code.Entities.Interfaces.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DevOps.Code.DataAccess.Interfaces.Repository
{
    /// <summary>Represents a generic data-access repository</summary>
    public interface IRepository
        where TDbContext : DbContext
        where TEntity : class, IEntity<TKey>
        where TKey : struct
    {
        /// <summary>Adds the entity to the data repository</summary>
        Task<TEntity> AddAsync(TEntity entity);

        /// <summary>Finds an entity with the given key</summary>
        Task<TEntity> FindAsync(TKey key);

        /// <summary>Removes the entity from the data repository</summary>
        Task RemoveAsync(TKey key);

        /// <summary>Replaces an entity in the data repository</summary>
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
