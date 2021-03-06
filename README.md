# AnyStatus Plugins

A repository of community contributed plugins and extensions for [AnyStatus](https://www.anystat.us).

[![Build status](https://ci.appveyor.com/api/projects/status/dvn1rwrauwyq5yx6?svg=true)](https://ci.appveyor.com/project/AnyStatus/plugins)
[![NuGet](https://img.shields.io/nuget/v/AnyStatus.Plugins.svg)](https://www.nuget.org/packages/AnyStatus.Plugins/)

AnyStatus is a lightweight desktop application for Windows that brings together metrics and events from various sources.
Examples include, Azure DevOps, Jenkins, AppVeyor, TeamCity, Health Checks, Operating System Metrics, Elasticsearch, Redis, Kubernetes, and more. Think of it as CCTray on steroids. It's also available as a Visual Studio plugin.

For a list of widgets and plugins please [visit our website](https://www.anystat.us/docs/plugins).

## Documentation

You can read the latest documentation at https://anystat.us/docs
To learn more about developing plugins for AnyStatus, please read the [API Documentation](https://www.anystat.us/docs/api).

## Install

You can download AnyStatus latest version from https://anystat.us/downloads

## Build

Clone the plugins repository

`git clone https://github.com/AnyStatus/Plugins.git`

Open _AnyStatus.Plugins.sln_ in Visual Studio. The free community edition works fine.
Make sure to download and install [.NET Framework 4.62 Dev Pack](https://dotnet.microsoft.com/download/dotnet-framework/net462).

## Debug

To debug plugins, copy and paste the following script to the post-build-event of _AnyStatus.Plugins_ project.
This script will copy the binary output to AnyStatus installation folder. Make sure to specify your user folder.

```
if $(ConfigurationName) == Debug (
  xcopy $(TargetDir)AnyStatus.Plugins.dll "C:\Users\YOUR-USER-FOLDER\AppData\Roaming\AnyStatus" /y
)
```

Open _AnyStatus.Plugins_ project properties in Visual Studio and go to Debug section.
In "Start secion", select "Start external program" and enter AnyStatus executable path. For example:
"C:\Users\YOUR-USER-FOLDER\AppData\Roaming\AnyStatus\AnyStatus.Desktop.exe".
Press F5 in Visual Studio to start AnyStatus in debug mode.

## Contribute

Contributions are most welcome. Please join us in maintaining a library of tools that we can all use in our day to day tasks.
We also welcome [issues submitted on GitHub](https://github.com/anystatus/support/issues).
