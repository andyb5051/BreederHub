using Abp.Domain.Entities;
using Abp.EntityFramework.Repositories;

namespace breederhub.EntityFramework.Repositories
{
    public abstract class breederhubRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<breederhubDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class breederhubRepositoryBase<TEntity> : breederhubRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
