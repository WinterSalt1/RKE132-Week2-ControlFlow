// See https://aka.ms/new-console-template for more information

// Rakendus küsib kasutajal valida oma sugu (mees/naine)
// Rakendus küsib kasutajal sisetada oma perekonnanime  
// Lähtudes kasutaja valikust, rakenuds tervitab kasutajat järgmiselt:
// "Welcome Mr. [kasutajanimi perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); // Loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, Enter Your Last Name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f') 
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

