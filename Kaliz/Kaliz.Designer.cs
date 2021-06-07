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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Line");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "File");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaliz));
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.MFile = new Telerik.WinControls.UI.RadMenuItem();
            this.FNew = new Telerik.WinControls.UI.RadMenuItem();
            this.FOpen = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.FPrint = new Telerik.WinControls.UI.RadMenuItem();
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
            this.EStart = new Telerik.WinControls.UI.RadMenuItem();
            this.EEnd = new Telerik.WinControls.UI.RadMenuItem();
            this.EIndent = new Telerik.WinControls.UI.RadMenuItem();
            this.EOutdent = new Telerik.WinControls.UI.RadMenuItem();
            this.EFold = new Telerik.WinControls.UI.RadMenuItem();
            this.FFold = new Telerik.WinControls.UI.RadMenuItem();
            this.FUnfold = new Telerik.WinControls.UI.RadMenuItem();
            this.FFoldAll = new Telerik.WinControls.UI.RadMenuItem();
            this.FFUnfoldAll = new Telerik.WinControls.UI.RadMenuItem();
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
            this.TPowerShell = new Telerik.WinControls.UI.RadMenuItem();
            this.MBuild = new Telerik.WinControls.UI.RadMenuItem();
            this.BRun = new Telerik.WinControls.UI.RadMenuItem();
            this.BBuild = new Telerik.WinControls.UI.RadMenuItem();
            this.MDebug = new Telerik.WinControls.UI.RadMenuItem();
            this.DEnable = new Telerik.WinControls.UI.RadMenuItem();
            this.DOpenGDB = new Telerik.WinControls.UI.RadMenuItem();
            this.MOptions = new Telerik.WinControls.UI.RadMenuItem();
            this.OEnableContext = new Telerik.WinControls.UI.RadMenuItem();
            this.OLock = new Telerik.WinControls.UI.RadMenuItem();
            this.PerReadonly = new Telerik.WinControls.UI.RadMenuItem();
            this.PerDisable = new Telerik.WinControls.UI.RadMenuItem();
            this.OCTooltip = new Telerik.WinControls.UI.RadMenuItem();
            this.OHightlight = new Telerik.WinControls.UI.RadMenuItem();
            this.OEnaPrompt = new Telerik.WinControls.UI.RadMenuItem();
            this.OLineNum = new Telerik.WinControls.UI.RadMenuItem();
            this.MHelp = new Telerik.WinControls.UI.RadMenuItem();
            this.HHowto = new Telerik.WinControls.UI.RadMenuItem();
            this.HLearn = new Telerik.WinControls.UI.RadMenuItem();
            this.LCpp = new Telerik.WinControls.UI.RadMenuItem();
            this.LPascal = new Telerik.WinControls.UI.RadMenuItem();
            this.LPython = new Telerik.WinControls.UI.RadMenuItem();
            this.HAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.DockPar = new Telerik.WinControls.UI.Docking.RadDock();
            this.Doutput = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.ListOutput = new Telerik.WinControls.UI.RadListView();
            this.DContainer = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.BMList = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.ListBm = new Telerik.WinControls.UI.RadListView();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.DockPar)).BeginInit();
            this.DockPar.SuspendLayout();
            this.Doutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.BMList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MFile
            // 
            this.MFile.BackColor = System.Drawing.Color.White;
            this.MFile.BorderHighlightColor = System.Drawing.Color.White;
            this.MFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.FNew,
            this.FOpen,
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
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FPrint
            // 
            this.FPrint.HintText = "Ctrl + P";
            this.FPrint.Name = "FPrint";
            this.FPrint.Text = "Print";
            this.FPrint.Click += new System.EventHandler(this.FPrint_Click);
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
            this.EFold});
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
            this.SynPython});
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
            // MTools
            // 
            this.MTools.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.TFind,
            this.TReplace,
            this.TGoToLine,
            this.TAscii,
            this.TCalc,
            this.Tcmd,
            this.TPowerShell});
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
            // TPowerShell
            // 
            this.TPowerShell.HintText = "Ctrl + Alt + T";
            this.TPowerShell.Name = "TPowerShell";
            this.TPowerShell.Text = "Windows PowerShell";
            this.TPowerShell.Click += new System.EventHandler(this.TPowerShell_Click);
            // 
            // MBuild
            // 
            this.MBuild.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.BRun,
            this.BBuild});
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
            // MDebug
            // 
            this.MDebug.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.DEnable,
            this.DOpenGDB});
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
            this.DOpenGDB.Text = "Open GDB Debug";
            this.DOpenGDB.Click += new System.EventHandler(this.DOpenGDB_Click);
            // 
            // MOptions
            // 
            this.MOptions.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.OEnableContext,
            this.OLock,
            this.OCTooltip,
            this.OHightlight,
            this.OEnaPrompt,
            this.OLineNum});
            this.MOptions.Name = "MOptions";
            this.MOptions.Text = "Options";
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
            this.OHightlight.Text = "Hightlight Current line";
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
            // MHelp
            // 
            this.MHelp.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.HHowto,
            this.HLearn,
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
            // HAbout
            // 
            this.HAbout.Name = "HAbout";
            this.HAbout.Text = "About Kaliz";
            this.HAbout.ToolTipText = "Về Kaliz...";
            this.HAbout.Click += new System.EventHandler(this.HAbout_Click);
            // 
            // DockPar
            // 
            this.DockPar.ActiveWindow = this.Doutput;
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
            this.DockPar.Size = new System.Drawing.Size(1259, 466);
            this.DockPar.SplitterWidth = 8;
            this.DockPar.TabIndex = 2;
            this.DockPar.TabStop = false;
            this.DockPar.ThemeName = "MaterialTeal";
            // 
            // Doutput
            // 
            this.Doutput.Caption = null;
            this.Doutput.Controls.Add(this.ListOutput);
            this.Doutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Doutput.Location = new System.Drawing.Point(4, 52);
            this.Doutput.Name = "Doutput";
            this.Doutput.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.Doutput.Size = new System.Drawing.Size(1251, 99);
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
            this.ListOutput.Size = new System.Drawing.Size(1251, 99);
            this.ListOutput.TabIndex = 0;
            this.ListOutput.ThemeName = "MaterialTeal";
            this.ListOutput.SelectedItemChanged += new System.EventHandler(this.ListOutput_SelectedItemChanged);
            this.ListOutput.ItemMouseClick += new Telerik.WinControls.UI.ListViewItemEventHandler(this.ListOutput_ItemMouseClick);
            // 
            // DContainer
            // 
            this.DContainer.Name = "DContainer";
            // 
            // 
            // 
            this.DContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.DContainer.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 500);
            this.DContainer.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.DContainer.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 19);
            this.DContainer.SplitterWidth = 8;
            this.DContainer.ThemeName = "MaterialTeal";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.CausesValidation = false;
            this.toolTabStrip1.Controls.Add(this.Doutput);
            this.toolTabStrip1.Controls.Add(this.BMList);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 285);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(1259, 181);
            this.toolTabStrip1.SizeInfo.AbsoluteSize = new System.Drawing.Size(200, 181);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -19);
            this.toolTabStrip1.TabIndex = 1;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "MaterialTeal";
            // 
            // BMList
            // 
            this.BMList.Caption = null;
            this.BMList.Controls.Add(this.ListBm);
            this.BMList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BMList.Location = new System.Drawing.Point(4, 52);
            this.BMList.Name = "BMList";
            this.BMList.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.BMList.Size = new System.Drawing.Size(1085, 99);
            this.BMList.Text = "Bookmark List";
            this.BMList.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // ListBm
            // 
            this.ListBm.AllowEdit = false;
            this.ListBm.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Line";
            listViewDetailColumn2.HeaderText = "File";
            this.ListBm.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2});
            this.ListBm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBm.GroupItemSize = new System.Drawing.Size(200, 32);
            this.ListBm.ItemSize = new System.Drawing.Size(200, 32);
            this.ListBm.ItemSpacing = -1;
            this.ListBm.Location = new System.Drawing.Point(0, 0);
            this.ListBm.Name = "ListBm";
            this.ListBm.Size = new System.Drawing.Size(1085, 99);
            this.ListBm.TabIndex = 0;
            this.ListBm.ThemeName = "MaterialTeal";
            this.ListBm.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Test";
            this.radMenuItem1.Click += new System.EventHandler(this.radMenuItem1_Click_1);
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
            this.EDark});
            this.PEditor.Name = "PEditor";
            this.PEditor.Text = "Editor Appearance";
            // 
            // ELight
            // 
            this.ELight.BackColor = System.Drawing.Color.Teal;
            this.ELight.FocusBorderColor = System.Drawing.Color.Teal;
            this.ELight.Name = "ELight";
            this.ELight.Text = "Light";
            this.ELight.Click += new System.EventHandler(this.ELight_Click);
            // 
            // EDark
            // 
            this.EDark.Name = "EDark";
            this.EDark.Text = "Dark";
            this.EDark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.MFile,
            this.MEdit,
            this.MTools,
            this.MBuild,
            this.MDebug,
            this.MOptions,
            this.MBookmark,
            this.MHelp,
            this.radMenuItem1,
            this.MPersonal});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1259, 37);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.ThemeName = "MaterialTeal";
            // 
            // Kaliz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 503);
            this.Controls.Add(this.DockPar);
            this.Controls.Add(this.radMenu1);
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
            this.Doutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.BMList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
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
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
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
        private Telerik.WinControls.UI.Docking.ToolWindow BMList;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadListView ListOutput;
        private Telerik.WinControls.UI.RadMenuItem OEnableContext;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadMenuItem OLock;
        private Telerik.WinControls.UI.RadMenuItem PerReadonly;
        private Telerik.WinControls.UI.RadMenuItem PerDisable;
        private Telerik.WinControls.UI.RadMenuItem OCTooltip;
        private Telerik.WinControls.UI.RadListView ListBm;
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
        private Telerik.WinControls.UI.RadMenuItem TPowerShell;
        private RadMenuItem ERedo;
        private RadMenuItem EFold;
        private RadMenuItem FFold;
        private RadMenuItem FUnfold;
        private RadMenuItem FFoldAll;
        private RadMenuItem FFUnfoldAll;
        private RadMenu radMenu1;
    }
}