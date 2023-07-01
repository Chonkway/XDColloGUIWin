// -----------------------------------------
// Shadow Pokemon.c
//
// As seen in DeckData_DarkPokemon.bin from Pokemon XD - Gale of Darkness (USA) region: US
// At offset: 0x20 (32)
// Struct length: 0x18 (24) bytes
// -----------------------------------------

struct ShadowPokemon {
    char mirorBWeighting; // offset: 0x0 Determines how likely this pokemon is to appear when encountering Miror B. Set to 0 for it to never trigger nor appear with Miror B.
    char catchRate; // offset: 0x1 Overrides the base catch rate for the species
    char shadowBoostLevel; // offset: 0x2 The hidden level the pokemon has before you catch it
    //char statusFlags[1]; // offset: 0x3 
    uint pokemonIndexInStoryDeck; // offset: 0x4 The ID in Deck Story for the pokemon that this shadow ID is attached to
    ushort heartGuage; // offset: 0x8 Determines how long it takes to purify the pokemon
    ushort padding; // offset: 0xA 
    //ushort shadowMoves[4]; // offset: 0xC 
    char aggression; // offset: 0x14 The lower the value, the more likely it is to enter reverse mode
    char fleesWhenPlayerLoses; // offset: 0x15 Determines if the pokemon should go to Miror B even if the player lost the battle
};