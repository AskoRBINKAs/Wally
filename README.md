# Wally
Утилита для установки видеофайлов как обоев. В основе лежит программа [Weebp](https://github.com/Francesco149/weebp) и плеер [MPV](https://mpv.io).
<br>
<br>
![](https://github.com/AskoRBINKAs/Wally/blob/master/0QUWXk1ghbU.jpg)
<br>
![](https://github.com/AskoRBINKAs/Wally/blob/master/3Rg_JfIQYr0.jpg)
<br>
<br>
## Возможности:<br>
- [x] Добавлять видео (.mp4; .avi; .gif; .webm; .mov; .mkv)
- [x] Добавить в автозагрузку
- [x] Сворачивать в трей
- [x] Есть поддержка двух языков - русский и английский (выбирать вручную)
## Требования
* ОС: Windows 7, 10 (Windows 8 не тестировалась)
* .NET 6
* Права администратора не нужны

## Как добавить обои 
1. Расположить в одном каталоге 2 файла - видео и превью
2. Создать файл project.json со следующим содержимым
```json
{
	"Name":"Car",
	"PathToVideo":"X6M.mp4",
	"PathToLogo":"preview.jpg"
}
```
3. Выбрать этот файл кнопкой Add

## Баги
1. Проблема со сменой языка - кнопки Gallery/Обои и Settings/Параметры меняются только при перезагрузке приложения. Остальный поля работают корректно
2. Возможны проблемы с автозагрузкой. Решение - создать ярлык и добавить его в папку автозагрузки

## Планы на будущее
1. Добавить создание и воспроизведение обоев из плейлистов
2. Оптимизация
3. Добавить возможность использования html страниц как обои

# ENGLISH
Utility for setting video files as wallpaper. It is based on [Weebp](https://github.com/Francesco149/weebp) and [MPV](https://mpv.io).
<br>
## Features
- [x] Using video (.mp4; .avi; .gif; .webm; .mov; .mkv) as wallpaper
- [x] Add program to autorun
- [x] Roll up to ray
- [x] Support 2 languages - Russian and English

## System requirements
1. OS - Windows 7 or newer (Win8 not tested)
2. .NET 6
3. Administrator rights are not required

## How to add wallpapers
1. Place 2 files in one directory - video and preview
2. Create "project.json" file with next text:
```json
{
"Name":"Car",
"PathToVideo":"X6M.mp4",
"PathToLogo":"preview.jpg"
}
```
3. Press "Add" in app

## Bugs
1. Localization - after selecting language you need to restart program to apply changes
2. Bug with autorun - sometimes app cannot read config files and load all wallpapers or start playing video. Solution - restart manualy

## TODO:
1. Add playlists system
2. Optimization 
