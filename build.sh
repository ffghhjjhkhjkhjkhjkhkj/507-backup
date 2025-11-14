echo "Добро пожаловать в билдер 507-Backup!"
echo "Если возникли ошибки значит вам нужно установить DotNet"

dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true --output ./binares

echo "Осталось совсем чуть чуть..."
rm -r bin
rm -r obj
echo "Готово!"