import gciso
import sys


def FileSystemTree(iso: str):
    """
    Takes in the iso path and returns all the files contained as a tree. \n
    Displays their offsets in the main file and their total size if offsets is set to 'True' \n
    """
    with gciso.IsoFile(iso) as isoFile:
        dirtree = isoFile.files

    for key, value in dirtree.items():
        return dirtree.items()
