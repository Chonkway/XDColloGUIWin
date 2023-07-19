// -----------------------------------------
// Battle.c
//
// As seen in common.rel from Pokemon XD - Gale of Darkness (USA) region: US
// At offset: 0x4020 (16416)
// Struct length: 0x3C (60) bytes
// -----------------------------------------

struct BattlePlayer
{
    ushort deckId; // offset: 0x0 
    ushort trainerId; // offset: 0x2 Use deck 0, id 5000 for the player's team
    uint controllerIndex; // offset: 0x4 0 for AI
};

struct Battle
{
    char battleType; // offset: 0x0 
    char trainersPerSide; // offset: 0x1 
    char battleStyle; // offset: 0x2 
    char pokemonPerPlayer; // offset: 0x3 
    char isStoryBattle; // offset: 0x4 
    ushort battleFieldId; // offset: 0x6 
    ushort battleCdId; // offset: 0x8 Set programmatically at run time so is always set to 0 in the game files
    uint battleIdentifierString; // offset: 0xC 
    uint bgmId; // offset: 0x10 
    uint unknown2; // offset: 0x14 
    uint colosseumRound; // offset: 0x18 wzx id for intro text

    // struct BattlePlayer players[4] // offset: 0x1C commented out until needed
}
