# .NET Core Playground

### Description

A test field/playground project for testing out ``.NET Core`` framework. Most of the source code is written in C#, but there is also a sample F# project. ``xUnit.net`` is used as testing framework. The project tech stack is:

```
  .NET Core     2.0
  xUnit.net     2.3.1
```

### Project structure

The project contains several modules (applications & libraries), which are displayed in the following tree structure:

```
.netcore-playground
	├─── ConsoleTestApp (C# console application)
	├─── FSharpApp (F# console application)
	├─── MathLib (C# library)
	└─── UnitTestApp (C# Unit Tests)
```

### Building & running the modules

The complete project can be built with the following command (executed at top level):

```
dotnet build
```

The ``ConsoleTestApp`` is a C# console application, which can be run with the following command (executed inside ``ConsoleTestApp`` directory):

```
dotnet run
```

With the same command the ``FSharpApp`` application can also be executed. The ``FSharpApp`` is a sample F# console application. Finally, the module/application ``UnitTestApp`` contains few unit tests, which can be executed with the following application (executed inside ``UnitTestApp`` directory):

```
dotnet test
```
