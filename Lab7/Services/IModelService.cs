using Lab7.Models;

namespace Lab7.Services;

public interface IModelService<T> where T : Model
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T?> GetByIdAsync(Guid id);

    Task<T> CreateAsync(T data);

    Task<bool> UpdateAsync(T data);

    Task<bool> DeleteAsync(Guid id);
}
