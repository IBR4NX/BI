import os

for filename in os.listdir('.'):

    if filename.endswith('.cs') and 'Sql' in filename:

        new_filename = filename.replace('Sql', 'Mysql')
        
        os.rename(filename, new_filename)
        print(f"تمت إعادة التسمية: {filename} -> {new_filename}")
