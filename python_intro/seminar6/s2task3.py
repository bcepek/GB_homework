# Пример для list comprehension.
# После exit() приведен изначальный код

# Задайте список из n чисел последовательности
# $(1+\frac 1 n)^n$ и выведите на экран их сумму.
# Пример:
# Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

n = int(input("n > "))
sum_elements = 0
seq_list = [(1+1/i)**i for i in range(1,n+1)]
for x in seq_list:
    sum_elements+=x
print(f"Σ{n}: {sum_elements:.2f}")

exit()

n = int(input("n > "))
sum_elements = 0
seq_list = []
for i in range(1, n+1):
    seq_list.append((1+1/i)**i)
    sum_elements += seq_list[i-1]
    print(f"{i}: {seq_list[i-1]:.2f}", end=" ")
print(f"\nΣ{n}: {sum_elements:.2f}")