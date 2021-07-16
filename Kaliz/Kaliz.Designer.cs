﻿using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Kaliz
{
    partial class Kaliz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.Docking.AutoHideGroup autoHideGroup1 = new Telerik.WinControls.UI.Docking.AutoHideGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaliz));
            this.dockWindowPlaceholder1 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
            this.dockWindowPlaceholder2 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
            this.dockWindowPlaceholder3 = new Telerik.WinControls.UI.Docking.DockWindowPlaceholder();
            this.MFile = new Telerik.WinControls.UI.RadMenuItem();
            this.FNew = new Telerik.WinControls.UI.RadMenuItem();
            this.FOpen = new Telerik.WinControls.UI.RadMenuItem();
            this.FReopen = new Telerik.WinControls.UI.RadMenuItem();
            this.EncodeUTF8 = new Telerik.WinControls.UI.RadMenuItem();
            this.EncodeUS = new Telerik.WinControls.UI.RadMenuItem();
            this.Encode1252 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.FPrint = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem15 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem14 = new Telerik.WinControls.UI.RadMenuItem();
            this.FSave = new Telerik.WinControls.UI.RadMenuItem();
            this.FSaveAs = new Telerik.WinControls.UI.RadMenuItem();
            this.FExport = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem2 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.FExit = new Telerik.WinControls.UI.RadMenuItem();
            this.MEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.ECopy = new Telerik.WinControls.UI.RadMenuItem();
            this.ECut = new Telerik.WinControls.UI.RadMenuItem();
            this.EPaste = new Telerik.WinControls.UI.RadMenuItem();
            this.EUndo = new Telerik.WinControls.UI.RadMenuItem();
            this.ERedo = new Telerik.WinControls.UI.RadMenuItem();
            this.ESelect = new Telerik.WinControls.UI.RadMenuItem();
            this.ESyntax = new Telerik.WinControls.UI.RadMenuItem();
            this.SPascal = new Telerik.WinControls.UI.RadMenuItem();
            this.SynC = new Telerik.WinControls.UI.RadMenuItem();
            this.SynPython = new Telerik.WinControls.UI.RadMenuItem();
            this.SynJava = new Telerik.WinControls.UI.RadMenuItem();
            this.EStart = new Telerik.WinControls.UI.RadMenuItem();
            this.EEnd = new Telerik.WinControls.UI.RadMenuItem();
            this.EIndent = new Telerik.WinControls.UI.RadMenuItem();
            this.EOutdent = new Telerik.WinControls.UI.RadMenuItem();
            this.EFold = new Telerik.WinControls.UI.RadMenuItem();
            this.FFold = new Telerik.WinControls.UI.RadMenuItem();
            this.FUnfold = new Telerik.WinControls.UI.RadMenuItem();
            this.FFoldAll = new Telerik.WinControls.UI.RadMenuItem();
            this.FFUnfoldAll = new Telerik.WinControls.UI.RadMenuItem();
            this.ESwitch = new Telerik.WinControls.UI.RadMenuItem();
            this.SwitchNext = new Telerik.WinControls.UI.RadMenuItem();
            this.SwitchPrevious = new Telerik.WinControls.UI.RadMenuItem();
            this.MTools = new Telerik.WinControls.UI.RadMenuItem();
            this.TFind = new Telerik.WinControls.UI.RadMenuItem();
            this.FindDia = new Telerik.WinControls.UI.RadMenuItem();
            this.FFindSelected = new Telerik.WinControls.UI.RadMenuItem();
            this.TReplace = new Telerik.WinControls.UI.RadMenuItem();
            this.TGoToLine = new Telerik.WinControls.UI.RadMenuItem();
            this.TAscii = new Telerik.WinControls.UI.RadMenuItem();
            this.ATable = new Telerik.WinControls.UI.RadMenuItem();
            this.AConvert = new Telerik.WinControls.UI.RadMenuItem();
            this.TCalc = new Telerik.WinControls.UI.RadMenuItem();
            this.Tcmd = new Telerik.WinControls.UI.RadMenuItem();
            this.TTermi = new Telerik.WinControls.UI.RadMenuItem();
            this.TEmail = new Telerik.WinControls.UI.RadMenuItem();
            this.TDiff = new Telerik.WinControls.UI.RadMenuItem();
            this.DSetDiff = new Telerik.WinControls.UI.RadMenuItem();
            this.DOpenDiff = new Telerik.WinControls.UI.RadMenuItem();
            this.DDiffDialog = new Telerik.WinControls.UI.RadMenuItem();
            this.MBuild = new Telerik.WinControls.UI.RadMenuItem();
            this.BRun = new Telerik.WinControls.UI.RadMenuItem();
            this.BBuild = new Telerik.WinControls.UI.RadMenuItem();
            this.BBuildaRun = new Telerik.WinControls.UI.RadMenuItem();
            this.BPara = new Telerik.WinControls.UI.RadMenuItem();
            this.BConfig = new Telerik.WinControls.UI.RadMenuItem();
            this.MDebug = new Telerik.WinControls.UI.RadMenuItem();
            this.DEnable = new Telerik.WinControls.UI.RadMenuItem();
            this.DOpenGDB = new Telerik.WinControls.UI.RadMenuItem();
            this.DeJDB = new Telerik.WinControls.UI.RadMenuItem();
            this.DebugPython = new Telerik.WinControls.UI.RadMenuItem();
            this.MOptions = new Telerik.WinControls.UI.RadMenuItem();
            this.OEnableContext = new Telerik.WinControls.UI.RadMenuItem();
            this.OLock = new Telerik.WinControls.UI.RadMenuItem();
            this.PerReadonly = new Telerik.WinControls.UI.RadMenuItem();
            this.PerDisable = new Telerik.WinControls.UI.RadMenuItem();
            this.OCTooltip = new Telerik.WinControls.UI.RadMenuItem();
            this.OHightlight = new Telerik.WinControls.UI.RadMenuItem();
            this.OEnaPrompt = new Telerik.WinControls.UI.RadMenuItem();
            this.OLineNum = new Telerik.WinControls.UI.RadMenuItem();
            this.OClearClip = new Telerik.WinControls.UI.RadMenuItem();
            this.OTer = new Telerik.WinControls.UI.RadMenuItem();
            this.ConPow = new Telerik.WinControls.UI.RadMenuItem();
            this.ConCmder = new Telerik.WinControls.UI.RadMenuItem();
            this.OZoom = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.MHelp = new Telerik.WinControls.UI.RadMenuItem();
            this.HHowto = new Telerik.WinControls.UI.RadMenuItem();
            this.HLearn = new Telerik.WinControls.UI.RadMenuItem();
            this.LCpp = new Telerik.WinControls.UI.RadMenuItem();
            this.LPascal = new Telerik.WinControls.UI.RadMenuItem();
            this.LPython = new Telerik.WinControls.UI.RadMenuItem();
            this.HLookUp = new Telerik.WinControls.UI.RadMenuItem();
            this.HAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.DockPar = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.wlcJava = new Telerik.WinControls.UI.RadButton();
            this.recentList = new Telerik.WinControls.UI.RadListView();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wclOpen = new Telerik.WinControls.UI.RadButton();
            this.wclCc = new Telerik.WinControls.UI.RadButton();
            this.wclPython = new Telerik.WinControls.UI.RadButton();
            this.wclPascal = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.DContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.Doutput = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.ListOutput = new Telerik.WinControls.UI.RadListView();
            this.Dclipboard = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radlistclip = new Telerik.WinControls.UI.RadListView();
            this.DClosedFiles = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.listClosedFiles = new Telerik.WinControls.UI.RadListView();
            this.MBookmark = new Telerik.WinControls.UI.RadMenuItem();
            this.BBookmark = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.BRemoveAll = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem3 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.BBookmarkPre = new Telerik.WinControls.UI.RadMenuItem();
            this.BBookmarkNext = new Telerik.WinControls.UI.RadMenuItem();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.MPersonal = new Telerik.WinControls.UI.RadMenuItem();
            this.MPcurrentline = new Telerik.WinControls.UI.RadMenuItem();
            this.PSelection = new Telerik.WinControls.UI.RadMenuItem();
            this.PEditor = new Telerik.WinControls.UI.RadMenuItem();
            this.ELight = new Telerik.WinControls.UI.RadMenuItem();
            this.EDark = new Telerik.WinControls.UI.RadMenuItem();
            this.EMaterialTeal = new Telerik.WinControls.UI.RadMenuItem();
            this.toolTabStrip3 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.radMenuHeaderItem1 = new Telerik.WinControls.UI.RadMenuHeaderItem();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.object_d76c15f1_b4da_4f3f_b911_a99b364b78fa = new Telerik.WinControls.RootRadElement();
            this.MView = new Telerik.WinControls.UI.RadMenuItem();
            this.VOutput = new Telerik.WinControls.UI.RadMenuItem();
            this.VClosedList = new Telerik.WinControls.UI.RadMenuItem();
            this.VClipboardList = new Telerik.WinControls.UI.RadMenuItem();
            this.VSplitHorizon = new Telerik.WinControls.UI.RadMenuItem();
            this.VSplitVertical = new Telerik.WinControls.UI.RadMenuItem();
            this.MWindows = new Telerik.WinControls.UI.RadMenuItem();
            this.WFloat = new Telerik.WinControls.UI.RadMenuItem();
            this.WFloatAll = new Telerik.WinControls.UI.RadMenuItem();
            this.WDock = new Telerik.WinControls.UI.RadMenuItem();
            this.DockLeft = new Telerik.WinControls.UI.RadMenuItem();
            this.DockRight = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem4 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.DockFill = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem5 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.DockTop = new Telerik.WinControls.UI.RadMenuItem();
            this.DockBottom = new Telerik.WinControls.UI.RadMenuItem();
            this.WCloseCur = new Telerik.WinControls.UI.RadMenuItem();
            this.WCloseAll = new Telerik.WinControls.UI.RadMenuItem();
            this.WResetWindows = new Telerik.WinControls.UI.RadMenuItem();
            this.MenuTop = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem16 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem17 = new Telerik.WinControls.UI.RadMenuItem();
            
            ((System.ComponentModel.ISupportInitialize)(this.DockPar)).BeginInit();
            this.DockPar.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wlcJava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclCc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclPython)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclPascal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.radLabel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DContainer)).BeginInit();
            this.DContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.Doutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOutput)).BeginInit();
            this.Dclipboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radlistclip)).BeginInit();
            this.DClosedFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClosedFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dockWindowPlaceholder1
            // 
            this.dockWindowPlaceholder1.AutoHideSize = new System.Drawing.Size(200, 185);
            this.dockWindowPlaceholder1.DockWindowName = "Doutput";
            this.dockWindowPlaceholder1.DockWindowText = "Output";
            this.dockWindowPlaceholder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dockWindowPlaceholder1.Location = new System.Drawing.Point(0, 0);
            this.dockWindowPlaceholder1.Name = "dockWindowPlaceholder1";
            this.dockWindowPlaceholder1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.dockWindowPlaceholder1.Size = new System.Drawing.Size(200, 200);
            this.dockWindowPlaceholder1.Text = "dockWindowPlaceholder1";
            // 
            // dockWindowPlaceholder2
            // 
            this.dockWindowPlaceholder2.AutoHideSize = new System.Drawing.Size(200, 185);
            this.dockWindowPlaceholder2.DockWindowName = "Dclipboard";
            this.dockWindowPlaceholder2.DockWindowText = "ClipBoard";
            this.dockWindowPlaceholder2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dockWindowPlaceholder2.Location = new System.Drawing.Point(0, 0);
            this.dockWindowPlaceholder2.Name = "dockWindowPlaceholder2";
            this.dockWindowPlaceholder2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.dockWindowPlaceholder2.Size = new System.Drawing.Size(200, 200);
            this.dockWindowPlaceholder2.Text = "dockWindowPlaceholder2";
            // 
            // dockWindowPlaceholder3
            // 
            this.dockWindowPlaceholder3.AutoHideSize = new System.Drawing.Size(200, 185);
            this.dockWindowPlaceholder3.DockWindowName = "DClosedFiles";
            this.dockWindowPlaceholder3.DockWindowText = "Closed Files";
            this.dockWindowPlaceholder3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dockWindowPlaceholder3.Location = new System.Drawing.Point(0, 0);
            this.dockWindowPlaceholder3.Name = "dockWindowPlaceholder3";
            this.dockWindowPlaceholder3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.dockWindowPlaceholder3.Size = new System.Drawing.Size(200, 200);
            this.dockWindowPlaceholder3.Text = "dockWindowPlaceholder3";
            // 
            // MFile
            // 
            this.MFile.BackColor = System.Drawing.Color.White;
            this.MFile.BorderHighlightColor = System.Drawing.Color.White;
            this.MFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.FNew,
            this.FOpen,
            this.FReopen,
            this.radMenuSeparatorItem1,
            this.FPrint,
            this.FSave,
            this.FSaveAs,
            this.FExport,
            this.radMenuSeparatorItem2,
            this.FExit});
            this.MFile.Name = "MFile";
            this.MFile.Text = "File";
            // 
            // FNew
            // 
            this.FNew.HintText = "Ctrl + N";
            this.FNew.Name = "FNew";
            this.FNew.Text = "New File";
            this.FNew.ToolTipText = "Tệp Mới";
            this.FNew.Click += new System.EventHandler(this.FNew_Click);
            // 
            // FOpen
            // 
            this.FOpen.HintText = "Ctrl + O";
            this.FOpen.Name = "FOpen";
            this.FOpen.Text = "Open File";
            this.FOpen.Click += new System.EventHandler(this.FOpen_Click);
            // 
            // FReopen
            // 
            this.FReopen.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.EncodeUTF8,
            this.EncodeUS,
            this.Encode1252});
            this.FReopen.Name = "FReopen";
            this.FReopen.Text = "Reopen with Encoding";
            // 
            // EncodeUTF8
            // 
            this.EncodeUTF8.Name = "EncodeUTF8";
            this.EncodeUTF8.Text = "UTF-8";
            this.EncodeUTF8.Click += new System.EventHandler(this.EncodeUTF8_Click);
            // 
            // EncodeUS
            // 
            this.EncodeUS.Name = "EncodeUS";
            this.EncodeUS.Text = "US-ASCII";
            this.EncodeUS.Click += new System.EventHandler(this.EncodeUS_Click);
            // 
            // Encode1252
            // 
            this.Encode1252.Name = "Encode1252";
            this.Encode1252.Text = "Windows-1252";
            this.Encode1252.Click += new System.EventHandler(this.Encode1252_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FPrint
            // 
            this.FPrint.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem15,
            this.radMenuItem13,
            this.radMenuItem14});
            this.FPrint.Name = "FPrint";
            this.FPrint.Text = "Print";
            this.FPrint.Click += new System.EventHandler(this.FPrint_Click);
            // 
            // radMenuItem15
            // 
            this.radMenuItem15.HintText = "Ctrl + P";
            this.radMenuItem15.Name = "radMenuItem15";
            this.radMenuItem15.Text = "Print";
            this.radMenuItem15.Click += new System.EventHandler(this.radMenuItem15_Click);
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "Print Preview";
            this.radMenuItem13.Click += new System.EventHandler(this.radMenuItem13_Click);
            // 
            // radMenuItem14
            // 
            this.radMenuItem14.Name = "radMenuItem14";
            this.radMenuItem14.Text = "Print Selection";
            this.radMenuItem14.Click += new System.EventHandler(this.radMenuItem14_Click);
            // 
            // FSave
            // 
            this.FSave.HintText = "Ctrl + S";
            this.FSave.Name = "FSave";
            this.FSave.Text = "Save";
            this.FSave.Click += new System.EventHandler(this.FSave_Click);
            // 
            // FSaveAs
            // 
            this.FSaveAs.HintText = "Ctrl + Shift + S";
            this.FSaveAs.Name = "FSaveAs";
            this.FSaveAs.Text = "Save As";
            this.FSaveAs.Click += new System.EventHandler(this.FSaveAs_Click);
            // 
            // FExport
            // 
            this.FExport.Name = "FExport";
            this.FExport.Text = "Export to RTF";
            this.FExport.Click += new System.EventHandler(this.FExport_Click);
            // 
            // radMenuSeparatorItem2
            // 
            this.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2";
            this.radMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FExit
            // 
            this.FExit.Name = "FExit";
            this.FExit.Text = "Exit";
            this.FExit.Click += new System.EventHandler(this.FExit_Click);
            // 
            // MEdit
            // 
            this.MEdit.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ECopy,
            this.ECut,
            this.EPaste,
            this.EUndo,
            this.ERedo,
            this.ESelect,
            this.ESyntax,
            this.EStart,
            this.EEnd,
            this.EIndent,
            this.EOutdent,
            this.EFold,
            this.ESwitch});
            this.MEdit.Name = "MEdit";
            this.MEdit.Text = "Edit";
            // 
            // ECopy
            // 
            this.ECopy.HintText = "Ctrl + C";
            this.ECopy.Name = "ECopy";
            this.ECopy.Text = "Copy";
            this.ECopy.Click += new System.EventHandler(this.ECopy_Click);
            // 
            // ECut
            // 
            this.ECut.HintText = "Ctrl + X";
            this.ECut.Name = "ECut";
            this.ECut.Text = "Cut";
            this.ECut.Click += new System.EventHandler(this.ECut_Click);
            // 
            // EPaste
            // 
            this.EPaste.HintText = "Ctrl + V";
            this.EPaste.Name = "EPaste";
            this.EPaste.Text = "Paste";
            this.EPaste.Click += new System.EventHandler(this.EPaste_Click);
            // 
            // EUndo
            // 
            this.EUndo.HintText = "Ctrl + Z";
            this.EUndo.Name = "EUndo";
            this.EUndo.Text = "Undo";
            this.EUndo.Click += new System.EventHandler(this.EUndo_Click);
            // 
            // ERedo
            // 
            this.ERedo.HintText = "Ctrl + Shift + Z";
            this.ERedo.Name = "ERedo";
            this.ERedo.Text = "Redo";
            this.ERedo.Click += new System.EventHandler(this.ERedo_Click);
            // 
            // ESelect
            // 
            this.ESelect.Name = "ESelect";
            this.ESelect.Text = "Select Mode: Block";
            this.ESelect.Click += new System.EventHandler(this.ESelect_Click);
            // 
            // ESyntax
            // 
            this.ESyntax.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.SPascal,
            this.SynC,
            this.SynPython,
            this.SynJava});
            this.ESyntax.Name = "ESyntax";
            this.ESyntax.Text = "Syntax";
            // 
            // SPascal
            // 
            this.SPascal.Name = "SPascal";
            this.SPascal.Text = "Pascal";
            this.SPascal.Click += new System.EventHandler(this.SPascal_Click);
            // 
            // SynC
            // 
            this.SynC.Name = "SynC";
            this.SynC.Text = "C/C++";
            this.SynC.Click += new System.EventHandler(this.SynC_Click);
            // 
            // SynPython
            // 
            this.SynPython.Name = "SynPython";
            this.SynPython.Text = "Python";
            this.SynPython.Click += new System.EventHandler(this.SynPython_Click);
            // 
            // SynJava
            // 
            this.SynJava.Name = "SynJava";
            this.SynJava.Text = "Java";
            this.SynJava.Click += new System.EventHandler(this.SynJava_Click);
            // 
            // EStart
            // 
            this.EStart.HintText = "Ctrl + Up";
            this.EStart.Name = "EStart";
            this.EStart.Text = "Jump to Block Start";
            this.EStart.Click += new System.EventHandler(this.EStart_Click);
            // 
            // EEnd
            // 
            this.EEnd.HintText = "Ctrl + Down";
            this.EEnd.Name = "EEnd";
            this.EEnd.Text = "Jump to Block End";
            this.EEnd.Click += new System.EventHandler(this.EEnd_Click);
            // 
            // EIndent
            // 
            this.EIndent.HintText = "Ctrl + ]";
            this.EIndent.Name = "EIndent";
            this.EIndent.Text = "Indent Selection";
            this.EIndent.Click += new System.EventHandler(this.EIndent_Click);
            // 
            // EOutdent
            // 
            this.EOutdent.HintText = "Ctrl + [";
            this.EOutdent.Name = "EOutdent";
            this.EOutdent.Text = "Outdent Selection";
            this.EOutdent.Click += new System.EventHandler(this.EOutdent_Click);
            // 
            // EFold
            // 
            this.EFold.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.FFold,
            this.FUnfold,
            this.FFoldAll,
            this.FFUnfoldAll});
            this.EFold.Name = "EFold";
            this.EFold.Text = "Code Folding";
            // 
            // FFold
            // 
            this.FFold.Name = "FFold";
            this.FFold.Text = "Fold";
            this.FFold.Click += new System.EventHandler(this.FFold_Click);
            // 
            // FUnfold
            // 
            this.FUnfold.Name = "FUnfold";
            this.FUnfold.Text = "Unfold";
            this.FUnfold.Click += new System.EventHandler(this.FUnfold_Click);
            // 
            // FFoldAll
            // 
            this.FFoldAll.Name = "FFoldAll";
            this.FFoldAll.Text = "Fold All";
            this.FFoldAll.Click += new System.EventHandler(this.FFoldAll_Click);
            // 
            // FFUnfoldAll
            // 
            this.FFUnfoldAll.Name = "FFUnfoldAll";
            this.FFUnfoldAll.Text = "Unfold All";
            this.FFUnfoldAll.Click += new System.EventHandler(this.FFUnfoldAll_Click);
            // 
            // ESwitch
            // 
            this.ESwitch.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.SwitchNext,
            this.SwitchPrevious});
            this.ESwitch.Name = "ESwitch";
            this.ESwitch.Text = "Switch File";
            // 
            // SwitchNext
            // 
            this.SwitchNext.Name = "SwitchNext";
            this.SwitchNext.Text = "Next File";
            this.SwitchNext.Click += new System.EventHandler(this.SwitchNext_Click);
            // 
            // SwitchPrevious
            // 
            this.SwitchPrevious.Name = "SwitchPrevious";
            this.SwitchPrevious.Text = "Previous File";
            this.SwitchPrevious.Click += new System.EventHandler(this.SwitchPrevious_Click);
            // 
            // MTools
            // 
            this.MTools.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.TFind,
            this.TReplace,
            this.TGoToLine,
            this.TAscii,
            this.TCalc,
            this.Tcmd,
            this.TTermi,
            this.TEmail,
            this.TDiff});
            this.MTools.Name = "MTools";
            this.MTools.Text = "Tools";
            // 
            // TFind
            // 
            this.TFind.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.FindDia,
            this.FFindSelected});
            this.TFind.Name = "TFind";
            this.TFind.Text = "Find";
            // 
            // FindDia
            // 
            this.FindDia.HintText = "Ctrl + F";
            this.FindDia.Name = "FindDia";
            this.FindDia.Text = "Open Find Dialog";
            this.FindDia.Click += new System.EventHandler(this.TFind_Click);
            // 
            // FFindSelected
            // 
            this.FFindSelected.HintText = "Ctrl + Enter";
            this.FFindSelected.Name = "FFindSelected";
            this.FFindSelected.Text = "Find Selected Text";
            this.FFindSelected.Click += new System.EventHandler(this.FFindSelected_Click);
            // 
            // TReplace
            // 
            this.TReplace.HintText = "Ctrl + H";
            this.TReplace.Name = "TReplace";
            this.TReplace.Text = "Replace";
            this.TReplace.Click += new System.EventHandler(this.TReplace_Click);
            // 
            // TGoToLine
            // 
            this.TGoToLine.HintText = "Ctrl + G";
            this.TGoToLine.Name = "TGoToLine";
            this.TGoToLine.Text = "Go To Line";
            this.TGoToLine.Click += new System.EventHandler(this.TGoToLine_Click);
            // 
            // TAscii
            // 
            this.TAscii.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ATable,
            this.AConvert});
            this.TAscii.Name = "TAscii";
            this.TAscii.Text = "ASCII";
            // 
            // ATable
            // 
            this.ATable.Name = "ATable";
            this.ATable.Text = "ASCII Table";
            this.ATable.ToolTipText = "Bảng mã ASCII";
            this.ATable.Click += new System.EventHandler(this.ATable_Click);
            // 
            // AConvert
            // 
            this.AConvert.Name = "AConvert";
            this.AConvert.Text = "Convert string to ASCII";
            this.AConvert.ToolTipText = "Chuyển đổi ký tự hoặc xâu sang ASCII";
            this.AConvert.Click += new System.EventHandler(this.AConvert_Click);
            // 
            // TCalc
            // 
            this.TCalc.Name = "TCalc";
            this.TCalc.Text = "Calculator";
            this.TCalc.ToolTipText = "Máy tính";
            this.TCalc.Click += new System.EventHandler(this.TCalc_Click);
            // 
            // Tcmd
            // 
            this.Tcmd.Name = "Tcmd";
            this.Tcmd.Text = "Command Prompt";
            this.Tcmd.ToolTipText = "Dấu nhắc lệnh Command Prompt";
            this.Tcmd.Click += new System.EventHandler(this.Tcmd_Click);
            // 
            // TTermi
            // 
            this.TTermi.HintText = "Ctrl + Alt + T";
            this.TTermi.Name = "TTermi";
            this.TTermi.Text = "Terminal";
            this.TTermi.Click += new System.EventHandler(this.TPowerShell_Click);
            // 
            // TEmail
            // 
            this.TEmail.Name = "TEmail";
            this.TEmail.Text = "Send Email with this file";
            this.TEmail.Click += new System.EventHandler(this.TEmail_Click);
            // 
            // TDiff
            // 
            this.TDiff.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.DSetDiff,
            this.DOpenDiff,
            this.DDiffDialog});
            this.TDiff.Name = "TDiff";
            this.TDiff.Text = "Different Merge";
            // 
            // DSetDiff
            // 
            this.DSetDiff.Name = "DSetDiff";
            this.DSetDiff.Text = "Set Different in this file";
            this.DSetDiff.Click += new System.EventHandler(this.DSetDiff_Click);
            // 
            // DOpenDiff
            // 
            this.DOpenDiff.Name = "DOpenDiff";
            this.DOpenDiff.Text = "Open Different Merge";
            this.DOpenDiff.Click += new System.EventHandler(this.DOpenDiff_Click);
            // 
            // DDiffDialog
            // 
            this.DDiffDialog.Name = "DDiffDialog";
            this.DDiffDialog.Text = "Open Different Merge Dialog";
            this.DDiffDialog.Click += new System.EventHandler(this.DDiffDialog_Click);
            // 
            // MBuild
            // 
            this.MBuild.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.BRun,
            this.BBuild,
            this.BBuildaRun,
            this.BPara,
            this.BConfig});
            this.MBuild.Name = "MBuild";
            this.MBuild.Text = "Buid";
            // 
            // BRun
            // 
            this.BRun.HintText = "Ctrl + B";
            this.BRun.Name = "BRun";
            this.BRun.Text = "Run";
            this.BRun.Click += new System.EventHandler(this.BRun_Click);
            // 
            // BBuild
            // 
            this.BBuild.HintText = "Ctrl + Shift + B";
            this.BBuild.Name = "BBuild";
            this.BBuild.Text = "Build This File";
            this.BBuild.Click += new System.EventHandler(this.BBuild_Click);
            // 
            // BBuildaRun
            // 
            this.BBuildaRun.Name = "BBuildaRun";
            this.BBuildaRun.Text = "Build And Run";
            this.BBuildaRun.Click += new System.EventHandler(this.BBuildaRun_Click);
            // 
            // BPara
            // 
            this.BPara.Name = "BPara";
            this.BPara.Text = "Parameter Dialog";
            this.BPara.Click += new System.EventHandler(this.BPara_Click);
            // 
            // BConfig
            // 
            this.BConfig.Name = "BConfig";
            this.BConfig.Text = "Build Configurator";
            this.BConfig.Click += new System.EventHandler(this.BConfig_Click);
            // 
            // MDebug
            // 
            this.MDebug.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.DEnable,
            this.DOpenGDB,
            this.DeJDB,
            this.DebugPython});
            this.MDebug.Name = "MDebug";
            this.MDebug.Text = "Debug";
            this.MDebug.Click += new System.EventHandler(this.MDebug_Click);
            // 
            // DEnable
            // 
            this.DEnable.Name = "DEnable";
            this.DEnable.Text = "Enable Debug";
            this.DEnable.Click += new System.EventHandler(this.DEnable_Click);
            // 
            // DOpenGDB
            // 
            this.DOpenGDB.Name = "DOpenGDB";
            this.DOpenGDB.Text = "Open GDB Debug for C/C++, Pascal";
            this.DOpenGDB.Click += new System.EventHandler(this.DOpenGDB_Click);
            // 
            // DeJDB
            // 
            this.DeJDB.Name = "DeJDB";
            this.DeJDB.Text = "Open JDB Debug for Java";
            this.DeJDB.Click += new System.EventHandler(this.DeJDB_Click);
            // 
            // DebugPython
            // 
            this.DebugPython.Name = "DebugPython";
            this.DebugPython.Text = "Open Python Debugger";
            this.DebugPython.Click += new System.EventHandler(this.DebugPython_Click);
            // 
            // MOptions
            // 
            this.MOptions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.OEnableContext,
            this.OLock,
            this.OCTooltip,
            this.OHightlight,
            this.OEnaPrompt,
            this.OLineNum,
            this.OClearClip,
            this.OTer,
            this.OZoom});
            this.MOptions.Name = "MOptions";
            this.MOptions.Text = "Options";
            this.MOptions.Click += new System.EventHandler(this.MOptions_Click);
            // 
            // OEnableContext
            // 
            this.OEnableContext.Name = "OEnableContext";
            this.OEnableContext.Text = "Enable Context Intellisense";
            this.OEnableContext.Click += new System.EventHandler(this.OEnableContext_Click);
            // 
            // OLock
            // 
            this.OLock.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.PerReadonly,
            this.PerDisable});
            this.OLock.Name = "OLock";
            this.OLock.Text = "File Permission";
            // 
            // PerReadonly
            // 
            this.PerReadonly.Name = "PerReadonly";
            this.PerReadonly.Text = "Enable Read Only";
            this.PerReadonly.Click += new System.EventHandler(this.PerReadonly_Click);
            // 
            // PerDisable
            // 
            this.PerDisable.Name = "PerDisable";
            this.PerDisable.Text = "Disable Read Only";
            this.PerDisable.Click += new System.EventHandler(this.PerDisable_Click);
            // 
            // OCTooltip
            // 
            this.OCTooltip.Name = "OCTooltip";
            this.OCTooltip.Text = "Enable Context Tooltip";
            this.OCTooltip.Click += new System.EventHandler(this.OCTooltip_Click);
            // 
            // OHightlight
            // 
            this.OHightlight.Name = "OHightlight";
            this.OHightlight.Text = "Hide Hightlight Current Line";
            this.OHightlight.Click += new System.EventHandler(this.OHightlight_Click);
            // 
            // OEnaPrompt
            // 
            this.OEnaPrompt.Name = "OEnaPrompt";
            this.OEnaPrompt.Text = "Enable Context Prompt";
            this.OEnaPrompt.Click += new System.EventHandler(this.OEnaPrompt_Click);
            // 
            // OLineNum
            // 
            this.OLineNum.Name = "OLineNum";
            this.OLineNum.Text = "Line Number";
            this.OLineNum.Click += new System.EventHandler(this.OLineNum_Click);
            // 
            // OClearClip
            // 
            this.OClearClip.Name = "OClearClip";
            this.OClearClip.Text = "Clear Clipboard History";
            this.OClearClip.ToolTipText = "Xóa bảng Khay nhớ tạm";
            this.OClearClip.Click += new System.EventHandler(this.OClearClip_Click);
            // 
            // OTer
            // 
            this.OTer.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ConPow,
            this.ConCmder});
            this.OTer.Name = "OTer";
            this.OTer.Text = "Select Terminal";
            // 
            // ConPow
            // 
            this.ConPow.Name = "ConPow";
            this.ConPow.Text = "PowerShell";
            this.ConPow.Click += new System.EventHandler(this.ConC_Click);
            // 
            // ConCmder
            // 
            this.ConCmder.Name = "ConCmder";
            this.ConCmder.Text = "Cmder";
            this.ConCmder.Click += new System.EventHandler(this.ConCmder_Click);
            // 
            // OZoom
            // 
            this.OZoom.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem4,
            this.radMenuItem5,
            this.radMenuItem6,
            this.radMenuItem7,
            this.radMenuItem8,
            this.radMenuItem9,
            this.radMenuItem10,
            this.radMenuItem11,
            this.radMenuItem12});
            this.OZoom.Name = "OZoom";
            this.OZoom.Text = "Zoom";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "50%";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "75%";
            this.radMenuItem5.Click += new System.EventHandler(this.radMenuItem5_Click);
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "100%";
            this.radMenuItem6.Click += new System.EventHandler(this.radMenuItem6_Click);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "125%";
            this.radMenuItem7.Click += new System.EventHandler(this.radMenuItem7_Click);
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "150%";
            this.radMenuItem8.Click += new System.EventHandler(this.radMenuItem8_Click);
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "200%";
            this.radMenuItem9.Click += new System.EventHandler(this.radMenuItem9_Click);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "250%";
            this.radMenuItem10.Click += new System.EventHandler(this.radMenuItem10_Click);
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "350%";
            this.radMenuItem11.Click += new System.EventHandler(this.radMenuItem11_Click);
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "";
            // 
            // MHelp
            // 
            this.MHelp.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.HHowto,
            this.HLearn,
            this.HLookUp,
            this.HAbout});
            this.MHelp.Name = "MHelp";
            this.MHelp.Text = "Help";
            // 
            // HHowto
            // 
            this.HHowto.Name = "HHowto";
            this.HHowto.Text = "How to use?";
            this.HHowto.ToolTipText = "Hướng dẫn sử dụng các tính năng";
            // 
            // HLearn
            // 
            this.HLearn.BackColor = System.Drawing.Color.LightCyan;
            this.HLearn.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.LCpp,
            this.LPascal,
            this.LPython});
            this.HLearn.Name = "HLearn";
            this.HLearn.Text = "Learn to programing";
            this.HLearn.ToolTipText = "Tới các trang web dạy lập trình hay";
            this.HLearn.Click += new System.EventHandler(this.HLearn_Click);
            // 
            // LCpp
            // 
            this.LCpp.Name = "LCpp";
            this.LCpp.Text = "Learn C++ from W3 Schools";
            this.LCpp.ToolTipText = "Học C++ từ W3 Schools";
            this.LCpp.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // LPascal
            // 
            this.LPascal.Name = "LPascal";
            this.LPascal.Text = "Learn Pascal from Tutorials Point";
            this.LPascal.ToolTipText = "Học Pascal tại Tutorials Point";
            this.LPascal.Click += new System.EventHandler(this.LPascal_Click);
            // 
            // LPython
            // 
            this.LPython.Name = "LPython";
            this.LPython.Text = "Learn Python from W3 Schools";
            this.LPython.ToolTipText = "Học Python tại W3 Schools";
            this.LPython.Click += new System.EventHandler(this.LPython_Click);
            // 
            // HLookUp
            // 
            this.HLookUp.Name = "HLookUp";
            this.HLookUp.Text = "Look Up";
            this.HLookUp.Click += new System.EventHandler(this.HLookUp_Click);
            // 
            // HAbout
            // 
            this.HAbout.Name = "HAbout";
            this.HAbout.Text = "About Kaliz";
            this.HAbout.ToolTipText = "Về Kaliz...";
            this.HAbout.Click += new System.EventHandler(this.HAbout_Click);
            // 
            // DockPar
            // 
            this.DockPar.ActiveWindow = this.documentWindow1;
            this.DockPar.CausesValidation = false;
            this.DockPar.Controls.Add(this.DContainer);
            this.DockPar.Controls.Add(this.toolTabStrip1);
            this.DockPar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockPar.IsCleanUpTarget = true;
            this.DockPar.Location = new System.Drawing.Point(0, 37);
            this.DockPar.MainDocumentContainer = this.DContainer;
            this.DockPar.Name = "DockPar";
            this.DockPar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.DockPar.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.DockPar.RootElement.MinSize = new System.Drawing.Size(25, 25);
            autoHideGroup1.Windows.Add(this.dockWindowPlaceholder1);
            autoHideGroup1.Windows.Add(this.dockWindowPlaceholder2);
            autoHideGroup1.Windows.Add(this.dockWindowPlaceholder3);
            this.DockPar.SerializableAutoHideContainer.BottomAutoHideGroups.Add(autoHideGroup1);
            this.DockPar.Size = new System.Drawing.Size(1257, 698);
            this.DockPar.SplitterWidth = 8;
            this.DockPar.TabIndex = 2;
            this.DockPar.TabStop = false;
            this.DockPar.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.wlcJava);
            this.documentWindow1.Controls.Add(this.recentList);
            this.documentWindow1.Controls.Add(this.radLabel3);
            this.documentWindow1.Controls.Add(this.pictureBox1);
            this.documentWindow1.Controls.Add(this.wclOpen);
            this.documentWindow1.Controls.Add(this.wclCc);
            this.documentWindow1.Controls.Add(this.wclPython);
            this.documentWindow1.Controls.Add(this.wclPascal);
            this.documentWindow1.Controls.Add(this.radButton2);
            this.documentWindow1.Controls.Add(this.radLabel10);
            this.documentWindow1.Controls.Add(this.radLabel2);
            this.documentWindow1.Controls.Add(this.radLabel8);
            this.documentWindow1.Controls.Add(this.radLabel1);
            this.documentWindow1.Controls.Add(this.radButton1);
            this.documentWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.documentWindow1.Location = new System.Drawing.Point(4, 54);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow1.Size = new System.Drawing.Size(1249, 447);
            this.documentWindow1.Text = "Welcome";
            this.documentWindow1.Click += new System.EventHandler(this.documentWindow1_Click);
            // 
            // wlcJava
            // 
            this.wlcJava.Location = new System.Drawing.Point(9, 348);
            this.wlcJava.Name = "wlcJava";
            this.wlcJava.Size = new System.Drawing.Size(320, 36);
            this.wlcJava.TabIndex = 7;
            this.wlcJava.Text = "<html><span style=\"font-size: 11pt; font-family: segoe ui\">Create new file with <" +
    "span style=\"font-size: 11pt; color: #8000ff\"><strong>Java</strong></span> syntax" +
    "</span></html>";
            this.wlcJava.ThemeName = "MaterialTeal";
            this.wlcJava.Click += new System.EventHandler(this.wlcJava_Click);
            // 
            // recentList
            // 
            this.recentList.AllowEdit = false;
            this.recentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentList.GroupItemSize = new System.Drawing.Size(200, 36);
            this.recentList.ItemSize = new System.Drawing.Size(200, 36);
            this.recentList.Location = new System.Drawing.Point(928, 133);
            this.recentList.Name = "recentList";
            this.recentList.Size = new System.Drawing.Size(313, 269);
            this.recentList.TabIndex = 9;
            this.recentList.ThemeName = "MaterialTeal";
            this.recentList.ItemMouseDoubleClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.recentList_ItemMouseDoubleClick);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.Gray;
            this.radLabel3.Location = new System.Drawing.Point(928, 86);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(95, 41);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Recent";
            this.radLabel3.ThemeName = "MaterialTeal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Kaliz.Properties.Resources.coding__1_;
            this.pictureBox1.Location = new System.Drawing.Point(375, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // wclOpen
            // 
            this.wclOpen.Location = new System.Drawing.Point(9, 133);
            this.wclOpen.Name = "wclOpen";
            this.wclOpen.Size = new System.Drawing.Size(320, 36);
            this.wclOpen.TabIndex = 7;
            this.wclOpen.Text = "Open File";
            this.wclOpen.ThemeName = "MaterialTeal";
            this.wclOpen.Click += new System.EventHandler(this.wclOpen_Click);
            // 
            // wclCc
            // 
            this.wclCc.Location = new System.Drawing.Point(9, 295);
            this.wclCc.Name = "wclCc";
            this.wclCc.Size = new System.Drawing.Size(320, 36);
            this.wclCc.TabIndex = 6;
            this.wclCc.Text = "<html><span style=\"font-size: 11pt; font-family: segoe ui\">Create new file with <" +
    "span style=\"font-size: 11pt; color: #8000ff\"><strong>C/C++</strong></span> synta" +
    "x</span></html>";
            this.wclCc.ThemeName = "MaterialTeal";
            this.wclCc.Click += new System.EventHandler(this.wclCc_Click);
            // 
            // wclPython
            // 
            this.wclPython.Location = new System.Drawing.Point(9, 241);
            this.wclPython.Name = "wclPython";
            this.wclPython.Size = new System.Drawing.Size(320, 36);
            this.wclPython.TabIndex = 6;
            this.wclPython.Text = "<html><span style=\"font-size: 11pt; font-family: segoe ui\">Create new file with <" +
    "span style=\"font-size: 11pt; color: #8000ff\"><strong>Python</strong></span> synt" +
    "ax</span></html>";
            this.wclPython.ThemeName = "MaterialTeal";
            this.wclPython.Click += new System.EventHandler(this.wclPython_Click);
            // 
            // wclPascal
            // 
            this.wclPascal.Location = new System.Drawing.Point(9, 187);
            this.wclPascal.Name = "wclPascal";
            this.wclPascal.Size = new System.Drawing.Size(320, 36);
            this.wclPascal.TabIndex = 5;
            this.wclPascal.Text = "<html><span style=\"font-size: 11pt; font-family: segoe ui\">Create new file with <" +
    "span style=\"font-size: 11pt; color: #8000ff\"><strong>Pascal</strong></span> synt" +
    "ax</span></html>";
            this.wclPascal.ThemeName = "MaterialTeal";
            this.wclPascal.Click += new System.EventHandler(this.wclPascal_Click);
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.Location = new System.Drawing.Point(1052, 408);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(189, 36);
            this.radButton2.TabIndex = 3;
            this.radButton2.Text = "Explore GoPas Editor";
            this.radButton2.ThemeName = "MaterialTeal";
            // 
            // radLabel10
            // 
            this.radLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel10.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel10.Location = new System.Drawing.Point(928, 413);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(118, 38);
            this.radLabel10.TabIndex = 3;
            this.radLabel10.Text = "<html><p><span style=\"font-size: 36pt; color: #008080\"><span style=\"font-size: 12" +
    "pt\"><strong>Other Product?</strong></span></span></p><p><strong></strong></p></h" +
    "tml>";
            this.radLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.Gray;
            this.radLabel2.Location = new System.Drawing.Point(9, 86);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(69, 41);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Start";
            this.radLabel2.ThemeName = "MaterialTeal";
            // 
            // radLabel8
            // 
            this.radLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radLabel8.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel8.Location = new System.Drawing.Point(14, 408);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(107, 38);
            this.radLabel8.TabIndex = 2;
            this.radLabel8.Text = "<html><p><span style=\"font-size: 36pt; color: #008080\"><span style=\"font-size: 12" +
    "pt\"><strong>New to Kaliz?</strong></span></span></p><p><strong></strong></p></ht" +
    "ml>";
            this.radLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radLabel1.Controls.Add(this.radLabel6);
            this.radLabel1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.Location = new System.Drawing.Point(445, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(372, 81);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "<html><p><span style=\"font-size: 36pt; color: #008080\">Welcome to Kaliz</span></p" +
    "><p><span style=\"font-size: 36pt\"></span></p></html>";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.ForeColor = System.Drawing.Color.Gray;
            this.radLabel6.Location = new System.Drawing.Point(332, 83);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(95, 41);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "Recent";
            // 
            // radButton1
            // 
            this.radButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radButton1.Location = new System.Drawing.Point(129, 404);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(200, 36);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "See Document";
            this.radButton1.ThemeName = "MaterialTeal";
            // 
            // DContainer
            // 
            this.DContainer.CausesValidation = false;
            this.DContainer.Controls.Add(this.documentTabStrip1);
            this.DContainer.Name = "DContainer";
            // 
            // 
            // 
            this.DContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.DContainer.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 511);
            this.DContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.DContainer.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 15);
            this.DContainer.SplitterWidth = 8;
            this.DContainer.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.CausesValidation = false;
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(1257, 505);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.Doutput);
            this.toolTabStrip1.Controls.Add(this.Dclipboard);
            this.toolTabStrip1.Controls.Add(this.DClosedFiles);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 513);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.ShowItemPinButton = true;
            this.toolTabStrip1.Size = new System.Drawing.Size(1257, 185);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 185);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -15);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // Doutput
            // 
            this.Doutput.Caption = null;
            this.Doutput.Controls.Add(this.ListOutput);
            this.Doutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Doutput.Location = new System.Drawing.Point(4, 52);
            this.Doutput.Name = "Doutput";
            this.Doutput.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.Doutput.Size = new System.Drawing.Size(1249, 103);
            this.Doutput.Text = "Output";
            this.Doutput.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // ListOutput
            // 
            this.ListOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOutput.GroupItemSize = new System.Drawing.Size(200, 36);
            this.ListOutput.ItemSize = new System.Drawing.Size(200, 36);
            this.ListOutput.Location = new System.Drawing.Point(0, 0);
            this.ListOutput.Name = "ListOutput";
            this.ListOutput.Size = new System.Drawing.Size(1249, 103);
            this.ListOutput.TabIndex = 0;
            this.ListOutput.ThemeName = "MaterialTeal";
            this.ListOutput.SelectedItemChanged += new System.EventHandler(this.ListOutput_SelectedItemChanged);
            this.ListOutput.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.ListOutput_ItemMouseClick);
            // 
            // Dclipboard
            // 
            this.Dclipboard.Caption = null;
            this.Dclipboard.Controls.Add(this.radlistclip);
            this.Dclipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Dclipboard.Location = new System.Drawing.Point(4, 52);
            this.Dclipboard.Name = "Dclipboard";
            this.Dclipboard.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.Dclipboard.Size = new System.Drawing.Size(1249, 103);
            this.Dclipboard.Text = "ClipBoard";
            this.Dclipboard.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radlistclip
            // 
            this.radlistclip.AllowDragDrop = true;
            this.radlistclip.AllowEdit = false;
            this.radlistclip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radlistclip.GroupItemSize = new System.Drawing.Size(200, 36);
            this.radlistclip.ItemSize = new System.Drawing.Size(200, 36);
            this.radlistclip.Location = new System.Drawing.Point(0, 0);
            this.radlistclip.Name = "radlistclip";
            this.radlistclip.Size = new System.Drawing.Size(1249, 103);
            this.radlistclip.TabIndex = 0;
            this.radlistclip.ThemeName = "MaterialTeal";
            this.radlistclip.ItemMouseDoubleClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.radlistclip_ItemMouseDoubleClick);
            // 
            // DClosedFiles
            // 
            this.DClosedFiles.Caption = null;
            this.DClosedFiles.Controls.Add(this.listClosedFiles);
            this.DClosedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DClosedFiles.Location = new System.Drawing.Point(4, 52);
            this.DClosedFiles.Name = "DClosedFiles";
            this.DClosedFiles.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.DClosedFiles.Size = new System.Drawing.Size(1249, 103);
            this.DClosedFiles.Text = "Closed Files";
            this.DClosedFiles.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // listClosedFiles
            // 
            this.listClosedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listClosedFiles.GroupItemSize = new System.Drawing.Size(200, 36);
            this.listClosedFiles.ItemSize = new System.Drawing.Size(200, 36);
            this.listClosedFiles.Location = new System.Drawing.Point(0, 0);
            this.listClosedFiles.Name = "listClosedFiles";
            this.listClosedFiles.Size = new System.Drawing.Size(1249, 103);
            this.listClosedFiles.TabIndex = 0;
            this.listClosedFiles.ThemeName = "MaterialTeal";
            this.listClosedFiles.ItemMouseDoubleClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.listClosedFiles_ItemMouseDoubleClick);
            // 
            // MBookmark
            // 
            this.MBookmark.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.BBookmark,
            this.radMenuItem2,
            this.BRemoveAll,
            this.radMenuSeparatorItem3,
            this.BBookmarkPre,
            this.BBookmarkNext});
            this.MBookmark.Name = "MBookmark";
            this.MBookmark.Text = "Bookmark";
            // 
            // BBookmark
            // 
            this.BBookmark.HintText = "Ctrl + M";
            this.BBookmark.Name = "BBookmark";
            this.BBookmark.Text = "Add to current line";
            this.BBookmark.Click += new System.EventHandler(this.BBookmark_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.HintText = "Ctrl + Shift + M";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Remove in current line";
            this.radMenuItem2.Click += new System.EventHandler(this.BRemoveBookmark_Click);
            // 
            // BRemoveAll
            // 
            this.BRemoveAll.Name = "BRemoveAll";
            this.BRemoveAll.Text = "Remove All";
            this.BRemoveAll.Click += new System.EventHandler(this.BRemoveAll_Click);
            // 
            // radMenuSeparatorItem3
            // 
            this.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3";
            this.radMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BBookmarkPre
            // 
            this.BBookmarkPre.HintText = "Ctrl + ,";
            this.BBookmarkPre.Name = "BBookmarkPre";
            this.BBookmarkPre.Text = "Bookmark Previous";
            this.BBookmarkPre.Click += new System.EventHandler(this.BBookmarkPre_Click);
            // 
            // BBookmarkNext
            // 
            this.BBookmarkNext.HintText = "Ctrl + .";
            this.BBookmarkNext.Name = "BBookmarkNext";
            this.BBookmarkNext.Text = "Bookmark Next";
            this.BBookmarkNext.Click += new System.EventHandler(this.BBookmarkNext_Click);
            // 
            // MPersonal
            // 
            this.MPersonal.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MPcurrentline,
            this.PSelection,
            this.PEditor});
            this.MPersonal.Name = "MPersonal";
            this.MPersonal.Text = "Personalized";
            // 
            // MPcurrentline
            // 
            this.MPcurrentline.Name = "MPcurrentline";
            this.MPcurrentline.Text = "Highlight Current Line Color";
            this.MPcurrentline.Click += new System.EventHandler(this.MPcurrentline_Click);
            // 
            // PSelection
            // 
            this.PSelection.Name = "PSelection";
            this.PSelection.Text = "Selection Color";
            this.PSelection.Click += new System.EventHandler(this.PSelection_Click);
            // 
            // PEditor
            // 
            this.PEditor.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ELight,
            this.EDark,
            this.EMaterialTeal});
            this.PEditor.Name = "PEditor";
            this.PEditor.Text = "Visual Style";
            // 
            // ELight
            // 
            this.ELight.BackColor = System.Drawing.Color.Teal;
            this.ELight.FocusBorderColor = System.Drawing.Color.Teal;
            this.ELight.Name = "ELight";
            this.ELight.Text = "Fluent Light";
            this.ELight.Click += new System.EventHandler(this.ELight_Click);
            // 
            // EDark
            // 
            this.EDark.Name = "EDark";
            this.EDark.Text = "Fluent Dark";
            this.EDark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // EMaterialTeal
            // 
            this.EMaterialTeal.Name = "EMaterialTeal";
            this.EMaterialTeal.Text = "Material Teal";
            this.EMaterialTeal.Click += new System.EventHandler(this.EMatiral_Click);
            // 
            // toolTabStrip3
            // 
            this.toolTabStrip3.CanUpdateChildIndex = true;
            this.toolTabStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip3.Name = "toolTabStrip3";
            // 
            // 
            // 
            this.toolTabStrip3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip3.SelectedIndex = 0;
            this.toolTabStrip3.Size = new System.Drawing.Size(200, 200);
            this.toolTabStrip3.TabIndex = 0;
            this.toolTabStrip3.TabStop = false;
            this.toolTabStrip3.ThemeName = "MaterialTeal";
            // 
            // radMenuHeaderItem1
            // 
            this.radMenuHeaderItem1.Name = "radMenuHeaderItem1";
            this.radMenuHeaderItem1.Text = "radMenuHeaderItem1";
            // 
            // object_d76c15f1_b4da_4f3f_b911_a99b364b78fa
            // 
            this.object_d76c15f1_b4da_4f3f_b911_a99b364b78fa.Name = "object_d76c15f1_b4da_4f3f_b911_a99b364b78fa";
            this.object_d76c15f1_b4da_4f3f_b911_a99b364b78fa.StretchHorizontally = true;
            this.object_d76c15f1_b4da_4f3f_b911_a99b364b78fa.StretchVertically = true;
            // 
            // MView
            // 
            this.MView.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.VOutput,
            this.VClosedList,
            this.VClipboardList,
            this.VSplitHorizon,
            this.VSplitVertical});
            this.MView.Name = "MView";
            this.MView.Text = "View";
            // 
            // VOutput
            // 
            this.VOutput.Name = "VOutput";
            this.VOutput.Text = "Hide Output";
            this.VOutput.Click += new System.EventHandler(this.VOutput_Click);
            // 
            // VClosedList
            // 
            this.VClosedList.Name = "VClosedList";
            this.VClosedList.Text = "Hide Closed List";
            this.VClosedList.Click += new System.EventHandler(this.VClosedList_Click);
            // 
            // VClipboardList
            // 
            this.VClipboardList.Name = "VClipboardList";
            this.VClipboardList.Text = "Hide Clipboard List";
            this.VClipboardList.Click += new System.EventHandler(this.VClipboardList_Click);
            // 
            // VSplitHorizon
            // 
            this.VSplitHorizon.Name = "VSplitHorizon";
            this.VSplitHorizon.Text = "Split Horizontally";
            this.VSplitHorizon.Click += new System.EventHandler(this.radMenuItem1_Click);
            // 
            // VSplitVertical
            // 
            this.VSplitVertical.Name = "VSplitVertical";
            this.VSplitVertical.Text = "Split Vertically";
            this.VSplitVertical.Click += new System.EventHandler(this.VSplitVertical_Click);
            // 
            // MWindows
            // 
            this.MWindows.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.WFloat,
            this.WFloatAll,
            this.WDock,
            this.WCloseCur,
            this.WCloseAll,
            this.WResetWindows});
            this.MWindows.Name = "MWindows";
            this.MWindows.Text = "Window";
            // 
            // WFloat
            // 
            this.WFloat.Name = "WFloat";
            this.WFloat.Text = "Float";
            this.WFloat.Click += new System.EventHandler(this.WFloat_Click);
            // 
            // WFloatAll
            // 
            this.WFloatAll.Name = "WFloatAll";
            this.WFloatAll.Text = "Float All";
            this.WFloatAll.Click += new System.EventHandler(this.WFloatAll_Click);
            // 
            // WDock
            // 
            this.WDock.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.DockLeft,
            this.DockRight,
            this.radMenuSeparatorItem4,
            this.DockFill,
            this.radMenuSeparatorItem5,
            this.DockTop,
            this.DockBottom});
            this.WDock.Name = "WDock";
            this.WDock.Text = "Dock";
            // 
            // DockLeft
            // 
            this.DockLeft.Name = "DockLeft";
            this.DockLeft.Text = "Left";
            this.DockLeft.Click += new System.EventHandler(this.DockLeft_Click);
            // 
            // DockRight
            // 
            this.DockRight.Name = "DockRight";
            this.DockRight.Text = "Right";
            this.DockRight.Click += new System.EventHandler(this.DockRight_Click);
            // 
            // radMenuSeparatorItem4
            // 
            this.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.Text = "radMenuSeparatorItem4";
            this.radMenuSeparatorItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DockFill
            // 
            this.DockFill.Name = "DockFill";
            this.DockFill.Text = "Fill";
            this.DockFill.Click += new System.EventHandler(this.DockFill_Click);
            // 
            // radMenuSeparatorItem5
            // 
            this.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5";
            this.radMenuSeparatorItem5.Text = "radMenuSeparatorItem5";
            this.radMenuSeparatorItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DockTop
            // 
            this.DockTop.Name = "DockTop";
            this.DockTop.Text = "Top";
            this.DockTop.Click += new System.EventHandler(this.DockTop_Click);
            // 
            // DockBottom
            // 
            this.DockBottom.Name = "DockBottom";
            this.DockBottom.Text = "Bottom";
            this.DockBottom.Click += new System.EventHandler(this.DockBottom_Click);
            // 
            // WCloseCur
            // 
            this.WCloseCur.Name = "WCloseCur";
            this.WCloseCur.Text = "Close Current Document Windows";
            this.WCloseCur.Click += new System.EventHandler(this.WCloseCur_Click);
            // 
            // WCloseAll
            // 
            this.WCloseAll.Name = "WCloseAll";
            this.WCloseAll.Text = "Close All Windows";
            this.WCloseAll.Click += new System.EventHandler(this.WCloseAll_Click);
            // 
            // WResetWindows
            // 
            this.WResetWindows.Name = "WResetWindows";
            this.WResetWindows.Text = "Reset Windows";
            this.WResetWindows.Click += new System.EventHandler(this.WResetWindows_Click);
            // 
            // MenuTop
            // 
            this.MenuTop.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MFile,
            this.MEdit,
            this.MView,
            this.MTools,
            this.MBuild,
            this.MDebug,
            this.MOptions,
            this.MBookmark,
            this.MWindows,
            this.MPersonal,
            this.MHelp,
            this.radMenuItem1});
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1257, 37);
            this.MenuTop.TabIndex = 1;
            this.MenuTop.ThemeName = "MaterialTeal";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3,
            this.radMenuItem16,
            this.radMenuItem17});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Test";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "radMenuItem3";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click_3);
            // 
            // radMenuItem16
            // 
            this.radMenuItem16.Name = "radMenuItem16";
            this.radMenuItem16.Text = "radMenuItem16";
            this.radMenuItem16.Click += new System.EventHandler(this.radMenuItem16_Click_2);
            // 
            // radMenuItem17
            // 
            this.radMenuItem17.Name = "radMenuItem17";
            this.radMenuItem17.Text = "radMenuItem17";
            this.radMenuItem17.Click += new System.EventHandler(this.radMenuItem17_Click_1);
            // 
            // Kaliz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 735);
            this.Controls.Add(this.DockPar);
            this.Controls.Add(this.MenuTop);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Kaliz";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaliz - CMB Studio";
            this.ThemeName = "MaterialTeal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DockPar)).EndInit();
            this.DockPar.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            this.documentWindow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wlcJava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclCc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclPython)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wclPascal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.radLabel1.ResumeLayout(false);
            this.radLabel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DContainer)).EndInit();
            this.DContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.Doutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOutput)).EndInit();
            this.Dclipboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radlistclip)).EndInit();
            this.DClosedFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listClosedFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadMenuItem MFile;
        private Telerik.WinControls.UI.RadMenuItem MEdit;
        private Telerik.WinControls.UI.RadMenuItem MTools;
        private Telerik.WinControls.UI.RadMenuItem MBuild;
        private Telerik.WinControls.UI.RadMenuItem MDebug;
        private Telerik.WinControls.UI.RadMenuItem MOptions;
        private Telerik.WinControls.UI.RadMenuItem MHelp;
        private Telerik.WinControls.UI.RadMenuItem FNew;
        private Telerik.WinControls.UI.RadMenuItem FOpen;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem FPrint;
        private Telerik.WinControls.UI.RadMenuItem FSave;
        private Telerik.WinControls.UI.RadMenuItem FSaveAs;
        private Telerik.WinControls.UI.RadMenuItem FExport;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem2;
        private Telerik.WinControls.UI.RadMenuItem FExit;
        private Telerik.WinControls.UI.Docking.RadDock DockPar;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow Doutput;
        private Telerik.WinControls.UI.RadMenuItem ECopy;
        private Telerik.WinControls.UI.RadMenuItem ECut;
        private Telerik.WinControls.UI.RadMenuItem EPaste;
        private Telerik.WinControls.UI.RadMenuItem TFind;
        private Telerik.WinControls.UI.RadMenuItem BRun;
        private Telerik.WinControls.UI.RadMenuItem BBuild;
        private Telerik.WinControls.UI.RadMenuItem DEnable;
        private Telerik.WinControls.UI.RadMenuItem DOpenGDB;
        private Telerik.WinControls.UI.Docking.DocumentContainer DContainer;
        private Telerik.WinControls.UI.RadMenuItem MBookmark;
        private Telerik.WinControls.UI.RadMenuItem BBookmark;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem BRemoveAll;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem3;
        private Telerik.WinControls.UI.RadMenuItem TReplace;
        private Telerik.WinControls.UI.RadMenuItem TGoToLine;
        private Telerik.WinControls.UI.RadMenuItem EUndo;
        private Telerik.WinControls.UI.RadMenuItem BBookmarkPre;
        private Telerik.WinControls.UI.RadMenuItem BBookmarkNext;
        private Telerik.WinControls.UI.RadMenuItem ESelect;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadListView ListOutput;
        private Telerik.WinControls.UI.RadMenuItem OEnableContext;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadMenuItem OLock;
        private Telerik.WinControls.UI.RadMenuItem PerReadonly;
        private Telerik.WinControls.UI.RadMenuItem PerDisable;
        private Telerik.WinControls.UI.RadMenuItem OCTooltip;
        private Telerik.WinControls.UI.RadMenuItem OHightlight;
        private Telerik.WinControls.UI.RadMenuItem OEnaPrompt;
        private Telerik.WinControls.UI.RadMenuItem HHowto;
        private Telerik.WinControls.UI.RadMenuItem HLearn;
        private Telerik.WinControls.UI.RadMenuItem LCpp;
        private Telerik.WinControls.UI.RadMenuItem LPascal;
        private Telerik.WinControls.UI.RadMenuItem LPython;
        private Telerik.WinControls.UI.RadMenuItem HAbout;
        private Telerik.WinControls.UI.RadMenuItem TAscii;
        private Telerik.WinControls.UI.RadMenuItem ATable;
        private Telerik.WinControls.UI.RadMenuItem AConvert;
        private Telerik.WinControls.UI.RadMenuItem TCalc;
        private Telerik.WinControls.UI.RadMenuItem Tcmd;
        private Telerik.WinControls.UI.RadMenuItem MPersonal;
        private Telerik.WinControls.UI.RadMenuItem MPcurrentline;
        private Telerik.WinControls.UI.RadMenuItem PSelection;
        private Telerik.WinControls.UI.RadMenuItem OLineNum;
        private Telerik.WinControls.UI.RadMenuItem PEditor;
        private Telerik.WinControls.UI.RadMenuItem ELight;
        private Telerik.WinControls.UI.RadMenuItem EDark;
        private Telerik.WinControls.UI.RadMenuItem ESyntax;
        private Telerik.WinControls.UI.RadMenuItem SPascal;
        private Telerik.WinControls.UI.RadMenuItem SynC;
        private Telerik.WinControls.UI.RadMenuItem SynPython;
        private Telerik.WinControls.UI.RadMenuItem EStart;
        private Telerik.WinControls.UI.RadMenuItem EEnd;
        private Telerik.WinControls.UI.RadMenuItem EIndent;
        private Telerik.WinControls.UI.RadMenuItem FindDia;
        private Telerik.WinControls.UI.RadMenuItem FFindSelected;
        private Telerik.WinControls.UI.RadMenuItem EOutdent;
        private Telerik.WinControls.UI.RadMenuItem TTermi;
        private RadMenuItem ERedo;
        private RadMenuItem EFold;
        private RadMenuItem FFold;
        private RadMenuItem FUnfold;
        private RadMenuItem FFoldAll;
        private RadMenuItem FFUnfoldAll;
        private RadMenuItem TEmail;
        private Telerik.WinControls.UI.Docking.ToolWindow Dclipboard;
        private RadListView radlistclip;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip3;
        private RadMenuItem OClearClip;
        private RadMenuItem EMaterialTeal;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private RadMenuItem OTer;
        private RadMenuItem ConPow;
        private RadMenuItem ConCmder;
        private RadMenuItem OZoom;
        private RadMenuItem radMenuItem4;
        private RadMenuItem radMenuItem5;
        private RadMenuItem radMenuItem6;
        private RadMenuItem radMenuItem7;
        private RadMenuItem radMenuItem8;
        private RadMenuItem radMenuItem9;
        private RadMenuItem radMenuItem10;
        private RadMenuItem radMenuItem11;
        private RadMenuItem radMenuItem12;
        private RadMenuHeaderItem radMenuHeaderItem1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private RadMenuItem BBuildaRun;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private RadLabel radLabel2;
        private RadLabel radLabel1;
        private RadLabel radLabel6;
        private RadLabel radLabel8;
        private RadButton radButton1;
        //private RadListView recentList;
        private RadButton radButton2;
        private RadLabel radLabel10;
        private RootRadElement object_d76c15f1_b4da_4f3f_b911_a99b364b78fa;
        private RadMenuItem HLookUp;
        private RadMenuItem radMenuItem13;
        private RadMenuItem radMenuItem14;
        private RadMenuItem radMenuItem15;
        private RadMenuItem TDiff;
        private RadMenuItem DSetDiff;
        private RadMenuItem DOpenDiff;
        private RadMenuItem DDiffDialog;
        private RadMenuItem ESwitch;
        private RadMenuItem SwitchNext;
        private RadMenuItem SwitchPrevious;
        private Telerik.WinControls.UI.Docking.ToolWindow DClosedFiles;
        private RadListView listClosedFiles;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder1;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder2;
        private Telerik.WinControls.UI.Docking.DockWindowPlaceholder dockWindowPlaceholder3;
        private RadButton wclCc;
        private RadButton wclPython;
        private RadButton wclPascal;
        private RadButton wclOpen;
        private PictureBox pictureBox1;
        private RadListView recentList;
        private RadLabel radLabel3;
        private RadMenuItem MView;
        private RadMenuItem VOutput;
        private RadMenuItem VClosedList;
        private RadMenuItem VClipboardList;
        private RadMenuItem VSplitHorizon;
        private RadMenuItem VSplitVertical;
        private RadMenuItem DeJDB;
        private RadButton wlcJava;
        private RadMenuItem SynJava;
        private RadMenuItem FReopen;
        private RadMenuItem EncodeUTF8;
        private RadMenuItem EncodeUS;
        private RadMenuItem MWindows;
        private RadMenuItem WFloat;
        private RadMenuItem WFloatAll;
        private RadMenuItem WDock;
        private RadMenuItem Encode1252;
        private RadMenuItem WCloseAll;
        private RadMenuItem WResetWindows;
        private RadMenuItem WCloseCur;
        private RadMenuItem DockLeft;
        private RadMenuItem DockRight;
        private RadMenuSeparatorItem radMenuSeparatorItem4;
        private RadMenuItem DockFill;
        private RadMenuSeparatorItem radMenuSeparatorItem5;
        private RadMenuItem DockTop;
        private RadMenuItem DockBottom;
        private RadMenu MenuTop;
        private RadMenuItem radMenuItem1;
        private RadMenuItem radMenuItem3;
        private RadMenuItem radMenuItem16;
        private RadMenuItem radMenuItem17;
        private RadMenuItem DebugPython;
        private RadMenuItem BPara;
        private RadMenuItem BConfig;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
    }
}