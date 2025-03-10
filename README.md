# Code10

### Задания для учеников 1 курса Backend

## Инструкция по получению обновлений из основного репозитория в форк

### Пункт 1 необходимо выполнить только один раз, после этого информация об `upstream` репозитории будет сохранена

### Вы должны находится в директории, где находится ваш форк репозитория

1. Для начала необходимо добавить информацию о `upstream` (основной репозиторий)
```bash
git remote add upstream https://github.com/gnipka-pc/Code10.git
```
  - Проверьте, что `upstream` добавлен командой `git remote -v`
```bash
» git remote -v
origin  git@github.com:your-username/Code10-Fork.git (fetch)
origin  git@github.com:your-username/Code10-Fork.git (push)
upstream        git@github.com:gnipka-pc/Code10.git (fetch)
upstream        git@github.com:gnipka-pc/Code10.git (push)
```
2. Теперь получите последние изменения из оригинального репозитория
```bash
git fetch upstream
```
3. Сделайте merge в свою ветку main форкнутого репозитория
```bash
git merge upstream/main
```
  - Если есть конфликты, исправьте их, затем выполните
```bash
git add .
git commit -m "Merged updates from upstream"
```
4. Отправьте обновления в ваш форк
```bash
git push origin main
```
