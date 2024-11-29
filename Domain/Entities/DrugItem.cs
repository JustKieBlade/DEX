namespace Domain.Entities;

/// <summary>
/// Связь между препаратом и аптекой
/// </summary>
public class DrugItem : BaseEntity
{
    
    /// <summary>
    /// Конструкор
    /// </summary>
    public DrugItem(Guid drugId, Guid drugStoreId, decimal cost, int count, Drug drug, DrugStore drugStore)
    {
        DrugId = drugId;
        DrugStoreId = drugStoreId;
        Cost = cost;
        Count = count;
        Drug = drug;
        DrugStore = drugStore;
    }

    /// <summary>
    /// Идентификатор препарата
    /// </summary>
    public Guid DrugId { get; private set; }

    /// <summary>
    /// Идентификатор аптеки
    /// </summary>
    public Guid DrugStoreId { get; private set; }

    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal Cost { get; private set; }

    /// <summary>
    /// Количество на складе
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Навигационное свойство к препарату
    /// </summary>
    public Drug Drug { get; private set; }

    /// <summary>
    /// Навигационное свойство к аптеке
    /// </summary>
    public DrugStore DrugStore { get; private set; }
}