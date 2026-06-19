# Spy's KAC KS-1

![Spy's KAC KS-1 preview](media/ks1-preview.png)
![Spy's KAC KS-1 rifle preview](media/ks1-preview-2.png)
![Spy's KAC KS-1 gameplay preview](media/ks1-gameplay.gif)

SPT 4.0.13 weapon mod adding Knight's Armament KS-1 variants, parts, presets, and Peacekeeper assort entries.

Current release: 1.0.4

## Source

The C# source used for the server loader DLL is in `src/KAC_KS1`.

## Install

Open the release archive. It is structured like this:

```txt
SPT
+-- user
    +-- mods
        +-- spys-kac-ks1
```

Drag the `SPT` folder from the archive into the same place you keep your SPT install and allow Windows to merge folders.

This mod is server-side only. There is no BepInEx plugin for the KS-1.

## Credits

- SpyPilot: mod author
- EpicRangeTime: shaders
- bobinstein: Unity, Blender, and shader help

Please credit both bobinstein and EpicRangeTime when redistributing, mirroring, or showcasing this mod.

## Notes

- Built for SPT 4.0.13.
- Requires WTT-ServerCommonLib.
- Bundles include the custom shader/assets needed by the mod.

## Changelog

### 1.0.4

- Removed leftover `epic_shaders.bundle` dependency references from `bundles.json`.
- This is a cleanup-only change. The dependency was not required by the included shader bundle and should not affect visuals or functionality.
