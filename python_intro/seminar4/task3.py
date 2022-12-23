# Задайте последовательность чисел. Напишите программу, 
# которая выведет список неповторяющихся элементов 
# исходной последовательности.

import random
list_len = random.randrange(5, 15)
my_list = []
for i in range(0, list_len):
    my_list.append(random.randrange(0, 10))
    
unique_list = []
isunique = True
for i in range(0, len(my_list)):
    for j in range(0, len(unique_list)):
        if(my_list[i]==unique_list[j]):
            isunique = False
            break
    if(isunique):
        unique_list.append(my_list[i])
    isunique = True

print(f"{my_list}\nUnique elements in list are:\n{unique_list}")