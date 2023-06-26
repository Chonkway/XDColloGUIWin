// -----------------------------------------
// Battle.c
//
// As seen in common.rel from Pokemon XD - Gale of Darkness (USA) region: US
// At offset: 0x4020 (16416)
// Struct length: 0x3C (60) bytes
// -----------------------------------------

struct BattlePlayer {
    uint16_t deckId; // offset: 0x0 
    uint16_t trainerId; // offset: 0x2 Use deck 0, id 5000 for the player's team
    uint32_t controllerIndex; // offset: 0x4 0 for AI
};

struct Battle {
    char battleType; // offset: 0x0 
    char trainersPerSide; // offset: 0x1 
    char battleStyle; // offset: 0x2 
    char pokemonPerPlayer; // offset: 0x3 
    char isStoryBattle; // offset: 0x4 
    uint16_t battleFieldId; // offset: 0x6 
    uint16_t battleCdId; // offset: 0x8 Set programmatically at run time so is always set to 0 in the game files
    uint32_t battleIdentifierString; // offset: 0xC 
    uint32_t bgmId; // offset: 0x10 
    uint32_t unknown2; // offset: 0x14 
    uint32_t colosseumRound; // offset: 0x18 wzx id for intro text
    struct BattlePlayer players[4]; // offset: 0x1C 
};