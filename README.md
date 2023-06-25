# Wally (Deprecated)
Утилита для установки видеофайлов как обоев. В основе лежит программа [Weebp](https://github.com/Francesco149/weebp) и плеер [MPV](https://mpv.io).
<br>
<br>
![](https://github.com/AskoRBINKAs/Wally/blob/master/Qe3PC9W8iGw.jpg)
<br>
![](https://github.com/AskoRBINKAs/Wally/blob/master/5y0DJD0JxoE.jpg)
<br>
![](https://github.com/AskoRBINKAs/Wally/blob/master/hGp07Qi1X3k.jpg)
<br>
![](https://github.com/AskoRBINKAs/Wally/blob/master/yoJS-HCnZFg.jpg)
<br>
## Возможности:<br>
- [x] Добавлять видео (.mp4; .avi; .gif; .webm; .mov; .mkv)
- [x] Ставить веб страницы на обои (через URL или из HTML файла) без интерактива
- [x] Добавлена кастомизация параметров запуска MPV 
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
4. ВАЖНО - расположите обои в отдельном каталоге, который не будет удаляться и т.д.! Программа чувствительна к пути расположения видео и превью! Также избегайте кириллицы в путях установки утилиты и расположения обоев

Другой способ - во вкладке Создать/Create указать путь к файлам по отдельности (файл для превью необязателен)

## Баги
1. Проблема со сменой языка - кнопки Gallery/Обои и Settings/Параметры меняются только при перезагрузке приложения. Остальный поля работают корректно
2. Возможны баги с разворачиванием окна

## Планы на будущее
1. Добавить создание и воспроизведение обоев из плейлистов

# ENGLISH
Utility for setting video files as wallpaper. It is based on [Weebp](https://github.com/Francesco149/weebp) and [MPV](https://mpv.io).
<br>
## Features
- [x] Using video (.mp4; .avi; .gif; .webm; .mov; .mkv) as wallpaper
- [x] Using web pages (by URL or HTML File) as wallpaper without interacting
- [x] Customizing MPV run arguments 
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
4. IMPORTANT -  Please, place wallpapers in stable directory. Program very sensetive for path to video and preview!!! Also, try to avoid cyrillic symbols in installation path and location wallpapers

Another way - click Create and add needed files (preview file is not neccessary)
## Bugs
1. Localization - after selecting language you need to restart program to apply changes
2. May bugs with opening main window

## TODO:
1. Add playlists system

