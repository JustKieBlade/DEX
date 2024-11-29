namespace Domain.Entities;

/// <summary>
/// Препарат
/// </summary>
public class Drug : BaseEntity
{
    
    /// <summary>
    /// Конструкор
    /// </summary>
    public Drug(string name, string manufacturer, string countryCodeId, Country country)
    {
        Name = name;
        Manufacturer = manufacturer;
        CountryCodeId = countryCodeId;
        Country = country;
        DrugItems = new Collection<DrugItem>();
    }

    /// <summary>
    /// Название препарата
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Производитель
    /// </summary>
    public string Manufacturer { get; private set; }

    /// <summary>
    /// Код страны
    /// </summary>
    public string CountryCodeId { get; private set; }

    /// <summary>
    /// Страна производства
    /// </summary>
    public Country Country { get; private set; }

    /// <summary>
    /// Связи с аптеками
    /// </summary>
    public Collection<DrugItem> DrugItems { get; private set; }
}