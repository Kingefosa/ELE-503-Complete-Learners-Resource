import os

# Define the directory
directory = 'reports/'

# Iterate over files
for filename in os.listdir(directory):
    if filename.endswith('.txt'):
        base, ext = os.path.splitext(filename)
        new_name = f"report_{base}.txt"
        os.rename(os.path.join(directory, filename), os.path.join(directory, new_name))
        print(f"Renamed {filename} to {new_name}")
