# Spy's JSOC-SWR

JSOC-SWR is short for Joint Special Operations Command Service Weapon Replacement.

This is the 2.0.0 refactor and rename of Spy's KAC KS-1. It keeps the KS-1 and SOLGW content and expands the pack with the GFR, GFR-X, LMT platform, and 6mm ARC support.

Current release: 2.0.0

## Important Install Note

Delete the old `user/mods/spys-kac-ks1` folder before installing this version.

Do not run `spys-kac-ks1` and `spys-JSOC-SWR` at the same time. The new package uses a new folder name, new DLL name, and new mod GUID.

## Install

Open the release archive. It is structured like this:

```txt
SPT
+-- user
    +-- mods
        +-- spys-JSOC-SWR
```

Drag the `SPT` folder from the archive into the same place you keep your SPT install and allow Windows to merge folders.

This mod is server-side only. There is no BepInEx plugin for JSOC-SWR.

## Requirements

- SPT 4.0.13
- WTT-ServerCommonLib 2.0.20
- EpicsAIO 4.0.8

Dependency change from the old KAC KS-1 release: JSOC-SWR now requires EpicsAIO in addition to WTT-ServerCommonLib.

## Source

The C# source used for the server loader DLL is in `src/JSOC_SWR`.

## Credits

- SpyPilot: mod author
- bobinstein: Unity, Blender, refactor, and shader help
- EpicRangeTime: shaders and EpicsAIO

Please credit bobinstein and EpicRangeTime when redistributing, mirroring, or showcasing this mod.

## Changelog

See `CHANGELOG.md`.
