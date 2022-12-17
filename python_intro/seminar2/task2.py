# Напишите программу, которая принимает на вход число N и
# выдает набор произведений чисел от 1 до N.

N = int(input("N > "))
output_number = 1
for i in range(1, N+1):
    output_number *= i
    print(output_number, end=" ")
