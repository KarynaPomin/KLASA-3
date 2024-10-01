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
def SumaSitoEratostenesa(n):
    czyPierwszaList = [True] * (n + 1)
    czyPierwszaList[0] = False
    czyPierwszaList[1] = False

    sumaDzielnikow = 0
    p = 2
    while p * p <= n:
        if czyPierwszaList[p]:
            for i in range(p * p, n + 1, p):
                czyPierwszaList[i] = False
        p = p + 1

    for i in range(2, n + 1):
        if czyPierwszaList[i] == True:
            sumaDzielnikow += i

    print(n, sumaDzielnikow)

# Zad 3
def WhileSitoEratostenesa(n):
    czyPierwszaList = [True] * (n + 1)
    czyPierwszaList[0] = False
    czyPierwszaList[1] = False

    p = 2
    while p * p <= n:
        if czyPierwszaList[p]:
            i = p * p
            while i < n + 1:
                czyPierwszaList[i] = False
                i += p
        p = p + 1

    for i in range(2, n + 1):
        if czyPierwszaList[i] == True:
            print(i, end=" ")

# Zad 4
def CzyPierwszaSitoEratostenesa(n):
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
            return True

# Nie zakończone
def Zad_4():
    SitoEratostenesa(1000)

    plik = open("liczby.txt", "r")
    LiczbyList = list(map(int, plik.read().split()))
    plik.close()

    ileLiczbPierwszych = 0
    for liczba in LiczbyList:
        if CzyPierwszaSitoEratostenesa(liczba):
            ileLiczbPierwszych += 1
    print(ileLiczbPierwszych)
    # Odp. 1735

Zad_4()
