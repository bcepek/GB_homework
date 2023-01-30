def read_csv(filename):
    data = []
    with open(filename, 'r') as file:
        for line in file:
            data.append(line.split(';'))
            data[-1][-1] = data[-1][-1][0:-1]   # removing "\n"
    return data

def write_csv(filename, data):
    with open(filename, 'w') as file:
        for record in data:
            file.write(';'.join(record))
            file.write('\n')

def read_txt_f1(filename):
    data = [[]]
    with open(filename, 'r') as file:
        for line in file:
            if line == '\n':
                data.append([])
            else:
                data[-1].append(line[1:-2])
    return data

def write_txt_f1(filename, data):
    with open(filename, 'w') as file:
        for record in data:
            for item in record:
                file.write(f'*{item}*\n')
            file.write("\n")
    
def read_txt_f2(filename):
    data = []
    with open(filename, 'r') as file:
        for line in file:
            data.append(line[1:-2].split(','))
    return data

def write_txt_f2(filename, data):
    with open(filename, 'w') as file:
        for record in data:
            line = ",".join(record)
            file.write(f"*{line}*\n")
       