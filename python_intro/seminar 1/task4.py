# Напишите программу, которая по заданному номеру
# четверти, показывает диапазон возможных координат
# точек в этой четверти (x и y).

quater = int(input("Quater number = "))
if quater == 1:
    print("X > 0, Y > 0")
elif quater == 2:
    print("X < 0, Y > 0")
elif quater == 3:
    print("X < 0, Y < 0")
elif quater == 4:
    print("X > 0, Y < 0")
else:
    print("Incorrect input")
