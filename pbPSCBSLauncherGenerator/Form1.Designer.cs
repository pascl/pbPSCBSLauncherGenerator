namespace pbPSCBSLauncherGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLauncherDir = new System.Windows.Forms.TextBox();
            this.tbRomsDir = new System.Windows.Forms.TextBox();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.tbCoreDir = new System.Windows.Forms.TextBox();
            this.nudParentFolderIdForScan = new System.Windows.Forms.NumericUpDown();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.cbDriveList = new System.Windows.Forms.ComboBox();
            this.gbDrive = new System.Windows.Forms.GroupBox();
            this.lbDriveInfo = new System.Windows.Forms.Label();
            this.btRefreshDriveList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCoreDirNotFound = new System.Windows.Forms.Label();
            this.lbLauncherDirNotFound = new System.Windows.Forms.Label();
            this.btExploreCoreFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExploreLauncherFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGlFolder = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbCoreFile = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbRomsDirNotFound = new System.Windows.Forms.Label();
            this.btScanRoms = new System.Windows.Forms.Button();
            this.btExploreRomFolder = new System.Windows.Forms.Button();
            this.cbQuickSettings = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbImgForFolder = new System.Windows.Forms.PictureBox();
            this.tbNameForFolder = new System.Windows.Forms.TextBox();
            this.tbPublisherForFolder = new System.Windows.Forms.TextBox();
            this.nudYearForFolder = new System.Windows.Forms.NumericUpDown();
            this.tbDBFileForFolder = new System.Windows.Forms.TextBox();
            this.nudParentIdForFolder = new System.Windows.Forms.NumericUpDown();
            this.nudFolderIdForFolder = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCreateFolder = new System.Windows.Forms.Button();
            this.ofdLoadImg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentFolderIdForScan)).BeginInit();
            this.gbDrive.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgForFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearForFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentIdForFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFolderIdForFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLauncherDir
            // 
            this.tbLauncherDir.Enabled = false;
            this.tbLauncherDir.Location = new System.Drawing.Point(9, 45);
            this.tbLauncherDir.Name = "tbLauncherDir";
            this.tbLauncherDir.Size = new System.Drawing.Size(323, 20);
            this.tbLauncherDir.TabIndex = 0;
            // 
            // tbRomsDir
            // 
            this.tbRomsDir.Location = new System.Drawing.Point(9, 33);
            this.tbRomsDir.Name = "tbRomsDir";
            this.tbRomsDir.Size = new System.Drawing.Size(323, 20);
            this.tbRomsDir.TabIndex = 1;
            this.tbRomsDir.Leave += new System.EventHandler(this.tbRomsDir_Leave);
            // 
            // tbExtension
            // 
            this.tbExtension.Location = new System.Drawing.Point(102, 66);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(188, 20);
            this.tbExtension.TabIndex = 5;
            this.tbExtension.Text = ".nes";
            // 
            // tbCoreDir
            // 
            this.tbCoreDir.Enabled = false;
            this.tbCoreDir.Location = new System.Drawing.Point(9, 104);
            this.tbCoreDir.Name = "tbCoreDir";
            this.tbCoreDir.Size = new System.Drawing.Size(323, 20);
            this.tbCoreDir.TabIndex = 6;
            // 
            // nudParentFolderIdForScan
            // 
            this.nudParentFolderIdForScan.Location = new System.Drawing.Point(102, 118);
            this.nudParentFolderIdForScan.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudParentFolderIdForScan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudParentFolderIdForScan.Name = "nudParentFolderIdForScan";
            this.nudParentFolderIdForScan.Size = new System.Drawing.Size(188, 20);
            this.nudParentFolderIdForScan.TabIndex = 7;
            this.nudParentFolderIdForScan.Value = new decimal(new int[] {
            116,
            0,
            0,
            0});
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(341, 305);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(419, 151);
            this.tbLog.TabIndex = 8;
            // 
            // cbDriveList
            // 
            this.cbDriveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriveList.FormattingEnabled = true;
            this.cbDriveList.Location = new System.Drawing.Point(9, 19);
            this.cbDriveList.Name = "cbDriveList";
            this.cbDriveList.Size = new System.Drawing.Size(263, 21);
            this.cbDriveList.TabIndex = 16;
            this.cbDriveList.SelectedIndexChanged += new System.EventHandler(this.cbDriveList_SelectedIndexChanged);
            // 
            // gbDrive
            // 
            this.gbDrive.Controls.Add(this.lbDriveInfo);
            this.gbDrive.Controls.Add(this.btRefreshDriveList);
            this.gbDrive.Controls.Add(this.cbDriveList);
            this.gbDrive.Location = new System.Drawing.Point(12, 3);
            this.gbDrive.Name = "gbDrive";
            this.gbDrive.Size = new System.Drawing.Size(356, 74);
            this.gbDrive.TabIndex = 17;
            this.gbDrive.TabStop = false;
            this.gbDrive.Text = "Drive";
            // 
            // lbDriveInfo
            // 
            this.lbDriveInfo.AutoSize = true;
            this.lbDriveInfo.Location = new System.Drawing.Point(6, 49);
            this.lbDriveInfo.Name = "lbDriveInfo";
            this.lbDriveInfo.Size = new System.Drawing.Size(16, 13);
            this.lbDriveInfo.TabIndex = 18;
            this.lbDriveInfo.Text = "---";
            // 
            // btRefreshDriveList
            // 
            this.btRefreshDriveList.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.arrow_refresh;
            this.btRefreshDriveList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefreshDriveList.Location = new System.Drawing.Point(275, 19);
            this.btRefreshDriveList.Name = "btRefreshDriveList";
            this.btRefreshDriveList.Size = new System.Drawing.Size(75, 40);
            this.btRefreshDriveList.TabIndex = 17;
            this.btRefreshDriveList.Text = "Refresh list";
            this.btRefreshDriveList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRefreshDriveList.UseVisualStyleBackColor = true;
            this.btRefreshDriveList.Click += new System.EventHandler(this.btRefreshDriveList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCoreDirNotFound);
            this.groupBox1.Controls.Add(this.lbLauncherDirNotFound);
            this.groupBox1.Controls.Add(this.btExploreCoreFolder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btExploreLauncherFolder);
            this.groupBox1.Controls.Add(this.tbLauncherDir);
            this.groupBox1.Controls.Add(this.tbCoreDir);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 148);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // lbCoreDirNotFound
            // 
            this.lbCoreDirNotFound.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.exclamation;
            this.lbCoreDirNotFound.Location = new System.Drawing.Point(338, 107);
            this.lbCoreDirNotFound.Name = "lbCoreDirNotFound";
            this.lbCoreDirNotFound.Size = new System.Drawing.Size(18, 18);
            this.lbCoreDirNotFound.TabIndex = 10;
            this.lbCoreDirNotFound.Visible = false;
            // 
            // lbLauncherDirNotFound
            // 
            this.lbLauncherDirNotFound.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.exclamation;
            this.lbLauncherDirNotFound.Location = new System.Drawing.Point(338, 47);
            this.lbLauncherDirNotFound.Name = "lbLauncherDirNotFound";
            this.lbLauncherDirNotFound.Size = new System.Drawing.Size(18, 18);
            this.lbLauncherDirNotFound.TabIndex = 9;
            this.lbLauncherDirNotFound.Visible = false;
            // 
            // btExploreCoreFolder
            // 
            this.btExploreCoreFolder.Enabled = false;
            this.btExploreCoreFolder.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.folder;
            this.btExploreCoreFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExploreCoreFolder.Location = new System.Drawing.Point(362, 102);
            this.btExploreCoreFolder.Name = "btExploreCoreFolder";
            this.btExploreCoreFolder.Size = new System.Drawing.Size(75, 23);
            this.btExploreCoreFolder.TabIndex = 8;
            this.btExploreCoreFolder.Text = "Open";
            this.btExploreCoreFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExploreCoreFolder.UseVisualStyleBackColor = true;
            this.btExploreCoreFolder.Click += new System.EventHandler(this.btExploreCoreFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RetroArch core folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Launcher folder:";
            // 
            // btExploreLauncherFolder
            // 
            this.btExploreLauncherFolder.Enabled = false;
            this.btExploreLauncherFolder.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.folder;
            this.btExploreLauncherFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExploreLauncherFolder.Location = new System.Drawing.Point(362, 43);
            this.btExploreLauncherFolder.Name = "btExploreLauncherFolder";
            this.btExploreLauncherFolder.Size = new System.Drawing.Size(75, 23);
            this.btExploreLauncherFolder.TabIndex = 2;
            this.btExploreLauncherFolder.Text = "Open";
            this.btExploreLauncherFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExploreLauncherFolder.UseVisualStyleBackColor = true;
            this.btExploreLauncherFolder.Click += new System.EventHandler(this.btExploreLauncherFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rom folder to scan:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbGlFolder);
            this.groupBox2.Controls.Add(this.tbTag);
            this.groupBox2.Controls.Add(this.tbCoreFile);
            this.groupBox2.Controls.Add(this.nudParentFolderIdForScan);
            this.groupBox2.Controls.Add(this.tbExtension);
            this.groupBox2.Location = new System.Drawing.Point(464, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 148);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scan Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Parent folder ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gamelist folder:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Extension:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "RA core:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tag:";
            // 
            // tbGlFolder
            // 
            this.tbGlFolder.Location = new System.Drawing.Point(102, 92);
            this.tbGlFolder.Name = "tbGlFolder";
            this.tbGlFolder.Size = new System.Drawing.Size(188, 20);
            this.tbGlFolder.TabIndex = 10;
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(102, 13);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(188, 20);
            this.tbTag.TabIndex = 9;
            // 
            // tbCoreFile
            // 
            this.tbCoreFile.Location = new System.Drawing.Point(102, 40);
            this.tbCoreFile.Name = "tbCoreFile";
            this.tbCoreFile.Size = new System.Drawing.Size(188, 20);
            this.tbCoreFile.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRomsDirNotFound);
            this.groupBox3.Controls.Add(this.btScanRoms);
            this.groupBox3.Controls.Add(this.tbRomsDir);
            this.groupBox3.Controls.Add(this.btExploreRomFolder);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 62);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scanner";
            // 
            // lbRomsDirNotFound
            // 
            this.lbRomsDirNotFound.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.exclamation;
            this.lbRomsDirNotFound.Location = new System.Drawing.Point(338, 36);
            this.lbRomsDirNotFound.Name = "lbRomsDirNotFound";
            this.lbRomsDirNotFound.Size = new System.Drawing.Size(18, 18);
            this.lbRomsDirNotFound.TabIndex = 11;
            this.lbRomsDirNotFound.Visible = false;
            // 
            // btScanRoms
            // 
            this.btScanRoms.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.media_playback_play_blue;
            this.btScanRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btScanRoms.Location = new System.Drawing.Point(603, 19);
            this.btScanRoms.Name = "btScanRoms";
            this.btScanRoms.Size = new System.Drawing.Size(139, 34);
            this.btScanRoms.TabIndex = 4;
            this.btScanRoms.Text = "Scan folder";
            this.btScanRoms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btScanRoms.UseVisualStyleBackColor = true;
            this.btScanRoms.Click += new System.EventHandler(this.btScanRoms_Click);
            // 
            // btExploreRomFolder
            // 
            this.btExploreRomFolder.Enabled = false;
            this.btExploreRomFolder.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.folder;
            this.btExploreRomFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExploreRomFolder.Location = new System.Drawing.Point(362, 31);
            this.btExploreRomFolder.Name = "btExploreRomFolder";
            this.btExploreRomFolder.Size = new System.Drawing.Size(75, 23);
            this.btExploreRomFolder.TabIndex = 5;
            this.btExploreRomFolder.Text = "Open";
            this.btExploreRomFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExploreRomFolder.UseVisualStyleBackColor = true;
            this.btExploreRomFolder.Click += new System.EventHandler(this.btExploreRomFolder_Click);
            // 
            // cbQuickSettings
            // 
            this.cbQuickSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuickSettings.FormattingEnabled = true;
            this.cbQuickSettings.Location = new System.Drawing.Point(102, 19);
            this.cbQuickSettings.Name = "cbQuickSettings";
            this.cbQuickSettings.Size = new System.Drawing.Size(188, 21);
            this.cbQuickSettings.TabIndex = 21;
            this.cbQuickSettings.SelectedIndexChanged += new System.EventHandler(this.cbQuickSettings_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbQuickSettings);
            this.groupBox4.Location = new System.Drawing.Point(464, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 78);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pbImgForFolder);
            this.groupBox5.Controls.Add(this.tbNameForFolder);
            this.groupBox5.Controls.Add(this.tbPublisherForFolder);
            this.groupBox5.Controls.Add(this.nudYearForFolder);
            this.groupBox5.Controls.Add(this.tbDBFileForFolder);
            this.groupBox5.Controls.Add(this.nudParentIdForFolder);
            this.groupBox5.Controls.Add(this.nudFolderIdForFolder);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btCreateFolder);
            this.groupBox5.Location = new System.Drawing.Point(12, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 151);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create a folder";
            // 
            // pbImgForFolder
            // 
            this.pbImgForFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgForFolder.Location = new System.Drawing.Point(217, 13);
            this.pbImgForFolder.Name = "pbImgForFolder";
            this.pbImgForFolder.Size = new System.Drawing.Size(100, 100);
            this.pbImgForFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgForFolder.TabIndex = 13;
            this.pbImgForFolder.TabStop = false;
            this.pbImgForFolder.Click += new System.EventHandler(this.pbImgForFolder_Click);
            this.pbImgForFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbImgForFolder_DragDrop);
            this.pbImgForFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbImgForFolder_DragEnter);
            this.pbImgForFolder.DoubleClick += new System.EventHandler(this.pbImgForFolder_DoubleClick);
            // 
            // tbNameForFolder
            // 
            this.tbNameForFolder.Location = new System.Drawing.Point(65, 13);
            this.tbNameForFolder.Name = "tbNameForFolder";
            this.tbNameForFolder.Size = new System.Drawing.Size(129, 20);
            this.tbNameForFolder.TabIndex = 12;
            this.tbNameForFolder.Text = "Defaultname";
            // 
            // tbPublisherForFolder
            // 
            this.tbPublisherForFolder.Location = new System.Drawing.Point(65, 35);
            this.tbPublisherForFolder.Name = "tbPublisherForFolder";
            this.tbPublisherForFolder.Size = new System.Drawing.Size(129, 20);
            this.tbPublisherForFolder.TabIndex = 11;
            this.tbPublisherForFolder.Text = "PB";
            // 
            // nudYearForFolder
            // 
            this.nudYearForFolder.Location = new System.Drawing.Point(65, 58);
            this.nudYearForFolder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYearForFolder.Name = "nudYearForFolder";
            this.nudYearForFolder.Size = new System.Drawing.Size(129, 20);
            this.nudYearForFolder.TabIndex = 10;
            this.nudYearForFolder.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // tbDBFileForFolder
            // 
            this.tbDBFileForFolder.Location = new System.Drawing.Point(65, 79);
            this.tbDBFileForFolder.Name = "tbDBFileForFolder";
            this.tbDBFileForFolder.Size = new System.Drawing.Size(129, 20);
            this.tbDBFileForFolder.TabIndex = 9;
            this.tbDBFileForFolder.Text = "regional.db";
            // 
            // nudParentIdForFolder
            // 
            this.nudParentIdForFolder.Location = new System.Drawing.Point(65, 124);
            this.nudParentIdForFolder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudParentIdForFolder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudParentIdForFolder.Name = "nudParentIdForFolder";
            this.nudParentIdForFolder.Size = new System.Drawing.Size(129, 20);
            this.nudParentIdForFolder.TabIndex = 8;
            this.nudParentIdForFolder.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudFolderIdForFolder
            // 
            this.nudFolderIdForFolder.Location = new System.Drawing.Point(65, 102);
            this.nudFolderIdForFolder.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudFolderIdForFolder.Name = "nudFolderIdForFolder";
            this.nudFolderIdForFolder.Size = new System.Drawing.Size(129, 20);
            this.nudFolderIdForFolder.TabIndex = 7;
            this.nudFolderIdForFolder.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Parent ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Folder ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "DB file:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Publisher:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // btCreateFolder
            // 
            this.btCreateFolder.Location = new System.Drawing.Point(217, 121);
            this.btCreateFolder.Name = "btCreateFolder";
            this.btCreateFolder.Size = new System.Drawing.Size(100, 23);
            this.btCreateFolder.TabIndex = 0;
            this.btCreateFolder.Text = "Create";
            this.btCreateFolder.UseVisualStyleBackColor = true;
            this.btCreateFolder.Click += new System.EventHandler(this.btCreateFolder_Click);
            // 
            // ofdLoadImg
            // 
            this.ofdLoadImg.DefaultExt = "png";
            this.ofdLoadImg.FileName = "file.png";
            this.ofdLoadImg.Filter = "image files|*.png;*.jpg;*.jpeg;*.bmp";
            this.ofdLoadImg.RestoreDirectory = true;
            this.ofdLoadImg.ShowHelp = true;
            this.ofdLoadImg.Title = "Load picture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 463);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDrive);
            this.Controls.Add(this.tbLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "pbPSCBSLauncherGenerator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudParentFolderIdForScan)).EndInit();
            this.gbDrive.ResumeLayout(false);
            this.gbDrive.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgForFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearForFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentIdForFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFolderIdForFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLauncherDir;
        private System.Windows.Forms.TextBox tbRomsDir;
        private System.Windows.Forms.Button btScanRoms;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.TextBox tbCoreDir;
        private System.Windows.Forms.NumericUpDown nudParentFolderIdForScan;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ComboBox cbDriveList;
        private System.Windows.Forms.GroupBox gbDrive;
        private System.Windows.Forms.Button btRefreshDriveList;
        private System.Windows.Forms.Label lbDriveInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExploreLauncherFolder;
        private System.Windows.Forms.Button btExploreRomFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExploreCoreFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbGlFolder;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbCoreFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbQuickSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudFolderIdForFolder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCreateFolder;
        private System.Windows.Forms.PictureBox pbImgForFolder;
        private System.Windows.Forms.TextBox tbNameForFolder;
        private System.Windows.Forms.TextBox tbPublisherForFolder;
        private System.Windows.Forms.NumericUpDown nudYearForFolder;
        private System.Windows.Forms.TextBox tbDBFileForFolder;
        private System.Windows.Forms.NumericUpDown nudParentIdForFolder;
        private System.Windows.Forms.Label lbLauncherDirNotFound;
        private System.Windows.Forms.Label lbCoreDirNotFound;
        private System.Windows.Forms.Label lbRomsDirNotFound;
        private System.Windows.Forms.OpenFileDialog ofdLoadImg;
    }
}

