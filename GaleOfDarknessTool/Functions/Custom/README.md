---------
External Functions Folder
---------


These functions are meant to assist with editing, they're written in Python to help extract data into files to be accessed by the main program.

In order to use them yourself, first ensure you have the following:

- Python 3.0+, install the latest version [here](https://www.python.org/)
- gciso, a Python library designed to interface with the GameCube's ISO Filesystem. Install it using `pip install gciso` in your command line (assuming you have Python installed to PATH)




## Functions


### FileTree.py
- `FileTree.py` is meant to provide a JSON file of the entire filesystem of your ISO. Using this manually is simple, just drag your ISO onto the file and it will spit out a file in the root folder of the function and will look something like this:
```JSON
{
    "boot.bin": [
        0,
        1088
    ],
    "bi2.bin": [
        1088,
        8192
    ]
}
```

The integers are the offset location and size of the file respectively in bytes relative to the entire ISO. 

If you end up editing the ISO to the point where these offsets and sizes will change, this is meant to regenerate the filetree to load into the tool. 

- Locate the JSON file in either the` XD` or `Colo` folder and replace the filetree json file with your new one and the tool will load this new information at runtime into the insert/extract window.