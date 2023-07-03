using System;
//----------
// Handles the randomizing logic of the program
// DeckDataSwap - Takes a block of byte data starting at an offset in an array of all relevant bytes, shuffles existing pokemon around
// RandomizeDeck - Takes in a buffer of bytes, targets a value at an offset and changes it from 0 -> (range-1)
//----------
namespace XDColloWPF.Randomize
{
    class Randomize
    {
        public byte[][] Shuffle(byte[] buffer, int offset, byte blocksize, int deckslots)
        {

            int totalslots = (buffer.Length - offset) / blocksize; //how many slots do we need for our array
            byte[][] shuffleddeck = new byte[totalslots][]; //initialize new array with the number of slots needed
            int slotpos = 0;

            while (slotpos <= totalslots)
            { //begin copying blocks of bytes

                foreach (byte slot in shuffleddeck[slotpos])
                {

                    byte[] copybuffer = new byte[blocksize];

                    Array.Copy(buffer, offset, copybuffer, 0, blocksize);

                    shuffleddeck[slotpos] = copybuffer; //write all 32 bytes to new slot position?

                    slotpos++;
                }
                System.Diagnostics.Debug.WriteLine(shuffleddeck.ToString());
            }
            return shuffleddeck;
        }

        //public byte[] RandomizeDeck(byte[] buffer, char offset, byte range)
        //{
        //return;
        //}
    }
}
