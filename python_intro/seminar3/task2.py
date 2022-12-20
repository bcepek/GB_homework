# Напишите программу, которая найдёт произведение пар
# чисел списка. Парой считаем первый и последний элемент,
# второй и предпоследний и т.д.

import random
list_len = random.randrange(3, 10)
my_list = []
for i in range(0, list_len):
    my_list.append(random.randrange(0, 10))

print(my_list)
for i in range(0, round((len(my_list)-1)/2)):
    print(my_list[i]+my_list[len(my_list)-i-1], end=' ')
