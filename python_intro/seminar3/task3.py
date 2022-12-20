# Задайте список из вещественных чисел. Напишите программу,
# которая найдёт разницу между максимальным и минимальным
# значением дробной части элементов.

import random
list_len = random.randrange(0, 10)
my_list = []
for i in range(0, list_len):
    my_list.append(random.uniform(0, 10))

min_frac_part = 1
max_frac_part = 0
for element in my_list:
    print(f"{element:.2f}", end=' ')
    if (min_frac_part > element % 1):
        min_frac_part = element % 1
    if (max_frac_part < element % 1):
        max_frac_part = element % 1
print(f"\n{max_frac_part:.2f} - {min_frac_part:.2f} = {max_frac_part - min_frac_part:.2f}")
