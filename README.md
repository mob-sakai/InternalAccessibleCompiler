# InternalAccessibleCompiler

`InternalAccessibleCompiler` is a tool to compile a c# project to a _internal accessible_ dll.

![icon](https://user-images.githubusercontent.com/12690315/69955042-1dc8a380-1540-11ea-9d38-fa7fa77b22d9.png)

[![Nuget](https://img.shields.io/nuget/v/InternalAccessibleCompiler)](https://www.nuget.org/packages/InternalAccessibleCompiler)
![GitHub](https://img.shields.io/github/license/mob-sakai/InternalAccessibleCompiler)
![Nuget](https://img.shields.io/nuget/dt/InternalAccessibleCompiler)
![release](https://github.com/mob-sakai/InternalAccessibleCompiler/workflows/release/badge.svg)

## Summary

`InternalAccessibleCompiler` is a tool to compile a c# project to a _internal accessible_ dll.

## Installation

```bash
$ dotnet tool install --global InternalAccessibleCompiler
```

## Usage

```bash
InternalAccessibleCompiler --output your.dll your.csproj

  -o, --output            Output path

  -c, --configuration     (Default: Release) Configuration

  -l, --logfile           (Default: compile.log) Logfile path

  --help                  Display this help screen.

  --version               Display version information.

  ProjectPath (pos. 1)    Input .csproj path
```

## License

MIT

## See Also

- GitHub page : https://github.com/mob-sakai/InternalAccessibleCompiler
- Nuget page : https://www.nuget.org/packages/InternalAccessibleCompiler

[![become_a_sponsor_on_github](https://user-images.githubusercontent.com/12690315/66942881-03686280-f085-11e9-9586-fc0b6011029f.png)](https://github.com/users/mob-sakai/sponsorship)
