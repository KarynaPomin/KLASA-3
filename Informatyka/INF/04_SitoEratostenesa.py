# Zad 1
def SitoEratostenesa(n):
    czyPierwszaList = [True] * (n + 1)
    czyPierwszaList[0] = False
    czyPierwszaList[1] = False

    p = 2
    while p * p <= n:
        if czyPierwszaList[p]:
            for i in range(p * p, n + 1, p):
                czyPierwszaList[i] = False
        p = p + 1

    for i in range(2, n + 1):
        if czyPierwszaList[i] == True:
            print(i, end=" ")

# Zad 2
