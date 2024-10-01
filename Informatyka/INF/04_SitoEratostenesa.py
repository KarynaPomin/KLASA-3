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
def SitoErastosenesaList(n):
    CzyPierwszaLista = [True] * (n + 1)
    CzyPierwszaLista[0] = False
    CzyPierwszaLista[1] = False

    p = 2
    while p * p <= n:
        if CzyPierwszaLista[p]:
            for i in range(p * p, n + 1, p):
                CzyPierwszaLista[i] = False
        p += 1

    return CzyPierwszaLista

def Zad_4():
    sumaLiczbZpliku = 0
    plik = open("liczby.txt", "r")
    liczbyList = list(map(int, input().split()))
    plik.close()

    PierwszeLista = SitoErastosenesaList(1000)

    for liczba in liczbyList:
        if PierwszeLista[int(liczba)]:
            sumaLiczbZpliku += 1
        
    print(sumaLiczbZpliku)



