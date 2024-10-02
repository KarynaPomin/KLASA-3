def CzyPosortowana(T):
    return 

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
        return T[lewy] == a

T = [1, 2, 3, 4, 5, 6, 7]

if WyszukiwanieBinarne(T, 9, len(T)):
    print("Jest")
else:
    print("Brak")
