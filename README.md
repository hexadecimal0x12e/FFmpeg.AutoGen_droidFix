# What changed from original project:

As very beginning of making projectFrameCut, I selected this library to decode videos, etc. because this thing can let me call FFmpeg and read out frame directly, by all C# Managed code, save my time and increase the speed.

When I'm trying to test projectFrameCut on Android, while I try to call this library on the Android platform, I found that I kept receiving the "PlatformNotSupportedException" error. After some diagnosis, I discovered that it was caused by the changes in .NET 5+ to System.OSPlatform. So that I fixed [this](https://github.com/Ruslan-B/FFmpeg.AutoGen/blob/master/FFmpeg.AutoGen/FunctionResolverFactory.cs#L15) file by use the modern [System.OperatingSystem API](https://learn.microsoft.com/dotnet/api/system.operatingsystem?view=net-9.0), also I added a Function Resolver for Android.

But, I found this is not the only problem while running on Android devices. After this fix, I start receive a "DllImportException" when I try to call the library, after days of fix, I finally discover why: "libdl.so.2" isn't exists on Android devices, and [dlopen](https://www.man7.org/linux/man-pages/man3/dlopen.3.html) moved to "libc.so" instead of libdl. I also added a user-friendly exception processing telling why libraries failed to load.

I also added a property ```AddVersionSuffixToLibraryPath```that allows you to manually disable adding a version suffix to library names when attempting to load a library. This can resolve issues where certain platforms remove the version suffix when packaging the application.

Other things, and contents below, are unchanged. In addition, this library is fully compatible with the original FFmpeg.AutoGen library. 

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

The basic example of the library usage: video decoding, conversion and frame extraction to jpeg is included in ```FFmpeg.AutoGen.Example``` project.  
For the more sophisticated operations please refer to offical [ffmpeg Documentation](https://www.ffmpeg.org/documentation.html) expecially API section of it.
Nuget packages version uses [semantic versioning](https://semver.org/) and in sync with MAJOR and MINOR version of FFmpeg as PATCH incremets does not changing API.

- on Windows:  
Native ffmpeg libraries are pre bundled in this repository, please note the are **GPL**(!) libraries. 
The x64 libraries source from [CODEX FFMPEG](https://www.gyan.dev/ffmpeg/builds/).
Please check to example project it shows how specify path to libraries.  

- on OS X:  
Install ffmpeg via [Homebrew](https://formulae.brew.sh/formula/ffmpeg):
```bash
brew install ffmpeg
```
Normally you need to set static ```ffmpeg.RootPath = ``` with full path to FFmpeg libraries.

- on Android (.NET MAUI):
First, add these code to ```MauiProgram.cs```:
```csharp
#if ANDROID
ffmpeg.RootPath = Android.App.Application.Context.ApplicationInfo.NativeLibraryDir;
JavaSystem.LoadLibrary("c");
#endif
```

Second, create a directory inside ```<your .NET MAUI project root path>/Platforms/Android/```, name it whatever you want. Create a folder named same as the FFmpeg libraries' ABI name (like ```arm64-v8a```) your get/compile inside the folder your created. Put all ```.so``` files inside it, don't add any suffix or prefix.

Then, add these things to the project's ```.csproj``` file:
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
Use your package manager of choice.
Normally you need to set static ```ffmpeg.RootPath = ``` with full path to FFmpeg libraries.

## Generation

The bindings generator uses [CppSharp](https://github.com/mono/CppSharp).

Prerequisites:
 - Visual Studio 2022 with C# and C++ desktop development workloads and Windows SDK for desktop.

Steps to generate:
- Run ```FFmpeg.AutoGen.CppSharpUnsafeGenerator;```
- All files with extension ```*.g.cs```  in ```FFmpeg.AutoGen``` project will be regenerated.

## License

Copyright © Ruslan Balanukhin 2023
All rights reserved.

Distributed under the GNU Lesser General Public License (LGPL) version 3.  
http://www.gnu.org/licenses/lgpl.html

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
