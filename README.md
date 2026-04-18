## What changed from original project:

As very beginning of making [projectFrameCut](https://github.com/hexadecimal0x12e/projectFrameCut), I selected this library to implement AV decoding/encoding, etc. because this thing can let me call FFmpeg and read out frame directly, by all C# Managed code, save my time and increase the speed. ~~Also the alternative choice FFmpegKit has been discontinued at that time, and I don't want to take this risk of using something has no longer be maintainced.~~

When I'm trying to test projectFrameCut on Android, while I try to call this library on the Android platform, I found that I kept receiving the "PlatformNotSupportedException" error. After some diagnosis, I discovered that it was caused by the changes in .NET 5+ to System.OSPlatform. So that I fixed [this](https://github.com/Ruslan-B/FFmpeg.AutoGen/blob/master/FFmpeg.AutoGen/FunctionResolverFactory.cs#L15) file by use the modern [System.OperatingSystem API](https://learn.microsoft.com/dotnet/api/system.operatingsystem?view=net-9.0), also I added a Function Resolver for Android. ~~Finally this is fixed in the upstream repo~~

But, I found this is not the only problem while running on Android devices. After this fix, I start receive a "DllImportException" when I try to call the library, after days of fix, I finally discover why: "libdl.so.2" isn't exists on Android devices, and [dlopen](https://www.man7.org/linux/man-pages/man3/dlopen.3.html) moved to "libc.so" instead of libdl. I also added a user-friendly exception processing telling why libraries failed to load.

I also added a property ```AddVersionSuffixToLibraryPath```that allows you to manually disable adding a version suffix to library names when attempting to load a library. This can resolve issues where certain platforms remove the version suffix when packaging the application.

This fork is fully compatible with the original FFmpeg.AutoGen library (8.0.0 branch). 

By the way, I also implement the support of .NET's Native AOT support this fork. 

[![NuGet Version](https://img.shields.io/nuget/v/FFmpeg_droidFix.AutoGen)](https://www.nuget.org/packages/FFmpeg_droidFix.AutoGen/) get the fork here

## Important Announcement

**This project is undergoing a transition to a semi-managed model over the coming months.**

- **All existing packages and versions will continue to work** - there will be no breaking changes to existing functionality
- The project is now **MIT licensed** (changed from LGPL) - see LICENSE.txt for details
- **Contributions are welcome!** If you'd like to help with the project, please feel free to contribute
- The FFmpeg binaries continue to be distributed with their original licenses from the source

**Founder & Maintainer:** Ruslan Balanukhin (Rationale One)

For questions and support, please continue using [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or the [questions repository](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues).

---

# Important
**The FFmpeg API is vast and complex and this project exposes it with minimum modifications - support is very limited.
Please consider to ask *how to* questions on [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or in special repository on [github.com](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues). 
The community may be able to offer some assistance but you will largely be on your own.
As another option you can search for a solution in C(lang) as with some effort you can convert it to C#.**
Here repository with C# converted examples: https://github.com/stjeong/ffmpeg_autogen_cs

## FFmpeg.AutoGen 
[![main](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml/badge.svg)](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml)
[![nuget](https://img.shields.io/nuget/v/FFmpeg.AutoGen.svg)](https://www.nuget.org/packages/FFmpeg.AutoGen/)

FFmpeg auto generated unsafe bindings for C#/.NET and Mono.

## Usage

You may check to example project it shows how specify path to libraries, anc call these libraries like decode video, convert it and extract frames to jpeg.

The basic example of the library usage: video decoding, conversion and frame extraction to jpeg is included in ```FFmpeg.AutoGen.Example``` project.  
For the more sophisticated operations please refer to offical [ffmpeg Documentation](https://www.ffmpeg.org/documentation.html) expecially API section of it.
Nuget packages version uses [semantic versioning](https://semver.org/) and in sync with MAJOR and MINOR version of FFmpeg as PATCH incremets does not changing API.

- on Windows:  
  Native ffmpeg libraries are **NOT pre bundled in this repository**, not like the origin build. Obtain the binary by yourself, either by downloading from [ffmpeg official website](https://ffmpeg.org/download.html) or by compiling it by yourself.

  Set `ffmpeg.RootPath` to manual specify the path to the directory where the FFmpeg libraries are located. 
  
  Othwerwise the library will try to load them from the `AppDomain.CurrentDomain.BaseDirectory`.

- on OSX(macOS):
  > [!WARNING]
  > 
  > This library's MacOS usage mostly only works in Console/Avalonia application (untested, but maybe work if you don't use MAUI as backend) , not **MacCatalyst**
  
  Install ffmpeg via Homebrew (`brew install ffmpeg`) or download the assets from [ffmpeg official website](https://ffmpeg.org/download.html#build-mac) and put them in your project
  
  Then set static ```ffmpeg.RootPath = ``` with full path to FFmpeg libraries.

- on iOS/iPadOS/TvOS/WatchOS/VisionOS/MacCatalyst, etc. (.NET MAUI):

  **Currently not implemented yet.**

  But you may try implement a `IFunctionResolver` by yourself, and set `DynamicallyLoadedBindings.FunctionResolver` to it.

- on Android (.NET MAUI):
    Follow these steps to use this library on Android:
    1. add these code to any place in your app (suggested in ```MauiProgram.cs```) before you call any FFmpeg functions:
    ```csharp
    #if ANDROID
    ffmpeg.RootPath = Android.App.Application.Context.ApplicationInfo.NativeLibraryDir;
    JavaSystem.LoadLibrary("c");
    #endif
    ```

    2. Then, create a directory inside ```<your .NET MAUI project root path>/Platforms/Android/```, name it whatever you want. Create a folder named same as the FFmpeg libraries' ABI name (like ```arm64-v8a```) your get/compile inside the folder your created. Put all ```.so``` files inside it, don't add any suffix or prefix.

    3. Add these things to the project's ```.csproj``` file:
    ```xml
    <ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'android'">
            <AndroidNativeLibrary Include="Platforms\Android\<name of the directory your named>\**\*.so" />
    </ItemGroup>
    ```
    Don't forget to replace ```<name of the directory your named>``` to the name of the directory your named in 2nd step.

    Your project's file structure should like this:
    ```
    .
    |   
    |
    \---Platforms
        +---Android
        |   |   ......
        |   |
        |   +---Assets
        |   +---ffmpeg
        |   |   \---arm64-v8a
        |   |           libavcodec.so
        |   |           libavfilter.so
        |   |           libavformat.so
        |   |           libavutil.so
        |   |           libswresample.so
        |   |           libswscale.so
        |   |
        |   +---Resources
        |   ......
        |
    ......
    ```

- on Linux:  
Use your package manager of choice, or download the assets from [ffmpeg official website](https://ffmpeg.org/download.html#build-linux) and put them in your project.

  Similar to Windows, set `ffmpeg.RootPath` to manual specify the path to the directory where the FFmpeg libraries are located.
  
  Othwerwise the library will try to load them from the `AppDomain.CurrentDomain.BaseDirectory`.

## Generation

The bindings generator uses [CppSharp](https://github.com/mono/CppSharp).

Prerequisites:
 - Visual Studio 2022 with C# and C++ desktop development workloads and Windows SDK for desktop.

Steps to generate:
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## License

Copyright © 2025 Ruslan Balanukhin (Rationale One)  
All rights reserved.

Distributed under the **MIT License**.  
See LICENSE.txt for full license text.

**Note:** FFmpeg binaries are distributed under their original licenses (GPL/LGPL) from the source.
Please refer to [FFmpeg License](https://www.ffmpeg.org/legal.html) for details.

The fork is created by hexadecimal0x12e. Copyright © 2025-2026 hexadecimal0x12e. All rights reserved.

