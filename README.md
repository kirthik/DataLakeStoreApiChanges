# Information on assemblies

To make it easier I already ran `dotnet build` and checked in the assemblies.

Assemblies to compare
```
Original\DataLake.Store\Microsoft.Azure.Manag
ement.DataLake.Store\bin\Debug\netstandard1.1\Microsoft.Azure.Management.DataLake.Store.dll
```

```
PR\DataLake.Store\Microsoft.Azure.Management.DataLake.Store\bin\Debug\netstandard1.1\Microsoft.Azure.Management.DataL
ake.Store.dll
```

Here is the command I ran (directory paths are absolute paths on my local machine)

```
\\fxcore\tools\bin\ApiCompat.exe C:\test\DataLakeDiff\Original\DataLake.Store\Microsoft.Azure.Manag
ement.DataLake.Store\bin\Debug\netstandard1.1\Microsoft.Azure.Management.DataLake.Store.dll -implDirs C:\test\DataLakeDi
ff\PR\DataLake.Store\Microsoft.Azure.Management.DataLake.Store\bin\Debug\netstandard1.1\Microsoft.Azure.Management.DataL
ake.Store.dll
```
