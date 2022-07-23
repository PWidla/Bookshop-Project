# Temat projektu: Aplikacja księgarni
## Wizualnie
**Okno logowania**
- Pola do wprowadzania danych (username & password) 
- Przycisk logowania
- Komunikat o niepoprawnych danych / komunikat o udanym logowaniu
- Przycisk przejścia do okna rejestracji

**Okno rejestracji**
- Pola do wprowadzania danych (username & password) 
- Przycisk rejestracji
- Komunikat o niepoprawnych danych / komunikat o udanej rejestracji
- Przycisk przejścia do okna logowania

**Okno dostępnych książek**
- Tabela zawierająca dostępne książki
- Przycisk umożliwiający rezerwację zaznaczonej pozycji
- Przycisk wylogowania
- Przycisk przejścia do okna z wiadomościami (postami)

**Okno dostępnych książek (administrator)**
- Tabela zawierająca dostępne książki
- Przycisk umożliwiający rezerwację zaznaczonej pozycji
- Przycisk wylogowania
- Przycisk przejścia do okna z wiadomościami (postami)
- Przycisk przejścia do okna z historią rezerwacji 

**Okno z wiadomościami/postami**
- Tabela zawierająca dodane posty
- Przycisk powrotu do okna z listą książek
- Przycisk wylogowania

**Okno z wiadomościami/postami (administrator)**
- Tabela zawierająca dodane posty
- Pola do wprowadzania danych nowego postu
- Przycisk dodający nowy post zawierający dane wprowadzone przez administraotra
- Przycisk umożliwiający usunięcie zaznaczonego postu
- Przycisk powrotu do okna z listą książek
- Przycisk wylogowania

**Okno z historią rezerwacji (administrator)**
- Tabela zawierająca historię rezerwacji
- Przycisk powrotu do okna z listą książek
- Przycisk wylogowania


## Technicznie
**Baza danych**
- Tabela "users"
- Tabela "books"
- Tabela "wishlist"
- Tabela "posts"

**ORM + operacje na bazie**
- Dodawanie rekordów do bazy
- Usuwanie rekordów z bazy
- Pobieranie danych z bazy
