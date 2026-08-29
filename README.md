[![](https://img.shields.io/nuget/v/soenneker.tags.util.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tags.util/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tags.util/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.tags.util/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.tags.util.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tags.util/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tags.util/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.tags.util/actions/workflows/codeql.yml)

# Soenneker.Tags.Util

Defines the tags util contract.

## Install

```bash
dotnet add package Soenneker.Tags.Util
```

## Quick start

```csharp
using Soenneker.Tags.Util.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddTagsUtilAsScoped();
```

Registers Tags Util with a scoped lifetime.

## What you get

- `ITagsUtil` — Defines the tags util contract.
- `TagsUtilRegistrar` — Represents the tags util registrar.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ITagsUtil.OpenFile(filePath)` | Opens a media file using TagLibSharp, logs tag information, and logs errors if they occur. The file is not stored beyond the scope of this method. | The resulting tag Lib.File. |
| `TagsUtilRegistrar.AddTagsUtilAsScoped(services)` | Registers Tags Util with a scoped lifetime. | The same service collection, so additional registrations can be chained. |
