# MSEssentials.Extensions

### Set of helpers, class extensions, UI controls used in my other C# projects

MSEssentials is package of useful classes, helpers, extensions and UI controls, I use in my C# projects. Extensions subpackage contains classes extensions.

---

## NuGet registry status

| Subpackage                        | Status                                                                                                                                                                                                            |
|-----------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **MSEssentials.Extensions**       | [![NuGet version (MSEssentials.Extensions)](https://img.shields.io/nuget/v/MSEssentials.Extensions.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.Extensions/)                               |
| MSEssentials.AspNetCore.Attributes           | [![NuGet version (MSEssentials.AspNetCore.Attributes)](https://img.shields.io/nuget/v/MSEssentials.AspNetCore.Attributes.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.AspNetCore.Attributes/)                               |
| MSEssentials.UI.Common.MVVM       | [![NuGet version (MSEssentials.UI.Common.MVVM)](https://img.shields.io/nuget/v/MSEssentials.UI.Common.MVVM.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.Common.MVVM/)                   |
| MSEssentials.UI.Common.Extensions | [![NuGet version (MSEssentials.UI.Common.Extensions)](https://img.shields.io/nuget/v/MSEssentials.UI.Common.Extensions.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.Common.Extensions/) |
| MSEssentials.UI.WinUI.Behaviors   | [![NuGet version (MSEssentials.UI.WinUI.Behaviors)](https://img.shields.io/nuget/v/MSEssentials.UI.WinUI.Behaviors.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.WinUI.Behaviors/)       |
| MSEssentials.UI.WinUI.Converters  | [![NuGet version (MSEssentials.UI.WinUI.Converters)](https://img.shields.io/nuget/v/MSEssentials.UI.WinUI.Converters.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.WinUI.Converters/)    |
| MSEssentials.UI.WinUI.Controls    | [![NuGet version (MSEssentials.UI.WinUI.Controls)](https://img.shields.io/nuget/v/MSEssentials.UI.WinUI.Controls.svg?style=flat-square)](https://www.nuget.org/packages/MSEssentials.UI.WinUI.Controls/)          |

## Features

- **StringExtensions**
    - *(static)* **CreateRandom** - returns random string
    - **Shuffle** - returns shuffled string
- **HttpClientExtensions**
    - **DownloadAsync** - allows to track progress of downloading data
- **StreamExtensions**
    - **CopyToAsync** - allows to track progress of copying data
- **IEnumerableExtensions**
    - **Random** - returns random item from IEnumerable

## Installation and usage

You can download package from official NuGet registry or .nupkg file itself from Releases tab.

**CLI:**

```
dotnet add package MSEssentials.Extensions
```

**Package reference in .csproj file:**

```
<PackageReference Include="MSEssentials.Extensions" Version="<version>" />
```

## Attribution and contribution

This project is open source on MIT License, so you can just copy and upload again to your repository. But according to the license, you must include information about the original author. You can find license [here](https://repos.mateuszskoczek.com/MSEssentials/MSEssentials.Extensions/src/branch/main/LICENSE).

However, the preferred way to contribute would be to propose improvements in a pull request, through issues, or through other means of communication.

**Other sources:**

- Icon by [Icons8](icons8.com)