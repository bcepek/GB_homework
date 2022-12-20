# Напишите программу, которая будет преобразовывать десятичное число в двоичное.

dec_number = int(input("number > "))
bin_number = 0
factor = 1
while dec_number != 0:
    bin_number += factor*(dec_number % 2)
    factor *= 10
    dec_number = int(dec_number/2)
print(bin_number)
