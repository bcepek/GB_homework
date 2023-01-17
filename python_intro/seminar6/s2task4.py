# Пример для list comprehension, lambda, enumerate, filter.
# После exit() приведен изначальный код

# Задайте список из N элементов, заполненных числами из
# промежутка [-N, N]. Найдите произведение элементов на
# указанных позициях.

positions = [2, 5, 7, 6, 3]
N = 10
my_list = [x for x in range(-N, N+1)]
numerated_list = list(enumerate(my_list))
list_to_sum = list(filter(lambda x: x[0] in positions, numerated_list))
result = list_to_sum.pop()[1]
for x in list_to_sum:
    result *= x[1]
print(f"Initial list:\n{my_list}")
print(f"Selected positions:\n{positions}")
print(f"Multiplication result:\n{result}")

exit()

# reading positions from file
path = 'file.txt'
data = open(path, 'r')
positions = []
for line in data:
    positions.append(int(line))
data.close()

# generating list
N = 10
my_list = []
for i in range(-N, N+1):
    my_list.append(i)

    # multiplying selected elemets
result = my_list[positions[0]]
for i in range(1, len(positions)):
    result *= my_list[positions[i]]

    # printing result
print(f"Initial list:\n{my_list}")
print(f"Selected positions:\n{positions}")
print(f"Multiplication result:\n{result}")
