1. Which IDE should I use to open the Tencent Cloud 3.0 .NET SDK code?
The Tencent Cloud 3.0 .NET SDK code supports .NET Framework 4.5 and .NET Standard 2.0. You can use Visual Studio 2017 or Visual Studio Code for editing the code, and use the .NET Core CLI tool dotnet. If you are developing a new application, .NET Standard 2.0 supports .NET Core 2.0/2.1. It is recommended to use .NET Core 2.1, which allows cross-platform operation on both Windows and Linux.

2. How do I reference the Tencent Cloud 3.0 SDK?
Install the 3.0 SDK via NuGet. It can be referenced in various ways. If you encounter any issues during use, please feel free to submit an issue on GitHub.

3. How do I handle reference version conflicts?
The 3.0 SDK depends on two packages: Newtonsoft.Json and Pathoschild.Http.FluentClient. There is a possibility of conflict with different versions of these packages referenced in your project. If you are using Visual Studio 2017, add <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects> inside the project's <PropertyGroup> element (or equivalent in the .csproj file). For details, please refer to: https://docs.microsoft.com/zh-cn/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection
