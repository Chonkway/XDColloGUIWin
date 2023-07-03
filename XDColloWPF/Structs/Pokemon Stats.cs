﻿using System.Runtime.InteropServices;
// -----------------------------------------
// Pokemon Stats.cs
//
// As seen in common.rel from Pokemon XD - Gale of Darkness (USA) region: US
// At offset: 0x29DA8 (171432)
// Struct length: 0x124 (292) bytes
// Original c struct generated by StarsMMD GoD Tool
// -----------------------------------------

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct Stats
{
    public ushort hp;           // offset: 0x0 
    public ushort attack;       // offset: 0x2 
    public ushort defense;      // offset: 0x4 
    public ushort spatk;        // offset: 0x6 
    public ushort spdef;        // offset: 0x8 
    public ushort speed;        // offset: 0xA 
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct Evolution
{
    public char evolutionMethod;         // offset: 0x0 
    public ushort evolutionCondition;    // offset: 0x2 
    public ushort evolvedForm;           // offset: 0x4 
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct LevelUpMove
{
    public char level;                   // offset: 0x0 
    public ushort move;                  // offset: 0x2 
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct PokemonSprites
{
    public char pokedexColourId;         // offset: 0x0 
    public ushort faceId;                // offset: 0x2 The index of the image for the pokemon's face
    public uint purifyChamberImageId;    // offset: 0x4 File identifier for the animated texture
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct PokemonStats
{
    public char levelUpRate;                 // offset: 0x0 Determines how much exp it takes for the pokemon to level up
    public char catchRate;                   // offset: 0x1 
    public char genderRatio;                 // offset: 0x2 
    public ushort expYield;                  // offset: 0x4 Determines how much exp you get for defeating this pokemon species
    public ushort baseHappiness;             // offset: 0x6 Default happiness when this pokemon is caught
    public short height;                     // offset: 0x8 Height in meters x10
    public short weight;                     // offset: 0xA Weight in kg x10
    public ushort cryId;                     // offset: 0xC 
    public ushort unknown1;                  // offset: 0xE 
    public ushort unknown2;                  // offset: 0x10 Something sound related
    public ushort nationalDexIndex;          // offset: 0x12 
    public ushort hoennDexRegionalId;        // offset: 0x14 If not in the Hoenn dex then listed after deoxys
    public uint nameId;                      // offset: 0x18 
    public uint speciesNameId;               // offset: 0x1C The species name used in the pokedex entry
    public uint unknown3;                    // offset: 0x20 unused?
    public uint unknown4;                    // offset: 0x24 
    public uint unknown5;                    // offset: 0x28 
    public uint modelId;                     // offset: 0x2C 

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public char[] types;                     // offset: 0x30 

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public char[] abilities;                 // offset: 0x32 

    public char tm01FocusPunch;              // offset: 0x34 
    public char tm02DragonClaw;              // offset: 0x35 
    public char tm03WaterPulse;              // offset: 0x36 
    public char tm04CalmMind;                // offset: 0x37 
    public char tm05Roar;                    // offset: 0x38 
    public char tm06Toxic;                   // offset: 0x39 
    public char tm07Hail;                    // offset: 0x3A 
    public char tm08BulkUp;                  // offset: 0x3B 
    public char tm09BulletSeed;              // offset: 0x3C 
    public char tm10HiddenPower;             // offset: 0x3D 
    public char tm11SunnyDay;                // offset: 0x3E 
    public char tm12Taunt;                   // offset: 0x3F 
    public char tm13IceBeam;                 // offset: 0x40 
    public char tm14Blizzard;                // offset: 0x41 
    public char tm15HyperBeam;               // offset: 0x42 
    public char tm16LightScreen;             // offset: 0x43 
    public char tm17Protect;                 // offset: 0x44 
    public char tm18RainDance;               // offset: 0x45 
    public char tm19GigaDrain;               // offset: 0x46 
    public char tm20Safeguard;               // offset: 0x47 
    public char tm21Frustration;              // offset: 0x48 
    public char tm22Solarbeam;               // offset: 0x49 
    public char tm23IronTail;                // offset: 0x4A 
    public char tm24Thunderbolt;             // offset: 0x4B 
    public char tm25Thunder;                 // offset: 0x4C 
    public char tm26Earthquake;              // offset: 0x4D 
    public char tm27Return;                  // offset: 0x4E 
    public char tm28Dig;                     // offset: 0x4F 
    public char tm29Psychic;                 // offset: 0x50 
    public char tm30ShadowBall;              // offset: 0x51 
    public char tm31BrickBreak;              // offset: 0x52 
    public char tm32DoubleTeam;              // offset: 0x53 
    public char tm33Reflect;                 // offset: 0x54 
    public char tm34ShockWave;               // offset: 0x55 
    public char tm35Flamethrower;            // offset: 0x56 
    public char tm36SludgeBomb;              // offset: 0x57 
    public char tm37Sandstorm;               // offset: 0x58 
    public char tm38FireBlast;               // offset: 0x59 
    public char tm39RockTomb;                // offset: 0x5A 
    public char tm40AerialAce;               // offset: 0x5B 
    public char tm41Torment;                 // offset: 0x5C 
    public char tm42Facade;                  // offset: 0x5D 
    public char tm43SecretPower;             // offset: 0x5E 
    public char tm44Rest;                    // offset: 0x5F 
    public char tm45Attract;                 // offset: 0x60 
    public char tm46Thief;                   // offset: 0x61 
    public char tm47SteelWing;               // offset: 0x62 
    public char tm48SkillSwap;               // offset: 0x63 
    public char tm49Snatch;                  // offset: 0x64 
    public char tm50Overheat;                // offset: 0x65 
    public char hm01Cut;                     // offset: 0x66 
    public char hm02Fly;                     // offset: 0x67 
    public char hm03Surf;                    // offset: 0x68 
    public char hm04Strength;                // offset: 0x69 
    public char hm05Flash;                   // offset: 0x6A 
    public char hm06RockSmash;               // offset: 0x6B 
    public char hm07Waterfall;               // offset: 0x6C 
    public char hm08Dive;                    // offset: 0x6D 
    public char tutormove01Mimic;            // offset: 0x6E 
    public char tutormove02ThunderWave;      // offset: 0x6F 
    public char tutormove03SeismicToss;      // offset: 0x70 
    public char tutormove04IcyWind;          // offset: 0x71 
    public char tutormove05Substitute;       // offset: 0x72 
    public char tutormove06DreamEater;       // offset: 0x73 
    public char tutormove07Swagger;          // offset: 0x74 
    public char tutormove08BodySlam;         // offset: 0x75 
    public char tutormove09Nightmare;        // offset: 0x76 
    public char tutormove10SkyAttack;        // offset: 0x77 
    public char tutormove11Doubleedge;       // offset: 0x78 
    public char tutormove12Selfdestruct;     // offset: 0x79 

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public ushort[] wildItems;            // offset: 0x7A The Items pokemon of this species may hold when encountered in the wild

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public ushort[] eggMoves;             // offset: 0x7E 

    public Stats baseStats;                  // offset: 0x8E 
    public Stats evYields;                   // offset: 0x9A The EVs given for defeating this pokemon species

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public Evolution[] evolutions;          // offset: 0xA6 

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 19)]
    public LevelUpMove[] levelUpMoves;      // offset: 0xC4 

    public uint padding;                  // offset: 0x110 
    public PokemonSprites regularSprites;     // offset: 0x114 
    public PokemonSprites shinySprites;       // offset: 0x11C 
};
