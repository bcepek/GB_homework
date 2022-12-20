# Задайте число. Составьте список чисел Фибоначчи,
# в том числе для отрицательных индексов.

k = int(input("k > "))
fib_list = [0]
for i in range(1, k+1):
    if (i == 1):
        fib_list.append(1)
    else:
        fib_list.append(fib_list[i-1]+fib_list[i-2])
for i in range(1, k+1):
    if (i == 1):
        fib_list.insert(0, 1)
    else:
        fib_list.insert(0, fib_list[1]-fib_list[0])
print(fib_list)
