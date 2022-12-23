# Вычислить число c заданной точностью d

from decimal import *

d = Decimal(input("d > "))
pi = Decimal(0)
addendum = Decimal(4)
i = 1
while abs(addendum) > d/5:
    pi += addendum
    addendum = Decimal(4*((-1)**i)/(2*i+1))
    i += 1

precision = 0
while d < 1:
    precision += 1
    d *= 10
    
print(f'{pi:.{precision}f}')
