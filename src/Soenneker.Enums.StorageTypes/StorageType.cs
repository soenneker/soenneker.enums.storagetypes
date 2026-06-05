using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.StorageTypes;

/// <summary>
/// An enumerator for common storage types
/// </summary>
[EnumValue<string>]
public sealed partial class StorageType
{
    /// <summary>
    /// The memory.
    /// </summary>
    public static readonly StorageType Memory = new(nameof(Memory));

    /// <summary>
    /// The redis.
    /// </summary>
    public static readonly StorageType Redis = new(nameof(Redis));

    /// <summary>
    /// The cosmos.
    /// </summary>
    public static readonly StorageType Cosmos = new(nameof(Cosmos));
}