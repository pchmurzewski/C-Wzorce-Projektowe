#Composite Kompozyt
Kompozyt to strukturalny wzorzec obiektowy, który składa obiekty w struktury drzewiaste. Dzięki niemu można traktować obiekty jak i ich złożenia w ten sam sposób. 

Implementacja - wzorzec składa się z klasy abstrakcyjnej Component którą implementują dwie klasy Composite i Leaf. Leaf to najmniejsza jednoska w naszym drzewie (liść) a Composite to złożenie różnych jednostek (gałąź) mogący zawierać inne liście i gałęzie.

Cechy wzorca:
1. definiowanie hierarchii obiektów prostych i złożonych
2. uproszczenie kodu klienta - klient traktuje strutkury proste i złożone w ten sam sposób nie wiedząc czy coś jest liściem czy gałęzią (nie powinno to mieć znaczenia)
3. ułatwia dodawanie nowych komponentów, podklasy Composite albo Leaf automatycznie będą współdziałać z kodem klienta
4. może sprawić że projekt będzie zbyt ogólny, czasami chcemy dodawać do danego kompozytu tylko komponenty danego rodzaju i wtedy trzeba sprawdzać je w czasie wykonywania programu

Powiązane wzorce:
1. Łańcuch zobowiązań (Chain of responsibility) - używa powiązań pomiędzy obiektami
2. Dekorator (Decorator) -  stosując razem Dekorator i Kompozyt mają wspólną klasę nadrzędną i wtedy dekorator musi obsługiwać interfejs klasy komponent
3. Pyłek (Flyweight) - umożliwia współużytkowanie komponentów bez przechowywania referencji do elementów nadrzędnych
4. Iterator (Iterator) - można wykorzystać do przechodzenia po zawartości kompozytów
5. Odwiedzający (Visitor) - zapewnia jedną lokalizację dla operacji i zachowań

Diagram UML przykładu:
![UML Diagram](/out/diagram.png)