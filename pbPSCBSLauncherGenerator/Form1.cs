﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pbPSCBSLauncherGenerator
{
    public partial class Form1 : Form
    {
        enum CoreType { RetroArchType, DrasticType }
        Color[] knownColors = new Color[] {
            Color.AliceBlue,
            Color.AntiqueWhite,
            Color.Aqua,
            Color.Aquamarine,
            Color.Azure,
            Color.Beige,
            Color.Bisque,
            Color.Black,
            Color.BlanchedAlmond,
            Color.Blue,
            Color.BlueViolet,
            Color.Brown,
            Color.BurlyWood,
            Color.CadetBlue,
            Color.Chartreuse,
            Color.Chocolate,
            Color.Coral,
            Color.CornflowerBlue,
            Color.Cornsilk,
            Color.Crimson,
            Color.Cyan,
            Color.DarkBlue,
            Color.DarkCyan,
            Color.DarkGoldenrod,
            Color.DarkGray,
            Color.DarkGreen,
            Color.DarkKhaki,
            Color.DarkMagenta,
            Color.DarkOliveGreen,
            Color.DarkOrange,
            Color.DarkOrchid,
            Color.DarkRed,
            Color.DarkSalmon,
            Color.DarkSeaGreen,
            Color.DarkSlateBlue,
            Color.DarkSlateGray,
            Color.DarkTurquoise,
            Color.DarkViolet,
            Color.DeepPink,
            Color.DeepSkyBlue,
            Color.DimGray,
            Color.DodgerBlue,
            Color.Firebrick,
            Color.FloralWhite,
            Color.ForestGreen,
            Color.Fuchsia,
            Color.Gainsboro,
            Color.GhostWhite,
            Color.Gold,
            Color.Goldenrod,
            Color.Gray,
            Color.Green,
            Color.GreenYellow,
            Color.Honeydew,
            Color.HotPink,
            Color.IndianRed,
            Color.Indigo,
            Color.Ivory,
            Color.Khaki,
            Color.Lavender,
            Color.LavenderBlush,
            Color.LawnGreen,
            Color.LemonChiffon,
            Color.LightBlue,
            Color.LightCoral,
            Color.LightCyan,
            Color.LightGoldenrodYellow,
            Color.LightGray,
            Color.LightGreen,
            Color.LightPink,
            Color.LightSalmon,
            Color.LightSeaGreen,
            Color.LightSkyBlue,
            Color.LightSlateGray,
            Color.LightSteelBlue,
            Color.LightYellow,
            Color.Lime,
            Color.LimeGreen,
            Color.Linen,
            Color.Magenta,
            Color.Maroon,
            Color.MediumAquamarine,
            Color.MediumBlue,
            Color.MediumOrchid,
            Color.MediumPurple,
            Color.MediumSeaGreen,
            Color.MediumSlateBlue,
            Color.MediumSpringGreen,
            Color.MediumTurquoise,
            Color.MediumVioletRed,
            Color.MidnightBlue,
            Color.MintCream,
            Color.MistyRose,
            Color.Moccasin,
            Color.NavajoWhite,
            Color.Navy,
            Color.OldLace,
            Color.Olive,
            Color.OliveDrab,
            Color.Orange,
            Color.OrangeRed,
            Color.Orchid,
            Color.PaleGoldenrod,
            Color.PaleGreen,
            Color.PaleTurquoise,
            Color.PaleVioletRed,
            Color.PapayaWhip,
            Color.PeachPuff,
            Color.Peru,
            Color.Pink,
            Color.Plum,
            Color.PowderBlue,
            Color.Purple,
            Color.Red,
            Color.RosyBrown,
            Color.RoyalBlue,
            Color.SaddleBrown,
            Color.Salmon,
            Color.SandyBrown,
            Color.SeaGreen,
            Color.SeaShell,
            Color.Sienna,
            Color.Silver,
            Color.SkyBlue,
            Color.SlateBlue,
            Color.SlateGray,
            Color.Snow,
            Color.SpringGreen,
            Color.SteelBlue,
            Color.Tan,
            Color.Teal,
            Color.Thistle,
            Color.Tomato,
            Color.Turquoise,
            Color.Violet,
            Color.Wheat,
            Color.White,
            Color.WhiteSmoke,
            Color.Yellow,
            Color.YellowGreen
};
        CoreType m_coreType;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "pbPSCBSLauncherGenerator v" + Assembly.GetExecutingAssembly().GetName().Version;
            m_coreType = CoreType.RetroArchType;
            List<ClQuickSettings> lsqs = new List<ClQuickSettings>();
            pbImgForFolder.AllowDrop = true;

            nudFolderIdForFolder.Value = (decimal)(Properties.Settings.Default.iFolderIdForFolder);
            nudParentIdForFolder.Value = (decimal)(Properties.Settings.Default.iParentIdForFolder);
            nudYearForFolder.Value = (decimal)(Properties.Settings.Default.iYearForFolder);
            tbDBFileForFolder.Text = Properties.Settings.Default.sDbFileForFolder.Trim();
            tbNameForFolder.Text = Properties.Settings.Default.sNameForFolder.Trim();
            tbPublisherForFolder.Text = Properties.Settings.Default.sPublisherForFolder.Trim();
            tbRomsDir.Text = Properties.Settings.Default.sRomFolder.Trim();

            try
            {
                using (XmlTextReader xmlreader = new XmlTextReader(Application.StartupPath + "\\" + "retroarch_params.xml"))
                {
                    String mycore = String.Empty;
                    String myextension = String.Empty;
                    String mygamelistfolder = String.Empty;
                    int mytargetfolderid = -1;
                    String myname = String.Empty;
                    while (xmlreader.Read())
                    {
                        switch (xmlreader.NodeType)
                        {
                            case XmlNodeType.Element:
                                // Console.WriteLine(xmlreader.Name);
                                if ("config" == xmlreader.Name)
                                {
                                    while (xmlreader.MoveToNextAttribute())
                                    {
                                        // Console.Write(" " + xmlreader.Name + "='" + xmlreader.Value + "'");
                                        if ("core" == xmlreader.Name)
                                        {
                                            mycore = xmlreader.Value;
                                        }
                                        else if ("extension" == xmlreader.Name)
                                        {
                                            myextension = xmlreader.Value;
                                        }
                                        else if ("gamelistfolder" == xmlreader.Name)
                                        {
                                            mygamelistfolder = xmlreader.Value;
                                        }
                                        else if ("targetfolderid" == xmlreader.Name)
                                        {
                                            try
                                            {
                                                mytargetfolderid = int.Parse(xmlreader.Value);
                                            }
                                            catch(Exception ex)
                                            {
                                                mytargetfolderid = -1;
                                            }
                                            
                                        }
                                    }
                                }
                                break;
                            case XmlNodeType.Text:
                                // Console.WriteLine(xmlreader.Value);
                                myname = xmlreader.Value;
                                //dcPs1Games.Add(mykey, new ClPS1Game(myvalue, mykey, mylink, mylang));
                                lsqs.Add(new ClQuickSettings(myname, mycore, myextension, mygamelistfolder, mytargetfolderid));
                                mycore = String.Empty;
                                myextension = String.Empty;
                                mygamelistfolder = String.Empty;
                                mytargetfolderid = -1;
                                myname = String.Empty;
                                break;
                            case XmlNodeType.EndElement:
                                //
                                break;
                        }
                    }
                    //slLogger.Debug("Found games in xml for search function: " + dcPs1Games.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                //slLogger.Fatal(ex.Message);
            }
            cbQuickSettings.Items.Clear();
            if(lsqs.Count > 0)
            {
                foreach(ClQuickSettings clqs in lsqs)
                {
                    cbQuickSettings.Items.Add(clqs);
                }
                cbQuickSettings.SelectedIndex = 0;
            }

            generateDriveList("");
        }

        private void generateDriveList(String sSelected)
        {
            int iSelected = -1;
            String[] sDrives = Directory.GetLogicalDrives();
            cbDriveList.Items.Clear();
            if (sDrives.Length > 0)
            {
                int iIndex = 0;
                foreach (String s in sDrives)
                {
                    DriveInfo di = new DriveInfo(s);
                    if (di.DriveType == DriveType.Removable)
                    {
                        String sCompleteDrive = di.ToString();
                        // di.VolumeLabel + " (" + s + ") " + ClPbHelper.FormatBytes(di.AvailableFreeSpace) + " free/" + ClPbHelper.FormatBytes(di.TotalSize);
                        cbDriveList.Items.Add(di);
                        if(s == sSelected)
                        {
                            iSelected = iIndex;
                        }
                        iIndex++;
                    }
                }
                if ((iSelected > -1) && (iSelected < cbDriveList.Items.Count))
                {
                    cbDriveList.SelectedIndex = iSelected;
                }
                else
                {
                    cbDriveList.SelectedIndex = 0;
                }
            }
        }
        
        private void btScanRoms_Click(object sender, EventArgs e)
        {
            if (cbDriveList.SelectedIndex > -1)
            {
                String sDir = tbRomsDir.Text;
                String sDirLauncher = tbLauncherDir.Text;
                String sGlFolder = String.Empty;
                if ((Directory.Exists(sDir)) && (Directory.Exists(sDirLauncher)))
                {
                    FileInfo[] inDirfileList = new DirectoryInfo(sDir).GetFiles("*" + tbExtension.Text.Trim(), SearchOption.AllDirectories);
                    int index = 0;

                    List<String> lsGames = new List<string>();
                    List<ClAnyGame> lsGamesInfo = new List<ClAnyGame>();
                    try
                    {
                        String sFileGamelist;
                        sGlFolder = tbGlFolder.Text.Replace("/", "\\");
                        if(sGlFolder.EndsWith("\\"))
                        {
                            sGlFolder = sGlFolder.Substring(0, sGlFolder.LastIndexOf("\\"));
                        }
                        if (sGlFolder.StartsWith(".\\"))
                        {
                            sFileGamelist = Application.StartupPath + sGlFolder.Substring(1) + "\\" + "gamelist.xml";
                        }
                        else
                        {
                            sFileGamelist = sGlFolder + "\\" + "gamelist.xml";
                        }
                        if (File.Exists(sFileGamelist))
                        {
                            using (XmlTextReader xmlreader = new XmlTextReader(sFileGamelist))
                            {
                                String myName = String.Empty;
                                String myDate = "1602";
                                String myPublisher = String.Empty;
                                String myImage = String.Empty;
                                bool bReadName = false;
                                bool bReadDate = false;
                                bool bReadPublisher = false;
                                bool bReadImage = false;
                                int iParamsFound = 0;
                                while (xmlreader.Read())
                                {
                                    switch (xmlreader.NodeType)
                                    {
                                        case XmlNodeType.Element:
                                            if ("name" == xmlreader.Name)
                                            {
                                                if (myName != String.Empty)
                                                {
                                                    iParamsFound = 0;
                                                    lsGames.Add(myName);
                                                    lsGamesInfo.Add(new ClAnyGame(myName, myDate, myImage, myPublisher));
                                                    myName = String.Empty;
                                                    myDate = "1602";
                                                    myPublisher = String.Empty;
                                                    myImage = String.Empty;
                                                }
                                                bReadName = true;
                                            }
                                            if ("releasedate" == xmlreader.Name)
                                            {
                                                if (myDate != "1602")
                                                {
                                                    iParamsFound = 0;
                                                    lsGames.Add(myName);
                                                    lsGamesInfo.Add(new ClAnyGame(myName, myDate, myImage, myPublisher));
                                                    myName = String.Empty;
                                                    myDate = "1602";
                                                    myPublisher = String.Empty;
                                                    myImage = String.Empty;
                                                }
                                                bReadDate = true;
                                            }
                                            if ("publisher" == xmlreader.Name)
                                            {
                                                if (myPublisher != String.Empty)
                                                {
                                                    iParamsFound = 0;
                                                    lsGames.Add(myName);
                                                    lsGamesInfo.Add(new ClAnyGame(myName, myDate, myImage, myPublisher));
                                                    myName = String.Empty;
                                                    myDate = "1602";
                                                    myPublisher = String.Empty;
                                                    myImage = String.Empty;
                                                }
                                                bReadPublisher = true;
                                            }
                                            if ("image" == xmlreader.Name)
                                            {
                                                if (myImage != String.Empty)
                                                {
                                                    iParamsFound = 0;
                                                    lsGames.Add(myName);
                                                    lsGamesInfo.Add(new ClAnyGame(myName, myDate, myImage, myPublisher));
                                                    myName = String.Empty;
                                                    myDate = "1602";
                                                    myPublisher = String.Empty;
                                                    myImage = String.Empty;
                                                }
                                                bReadImage = true;
                                            }
                                            break;
                                        case XmlNodeType.Text:
                                            // Console.WriteLine(xmlreader.Value);
                                            if (bReadName)
                                            {
                                                myName = xmlreader.Value.Trim();
                                                bReadName = false;
                                                iParamsFound++;
                                            }
                                            if (bReadDate)
                                            {
                                                myDate = xmlreader.Value.Trim();
                                                bReadDate = false;
                                                iParamsFound++;
                                            }
                                            if (bReadPublisher)
                                            {
                                                myPublisher = xmlreader.Value.Trim();
                                                bReadPublisher = false;
                                                iParamsFound++;
                                            }
                                            if (bReadImage)
                                            {
                                                myImage = xmlreader.Value.Trim();
                                                bReadImage = false;
                                                iParamsFound++;
                                            }
                                            if (4 == iParamsFound)
                                            {
                                                iParamsFound = 0;
                                                lsGames.Add(myName);
                                                lsGamesInfo.Add(new ClAnyGame(myName, myDate, myImage, myPublisher));
                                                myName = String.Empty;
                                                myDate = "1602";
                                                myPublisher = String.Empty;
                                                myImage = String.Empty;
                                            }
                                            break;
                                        case XmlNodeType.EndElement:
                                            //
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                    int romfound = 0;
                    int romnotfound = 0;
                    String sList = String.Empty;

                    DriveInfo di = (DriveInfo)cbDriveList.SelectedItem;
                    String sRootDir = di.Name;

                    foreach (FileInfo fi in inDirfileList)
                    {
                        if (fi.Extension == tbExtension.Text.Trim())
                        {
                            int iN = 1;
                            int len = fi.Name.LastIndexOf(fi.Extension);
                            if (fi.Name.IndexOf("(") > -1)
                            {
                                len = fi.Name.IndexOf("(");
                            }
                            if ((fi.Name.IndexOf("[") > -1) && (fi.Name.IndexOf("[") < len))
                            {
                                len = fi.Name.IndexOf("[");
                            }
                            String sNameFull = fi.Name.Substring(0, len).Replace("_", " ");
                            if (sNameFull.Length > 1)
                            {
                                sNameFull = sNameFull.Substring(0, 1).ToUpper() + sNameFull.Substring(1);
                            }
                            sNameFull = sNameFull.Trim();
                            String sName = Regex.Replace(sNameFull, @"[^0-9a-zA-Z ]+", "");
                            sName = Regex.Replace(sName, @" +", " ");
                            sName = sName.Trim();
                            String sNewDir = tbTag.Text + "_" + sName;
                            if (Directory.Exists(sDirLauncher + "\\" + sNewDir))
                            {
                                while (Directory.Exists(sDirLauncher + "\\" + sNewDir + "_" + iN.ToString()))
                                {
                                    iN++;
                                }
                                sNewDir = sDirLauncher + "\\" + sNewDir + "_" + iN.ToString();
                            }
                            else
                            {
                                sNewDir = sDirLauncher + "\\" + sNewDir;
                            }
                            bool bDefImage = false;
                            int toto = -1;
                            int indexlist = 0;
                            List<ClPaireIndexString> lsPairIndexName = new List<ClPaireIndexString>();
                            foreach (String s in lsGames)
                            {
                                toto = s.ToLower().IndexOf(sNameFull.ToLower());
                                if (toto > -1)
                                {
                                    lsPairIndexName.Add(new ClPaireIndexString(s, indexlist));
                                }
                                indexlist++;
                            }
                            if (lsPairIndexName.Count > 0)
                            {
                                toto = 0;
                                indexlist = lsPairIndexName[0].Index; // the first in the list (may be false)
                                if (lsPairIndexName.Count > 1)
                                {
                                    // here make a choice
                                    foreach (ClPaireIndexString cpis in lsPairIndexName)
                                    {
                                        //tbLog.AppendText(cpis.Name + " for " + sNameFull + Environment.NewLine);
                                        String sNewName = cpis.Name;
                                        int iLen = -1;
                                        if (sNewName.IndexOf("(") > -1)
                                        {
                                            iLen = fi.Name.IndexOf("(");
                                        }
                                        if ((sNewName.IndexOf("[") > -1) && (sNewName.IndexOf("[") < iLen))
                                        {
                                            iLen = sNewName.IndexOf("[");
                                        }
                                        if (iLen > -1)
                                        {
                                            sNewName = sNewName.Substring(0, iLen);
                                        }
                                        if (sNewName == sNameFull)
                                        {
                                            indexlist = cpis.Index;
                                            // instead of the first, pick the first found with the same name, which is supposedly more accurate
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // nothing found, search again
                                int toto2 = -1;
                                String sNameFullModded = Regex.Replace(sNameFull, @"[^0-9a-zA-Z ]+", " ");
                                sNameFullModded = Regex.Replace(sNameFullModded, @" +", " ").Trim();
                                String[] saTokensName = sNameFullModded.Split(' ');
                                Dictionary<String, int> dcMatchingNumber = new Dictionary<String, int>();
                                int iMaxMatch = 0;
                                foreach (String s in saTokensName)
                                {
                                    String sTrimmed = s.Trim();
                                    if (sTrimmed.Length > 0)
                                    {
                                        if (sTrimmed.Length == 1)
                                        {
                                            if (sNameFullModded.StartsWith(s + " "))
                                            {
                                                sTrimmed = sTrimmed + " ";
                                            }
                                            else
                                            if (sNameFullModded.EndsWith(" " + s))
                                            {
                                                sTrimmed = " " + sTrimmed;
                                            }
                                        }
                                        foreach (String ss in lsGames)
                                        {
                                            toto2 = ss.ToLower().IndexOf(sTrimmed.ToLower());
                                            if (toto2 > -1)
                                            {
                                                if (!dcMatchingNumber.ContainsKey(ss))
                                                {
                                                    dcMatchingNumber.Add(ss, 1);
                                                    if (iMaxMatch < 1)
                                                    {
                                                        iMaxMatch = 1;
                                                    }
                                                }
                                                else
                                                {
                                                    dcMatchingNumber[ss]++;
                                                    if (iMaxMatch < dcMatchingNumber[ss])
                                                    {
                                                        iMaxMatch = dcMatchingNumber[ss];
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                List<String> lsMatch = new List<string>();
                                if (iMaxMatch > 1)
                                {
                                    if (saTokensName.Length == iMaxMatch)
                                    {
                                        // matching
                                        foreach (KeyValuePair<String, int> pair in dcMatchingNumber)
                                        {
                                            if (pair.Value == iMaxMatch)
                                            {
                                                lsMatch.Add(pair.Key);
                                            }
                                        }
                                        indexlist = 0;
                                        foreach (String s in lsGames)
                                        {
                                            toto = lsMatch.IndexOf(s);
                                            if (toto > -1)
                                            {
                                                lsPairIndexName.Add(new ClPaireIndexString(s, indexlist));
                                            }
                                            indexlist++;
                                        }
                                        if (lsPairIndexName.Count > 0)
                                        {
                                            toto = 0;
                                            indexlist = lsPairIndexName[0].Index; // the first in the list (may be false)
                                        }
                                    }
                                    else
                                    {
                                        // matching
                                        foreach (KeyValuePair<String, int> pair in dcMatchingNumber)
                                        {
                                            if (pair.Value == iMaxMatch)
                                            {
                                                lsMatch.Add(pair.Key);
                                            }
                                        }
                                        indexlist = 0;
                                        foreach (String s in lsGames)
                                        {
                                            toto = lsMatch.IndexOf(s);
                                            if (toto > -1)
                                            {
                                                lsPairIndexName.Add(new ClPaireIndexString(s, indexlist));
                                            }
                                            indexlist++;
                                        }
                                        if (lsPairIndexName.Count > 0)
                                        {
                                            toto = 0;
                                            indexlist = lsPairIndexName[0].Index; // the first in the list (may be false)
                                        }
                                    }
                                }
                            }
                            if (toto > -1)
                            {
                                //tbLog.AppendText(lsGames[indexlist] + " for " + sNameFull + Environment.NewLine);
                                romfound++;
                            }
                            else
                            {
                                tbLog.AppendText("---------------not found for " + sNameFull + Environment.NewLine);
                                romnotfound++;
                            }
                            Directory.CreateDirectory(sNewDir);
                            // retroarch launch
                            switch(m_coreType)
                            {
                                case CoreType.DrasticType:
                                    // drastic launch
                                    using (StreamWriter sw = new StreamWriter(sNewDir + "\\" + "launch.sh"))
                                    {
                                        sw.Write("#!/bin/sh" + "\n");
                                        sw.Write("source \"/var/volatile/bleemsync.cfg\"" + "\n");
                                        sw.Write("source \"/var/volatile/launchtmp/launcher.cfg\"" + "\n");
                                        sw.Write("cd \"/media/bleemsync/etc/bleemsync/SUP/launchers/psc_drastic\"" + "\n");
                                        sw.Write("chmod + x \"drastic\"" + "\n");
                                        sw.Write("echo \"launch_StockUI\" > \"/tmp/launchfilecommand\"" + "\n");
                                        sw.Write("LD_PRELOAD=./drastic_sdl_remap.so ./drastic \"$pb_rom\" > $runtime_log_path/drastic.log 2>&1" + "\n");
                                    }
                                    break;
                                default: // case CoreType.RetroArchType:
                                    using (StreamWriter sw = new StreamWriter(sNewDir + "\\" + "launch.sh"))
                                    {
                                        sw.Write("#!/bin/sh" + "\n");
                                        sw.Write("echo \"launch_retroarch_directload\" > \"/tmp/launchfilecommand\"" + "\n");
                                    }
                                    break;
                            }
                            using (StreamWriter sw = new StreamWriter(sNewDir + "\\" + "launcher.cfg"))
                            {
                                sw.Write("launcher_filename=\"" + sName + "\"" + "\n");
                                String sRename = sName;
                                if (toto > -1)
                                {
                                    sRename = lsGamesInfo[indexlist].Title;
                                    int iLen = -1;
                                    if (sRename.IndexOf("(") > -1)
                                    {
                                        iLen = sRename.IndexOf("(");
                                    }
                                    if ((sRename.IndexOf("[") > -1) && (sRename.IndexOf("[") < iLen))
                                    {
                                        iLen = sRename.IndexOf("[");
                                    }
                                    if (iLen > -1)
                                    {
                                        sRename = sRename.Substring(0, iLen);
                                    }
                                }
                                sw.Write("launcher_title=\"" + sRename + "\"" + "\n");
                                if (toto > -1)
                                {
                                    sw.Write("launcher_publisher=\"" + lsGamesInfo[indexlist].Publisher + "\"" + "\n");
                                    sw.Write("launcher_year=\"" + lsGamesInfo[indexlist].Date.Substring(0, 4) + "\"" + "\n");
                                }
                                else
                                {
                                    sw.Write("launcher_publisher=\"TODO\"" + "\n");
                                    sw.Write("launcher_year=\"1990\"" + "\n");
                                }
                                if (m_coreType == CoreType.RetroArchType)
                                {
                                    sw.Write("pb_core=\"/media/" + tbCoreDir.Text.Substring(sRootDir.Length).Replace("\\", "/") + "\"" + "\n");
                                }
                                sw.Write("pb_rom=\"/media/" + fi.FullName.Substring(sRootDir.Length).Replace("\\", "/") + "\"" + "\n");
                                sw.Write("pb_parentfolder=\"" + nudParentFolderIdForScan.Value.ToString() + "\"" + "\n");
                            }
                            if (toto > -1)
                            {
                                if (File.Exists(sGlFolder + lsGamesInfo[indexlist].Image))
                                {
                                    using (Bitmap bm = new Bitmap(sGlFolder + "\\" + lsGamesInfo[indexlist].Image))
                                    {
                                        int width = 226;
                                        int height = 226;
                                        int orig_width = bm.Width;
                                        int orig_height = bm.Height;
                                        float orig_ratio = 0;
                                        Bitmap bm1;
                                        if (orig_height != 0)
                                        {
                                            orig_ratio = (float)(orig_width) / (float)(orig_height);
                                        }
                                        else
                                        {
                                            orig_ratio = 0;
                                        }
                                        if ((orig_ratio != 0) && (height != 0) && (orig_ratio != (width / height)))
                                        {
                                            float current_ratio = (float)(width) / (float)(height);
                                            int width1 = (int)(height * orig_ratio);
                                            int height1 = (int)(width / orig_ratio);
                                            Bitmap bm0;
                                            bm1 = new Bitmap(width, height);
                                            Graphics gp = Graphics.FromImage(bm1);
                                            gp.Clear(Color.Transparent);
                                            int x = 0;
                                            int y = 0;
                                            if (width1 < width)
                                            {
                                                bm0 = new Bitmap(ClPbHelper.ResizeImage(bm, width1, height));
                                                x = ((width - width1) / 2);
                                            }
                                            else
                                            {
                                                bm0 = new Bitmap(ClPbHelper.ResizeImage(bm, width, height1));
                                                y = ((height - height1) / 2);
                                            }
                                            gp.DrawImage(bm0, x, y);
                                        }
                                        else
                                        {
                                            bm1 = new Bitmap(ClPbHelper.ResizeImage(bm, width, height));
                                        }
                                        bm1.Save(sNewDir + "\\" + sName + ".png", ImageFormat.Png);
                                        sList += " \"" + sNewDir + "\\" + sName + ".png" + "\"";
                                    }
                                }
                                else
                                {
                                    bDefImage = true;
                                }
                            }
                            else
                            {
                                bDefImage = true;
                            }
                            if (bDefImage)
                            {
                                using (Bitmap bm = new Bitmap(226, 226))
                                {
                                    Graphics gp = Graphics.FromImage(bm);
                                    gp.Clear(knownColors[index]);
                                    index = (index + 1) % knownColors.Length;
                                    bm.Save(sNewDir + "\\" + sName + ".png", ImageFormat.Png);
                                    sList += " \"" + sNewDir + "\\" + sName + ".png" + "\"";
                                }
                            }
                        }
                    }
                    tbLog.AppendText("found: " + romfound.ToString() + ", notfound: " + romnotfound.ToString() + Environment.NewLine);
                    if (sList != String.Empty)
                    {
                        MyProcessHelper pPngQuant = new MyProcessHelper(Application.StartupPath + "\\pngquant\\pngquant.exe", sList + " --force --ext .png --verbose");
                        pPngQuant.DoIt();
                    }
                }
            }
        }

        private void btRefreshDriveList_Click(object sender, EventArgs e)
        {
            generateDriveList(cbDriveList.GetItemText(cbDriveList.SelectedItem));
        }

        private void cbDriveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDriveList.SelectedIndex > -1)
            {
                DriveInfo di = (DriveInfo)cbDriveList.SelectedItem;
                lbDriveInfo.Text = di.VolumeLabel + " (" + di.Name + ") " + ClPbHelper.FormatBytes(di.AvailableFreeSpace) + " free / " + ClPbHelper.FormatBytes(di.TotalSize);

                String sPathLauncher = di.Name + "bleemsync\\etc\\bleemsync\\SUP\\launchers";
                tbLauncherDir.Text = sPathLauncher;
                if(Directory.Exists(sPathLauncher))
                {
                    lbLauncherDirNotFound.Visible = false;
                    btExploreLauncherFolder.Enabled = true;
                    btCreateFolder.Enabled = true;
                }
                else
                {
                    lbLauncherDirNotFound.Visible = true;
                    btExploreLauncherFolder.Enabled = false;
                    btCreateFolder.Enabled = false;
                }
                String sPathCore = di.Name + "bleemsync\\opt\\retroarch\\.config\\retroarch\\cores";
                tbCoreDir.Text = sPathCore;
                if (Directory.Exists(sPathCore))
                {
                    lbCoreDirNotFound.Visible = false;
                    btExploreCoreFolder.Enabled = true;
                }
                else
                {
                    lbCoreDirNotFound.Visible = true;
                    btExploreCoreFolder.Enabled = false;
                }

                String sRomPath = String.Empty;
                if((!String.IsNullOrEmpty(tbRomsDir.Text.Trim())) && (1 == tbRomsDir.Text.Trim().IndexOf(":\\")))
                {
                    sRomPath = di.Name + tbRomsDir.Text.Trim().Substring(3);
                }
                else
                {
                    sRomPath = di.Name;
                }
                tbRomsDir.Text = sRomPath;
                if (Directory.Exists(sRomPath))
                {
                    lbRomsDirNotFound.Visible = false;
                    btExploreRomFolder.Enabled = true;
                }
                else
                {
                    lbRomsDirNotFound.Visible = true;
                    btExploreRomFolder.Enabled = false;
                }
            }
            else
            {
                lbDriveInfo.Text = "---";
                tbLauncherDir.Text = "";
                tbCoreDir.Text = "";
            }
        }

        private void btExploreLauncherFolder_Click(object sender, EventArgs e)
        {
            if (cbDriveList.SelectedIndex > -1)
            {
                String sPath = tbLauncherDir.Text;
                if (Directory.Exists(sPath))
                {
                    try
                    {
                        MyProcessHelper explo = new MyProcessHelper("explorer.exe", sPath);
                        explo.DoIt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btExploreCoreFolder_Click(object sender, EventArgs e)
        {
            if (cbDriveList.SelectedIndex > -1)
            {
                String sPath = tbCoreDir.Text;
                if (Directory.Exists(sPath))
                {
                    try
                    {
                        MyProcessHelper explo = new MyProcessHelper("explorer.exe", sPath);
                        explo.DoIt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btExploreRomFolder_Click(object sender, EventArgs e)
        {
            if (cbDriveList.SelectedIndex > -1)
            {
                String sPath = tbRomsDir.Text;
                if (Directory.Exists(sPath))
                {
                    try
                    {
                        MyProcessHelper explo = new MyProcessHelper("explorer.exe", sPath);
                        explo.DoIt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbQuickSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuickSettings.SelectedIndex > -1)
            {
                ClQuickSettings clqs = (ClQuickSettings)(cbQuickSettings.SelectedItem);
                tbTag.Text = clqs.Name;
                if (clqs.Core.ToLower() == "drastic")
                {
                    tbCoreFile.Text = "";
                    tbCoreFile.Enabled = false;
                    m_coreType = CoreType.DrasticType;
                }
                else
                {
                    tbCoreFile.Text = clqs.Core;
                    tbCoreFile.Enabled = true;
                    m_coreType = CoreType.RetroArchType;
                }
                tbExtension.Text = clqs.Extension;
                tbGlFolder.Text = clqs.Gamelistfolder;
                nudParentFolderIdForScan.Value = (decimal)(clqs.Targetfolderid);
            }
        }

        private void btCreateFolder_Click(object sender, EventArgs e)
        {
            if (cbDriveList.SelectedIndex > -1)
            {
                String sDirLauncher = tbLauncherDir.Text;
                if (Directory.Exists(sDirLauncher))
                {
                    String sTitle = tbNameForFolder.Text.Trim();
                    if(String.IsNullOrEmpty(sTitle))
                    {
                        sTitle = "default";
                    }
                    String sName = Regex.Replace(sTitle, @"[^0-9a-zA-Z ]+", "");
                    sName = Regex.Replace(sName, @" +", " ");
                    sName = sName.Trim();
                    String sNewDir = "folder_" + sName;
                    int iN = 1;
                    if (Directory.Exists(sDirLauncher + "\\" + sNewDir))
                    {
                        while (Directory.Exists(sDirLauncher + "\\" + sNewDir + "_" + iN.ToString()))
                        {
                            iN++;
                        }
                        sNewDir = sDirLauncher + "\\" + sNewDir + "_" + iN.ToString();
                    }
                    else
                    {
                        sNewDir = sDirLauncher + "\\" + sNewDir;
                    }
                    String sPublisher = tbPublisherForFolder.Text.Trim();
                    int iYear = (int)(nudYearForFolder.Value);
                    String sDbFile = tbDBFileForFolder.Text.Trim();
                    if (String.IsNullOrEmpty(sDbFile))
                    {
                        sDbFile = "regional.db";
                    }
                    int iParentId = (int)(nudParentIdForFolder.Value);
                    int iFolderId = (int)(nudFolderIdForFolder.Value);

                    Directory.CreateDirectory(sNewDir);
                    using (StreamWriter sw = new StreamWriter(sNewDir + "\\" + "launch.sh"))
                    {
                        sw.Write("#!/bin/sh" + "\n");
                        sw.Write("source \"/var/volatile/launchtmp/launcher.cfg\"" + "\n");
                        sw.Write("echo - e \"pb_currentdbfile =\\\"$pb_dbfile\\\"\\npb_currentidfolder=$pb_idfolder\" > \"/var/volatile/pb_folder.flag\"" + "\n");
                    }
                    using (StreamWriter sw = new StreamWriter(sNewDir + "\\" + "launcher.cfg"))
                    {
                        sw.Write("launcher_filename=\"" + sName + "\"" + "\n");
                        sw.Write("launcher_title=\"" + sTitle + "\"" + "\n");
                        sw.Write("launcher_publisher=\"" + sPublisher + "\"" + "\n");
                        sw.Write("launcher_year=\"" + iYear.ToString() + "\"" + "\n");
                        sw.Write("launcher_sort=\"" + "no" + "\"" + "\n"); // add option maybe TODO ?
                        sw.Write("pb_dbfile=\"" + sDbFile + "\"" + "\n");
                        sw.Write("pb_idfolder=\"" + iFolderId.ToString() + "\"" + "\n");
                        sw.Write("pb_parentfolder=\"" + iParentId.ToString() + "\"" + "\n");
                    }
                    if(null == pbImgForFolder.Image)
                    {
                        Random rand = new Random();
                        int index = rand.Next(knownColors.Length);
                        using (Bitmap bm = new Bitmap(226, 226))
                        {
                            Graphics gp = Graphics.FromImage(bm);
                            gp.Clear(knownColors[index]);
                            bm.Save(sNewDir + "\\" + sName + ".png", ImageFormat.Png);
                            String sParam = " \"" + sNewDir + "\\" + sName + ".png" + "\"";
                            MyProcessHelper pPngQuant = new MyProcessHelper(Application.StartupPath + "\\pngquant\\pngquant.exe", sParam + " --force --ext .png --verbose");
                            pPngQuant.DoIt();
                        }
                    }
                    else
                    {
                        String sImgName = sNewDir + "\\" + sName + ".png";
                        pbImgForFolder.Image.Save(sImgName, ImageFormat.Png);
                        String sParam = " \"" + sImgName + "\"";
                        MyProcessHelper pPngQuant = new MyProcessHelper(Application.StartupPath + "\\pngquant\\pngquant.exe", sParam + " --force --ext .png --verbose");
                        pPngQuant.DoIt();
                    }
                }
            }
        }

        private void pbImgForFolder_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                String[] sFileList = (String[])e.Data.GetData(DataFormats.FileDrop, false);
                if (sFileList.Length == 1)
                {
                    String sExt = Path.GetExtension(sFileList[0]).ToLower();
                    List<String> lsAcceptedExt = new List<string>() { ".png", ".jpg", ".jpeg", ".bmp" };
                    if (lsAcceptedExt.IndexOf(sExt) > -1)
                    {
                        using (Bitmap bmPicture = new Bitmap(sFileList[0]))
                        {
                            pbImgForFolder.Image = ClPbHelper.ResizeImage((Image)(new Bitmap(bmPicture)), 226, 226);
                        }
                    }
                    else
                    {
                        // MessageBox.Show("Extension " + sExt + " not accepted. Dragdrop a file with extension png, bmp, jpg or jpeg.");
                    }
                }
                else
                {
                    MessageBox.Show("Only one file for drag&drop operation please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbImgForFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pbImgForFolder_Click(object sender, EventArgs e)
        {
            // Click -> open browser
            // shift-click -> clear
        }

        private void tbRomsDir_Leave(object sender, EventArgs e)
        {
            tbRomsDir.Text = tbRomsDir.Text.Trim();
            if (Directory.Exists(tbRomsDir.Text))
            {
                lbRomsDirNotFound.Visible = false;
                btExploreRomFolder.Enabled = true;
                btScanRoms.Enabled = true;
            }
            else
            {
                lbRomsDirNotFound.Visible = true;
                btExploreRomFolder.Enabled = false;
                btScanRoms.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.iFolderIdForFolder = (int)(nudFolderIdForFolder.Value);
            Properties.Settings.Default.iParentIdForFolder = (int)(nudParentIdForFolder.Value);
            Properties.Settings.Default.iYearForFolder = (int)(nudYearForFolder.Value);
            Properties.Settings.Default.sDbFileForFolder = tbDBFileForFolder.Text.Trim();
            Properties.Settings.Default.sNameForFolder = tbNameForFolder.Text.Trim();
            Properties.Settings.Default.sPublisherForFolder = tbPublisherForFolder.Text.Trim();
            Properties.Settings.Default.sRomFolder = tbRomsDir.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void pbImgForFolder_DoubleClick(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if(DialogResult.Yes == MessageBox.Show("Are you sure you want to clear the picture ?", "Clear picture", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    pbImgForFolder.Image = null;
                }
            }
            else
            if (DialogResult.OK == ofdLoadImg.ShowDialog())
            {
                String sFileName = ofdLoadImg.FileName;
                try
                {
                    using (Bitmap bmPicture = new Bitmap(sFileName))
                    {
                        pbImgForFolder.Image = ClPbHelper.ResizeImage((Image)(new Bitmap(bmPicture)), 226, 226);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}