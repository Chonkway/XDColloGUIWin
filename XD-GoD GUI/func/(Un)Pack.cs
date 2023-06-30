

using System.IO;

namespace Unpack;

// ----------
// Manages the unpacking and repacking of ISO and directory holding
//

public class Unpack(string source)
{
    public void ISOUnpack() // Unpack ISO to program root
    {
        using (FileStream fsUnpack = System.IO.File.Open(source, FileMode.Open))
        {
           

        }
    }
}
