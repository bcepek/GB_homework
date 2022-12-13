# Напишите программу, которая принимает на вход координаты
# двух точек и находит расстояние между ними в 2D пространстве.

from math import sqrt

point_1 = []
point_2 = []

point_1.append(int(input("X1 = ")))
point_1.append(int(input("Y1 = ")))
point_2.append(int(input("X2 = ")))
point_2.append(int(input("Y2 = ")))

distance = sqrt((point_1[0]-point_2[0])**2 + (point_1[1]-point_2[1])**2)
print(
    f"({point_1[0]}, {point_1[1]}), ({point_2[0]}, {point_2[1]}) -> {distance}")
