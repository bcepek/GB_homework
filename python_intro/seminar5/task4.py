# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.

input_filename = 'task4_input.txt'
zipped_filename = 'task4_zipped.txt'
unzipped_filename = 'task4_unzipped.txt'

def string_zip(text):
    zipped = []
    while text != '':
        if zipped == []:
            zipped.append([1, text[0]])
        elif zipped[-1][1] == text[0]:
            zipped[-1][0] += 1
        else:
            zipped.append([1, text[0]])
        text = text[1:]
    zipped = [list(map(str, x)) for x in zipped]
    zipped = [''.join(x) for x in zipped]
    return ''.join(zipped)


def string_unzip(text):
    zipped = []
    while (text != ''):
        char_pos = 0
        while (not text[char_pos].isalpha()):
            char_pos += 1
        zipped.append([int(text[0:char_pos]), text[char_pos]])
        text = text[char_pos+1:]
    unzipped_str = ''
    for x in zipped:
        unzipped_str += x[0]*x[1]
    return unzipped_str

input_file = open(input_filename, 'r')
text = input_file.readline()
input_file.close()

zipped_str = string_zip(text)
unzipped_str = string_unzip(zipped_str)

zipped_file = open(zipped_filename, 'w')
zipped_file.write(zipped_str)
zipped_file.close()

unzipped_file = open(unzipped_filename, 'w')
unzipped_file.write(unzipped_str)
unzipped_file.close()
