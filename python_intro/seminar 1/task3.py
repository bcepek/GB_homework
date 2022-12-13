# Напишите программу, которая принимает на вход
# координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
# и выдаёт номер четверти плоскости, в которой
# находится эта точка (или на какой оси она находится).

X, Y = int(input("X > ")), int(input("Y > "))
print(f"X = {X}, Y = {Y} ->", end=" ")
if X > 0 and Y > 0:
    print("I")
elif X < 0 and Y > 0:
    print("II")
elif X < 0 and Y < 0:
    print("III")
elif X > 0 and Y < 0:
    print("IV")
else:
    print("Incorrect input")
