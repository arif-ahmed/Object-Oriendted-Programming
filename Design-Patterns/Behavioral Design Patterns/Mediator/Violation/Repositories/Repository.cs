namespace Mediator.Violation.Repositories;

public class Repository<TEntity>
{
    private readonly List<TEntity> _entities = new List<TEntity>();
    public void Add(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
        }
        _entities.Add(entity);

        Console.WriteLine($"Entity of type {typeof(TEntity).Name} added.");
    }
    public void Remove(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Entity cannot be null.");
        }
        _entities.Remove(entity);
    }
    public IEnumerable<TEntity> GetAll()
    {
        return _entities.AsReadOnly();
    }
    public TEntity? Find(Func<TEntity, bool> predicate)
    {
        return _entities.FirstOrDefault(predicate);
    }
}
