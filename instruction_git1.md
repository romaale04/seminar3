# **Инструкция по работе с системой контроля версий Git**

![Эмблема Гит](git.jpg)

## Что такое Git

Гит это система контроля версий. Нужна для того чтобы...

## Создание репозитория

Чтобы создать репозиторий (инициализировать) использует команду:

git init

## Проверка состояния репозитория

Чтобы проверить статус репозитория используем команду:

git status

## Добавление версии файла

Чтобы добавить новую версию файла используем команду:

git add

## Фиксация изменения

Чтобы зафиксировать изменение файла используем команду: 

git commit <message>

## Открытие текстового редактора

Чтобы открыть текстовый редактор используем команду:

git commit

## Добавление в индекс

Чтобы добавить в индекс, используем команду:

git commit -a 

## Добавление в индекс и фиксация изменения с помощью одной команды

Чтобы одновременно добавить в индекс и зафиксировать изменение, нужно использовать команду:

git -am "Message"

## Просмотр всех изменений

Чтобы просмотреть все изменения, нужно использовать команду: 

git log

## Выведение всех по одной строчке всех изменений

Чтобы вывести по одной строчке всех изменений, нужно использовать команду:

git log --oneline 

## Проверка изменений 

Чтобы проверить, что изменилось в файле, используем команду:

git diff

## Переключение на commit

Чтобы переключиться на commit, используем команду:

git checkout <hash>

## Просмотр всех коммитов

Чтобы просмотреть все коммиты, нужно использовать команду:

git log --oneline --all

## Возвращение обратно с коммита

Чтобы вернуться обратно с коммита, нужно использовать команд:

git checkout master

## Ветвления

### Просмотр существующих веток

Для того чтобы посмотреть, какие ветки созданы, используется команда:

    git branch

## Создание новой ветки 

Для создания новой команды используем команду:

    git branch <>

## Слияние веток

Для слияния веток используем команду:

    merge

## Удаление ветки

Для удаления ветки используем команду:

git -d <>
    
## Добавление картинки 

Для добавления картинки делаем следующее:

    ![Эмблема Гит](название файла.jpg)

## Конфликт

## Удалённые репозитории

###Связывание локального репозитория с удаленным
    
## Удаленные репозитории

Чтобы зайти в удаленный репозиторий используем команду:

    git rеmote add origin <имя репозитория>

Чтобы перейти на главную ветку удаленного репозитория, используем команду:

    git branch -M master

Чтобы загрузить репозиторий на git.hub, используем команду:

    git push
    
Чтобы связать локальный репозиторий с удаленным, используем команду:

    git merge