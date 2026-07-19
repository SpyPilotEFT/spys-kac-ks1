# Changelog

## 2.0.0

- Renamed and refactored the mod from Spy's KAC KS-1 to Spy's JSOC-SWR.
- JSOC-SWR stands for Joint Special Operations Command Service Weapon Replacement.
- Added GFR and GFR-X weapon content.
- Added LMT weapon content.
- Added 6mm ARC ammunition support.
- Kept the existing KS-1 and SOLGW content in the new package.
- Updated the mod folder, package metadata, DLL name, and source project name for JSOC-SWR.
- Updated the DLL and source version metadata to 2.0.0.
- Added EpicsAIO as a dependency alongside WTT-ServerCommonLib.
- Fixed recursive attachment loops reported by APBS on GFR/GFR-X handguard filters.
- Fixed the LMT monolithic upper item data issue that could break Peacekeeper's displayed inventory.
- Fixed SOLGW stock-slot setup so the rifle exposes the intended stock slot.

Install warning: delete the old `user/mods/spys-kac-ks1` folder before installing `spys-JSOC-SWR`. Running both folders together can break the mod.

## 1.0.4

- Removed leftover `epic_shaders.bundle` dependency references from `bundles.json`.
- Cleanup-only release for the original KAC KS-1 package.
