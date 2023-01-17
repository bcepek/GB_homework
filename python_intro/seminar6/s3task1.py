# Пример для list comprehension, lambda, enumerate, filter.
# После exit() приведен изначальный код

# Задайте список из нескольких чисел. Напишите программу,
# которая найдёт сумму элементов списка, стоящих на нечётной позиции.

import random

list_len = random.randrange(3, 10)
my_list = [random.randrange(0, 10) for i in range(list_len)]
list_to_sum = list(filter(lambda x: x[0] % 2 != 0, list(enumerate(my_list))))
elements_sum = 0
for x in list_to_sum:
    elements_sum += list_to_sum[1]
print(my_list)
print(elements_sum)

exit()

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
