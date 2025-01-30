### Program Wypożyczalnia skuterów i motorów -- Motorynka

### Temat: Jest to prosta aplikacja WPF napisana w języku C# oparta na koncepcji programowania obiektowego.
Cel biznesowy: Aplikacja umożliwia użytkownikom wynajem pojazdów jednośladowych odpłatnie zgodnie z podanym cennikiem.


### Opis Architektury

Paradygmat obiektowy został wdrożony w celu stworzenia poszczególnych pojazdów oraz zadeklarowania ich wartości. 
Kluczowe klasy to klasa Motor oraz Skuter, który dziedziczy większość wartości od klasy Motor. 
Główną klasą implementującą funkcjonalność wypożycznia pojazdu jest klasa Wypozyczenie tam zawarta jest logika sprawdzania czy może zostać ono utworzone.
Paradygmat obiektowy został zaimplementowyny w klasie Skuter, która dziedziczy od klasy Motor. Dodatkowo klasa obrazuje wykorzystanie polimorfizmu
gdzie o tym czy pojazd jest elektryczny czy nie decyduje wartość isElectric i na tej podstawie przypisuje właściwy ty pojazdu.
W aplikacji została takrze użyta enkapsulacja reprezentowana przez deklaracje prywatnych pól w klasie Wypozyczenie.

### Użyte technologie
WPF
C#
MySQL
VisualStudio
Krita (do tworzenia loga)
### Wymagania wstępne: 
Microsoft Visual Studio, MySQL

### Funkcjonalności
Wypożyczenie skuteru na okres x dni
Wypożyczenie motoru na okres x dni
Sprawdzenie czy dany pojazd jest zajęty
Utworzenie użytkownika 
Potwierdzenie wynajęcia pojazdu


### Załączniki ze zdjęciami bazy danych

https://cdn.discordapp.com/attachments/1325450504725069947/1334128589213270037/image.png?ex=679cb912&is=679b6792&hm=c5d1a244ad994afd047827d7daeed66ae61c21c58d4cce8d8a999268d271ac22&

https://cdn.discordapp.com/attachments/1325450504725069947/1334128863889981480/image.png?ex=679cb954&is=679b67d4&hm=3e132837b5133f82ca53593fdb3468b0ec2dad3160c5ef516a4b98cda7780e31&
