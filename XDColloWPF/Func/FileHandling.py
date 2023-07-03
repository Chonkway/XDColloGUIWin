import gciso
import codecs
import json


#Generates a JSON file containing the file tree of the ISO loaded with the files offset and sizeyou
isotree = {}
with gciso.IsoFile(sys.argv[1]) as isoFile:
    dirtree = isoFile.files
    for key, value in dirtree.items():
        fname = codecs.decode(key, 'UTF-8')
        isotree[fname] = value


with open('XD_GoD_File_Tree.json', 'w') as outfile:
    json.dump(isotree, outfile, indent=4)
