using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.StorageTypes;

/// <summary>
/// An enumerator for common storage types
/// </summary>
[EnumValue<string>]
public sealed partial class StorageType
{
    public static readonly StorageType Memory = new(nameof(Memory));

    public static readonly StorageType Redis = new(nameof(Redis));

    public static readonly StorageType Cosmos = new(nameof(Cosmos));
}