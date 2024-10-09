def CzyMalejacy(T):
    for i in range(len(T) - 1):
        if T[i] > T[i + 1]:
            return False
    return True


def WyszukiwanieBinarne(T, a, n):
    lewy = 0
    prawy = n - 1

    while lewy < prawy:
        srodek = (lewy + prawy) // 2
        if T[srodek] < a:
            lewy = srodek + 1
        else:
            prawy = srodek

    if T[lewy] == a:
        print("Tak")
    else:
        print("Nie")


# Zad 1
def Zad_1():
    T = []
    print("Podaj niemalejący ciąg: ")

    for i in range(10):
        element = int(input(f"Podaj {i + 1} element: "))
        T.append(element)

    if CzyMalejacy(T) == False:
        while CzyMalejacy(T) == False:
            T.clear()
            print("Błąd! Podaj niemalejący ciąg: ")
            for i in range(10):
                element = int(input(f"Podaj {i + 1} element: "))
                T.append(element)

    userNumber = int(input("Sprawdź czy jest w liście: "))
    WyszukiwanieBinarne(T, userNumber, 10)


# Zad 2
def RekuWyszukiwanieBinarne(T, a, n):
    print(T)
    if n <= 0:
        return 0
    if T[n // 2] == a:
        return T[n // 2]
    if T[n // 2] < a:
        T = T[(n // 2)::]
        return RekuWyszukiwanieBinarne(T, a, len(T))
    if T[n // 2] > a:
        T = T[:(n // 2):]
        return RekuWyszukiwanieBinarne(T, a, len(T))

def RekWbinarne(T, a, lewy, prawy):
    if lewy < prawy:
        srodek = (lewy + prawy) // 2
        if T[srodek] < a:
            return RekWbinarne(T, a, srodek + 1, prawy)
        else:
            return RekWbinarne(T, a, lewy, srodek)

    return T[lewy] == a

def Zad_2():
    T = [0] * 10
    print("Podaj niemalejący ciąg: ")

    for i in range(10):
        element = int(input(f"Podaj {i + 1} element: "))
        T[i] = element

    if CzyMalejacy(T) == False:
        while CzyMalejacy(T) == False:
            print("Błąd! Podaj niemalejący ciąg: ")
            for i in range(10):
                element = int(input(f"Podaj {i + 1} element: "))
                T[i] = element

    userNumber = int(input("Sprawdź czy jest w liście: "))

    # if RekuWyszukiwanieBinarne(T, userNumber, 10) == userNumber:
    #     print("Tak")
    # else:
    #     print("Nie")

    if RekWbinarne(T, userNumber, 0, len(T) - 1):
        print("Tak")
    else:
        print("Nie")

# Zad_3
def Zad_3():
    plik = open("ciag.txt", "r")
    Ciagi = plik.readlines()
    plik.close()

    for ciag in Ciagi:
        C = list(map(int, ciag.split()))
        if RekWbinarne(C, 10, 0, len(C) - 1):
            print(C)

# Zad 4
def Zad_4():
    plik = open("ciag2.txt", "r")
    n = int(plik.readline().rstrip()) # rstrip - usuwa białe znaki

    for i in range(n):
        dCiag = int(plik.readline().rstrip())
        ciag = list(map(int, plik.readline().split()))

        if RekWbinarne(ciag, 10, 0, len(ciag) - 1):
            print(ciag)

    plik.close()
