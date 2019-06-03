# pbPSCBSLauncherGenerator

A little software to use with *PSC*lassic and modded *B*leem*S*ync1.1 which can generate launcher files automatically by scanning folders on your USB drive.

Download Link: https://github.com/pascl/pbPSCBSLauncherGenerator/releases

Last version: 0.31

![Preview](https://i.imgur.com/ImZaOce.png)

## First
* Download the modded BleemSync1.1 files *and have a look at the readme*: https://github.com/pascl/BleemSync_Mods
* Download pbPSCReAlpha 1.3 (or more) to split database in several files: https://github.com/pascl/pbPSCReAlpha/releases
* In order to have pictures and correct information when scanning folders, you need to download gamelists for retro consoles.
  * https://github.com/recalbox/recalbox-gamelists
  * Or https://github.com/pascl/recalbox-gamelists
  There are not all the consoles, so I am planning to add the missing ones soon.
  You have to unzip these files to have a "gamelists" folder in the folder of the exe (./gamelists/nes/, ./gamelists/snes, etc...)
* You can edit retroarch_params.xml to add a quick setting shortcut in the combobox in the top-right corner, or edit path to search the game info and pictures elsewhere.
  
## Need to know
* You have to know that newly-created rom-launchers (or folders) don't overwrite if there is an existing one with the same name.
* If it already exists, the newly-created directory in your explorer will be suffixed '_X' (with X a number, ascending at each scan if you don't remove the old ones).

For example, if you scan twice the same folder, you'll have finally each rom twice on screen.

## Create rom launchers
* Select your drive.
* Select your rom folder on the drive.
* Select the scan settings with the quick settings combobox, then edit the settings for your convenience.
* Click on Scan Folder. The scan includes the subfolders.
* At the bottom-right of the window, you can see the count of found roms and not found roms. The scanning is not perfect, may find a wrong game, or don't find at all. If you don't have the gamelist folder for a console, all won't be found, and launchers will be created with default information.

## Create a folder
* At the bottom-left of the window, you can create folders.
* Edit name, publisher, year (this 3 information will be on screen).
* Edit the DB file (pbPSCReAlpha permits to split the database).
* Edit the folder ID and the parent ID (*see the readme of BleemSync_Mods for special cases*)
* Double-click in the black-bordered square to add a picture. Shift-double-clicked to clear the picture.
* Then click on Create.

## Video
https://www.youtube.com/watch?v=LEKqin5gYuA

## File list in release pack
* pbPSCBSLauncherGenerator.exe
* retroarch_params.xml
* README.md
* pngquant/COPYRIGHT - file from pngquant pack
* pngquant/pngquant.exe - file from pngquant pack
* pngquant/readme.txt - file from pngquant pack