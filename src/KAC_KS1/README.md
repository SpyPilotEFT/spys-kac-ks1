# KS-1 Server Source

This folder contains the C# source for `com.spy.kac-ks1.dll`.

The server loader uses WTT-ServerCommonLib to register the KS-1 embedded item JSON, locale JSON, and Peacekeeper assort JSON from the packaged mod folder.

## Build

Install SPT 4.0.13 and WTT-ServerCommonLib 2.0.20, then build:

```powershell
dotnet build .\src\KAC_KS1\KAC_KS1.csproj -c Release
```

If your SPT install is somewhere other than `C:\SPT\SPT`, pass the path explicitly:

```powershell
dotnet build .\src\KAC_KS1\KAC_KS1.csproj -c Release -p:SptRoot="D:\Path\To\SPT"
```

The built DLL is the server-side loader. Unity bundles and other packaged mod assets live under `SPT/user/mods/spys-kac-ks1`.
