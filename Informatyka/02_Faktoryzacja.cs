def algorytmFaktoryzacjaLista():
    n = int(input("Podaj: "))
    czynnik = 2
    DzielnikiPierwsze = []

    while n > 1:
        while n % czynnik == 0:
            DzielnikiPierwsze.append(czynnik)
            n = n // czynnik
        czynnik += 1

    return DzielnikiPierwsze

def Zad_1():
    n = int(input("Podaj: "))
    czynnik = 2

    while n > 1:
        while n % czynnik == 0:
            print(czynnik)
            n = n // czynnik
        czynnik += 1

def Zad_2():
    n = int(input("Podaj: "))
    czynnik = 2
    suma = 0

    while n > 1:
        while n % czynnik == 0:
            suma += czynnik
            n = n // czynnik
        czynnik += 1

    return suma

def czyPierwsza(n):
    for i in range(2, n):
        if n % i == 0:
            return False
    return True


def Zad_3():
    suma = Zad_2()
    print(suma)

    if czyPierwsza(suma):
        print("Suma czynników pierwszych jest pierwsza")
    else:
        print("Suma czynników pierwszych nie jest pierwsza")

def Zad_4():
    DzielnikiPierwsze = algorytmFaktoryzacjaLista()
    Dzielniki = []

    for i in DzielnikiPierwsze:
        if i not in Dzielniki:
            Dzielniki.append(i)

    print(len(Dzielniki))

def Zad_5():
