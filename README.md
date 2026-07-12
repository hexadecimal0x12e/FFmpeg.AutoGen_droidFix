FFmpeg auto generated unsafe bindings for C#/.NET.

## What changed from original project:

As very beginning of making [projectFrameCut](https://github.com/hexadecimal0x12e/projectFrameCut), I selected this library to implement AV decoding/encoding, etc. because this thing can let me call FFmpeg and read out frame directly, by all C# Managed code, save my time and increase the speed. ~~Also the alternative choice FFmpegKit has been discontinued at that time, and I don't want to take this risk of using something has no longer be maintainced.~~ 

When I'm trying to test projectFrameCut on Android, while I try to call this library on the Android platform, I found that I kept receiving the "PlatformNotSupportedException" error. After some diagnosis, I discovered that it was caused by the changes in .NET 5+ to System.OSPlatform. So that I fixed [this](https://github.com/Ruslan-B/FFmpeg.AutoGen/blob/master/FFmpeg.AutoGen/FunctionResolverFactory.cs#L15) file by use the modern [System.OperatingSystem API](https://learn.microsoft.com/dotnet/api/system.operatingsystem?view=net-9.0), also I added a Function Resolver for Android. ~~Finally this is fixed in the upstream repo, but it still could not be used on Android.~~

But, I found this is not the only problem while running on Android devices. After this fix, I start receive a "DllImportException" when I try to call the library, after days of fix, I finally discover why: "libdl.so.2" isn't exists on Android devices, and [dlopen](https://www.man7.org/linux/man-pages/man3/dlopen.3.html) moved to "libc.so" instead of libdl. I also added a user-friendly exception processing telling why libraries failed to load.

I also added a property ```AddVersionSuffixToLibraryPath```that allows you to manually disable adding a version suffix to library names when attempting to load a library. This can resolve issues where certain platforms remove the version suffix when packaging the application.

This fork is fully compatible with the original FFmpeg.AutoGen library with only a little bit breaking change (after 8.0.0.1, before that is almost compatible). 

~~This project is intended to fix the compatibility issues only on FFmpeg.AutoGen on Android, but I also add a lot of new features in the later release.~~

[![NuGet Version](https://img.shields.io/nuget/v/FFmpeg_droidFix.AutoGen)](https://www.nuget.org/packages/FFmpeg_droidFix.AutoGen/) get the fork here

## Breaking change from original project:
There is some breaking changes in this fork, but they are all optional and can be easily fixed by just set some properties before calling any FFmpeg functions.

### Target runtime changed
The project now targets .NET 8.0+ instead of .NET Standard 2.0, which means it can only be used in .NET 8.0 or later projects. If you are using an older version of .NET, you can still use the original FFmpeg.AutoGen library, which is compatible with .NET Standard 2.0.

### The main project worked on now changed
Now FFmpeg.AutoGen is the main project that works on, not the FFmpeg.AutoGen.Abstractions.
They've still exist, but they are not the main project anymore. The main project is now FFmpeg.AutoGen, which contains all the bindings and the main logic of the library. The FFmpeg.AutoGen.Abstractions project is now only used for the interface definitions and some helper classes.

### Another way to initialize the bindings:
In the original project, the bindings will be initialized when any FFmpeg function is called for the first time, or by calling `DynamicallyLoadedBindings.Initialize()`. In this fork, you can set `DynamicallyLoadedBindings.EnableAutoInitialization` to true to enable this behavior, or you can call `DynamicallyLoadedBindings.TryInitialize()` manually to initialize the bindings and validate the library versions before calling any FFmpeg functions.

The original `DynamicallyLoadedBindings.Initialize()` method is still available, and there is a overload with an optional bool parameter `enableAutoValidation` to enable or disable the auto library validation feature.

Also, `DynamicallyLoadedBindings.TryInitialize()` will return a boolean value indicating whether the initialization and validation succeed, so you can check the result before proceeding.

To keep original behavior, `DynamicallyLoadedBindings.EnableAutoInitialization` is default to true.

There is a new property `ffmpeg.Ready` that indicates whether the bindings have been initialized. You can check this property before calling any FFmpeg functions to ensure that the bindings are ready to use.

### The binding and version check system
There is a new binding check system in this fork, which will automatically validate the functions in the FFmpeg libraries against the expected functions defined in the code. If any function is missing or has a different signature, it will throw an exception with detailed information about the mismatch. This can help you to identify and fix any issues with the FFmpeg libraries you are using.

The check's result will be stored in `ffmpeg.BindingVerificationResult`, which is an instance of `FFmpegBindingVerificationResult` class. You can check the `IsSuccess` property to see if the validation succeed, and if not, you can check the `Errors` property to get a list of all the mismatches.

Also, the library version check will be performed during initialization, and it will compare the actual versions of the FFmpeg libraries against the expected versions defined in `ffmpeg.LibraryVersionMap`, as well as the target major and minor versions defined by `TargetFFmpegMajorVersion` and `TargetFFmpegMinorVersion` if `DynamicallyLoadedBindings.ValidateReleaseVersion` is true. If there is any mismatch, it will throw an exception with detailed information about the version mismatch. You can disable the version check by set `DynamicallyLoadedBindings.EnableAutoValidation` to false, but it's not recommended unless you know what you are doing, as it can lead to unexpected behavior if the FFmpeg libraries you are using are not compatible with the bindings.

### AOT Compatibility
This fork is compatible with .NET's Native AOT, which allows you to compile your application to native code.
You don't need to do anything special to use this feature.

---

## Usage

**DON'T FORGET TO Initialize the bindings before call any FFmpeg functions**, either by call `DynamicallyLoadedBindings.TryInitialize()` manually or set `DynamicallyLoadedBindings.EnableAutoInitialization` to true to enable auto initialization when call any FFmpeg function for the first time.

The basic example of the library usage: video decoding, conversion and frame extraction to jpeg is included in ```FFmpeg.AutoGen.Example``` project.

You may check to example project it shows how specify path to libraries, anc call these libraries like decode video, convert it and extract frames to jpeg.

For the more sophisticated operations please refer to offical [ffmpeg Documentation](https://www.ffmpeg.org/documentation.html) expecially API section of it.

The FFmpeg API is vast and complex and this project exposes it with minimum modifications - support is very limited.

Nuget packages version uses [semantic versioning](https://semver.org/) and in sync with MAJOR and MINOR version of FFmpeg as PATCH incremets does not changing API.

## Per-Platform Usage

- on Windows or Linux or macOS:  
  > [!WARNING]
  > 
  > This library's MacOS usage usually only works in Console/Avalonia application (untested, but maybe work if you don't use MAUI as backend) , **not MacCatalyst** (see below for MacCatalyst)

  Native ffmpeg libraries are **NOT pre bundled in this repository**, not like the origin build. Obtain the binary by yourself, either by downloading from [ffmpeg official website](https://ffmpeg.org/download.html), by compiling it by yourself or from the package manager.

  In default, the library will load from `AppDomain.CurrentDomain.BaseDirectory` in Windows or `/usr/lib64` (while running in 64bit apphost) or `/usr/lib` (while running in 32bit apphost) in Linux.

  Set `ffmpeg.RootPath` before any ffmpeg call to manually specify the path to the directory where the FFmpeg libraries are located. 

- on Android (.NET MAUI):
    Follow these steps to use this library on Android:
    1. Create a directory inside ```<your .NET MAUI project root path>/Platforms/Android/```, name it whatever you want. Create a folder named same as the FFmpeg libraries' ABI name (like ```arm64-v8a```) your get/compile inside the folder your created. Put all ```.so``` files inside it, don't add any suffix or prefix.

    2. Add these things to the project's ```.csproj``` file:
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


- on MacCatalyst and iOS-Like platform (iOS/iPadOS/tvOS/WatchOS/visionOS) in .NET MAUI:
  > [!WARNING]
  > 
  > **I haven't tested this yet. ~~(sorry I don't have a mac)~~**

  Follow these steps to use this library on iOS-like platforms:
  1. Create a directory inside ```<your .NET MAUI project root path>/Platforms/iOS/```, name it whatever you want. Create a folder named same as the FFmpeg libraries' ABI name (like ```arm64```) your get/compile inside the folder your created. Put all ```.dylib``` files inside it, don't add any suffix or prefix.

  2. Add these things to the project's ```.csproj``` file:
  ```xml
  <ItemGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'ios'">
          <NativeReference Include="Platforms\iOS\<name of the directory your named>\**\*.dylib" />
  </ItemGroup>
  ```
  Don't forget to replace ```<name of the directory your named>``` to the name of the directory your named in 2nd step.
  Your project's file structure should like this:
  ```
  .
  |
  \---Platforms
      +---iOS
      |   |   ......
      |   |
      |   +---Assets
      |   +---ffmpeg
      |   |   \---arm64
      |   |           libavcodec.dylib
      |   |           libavfilter.dylib
      |   |           libavformat.dylib
      |   |           libavutil.dylib
      |   |           libswresample.dylib
      |   |           libswscale.dylib
      |   |
      |   +---Resources
      |   ......
      |
  ......
  ```
- Other platforms (WebAssembly, .Net nanoFramework, Unity, etc.):
  1. Try to implement a IFunctionResolver for your platfrom.
  2. Set `DynamicallyLoadedBindings.FunctionResolver` to your implementation before call any FFmpeg functions, and call `DynamicallyLoadedBindings.LoadBinding`, like this:
  ```csharp
  var resolver = new YourPlatformFunctionResolver();
  DynamicallyLoadedBindings.FunctionResolver = resolver;
  DynamicallyLoadedBindings.LoadBinding();
  ```

  Note that, if your platform use a different constant for EAGAIN, ENOMEM, EINVAL, or EPIPE from default (11 or 35 in iOS-Like, 12, 22, 32), You'll need to avoid use them. They've a fixed constant.
  

## Generation

The bindings generator uses [CppSharp](https://github.com/mono/CppSharp).

Prerequisites:
 - Visual Studio 2022 with C# and C++ desktop development workloads and Windows SDK for desktop.

Steps to generate:
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## Origin content and License (picked)
[![main](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml/badge.svg)](https://github.com/Ruslan-B/FFmpeg.AutoGen/actions/workflows/main.yml)
[![nuget](https://img.shields.io/nuget/v/FFmpeg.AutoGen.svg)](https://www.nuget.org/packages/FFmpeg.AutoGen/)
### readme from original project

#### Important Announcement

**This project is undergoing a transition to a semi-managed model over the coming months.**

- **All existing packages and versions will continue to work** - there will be no breaking changes to existing functionality
- The project is now **MIT licensed** (changed from LGPL) - see LICENSE.txt for details
- **Contributions are welcome!** If you'd like to help with the project, please feel free to contribute
- The FFmpeg binaries continue to be distributed with their original licenses from the source

**Founder & Maintainer:** Ruslan Balanukhin (Rationale One)

For questions and support, please continue using [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or the [questions repository](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues).

### Important

**The FFmpeg API is vast and complex and this project exposes it with minimum modifications - support is very limited.
Please consider to ask *how to* questions on [stackoverflow.com](https://stackoverflow.com/search?tab=newest&q=ffmpeg%20autogen) or in special repository on [github.com](https://github.com/Ruslan-B/FFmpeg.AutoGen.Questions/issues). 
The community may be able to offer some assistance but you will largely be on your own.
As another option you can search for a solution in C(lang) as with some effort you can convert it to C#.**
Here repository with C# converted examples: https://github.com/stjeong/ffmpeg_autogen_cs

## License

Copyright © 2025 Ruslan Balanukhin (Rationale One)  
All rights reserved.

Distributed under the **MIT License**.  
See LICENSE.txt for full license text.

**Note:** FFmpeg binaries are distributed under their original licenses (GPL/LGPL) from the source.
Please refer to [FFmpeg License](https://www.ffmpeg.org/legal.html) for details.

---

## License

The fork is created by hexadecimal0x12e. Copyright © 2025-2026 hexadecimal0x12e. All rights reserved.

