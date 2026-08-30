[![](https://img.shields.io/nuget/v/soenneker.tags.util.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tags.util/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tags.util/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.tags.util/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.tags.util.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tags.util/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tags.util/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.tags.util/actions/workflows/codeql.yml)

# Soenneker.Tags.Util

A small, logging-aware wrapper for opening media files with TagLibSharp.

## Installation

```bash
dotnet add package Soenneker.Tags.Util
```

## Registration

```csharp
using Soenneker.Tags.Util.Registrars;

builder.Services.AddTagsUtilAsScoped();
```

## Reading tags

```csharp
using Soenneker.Tags.Util.Abstract;

public sealed class MediaInspector(ITagsUtil tags)
{
    public string? GetTitle(string path)
    {
        using TagLib.File? file = tags.OpenFile(path);
        return file?.Tag.Title;
    }
}
```

`OpenFile` returns `null` and logs the exception when TagLibSharp cannot open or recognize the file. It does not throw those open failures to the caller. If the application needs to distinguish missing files, unsupported formats, and access failures, use TagLibSharp directly or inspect the configured logs.

## Ownership and writes

The caller owns every non-null `TagLib.File` returned by `OpenFile` and must dispose it promptly so file handles are released.

The returned object is the full TagLibSharp file API. Changing its tag properties is in memory until `Save()` is called; calling `Save()` modifies the media file. Validate paths and authorization before exposing that capability to untrusted input.
