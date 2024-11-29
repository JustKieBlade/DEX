namespace Domain.Entities;

/// <summary>
/// Страна
/// </summary>
public class Country : BaseEntity
{
    
    /// <summary>
    /// Конструкор
    /// </summary>
    public Country(string name, string code)
    {
        Name = name;
        Code = code;
        Drugs = new Collection<Drug>();
    }

    /// <summary>
    /// Название страны
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Код страны
    /// </summary>
    public string Code { get; private set; }

    /// <summary>
    /// Список препаратов страны
    /// </summary>
    public Collection<Drug> Drugs { get; private set; }
}