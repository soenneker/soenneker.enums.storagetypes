[![](https://img.shields.io/nuget/v/soenneker.enums.storagetypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.storagetypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.storagetypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.storagetypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.storagetypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.storagetypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.storagetypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.storagetypes/actions/workflows/codeql.yml)

# Soenneker.Enums.StorageTypes

A string-backed enum-value type for selecting an in-memory, Redis, or Cosmos DB storage backend.

## Install

```bash
dotnet add package Soenneker.Enums.StorageTypes
```

## Usage

```csharp
using Soenneker.Enums.StorageTypes;

StorageType storage = StorageType.Redis;
string wireValue = storage.Value; // "Redis"

if (StorageType.TryFromValue(configuredValue, out StorageType? parsed))
{
    storage = parsed;
}
```

Available values:

- `Memory` — an in-memory implementation
- `Redis` — a Redis-backed implementation
- `Cosmos` — an Azure Cosmos DB-backed implementation

`System.Text.Json` serializes the type as the shown string value and restores recognized values to the shared static instances. `FromValue` throws for unknown input; use `TryFromValue` when reading configuration or requests. `FromName` and `TryFromName` are also generated.

This package identifies a backend; it does not create clients, register services, open connections, store data, or define durability and consistency behavior. The component consuming the value must document its concrete implementation and configuration. In particular, `Memory` does not inherently mean shared, durable, bounded, or safe for multi-instance deployments.
