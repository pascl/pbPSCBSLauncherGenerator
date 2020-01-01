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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.cbDriveList = new System.Windows.Forms.ComboBox();
            this.gbDrive = new System.Windows.Forms.GroupBox();
            this.lbDriveInfo = new System.Windows.Forms.Label();
            this.btRefreshDriveList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGamesDirNotFound = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btExploreGamesFolder = new System.Windows.Forms.Button();
            this.tbGamesDir = new System.Windows.Forms.TextBox();
            this.lbCoreDirNotFound = new System.Windows.Forms.Label();
            this.lbLauncherDirNotFound = new System.Windows.Forms.Label();
            this.btExploreCoreFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExploreLauncherFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.ofdLoadImg = new System.Windows.Forms.OpenFileDialog();
            this.tbRACfgPath = new System.Windows.Forms.TextBox();
            this.rbSelectAlphaYes = new System.Windows.Forms.RadioButton();
            this.rbSelectAlphaNo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDrive.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLauncherDir
            // 
            this.tbLauncherDir.Enabled = false;
            this.tbLauncherDir.Location = new System.Drawing.Point(9, 36);
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
            this.tbCoreDir.Location = new System.Drawing.Point(9, 117);
            this.tbCoreDir.Name = "tbCoreDir";
            this.tbCoreDir.Size = new System.Drawing.Size(323, 20);
            this.tbCoreDir.TabIndex = 6;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 305);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(748, 151);
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
            this.groupBox1.Controls.Add(this.lbGamesDirNotFound);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btExploreGamesFolder);
            this.groupBox1.Controls.Add(this.tbGamesDir);
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
            // lbGamesDirNotFound
            // 
            this.lbGamesDirNotFound.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.exclamation;
            this.lbGamesDirNotFound.Location = new System.Drawing.Point(338, 80);
            this.lbGamesDirNotFound.Name = "lbGamesDirNotFound";
            this.lbGamesDirNotFound.Size = new System.Drawing.Size(18, 18);
            this.lbGamesDirNotFound.TabIndex = 14;
            this.lbGamesDirNotFound.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Games folder:";
            // 
            // btExploreGamesFolder
            // 
            this.btExploreGamesFolder.Enabled = false;
            this.btExploreGamesFolder.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.folder;
            this.btExploreGamesFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExploreGamesFolder.Location = new System.Drawing.Point(362, 76);
            this.btExploreGamesFolder.Name = "btExploreGamesFolder";
            this.btExploreGamesFolder.Size = new System.Drawing.Size(75, 23);
            this.btExploreGamesFolder.TabIndex = 12;
            this.btExploreGamesFolder.Text = "Open";
            this.btExploreGamesFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExploreGamesFolder.UseVisualStyleBackColor = true;
            this.btExploreGamesFolder.Click += new System.EventHandler(this.btExploreGamesFolder_Click);
            // 
            // tbGamesDir
            // 
            this.tbGamesDir.Enabled = false;
            this.tbGamesDir.Location = new System.Drawing.Point(9, 78);
            this.tbGamesDir.Name = "tbGamesDir";
            this.tbGamesDir.Size = new System.Drawing.Size(323, 20);
            this.tbGamesDir.TabIndex = 11;
            // 
            // lbCoreDirNotFound
            // 
            this.lbCoreDirNotFound.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.exclamation;
            this.lbCoreDirNotFound.Location = new System.Drawing.Point(338, 120);
            this.lbCoreDirNotFound.Name = "lbCoreDirNotFound";
            this.lbCoreDirNotFound.Size = new System.Drawing.Size(18, 18);
            this.lbCoreDirNotFound.TabIndex = 10;
            this.lbCoreDirNotFound.Visible = false;
            // 
            // lbLauncherDirNotFound
            // 
            this.lbLauncherDirNotFound.Image = global::pbPSCBSLauncherGenerator.Properties.Resources.exclamation;
            this.lbLauncherDirNotFound.Location = new System.Drawing.Point(338, 38);
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
            this.btExploreCoreFolder.Location = new System.Drawing.Point(362, 115);
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
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RetroArch core folder:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
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
            this.btExploreLauncherFolder.Location = new System.Drawing.Point(362, 34);
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
            this.groupBox2.Controls.Add(this.rbSelectAlphaNo);
            this.groupBox2.Controls.Add(this.rbSelectAlphaYes);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbGlFolder);
            this.groupBox2.Controls.Add(this.tbTag);
            this.groupBox2.Controls.Add(this.tbCoreFile);
            this.groupBox2.Controls.Add(this.tbExtension);
            this.groupBox2.Location = new System.Drawing.Point(464, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 148);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scan Settings";
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
            this.groupBox4.Size = new System.Drawing.Size(296, 49);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick Settings";
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
            // tbRACfgPath
            // 
            this.tbRACfgPath.Enabled = false;
            this.tbRACfgPath.Location = new System.Drawing.Point(374, 57);
            this.tbRACfgPath.Name = "tbRACfgPath";
            this.tbRACfgPath.Size = new System.Drawing.Size(194, 20);
            this.tbRACfgPath.TabIndex = 23;
            this.tbRACfgPath.Visible = false;
            // 
            // rbSelectAlphaYes
            // 
            this.rbSelectAlphaYes.AutoSize = true;
            this.rbSelectAlphaYes.Location = new System.Drawing.Point(184, 118);
            this.rbSelectAlphaYes.Name = "rbSelectAlphaYes";
            this.rbSelectAlphaYes.Size = new System.Drawing.Size(43, 17);
            this.rbSelectAlphaYes.TabIndex = 15;
            this.rbSelectAlphaYes.Text = "Yes";
            this.rbSelectAlphaYes.UseVisualStyleBackColor = true;
            // 
            // rbSelectAlphaNo
            // 
            this.rbSelectAlphaNo.AutoSize = true;
            this.rbSelectAlphaNo.Checked = true;
            this.rbSelectAlphaNo.Location = new System.Drawing.Point(251, 118);
            this.rbSelectAlphaNo.Name = "rbSelectAlphaNo";
            this.rbSelectAlphaNo.Size = new System.Drawing.Size(39, 17);
            this.rbSelectAlphaNo.TabIndex = 16;
            this.rbSelectAlphaNo.TabStop = true;
            this.rbSelectAlphaNo.Text = "No";
            this.rbSelectAlphaNo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Add tag as Alphatitle:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 463);
            this.Controls.Add(this.tbRACfgPath);
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
            this.gbDrive.ResumeLayout(false);
            this.gbDrive.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLauncherDir;
        private System.Windows.Forms.TextBox tbRomsDir;
        private System.Windows.Forms.Button btScanRoms;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.TextBox tbCoreDir;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLauncherDirNotFound;
        private System.Windows.Forms.Label lbCoreDirNotFound;
        private System.Windows.Forms.Label lbRomsDirNotFound;
        private System.Windows.Forms.OpenFileDialog ofdLoadImg;
        private System.Windows.Forms.Label lbGamesDirNotFound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btExploreGamesFolder;
        private System.Windows.Forms.TextBox tbGamesDir;
        private System.Windows.Forms.TextBox tbRACfgPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbSelectAlphaNo;
        private System.Windows.Forms.RadioButton rbSelectAlphaYes;
    }
}

