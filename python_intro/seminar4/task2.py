# Задайте натуральное число N. Напишите программу,
# которая составит список простых множителей числа N.

N = int(input("N > "))
multipliers = []

while N > 1:
    for i in range(2, N+1):
        if (N % i == 0):
            multipliers.append(i)
            N = int(N/i)
            break

print(multipliers)
