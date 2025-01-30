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
