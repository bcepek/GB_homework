# Задайте список из N элементов, заполненных числами из
# промежутка [-N, N]. Найдите произведение элементов на
# указанных позициях. Позиции хранятся в файле file.txt
# в одной строке одно число.

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
