# Реализуйте алгоритм перемешивания списка.

import random
my_list = ['m', 'y',
           'l', 'i', 's', 't',
           'i', 's',
           'a', 'm', 'a', 'z', 'i', 'n', 'g']
shuffled_list = []
print(my_list)
for i in range(0, len(my_list)):
    pick_index = random.randrange(0, len(my_list))
    shuffled_list.append(my_list.pop(pick_index))
print(shuffled_list)
