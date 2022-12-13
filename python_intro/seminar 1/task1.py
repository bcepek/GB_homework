# Напишите программу, которая принимает на вход цифру,
# обозначающую день недели, и проверяет,
# является ли этот день выходным.

day_number = int(input("Enter day number > "))
print(f"{day_number} >", end=" ")
if day_number > 5 and day_number < 8:
    print("Yes")
elif day_number > 0 and day_number < 6:
    print("No")
else:
    print("Incorrect input")
