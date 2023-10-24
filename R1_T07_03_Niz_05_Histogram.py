import math
a, b = map(float, input().split())
n = int(input())
d = (b - a) / n
histogram = [0] * n
k = int(input())
for i in range(k):
    x = float(input())
    podeok = math.floor((x - a) / d)
    histogram[podeok] += 1

x = a
for h in histogram:
    print("[" + "%.3f" % x + ", " + "%.3f" % (x + d) + "): ", end="")
    
    print(h, end="\t")
    
    procenat = h / k
    brojZvezdica = round(100 * procenat)
    for i in range(brojZvezdica):
        print("*", end="")
    print()
    x = x + d
