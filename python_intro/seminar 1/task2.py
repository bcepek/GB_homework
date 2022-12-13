# Напишите программу для. проверки истинности утверждения
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат

print("X | Y | Z | left_part | right_part")
for x in range(0, 2):
    for y in range(0, 2):
        for z in range(0, 2):
            left_part = not (x and y and z)
            right_part = not x or not y or not z
            print(f"{x} {y} {z} {left_part} {right_part}")
