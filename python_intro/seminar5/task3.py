# Создайте программу для игры в ""Крестики-нолики"".

import os

def print_field(field):
    print('-------------')
    for i in range(3):
        print(f"| {field[i][0]} | {field[i][1]} | {field[i][2]} |")
        print("-------------")


def input_correct(i, j, field):
    if (i > 2 or i < 0 or j > 2 or j < 0):
        return False
    if (field[i][j] != " "):
        return False
    return True


def make_turn(field, player):
    coordinates = input(f"{player} turn. Format example: \"2 1\" > ")
    [i, j] = [int(coordinates[0]), int(coordinates[2])]
    while (not input_correct(i, j, field)):
        print("Input incorrect")
        coordinates = input(f"{player} turn. Format example: \"2 1\" > ")
        [i, j] = [int(coordinates[0]), int(coordinates[2])]
    field[i][j] = player
    return field


def is_victory(field, player):
    diag1 = ''
    for i in range(3):
        if(field[i][i]==player): diag1 += field[i][i]
    diag2 = ''
    for i in range(3):
        if(field[2-i][i]==player): diag2 += field[2-i][i]
    rows = ['', '', '']
    for i in range(3):
        for j in range(3):
            if(field[i][j]==player): rows[i] += field[i][j]
    cols = ['', '', '']
    for i in range(3):
        for j in range(3):
            if(field[i][j]==player): cols[j] += field[i][j]
    if (3*player in cols or 3*player in rows or diag1 == 3*player or diag2 == 3*player):
        return True
    else:
        return False


field = [[' ' for i in range(3)] for j in range(3)]
player = 'X'
for i in range(9):
    os.system("cls")
    print_field(field)
    make_turn(field, player)
    if (is_victory(field, player)):
        print(f"{player} won!")
        exit()
    if player == "X":
        player = "O"
    else:
        player = "X"
print("No winner")
