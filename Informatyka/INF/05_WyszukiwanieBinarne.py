def CzyPosortowana(T):
    return 

# do 1 zadania ! poprawić
def CzyMalejacy(T):
    for i in range(n - 1):
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
    print("Podaj rosnący ciąg")
    for i in range(10):
        element = int(input(f"Podaj {i + 1} element: "))
        T.append(element)

    userNumber = int(input("Sprawdź czy jest w liście: "))
    WyszukiwanieBinarne(T, userNumber, 10)
