import gciso
import sys



with gciso.IsoFile(sys.argv[1]) as isoFile:
    dirtree = isoFile.files

    for key, value in dirtree.items():
        print(key, value)


