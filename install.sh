echo "Добро пожаловать в установщик 507-Backup!"
echo "Устанавливаем!"

wget "https://github.com/ffghhjjhkhjkhjkhjkhkj/507-backup/raw/refs/heads/main/binares/507-backup" -q -O 507-backup
sudo mv 507-backup /usr/local/bin/
sudo chmod +x /usr/local/bin/507-backup

echo "Установка завершена!"