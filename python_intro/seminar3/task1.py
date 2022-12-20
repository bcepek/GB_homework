# Задайте список из нескольких чисел. Напишите программу,
# которая найдёт сумму элементов списка, стоящих на нечётной позиции.

import random
list_len = random.randrange(3, 10)
my_list = []
for i in range(0, list_len):
    my_list.append(random.randrange(0, 10))

print(f"{my_list}\nnumbers in odd positions are:")
elements_sum = 0
for i in range(1, len(my_list), 2):
    elements_sum += my_list[i]
    print(f"{my_list[i]}", end=' ')
print(f"\nsum of these elements is {elements_sum}")
