namespace Domain.Entities;

/// <summary>
/// Базовая сущность
/// </summary>
public class BaseEntity
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Время создания объекта
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Сравнение идентификаторов (слегкка изменил для работы сравнения)
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        var other = (BaseEntity)obj;
        return other.Id == Id;
    }

    /// <summary>
    /// Переопределение GetHashCode
    /// Как подсказал чат (не знаю, правильно ли это) :
    /// Если два объекта равны согласно Equals(), их хэш-коды, возвращаемые GetHashCode(), также должны быть равны.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    
    /// <summary>
    /// Переопределение ==
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator == (BaseEntity left, BaseEntity right)
    {
        if (left is null || right is null)
        {
            return false;
        }
        
        return left.Equals(right);
    }
    
    /// <summary>
    /// Переопределение !=
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(BaseEntity left, BaseEntity right)
    {
        if (left is null || right is null)
        {
            return false;
        }
        
        return !(left == right);
    }
}

