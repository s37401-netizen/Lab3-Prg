// Zadanie1
/*
Console.Write("Wpisz liczbę: ");
int liczba = int.Parse(Console.ReadLine()!);

string result = liczba % 2 == 0 ? "Liczba jest parzysta.": "Liczba jest nieparzysta";
Console.WriteLine(result);
*/
// Zadanie2
/*
Console.Write("Wpisz stronę: ");
string strona = Console.ReadLine()!;

switch (strona)
{
    case "północ":
        Console.WriteLine("Wyruszasz w stronę gór.");
        break;
    case "południe":
        Console.WriteLine("Wyruszasz w stronę pustyni.");
        break;
    case "wschód":
        Console.WriteLine("Wyruszasz w stronę lasu");
        break;
    case "zachód":
        Console.WriteLine("Wyruszasz w stronę morza.");
        break;
    default:
        Console.WriteLine("Nieznany kierunek");
        break;
}
*/
// Zadanie 3
/*
Console.Write("Wpisz swój wiek: ");
int wiek = int.Parse(Console.ReadLine()!);

if (wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek");
}
else if (wiek <= 12)
{
    Console.WriteLine("Dziecko");
}
else if (wiek <= 17)
{
    Console.WriteLine("Nastolatek");
}

else if (wiek <= 64)
{
    Console.WriteLine("Osoba dorosła");
}
else
{
    Console.WriteLine("Senior");
}
*/
// Zadanie 4
/*
Console.ForegroundColor = ConsoleColor.Blue;
int punktyZycia = int.Parse(Console.ReadLine()!);
bool maKlucz = bool.Parse(Console.ReadLine()!);
bool znaHaslo = bool.Parse(Console.ReadLine()!);

if (punktyZycia <= 0)
{   
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nie możesz wejść!");
}
else if (punktyZycia > 0 && (znaHaslo || maKlucz))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Możesz wejść!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Nie możesz wejść!");
}
*/
// Zadanie czw (1)
/*
Console.Write("Wpisz zdrowię: ");
int hp = int.Parse(Console.ReadLine()!);
Console.Write("Wpisz złoto: ");
int zloto = int.Parse(Console.ReadLine()!);
int mikstura = 30;
    
string stan = hp > 0 ? "Żyje": "Nie żyje";
string zakupy = zloto >= 30 ? "Możesz kupić miksturę." : "Brakuje złota.";

Console.WriteLine(stan);
Console.WriteLine(zakupy);
*/
// Zadanie czw (2)
/*
Console.Write("Wpisz zdrowię: ");
int hp = int.Parse(Console.ReadLine()!);

if (hp > 0)
{
    Console.WriteLine("Żyje");
}
else
{
    Console.WriteLine("Nie żyje");
}
// Moim zdaniem czw (2) jest czytelniejsze i go szybciej można zrozumieć
// Natomiast czw (1) jest szybszym wariantem, ale mniej zrozumiałym
*/
// Zadanie 5
/*
Console.Write("Wpisz zdrowię: ");
int hp = int.Parse(Console.ReadLine()!);
Console.Write("Wpisz obrażenia broni: ");
int obrazeniaBroni = int.Parse(Console.ReadLine()!);
Console.Write("Wpisz czy bohater ma miksturę: ");
bool maMiksture = bool.Parse(Console.ReadLine()!);
Console.WriteLine("Wybierz akcję: 1 — atak, 2 — leczenie, 3 — ucieczka.");
int akcja = int.Parse(Console.ReadLine()!);



if (hp < 0)
{
    Console.WriteLine("Przegrałeś");
}
else
{
    switch (akcja)
    {
        case 1:
            Console.WriteLine(obrazeniaBroni);
            break;
        case 2:
            if (maMiksture)
            {    hp += 20;
                Console.WriteLine("+20hp");
            }
            else
            {
                Console.WriteLine("Nie masz mikstury");
            }
            break;
        case 3:
            Console.WriteLine("Ucieczka");
            break;
        default:
            Console.WriteLine("Nieznana akcja");
            break;
    }
}    

if (hp < 20)
{
    Console.WriteLine("Masz mniej 20 punktów życia!");
}
*/
Console.WriteLine("Wpisz imię: ");
string imie = Console.ReadLine()!;
Console.WriteLine("Wpisz Hp: ");
int hp = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz poziom: ");
int poziom = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz siłę: ");
int sila = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz mikstury: ");
int mikstury = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz złoto: ");
int zloto = int.Parse(Console.ReadLine()!);
Console.WriteLine("Wpisz czy ma mapę: ");
bool maMape = bool.Parse(Console.ReadLine()!);

string zyje = hp > 0 ? "Żyje":"Nie żyje";
string niskiHp = hp <= 20 ? "Tak":"Nie";
string mozeWyr = zloto >= 5 && (maMape || mikstury >= 2) ? "Tak":"Nie";
string stan = zloto >= 100 ? "Tak":"Nie";
string gotowy = hp >= 69 && mikstury >= 5 ? "Tak":"Nie";

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("+==========================================+");
Console.WriteLine("|             KARTA BOHATERA               |");
Console.WriteLine("+==========================================+");
Console.ResetColor();
Console.WriteLine($"|Bohater: {imie}                            |");
Console.WriteLine($"|Mikstury: {poziom}                               |");
if (hp < 21)
{
    Console.ForegroundColor = ConsoleColor.Red;
}
else if (hp < 69)
{
    Console.ForegroundColor = ConsoleColor.Yellow;   
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
}
Console.WriteLine($"|Zdrowie: {hp}                              |");
Console.ResetColor();
Console.WriteLine($"|Mikstury: {sila}                               |");
Console.WriteLine($"|Mikstury: {mikstury}                               |");    
Console.WriteLine($"|Złoto: {zloto}                                 |");   
Console.WriteLine($"|Ma mapę: {maMape}                              |");    
Console.WriteLine("+------------------------------------------+");
Console.WriteLine($"|Żyje: {zyje}                                |");
Console.WriteLine($"|Niski poziom zdrowia: {niskiHp}                |");
Console.WriteLine($"|Może wyruszyć: {mozeWyr}                       |");
Console.WriteLine($"|Jest Bogat: {stan}                           |");
Console.WriteLine($"|Gotowa do walki: {gotowy}                      |");
Console.WriteLine("+==========================================+\n");
Console.WriteLine("Ready?");
bool ready = bool.Parse(Console.ReadLine()!);
if (ready)
{  
    Console.WriteLine("Wybierz akcje: 1- 2- 3-");
    int akcja = int.Parse(Console.ReadLine()!);
    switch (akcja)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
    }
}
else
{
    Console.WriteLine("Czekam");
}
