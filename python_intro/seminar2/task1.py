# Напишите программу, которая принимает на вход
# вещественное число и показывает сумму его цифр.

number = float(input("Enter number > "))
while (number % 1 != 0):
    number *= 10
sum_digits = 0
while (number >= 1):
    sum_digits += number % 10
    number /= 10    # функции типа floor() не использованы намеренно в целях тренировки
    number -= number % 1
print(f"Sum of number digits is {sum_digits:.0f}")
