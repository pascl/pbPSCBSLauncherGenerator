# pbPSCBSLauncherGenerator

A little software to use with *PSC*lassic (to use in conjonction with BleemSync1.2 and pbPscReAlpha1.6) which can generate files automatically by scanning folders on your USB drive.

Download Link: https://github.com/pascl/pbPSCBSLauncherGenerator/releases

Last version: 0.4

![Preview](https://i.imgur.com/PWkIGUH.png)

## First
* No need any file modifications using BleemSync1.2
* Download pbPSCReAlpha 1.6 (or more) to generate database file after using pbPscBsLauncherGenerator: https://github.com/pascl/pbPSCReAlpha/releases
* In order to have pictures and correct information when scanning folders, you need to download gamelists for retro consoles.
  * https://github.com/recalbox/recalbox-gamelists
  * Or https://github.com/pascl/recalbox-gamelists
  There are not all the consoles, so I am planning to add the missing ones soon.
  You have to unzip these files to have a "gamelists" folder in the folder of the exe (./gamelists/nes/, ./gamelists/snes, etc...)
* You can edit retroarch_params.xml to add a quick setting shortcut in the combobox in the top-right corner, or edit path to search the game info and pictures elsewhere.
  
## Need to know
* This tool creates new folders in the Games folder with all needed files. If you scan twice the same folder, you'll have finally each rom twice in folders.
* It doesn't move the roms. Roms stay where they are.
* After using it, you need pbPscReAlpha to regenerate the database.

## Create rom launchers
* Select your drive.
* Select your rom folder on the drive.
* Select the scan settings with the quick settings combobox, then edit the settings for your convenience.
* Click on Scan Folder. The scan includes the subfolders.
* At the bottom-right of the window, you can see the count of found roms and not found roms. The scanning is not perfect, may find a wrong game, or don't find at all. If you don't have the gamelist folder for a console, all won't be found, and files will be created with default information.

## File list in release pack
* pbPSCBSLauncherGenerator.exe
* retroarch_params.xml
* README.md
* pngquant/COPYRIGHT - file from pngquant pack
* pngquant/pngquant.exe - file from pngquant pack
* pngquant/readme.txt - file from pngquant pack