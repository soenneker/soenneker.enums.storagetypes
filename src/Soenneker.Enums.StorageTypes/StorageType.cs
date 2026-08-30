using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.StorageTypes;

/// <summary>
/// Identifies a supported storage backend category.
/// </summary>
[EnumValue<string>]
public sealed partial class StorageType
{
    /// <summary>
    /// In-memory storage.
    /// </summary>
    public static readonly StorageType Memory = new(nameof(Memory));

    /// <summary>
    /// Redis-backed storage.
    /// </summary>
    public static readonly StorageType Redis = new(nameof(Redis));

    /// <summary>
    /// Azure Cosmos DB-backed storage.
    /// </summary>
    public static readonly StorageType Cosmos = new(nameof(Cosmos));
}
