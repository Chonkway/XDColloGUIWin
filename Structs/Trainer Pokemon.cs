// -----------------------------------------
// Trainer Pokemon.c
//
// As seen in DeckData_Story.bin from Pokemon XD - Gale of Darkness (USA) region: US
// At offset: 0x3328 (13096)
// Struct length: 0x20 (32) bytes
// -----------------------------------------

struct ByteStats {
    char hp; // offset: 0x0 
    char attack; // offset: 0x1 
    char defense; // offset: 0x2 
    char spatk; // offset: 0x3 
    char spdef; // offset: 0x4 
    char speed; // offset: 0x5 
}

struct TrainerPokemon {
    ushort species; // offset: 0x0 
    char level; // offset: 0x2 
    char happiness; // offset: 0x3 
    ushort item; // offset: 0x4 
    char aiRole; // offset: 0x6 
    char unknown; // offset: 0x7 
    //struct ByteStats ivs{} // offset: 0x8 
    //struct ByteStats evs; // offset: 0xE 
    //ushort moves[]; // offset: 0x14 
    char unused; // offset: 0x1C 
    char unknown2; // offset: 0x1D 
    char miniPid; // offset: 0x1E 
    char useRandomNatureAndGender; // offset: 0x1F 
}