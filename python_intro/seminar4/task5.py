# Даны два файла, в каждом из которых находится запись многочлена.
# Задача - сформировать файл, содержащий сумму многочленов.

filename1 = 'task5_poly1.txt'
filename2 = 'task5_poly2.txt'
result_filename = 'task5_sumpoly.txt'

file1 = open(filename1, 'r')
line1 = file1.readline()
file1.close()
file2 = open(filename2, 'r')
line2 = file2.readline()
file2.close()

# returns list of multipliers in polynomial from string,
# position in list corresponds to the power of the term


def parse(line):
    line = line.replace(" ", "")
    line = line.replace("=0", "")
    line = line.replace("+", "\n")
    line = line.replace("-", "\n-")
    poly_list = line.splitlines()
    if (poly_list[0] == ''):
        poly_list.remove('')

    multipliers = []
    powers = []

    for i in range(0, len(poly_list)):
        index = poly_list[i].find("*x^")
        if index != -1:
            multipliers.append(int(poly_list[i][0:index]))
            powers.append(int(poly_list[i][index+3:len(poly_list[i])]))
        else:
            index = poly_list[i].find("*x")
            if index != -1:
                multipliers.append(int(poly_list[i][0:index]))
                powers.append(1)
            else:
                multipliers.append(int(poly_list[i]))
                powers.append(0)

    multiplier_list = [0]*(max(powers)+1)
    for i in range(0, len(powers)):
        multiplier_list[powers[i]] = multipliers[i]
    return multiplier_list


poly1 = parse(line1)
poly2 = parse(line2)

result_len = max([len(poly1), len(poly2)])
if (len(poly1) < result_len):
    poly1 = poly1 + [0]*(result_len-len(poly1))
if (len(poly2) < result_len):
    poly2 = poly2 + [0]*(result_len-len(poly2))

result_poly = [0]*result_len
for i in range(0, result_len):
    result_poly[i] = poly1[i] + poly2[i]

is_first_term = True
string2write = ''
for i in range(result_len-1, -1, -1):
    if (result_poly[i] != 0):
        if (not is_first_term and result_poly[i] > 0):
            string2write += "+"
        string2write += str(result_poly[i])
        is_first_term = False
        if (i > 0):
            string2write += "*x"
        if (i > 1):
            string2write += "^" + str(i)
string2write += " = 0\n"
string2write = string2write.replace('+', ' + ')
string2write = string2write.replace('-', ' - ')
if (string2write[1] == "-"):
    string2write = "-" + string2write[3:len(string2write)]
print(string2write)

file = open(result_filename, 'a')
file.write(string2write)
file.close()
