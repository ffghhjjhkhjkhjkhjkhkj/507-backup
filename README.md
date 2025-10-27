Привет! это еще один мой проект!
-------------------------------------------------------
Что это такое?:

Это 507-backup утилита для бекапа файлов

-------------------------------------------------------

Доступна на линуксе и винде! 

ДЛЯ ВИНДЫ:
Открываете PowerShell от имени админа и выполняете
```
$d="$env:USERPROFILE\Apps\507-backup"; mkdir $d -Force; iwr "https://github.com/ffghhjjhkhjkhjkhjkhkj/507-backup/releases/download/V1.0/507-backup.exe" -OutFile "$d\507-backup.exe"; $p=[Environment]::GetEnvironmentVariable("Path","User"); if($p -notlike "*$d*"){[Environment]::SetEnvironmentVariable("Path","$p;$d","User")}; echo "✅ Установлено! Перезапусти терминал."

```
Все!

Для линукса скоро появиться..
