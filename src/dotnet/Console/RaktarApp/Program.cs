using RaktarApp.Models;

Console.WriteLine("File beolvasása:");
Console.WriteLine("---------------");

Console.Write("Kérem a fájl elérésit útját: ");
string filePath = Console.ReadLine() ?? string.Empty;

if (!File.Exists(filePath))
{
    Console.WriteLine("A megadott fájl nem létezik.");
    return;
}

List<SchemaError> errors = new List<SchemaError>();
List<WarehouseCsv> validCsv = new List<WarehouseCsv>();

int lineNumber = 0;

foreach (var line in File.ReadAllLines(filePath).Skip(1))
{
    lineNumber++;
    var parts = line.Split(';');
    if (parts.Length != 7)
    {
        errors.Add(new SchemaError("Oszlopok száma hibás", lineNumber));
        continue;
    }
    if (!int.TryParse(parts[0], out int id))
    {
        errors.Add(new SchemaError($"Nem szám: '{parts[2]}' az id oszlopban", lineNumber));
    continue;
    }

    if (!int.TryParse(parts[4], out int postCode))
    {
        errors.Add(new SchemaError($"Nem szám: '{parts[2]}' az postCode oszlopban", lineNumber));
    continue;
    }

    if (errors.Count > 0) return;
    
    validCsv.Add(new WarehouseCsv(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]));
}


if(errors.Count != 0)
{
    Console.WriteLine("Hibák (" + errors.Count + ")" );
    foreach (SchemaError error in errors)
    {
        Console.WriteLine(error.LineNumber + ". sor: " + error.Message);
    }
}
