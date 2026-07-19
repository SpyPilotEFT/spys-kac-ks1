# Spy's JSOC-SWR 2.0.0

This is the new 2.0.0 release of the former Spy's KAC KS-1 mod, now renamed and refactored as Spy's JSOC-SWR.

JSOC-SWR stands for Joint Special Operations Command Service Weapon Replacement.

Important: delete the old `user/mods/spys-kac-ks1` folder before installing this version. Do not run the old KAC KS-1 folder and the new JSOC-SWR folder together.

Requirements:

- SPT 4.0.13
- WTT-ServerCommonLib 2.0.20
- EpicsAIO 4.0.8

Dependency change: EpicsAIO is now required alongside WTT-ServerCommonLib.

Highlights:

- Added GFR and GFR-X weapon content.
- Added LMT weapon content.
- Added 6mm ARC ammunition support.
- Kept the KS-1 and SOLGW content in the new package.
- Updated the DLL and source version metadata to 2.0.0.
- Added EpicsAIO as a dependency alongside WTT-ServerCommonLib.
- Fixed APBS recursive attachment-loop reports on GFR/GFR-X handguard filters.
- Fixed the LMT monolithic upper item data issue that could break Peacekeeper's displayed inventory.
- Fixed SOLGW stock-slot setup.
- Fixed the KS-1 heat-wave effect.
- Fixed the SOLGW gray handguard bundle.
- Fixed SOLGW MK1 handguards showing as compatible with SIG SPEAR uppers.
- Fixed a KS-1 failure-to-eject animation issue.
- Fixed invalid Strandhogg ABUPAT and Tasmanian Tiger Modular Pack compatibility on JSOC weapon handguards.
