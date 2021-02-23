
namespace WaypointCreatorGen2
{
    partial class WaypointCreator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EditorGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orientation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteAboveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteBelowStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateSQLStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditorListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditorWaypointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EditorToolStrip = new System.Windows.Forms.ToolStrip();
            this.EditorImportSniffButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditorFilterEntryTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.EditorFilterEntryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditorLoadingLabel = new System.Windows.Forms.ToolStripLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SQLOutputTextBox = new System.Windows.Forms.TextBox();
            this.SQLOutputToolStrip = new System.Windows.Forms.ToolStrip();
            this.SQLOutputSaveButton = new System.Windows.Forms.ToolStripButton();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorGridView)).BeginInit();
            this.GridViewContextMenuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorWaypointChart)).BeginInit();
            this.EditorToolStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SQLOutputToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1310, 563);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.EditorToolStrip);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1302, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EditorGridView);
            this.groupBox3.Location = new System.Drawing.Point(726, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 500);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Table";
            // 
            // EditorGridView
            // 
            this.EditorGridView.AllowUserToAddRows = false;
            this.EditorGridView.AllowUserToDeleteRows = false;
            this.EditorGridView.AllowUserToResizeColumns = false;
            this.EditorGridView.AllowUserToResizeRows = false;
            this.EditorGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EditorGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.EditorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PositionX,
            this.PositionY,
            this.PositionZ,
            this.Orientation,
            this.MoveTime,
            this.Delay});
            this.EditorGridView.ContextMenuStrip = this.GridViewContextMenuStrip;
            this.EditorGridView.Location = new System.Drawing.Point(7, 14);
            this.EditorGridView.Name = "EditorGridView";
            this.EditorGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EditorGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditorGridView.Size = new System.Drawing.Size(553, 472);
            this.EditorGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ID.Width = 50;
            // 
            // PositionX
            // 
            dataGridViewCellStyle1.NullValue = "0.0";
            this.PositionX.DefaultCellStyle = dataGridViewCellStyle1;
            this.PositionX.HeaderText = "PositionX";
            this.PositionX.Name = "PositionX";
            this.PositionX.ReadOnly = true;
            this.PositionX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PositionX.Width = 80;
            // 
            // PositionY
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.PositionY.DefaultCellStyle = dataGridViewCellStyle2;
            this.PositionY.HeaderText = "PositionY";
            this.PositionY.Name = "PositionY";
            this.PositionY.ReadOnly = true;
            this.PositionY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PositionY.Width = 80;
            // 
            // PositionZ
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.PositionZ.DefaultCellStyle = dataGridViewCellStyle3;
            this.PositionZ.HeaderText = "PositionZ";
            this.PositionZ.Name = "PositionZ";
            this.PositionZ.ReadOnly = true;
            this.PositionZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PositionZ.Width = 80;
            // 
            // Orientation
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.Orientation.DefaultCellStyle = dataGridViewCellStyle4;
            this.Orientation.HeaderText = "Orientation";
            this.Orientation.Name = "Orientation";
            this.Orientation.ReadOnly = true;
            this.Orientation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Orientation.Width = 80;
            // 
            // MoveTime
            // 
            this.MoveTime.HeaderText = "MoveTime";
            this.MoveTime.Name = "MoveTime";
            this.MoveTime.ReadOnly = true;
            this.MoveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MoveTime.Width = 80;
            // 
            // Delay
            // 
            this.Delay.HeaderText = "Delay";
            this.Delay.Name = "Delay";
            this.Delay.ReadOnly = true;
            this.Delay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Delay.Width = 80;
            // 
            // GridViewContextMenuStrip
            // 
            this.GridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutStripMenuItem,
            this.CopyStripMenuItem,
            this.PasteAboveStripMenuItem,
            this.PasteBelowStripMenuItem,
            this.GenerateSQLStripMenuItem});
            this.GridViewContextMenuStrip.Name = "GridViewContextMenuStrip";
            this.GridViewContextMenuStrip.Size = new System.Drawing.Size(146, 114);
            // 
            // CutStripMenuItem
            // 
            this.CutStripMenuItem.Name = "CutStripMenuItem";
            this.CutStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.CutStripMenuItem.Text = "Cut";
            this.CutStripMenuItem.Click += new System.EventHandler(this.CutStripMenuItem_Click);
            // 
            // CopyStripMenuItem
            // 
            this.CopyStripMenuItem.Name = "CopyStripMenuItem";
            this.CopyStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.CopyStripMenuItem.Text = "Copy";
            this.CopyStripMenuItem.Click += new System.EventHandler(this.CopyStripMenuItem_Click);
            // 
            // PasteAboveStripMenuItem
            // 
            this.PasteAboveStripMenuItem.Name = "PasteAboveStripMenuItem";
            this.PasteAboveStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.PasteAboveStripMenuItem.Text = "Paste Above";
            this.PasteAboveStripMenuItem.Click += new System.EventHandler(this.PasteAboveStripMenuItem_Click);
            // 
            // PasteBelowStripMenuItem
            // 
            this.PasteBelowStripMenuItem.Name = "PasteBelowStripMenuItem";
            this.PasteBelowStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.PasteBelowStripMenuItem.Text = "Paste Below";
            this.PasteBelowStripMenuItem.Click += new System.EventHandler(this.PasteBelowStripMenuItem_Click);
            // 
            // GenerateSQLStripMenuItem
            // 
            this.GenerateSQLStripMenuItem.Name = "GenerateSQLStripMenuItem";
            this.GenerateSQLStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.GenerateSQLStripMenuItem.Text = "Generate SQL";
            this.GenerateSQLStripMenuItem.Click += new System.EventHandler(this.GenerateSQLStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditorListBox);
            this.groupBox2.Location = new System.Drawing.Point(513, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 500);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Found Entries";
            // 
            // EditorListBox
            // 
            this.EditorListBox.FormattingEnabled = true;
            this.EditorListBox.Location = new System.Drawing.Point(7, 14);
            this.EditorListBox.Name = "EditorListBox";
            this.EditorListBox.Size = new System.Drawing.Size(194, 472);
            this.EditorListBox.TabIndex = 0;
            this.EditorListBox.SelectedValueChanged += new System.EventHandler(this.EditorListBox_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditorWaypointChart);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 500);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waypoint Visualization";
            // 
            // EditorWaypointChart
            // 
            this.EditorWaypointChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.EditorWaypointChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.EditorWaypointChart.Legends.Add(legend1);
            this.EditorWaypointChart.Location = new System.Drawing.Point(6, 14);
            this.EditorWaypointChart.Name = "EditorWaypointChart";
            this.EditorWaypointChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Path";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Line";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.EditorWaypointChart.Series.Add(series1);
            this.EditorWaypointChart.Series.Add(series2);
            this.EditorWaypointChart.Size = new System.Drawing.Size(480, 480);
            this.EditorWaypointChart.TabIndex = 1;
            this.EditorWaypointChart.Text = "chart1";
            // 
            // EditorToolStrip
            // 
            this.EditorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorImportSniffButton,
            this.toolStripSeparator1,
            this.EditorFilterEntryTextBox,
            this.EditorFilterEntryButton,
            this.toolStripSeparator2,
            this.EditorLoadingLabel});
            this.EditorToolStrip.Location = new System.Drawing.Point(3, 3);
            this.EditorToolStrip.Name = "EditorToolStrip";
            this.EditorToolStrip.Size = new System.Drawing.Size(1296, 25);
            this.EditorToolStrip.TabIndex = 0;
            this.EditorToolStrip.Text = "toolStrip1";
            // 
            // EditorImportSniffButton
            // 
            this.EditorImportSniffButton.Image = global::WaypointCreatorGen2.Properties.Resources.PIC_Import;
            this.EditorImportSniffButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditorImportSniffButton.Name = "EditorImportSniffButton";
            this.EditorImportSniffButton.Size = new System.Drawing.Size(128, 22);
            this.EditorImportSniffButton.Text = "Import Parsed Sniff";
            this.EditorImportSniffButton.ToolTipText = "Loads a parsed sniff .txt file and generates waypoint data from it. You can obtai" +
    "n such .txt files by parsing .pkt sniff files with the WoW Packet Parser of Trin" +
    "ityCore.";
            this.EditorImportSniffButton.Click += new System.EventHandler(this.EditorImportSniffButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditorFilterEntryTextBox
            // 
            this.EditorFilterEntryTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.EditorFilterEntryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditorFilterEntryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditorFilterEntryTextBox.Name = "EditorFilterEntryTextBox";
            this.EditorFilterEntryTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EditorFilterEntryTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // EditorFilterEntryButton
            // 
            this.EditorFilterEntryButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.EditorFilterEntryButton.Image = global::WaypointCreatorGen2.Properties.Resources.PIC_Search;
            this.EditorFilterEntryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditorFilterEntryButton.Name = "EditorFilterEntryButton";
            this.EditorFilterEntryButton.Size = new System.Drawing.Size(91, 22);
            this.EditorFilterEntryButton.Text = "Filter Entries";
            this.EditorFilterEntryButton.ToolTipText = "Filters the listed GUID values by CreatureID. If no or an invalid value is specif" +
    "ied it will list all entries.";
            this.EditorFilterEntryButton.Click += new System.EventHandler(this.EditorFilterEntryButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EditorLoadingLabel
            // 
            this.EditorLoadingLabel.Name = "EditorLoadingLabel";
            this.EditorLoadingLabel.Size = new System.Drawing.Size(110, 22);
            this.EditorLoadingLabel.Text = "No sniff file loaded.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SQLOutputTextBox);
            this.tabPage2.Controls.Add(this.SQLOutputToolStrip);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1302, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SQLOutputTextBox
            // 
            this.SQLOutputTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLOutputTextBox.Location = new System.Drawing.Point(6, 31);
            this.SQLOutputTextBox.Multiline = true;
            this.SQLOutputTextBox.Name = "SQLOutputTextBox";
            this.SQLOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQLOutputTextBox.Size = new System.Drawing.Size(1287, 500);
            this.SQLOutputTextBox.TabIndex = 1;
            // 
            // SQLOutputToolStrip
            // 
            this.SQLOutputToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SQLOutputSaveButton});
            this.SQLOutputToolStrip.Location = new System.Drawing.Point(3, 3);
            this.SQLOutputToolStrip.Name = "SQLOutputToolStrip";
            this.SQLOutputToolStrip.Size = new System.Drawing.Size(1296, 25);
            this.SQLOutputToolStrip.TabIndex = 0;
            this.SQLOutputToolStrip.Text = "toolStrip1";
            // 
            // SQLOutputSaveButton
            // 
            this.SQLOutputSaveButton.Image = global::WaypointCreatorGen2.Properties.Resources.PIC_Write;
            this.SQLOutputSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SQLOutputSaveButton.Name = "SQLOutputSaveButton";
            this.SQLOutputSaveButton.Size = new System.Drawing.Size(110, 22);
            this.SQLOutputSaveButton.Text = "Save as SQL File";
            this.SQLOutputSaveButton.Click += new System.EventHandler(this.SQLOutputSaveButton_Click);
            // 
            // WaypointCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 586);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WaypointCreator";
            this.Text = "Waypoint Creator Gen2";
            this.Load += new System.EventHandler(this.WaypointCreator_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditorGridView)).EndInit();
            this.GridViewContextMenuStrip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditorWaypointChart)).EndInit();
            this.EditorToolStrip.ResumeLayout(false);
            this.EditorToolStrip.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.SQLOutputToolStrip.ResumeLayout(false);
            this.SQLOutputToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip SQLOutputToolStrip;
        private System.Windows.Forms.ToolStripButton SQLOutputSaveButton;
        private System.Windows.Forms.TextBox SQLOutputTextBox;
        private System.Windows.Forms.ToolStrip EditorToolStrip;
        private System.Windows.Forms.ToolStripButton EditorImportSniffButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart EditorWaypointChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripTextBox EditorFilterEntryTextBox;
        private System.Windows.Forms.ToolStripButton EditorFilterEntryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListBox EditorListBox;
        private System.Windows.Forms.DataGridView EditorGridView;
        private System.Windows.Forms.ToolStripLabel EditorLoadingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orientation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.ContextMenuStrip GridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteAboveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteBelowStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerateSQLStripMenuItem;
    }
}

