namespace Domain.ValueObjects;

/// <summary>
/// BaseValueObject
/// </summary>
public class BaseValueObject
{
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Сравнение объектов значений
    /// </summary>
    public override bool Equals(object? obj)
    {
        // Проверка на null и совпадение типов
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        // Сравнение идентификаторов
        var other = (BaseValueObject)obj;
        return other.Id == Id;
    }

    /// <summary>
    /// Получение хэш-кода
    /// </summary>
    public override int GetHashCode()
    {
        // Хэш-код основан на идентификаторе
        return Id.GetHashCode();
    }

    /// <summary>
    /// Оператор равенства (на контрасте с сравнением в BaseEntity такой вариант (подсказал чат)
    /// </summary>
    public static bool operator ==(BaseValueObject? left, BaseValueObject? right)
    {
        // Если оба null, считаем равными
        if (ReferenceEquals(left, null) && ReferenceEquals(right, null)) return true;

        // Если один null, считаем неравными
        if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;

        // Используем Equals для сравнения
        return left.Equals(right);
    }

    /// <summary>
    /// Оператор неравенства
    /// </summary>
    public static bool operator !=(BaseValueObject? left, BaseValueObject? right)
    {
        return !(left == right);
    }
}