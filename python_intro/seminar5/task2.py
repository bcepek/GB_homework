# Создайте программу для игры с конфетами человек против человека.
# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход. Сколько конфет нужно взять
# первому игроку, чтобы забрать все конфеты у своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте как наделить бота ""интеллектом""

import random


def make_user_turn(candies):
    candies_to_take = int(input(f"Player 1 turn > "))
    while (candies_to_take < 1 or candies_to_take > 28 or candies_to_take > candies):
        print("Incorrect input")
        candies_to_take = int(input(f"Player 1 turn > "))
    return candies-candies_to_take


def make_bot_turn(candies):
    if (candies % 29 == 0):
        candies_to_take = random.randrange(1, 29)
    elif (candies < 29):
        candies_to_take = candies
    else:
        candies_to_take = candies % 29
    print(f"Player 2 turn > {candies_to_take}")
    return candies-candies_to_take


candy_amount = 2021
player_turn = random.randrange(0, 2)
while (candy_amount > 0):
    print(f"Candies left: {candy_amount}")
    if (player_turn == 1):
        candy_amount = make_user_turn(candy_amount)
        player_turn = 0
    else:
        candy_amount = make_bot_turn(candy_amount)
        player_turn = 1
print(f"Player {player_turn+1} won!")
