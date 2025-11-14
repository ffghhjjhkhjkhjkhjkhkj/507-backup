// Импортирование нужных библиотек
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

Console.WriteLine("Добро пожаловать в 507-BACKUP!");
Console.WriteLine("Какую папку нужна забекапить?");
string folder = Console.ReadLine();  // Спрашиваем у пользователя какую папку упаковать
Console.WriteLine("Отлично! приступаем к бекапу...");
string timestamp = DateTime.Now.ToString("dd.MM.yyyy");
Directory.CreateDirectory("backup");
System.Threading.Thread.Sleep(60);
ZipFile.CreateFromDirectory(folder, Path.Combine("backup", $@"Backup_{timestamp}.zip"), CompressionLevel.Optimal, false); // Архивируем
Console.WriteLine("Бекап завершен!");