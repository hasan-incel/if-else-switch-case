/*
Ürün sayısı fazla olduğunda switch-case'i kullanmak daha pratiktir, ayrıca kontrol if/else'e göre daha okunabilir.
*/

//Meyve fiyatlarını int ile giriyorum.
int elma = 2;
int armut = 3;
int cilek = 2;
int muz = 3;
int diger = 4;

Console.WriteLine("Rüya Manavina Hoş Geldiniz !");
Console.WriteLine($"Elma = {elma} TL ");
Console.WriteLine($"Armut = {armut} TL ");
Console.WriteLine($"Çilek = {cilek} TL ");
Console.WriteLine($"Muz = {muz} TL ");
Console.WriteLine($"Diğer Bütün Meyveler = {diger} TL ");

Console.Write("Hangi Meyveyi satın almak istersiniz? (Elma/Armut/Cilek/Muz/Diğer): ");
//ToLower ile kullanıcının girdiği bütün harfleri küçültür. 
string meyve1 = Console.ReadLine().ToLower();

if (meyve1 == "elma")
{
    Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {elma} TL ");
}
else if (meyve1 == "armut")
{
    Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {armut} TL");
}
else if (meyve1 == "çilek")
{
    Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {cilek} TL");
}
else if (meyve1 == "muz")
{
    Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {muz} TL");
}
else
{
    Console.WriteLine($"Seçtiğiniz Meyvenin Fiyatı: {diger} TL");
}

Console.WriteLine("-----------------------------------------------------------------");
//Switch Case ile aynı sonucu almaya çalışacağım.

Console.WriteLine("Rüya Manavina Hosgeldiniz ! ");
Console.WriteLine($"Elma = {elma} TL ");
Console.WriteLine($"Armut = {armut} TL ");
Console.WriteLine($"Çilek = {cilek} TL ");
Console.WriteLine($"Muz = {muz} TL ");
Console.WriteLine($"Diğer Bütün Meyveler = {diger} TL ");

Console.Write("Hangi Meyveyi satın almak istersiniz? (Elma/Armut/Cilek/Muz/Diğer): ");
//ToLower ile kullanıcının girdiği bütün harfleri küçültür. 
string meyve2 = Console.ReadLine().ToLower();

switch (meyve2)
{
    case "elma":
        Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {elma} TL");
        break;
    case "armut":
        Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {armut} TL");
        break;
    case "cilek":
        Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {cilek} TL");
        break;
    case "muz":
        Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {muz} TL");
        break;
    default:
        Console.WriteLine($"Seçtiğin Meyvenin Fiyatı {diger} TL");
        break;
}