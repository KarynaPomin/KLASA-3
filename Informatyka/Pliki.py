import math

# wczytanie w piionie
plik = open("liczby1.txt", "r")
liczby = list(map(int, plik.read().split()))
plik.close()

def CzyPierwsza(n):
    if n < 2:
        return False
    pierwiastek = int(math.sqrt(n))
    for i in range(2, pierwiastek + 1):
        if n % i == 0:
            return False
    return True

def Zad_1():
    ile = 0
    for liczba in liczby:
        if CzyPierwsza(liczba):
            ile += 1
    print(ile)


#ciag = plik.read() # wczyta wszystkie linie do tablicy
#ciag = plik.readline() # wczyta telko jedną linię do tablicy
#ciag = plik.readlines() # wczyta wszystkie linie oraz wiersze do tablicy do tablicy

# wczytanie w poziomie
