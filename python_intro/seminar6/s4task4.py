# Пример для list comprehension, lambda, zip, map.
# Ясно, что строки 11-13 можно объединить в одну, но нужно было как-то использовать zip :-)
# После exit() приведен изначальный код

# Задана натуральная степень k. Сформировать случайным образом 
# список коэффициентов (значения от 0 до 100) многочлена и 
# записать в файл многочлен степени k.

import random
k = 5
coeffs = [random.randrange(0,100) for i in range(k)]
powers = [i for i in range(k)]
terms = list(zip(coeffs, powers))
terms = list(map(lambda x: f' + {x[0]}*x^{x[1]}',terms))
print("".join(terms))


exit()

import random

k = int(input('k = '))

path = 'task4_polynomials.txt'
file = open(path, 'a')
file.write(f"{random.randrange(1,100)}*x^{k} ")
for i in range(k-1, 0, -1):
    coeff = random.randrange(0,100)
    if(coeff !=0 ):
        file.write(f"+ {coeff}*x^{i} ")
coeff = random.randrange(0,100)
if(coeff !=0 ):
    file.write(f"+ {coeff} ")
file.write('= 0\n')

file.close()