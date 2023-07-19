import json
import sys

json = sys.argv[1]

# Read the JSON file
with open('json', 'r') as file:
    data = json.load(file)

# Remove quotes from values
for key in data:
    data[key] = int(data[key], 16)  # Convert hexadecimal string to integer

# Write updated JSON to a new file
with open('output.json', 'w') as file:
    json.dump(data, file)