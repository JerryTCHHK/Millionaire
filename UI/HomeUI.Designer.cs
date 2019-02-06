namespace Millionaire.UI
{
    partial class HomeUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playSettingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.audienceSizeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.numberOfPlayerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.numberOfPlayerLabel = new MetroFramework.Controls.MetroLabel();
            this.QuestionTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.questionTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.homeButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startGameButton = new MetroFramework.Controls.MetroButton();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.HomeTableLayoutPanel.SuspendLayout();
            this.playSettingTableLayoutPanel.SuspendLayout();
            this.homeButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeTableLayoutPanel
            // 
            this.HomeTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.HomeTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HomeTableLayoutPanel.ColumnCount = 2;
            this.HomeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.76965F));
            this.HomeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.23035F));
            this.HomeTableLayoutPanel.Controls.Add(this.playSettingTableLayoutPanel, 0, 0);
            this.HomeTableLayoutPanel.Controls.Add(this.homeButtonTableLayoutPanel, 1, 0);
            this.HomeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HomeTableLayoutPanel.Name = "HomeTableLayoutPanel";
            this.HomeTableLayoutPanel.RowCount = 1;
            this.HomeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HomeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.HomeTableLayoutPanel.Size = new System.Drawing.Size(738, 388);
            this.HomeTableLayoutPanel.TabIndex = 0;
            // 
            // playSettingTableLayoutPanel
            // 
            this.playSettingTableLayoutPanel.ColumnCount = 2;
            this.playSettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.72269F));
            this.playSettingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.27731F));
            this.playSettingTableLayoutPanel.Controls.Add(this.audienceSizeComboBox, 1, 2);
            this.playSettingTableLayoutPanel.Controls.Add(this.numberOfPlayerComboBox, 1, 1);
            this.playSettingTableLayoutPanel.Controls.Add(this.metroLabel3, 0, 2);
            this.playSettingTableLayoutPanel.Controls.Add(this.numberOfPlayerLabel, 0, 1);
            this.playSettingTableLayoutPanel.Controls.Add(this.QuestionTypeLabel, 0, 0);
            this.playSettingTableLayoutPanel.Controls.Add(this.questionTypeComboBox, 1, 0);
            this.playSettingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playSettingTableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.playSettingTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.playSettingTableLayoutPanel.Name = "playSettingTableLayoutPanel";
            this.playSettingTableLayoutPanel.RowCount = 3;
            this.playSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playSettingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.playSettingTableLayoutPanel.Size = new System.Drawing.Size(476, 386);
            this.playSettingTableLayoutPanel.TabIndex = 0;
            // 
            // audienceSizeComboBox
            // 
            this.audienceSizeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audienceSizeComboBox.FormattingEnabled = true;
            this.audienceSizeComboBox.ItemHeight = 23;
            this.audienceSizeComboBox.Items.AddRange(new object[] {
            "100",
            "500",
            "1000",
            "5000"});
            this.audienceSizeComboBox.Location = new System.Drawing.Point(161, 306);
            this.audienceSizeComboBox.Margin = new System.Windows.Forms.Padding(10, 50, 10, 0);
            this.audienceSizeComboBox.Name = "audienceSizeComboBox";
            this.audienceSizeComboBox.Size = new System.Drawing.Size(305, 29);
            this.audienceSizeComboBox.TabIndex = 8;
            this.audienceSizeComboBox.UseSelectable = true;
            this.audienceSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.audienceSizeComboBox_SelectedIndexChanged);
            // 
            // numberOfPlayerComboBox
            // 
            this.numberOfPlayerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPlayerComboBox.FormattingEnabled = true;
            this.numberOfPlayerComboBox.ItemHeight = 23;
            this.numberOfPlayerComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numberOfPlayerComboBox.Location = new System.Drawing.Point(161, 178);
            this.numberOfPlayerComboBox.Margin = new System.Windows.Forms.Padding(10, 50, 10, 0);
            this.numberOfPlayerComboBox.Name = "numberOfPlayerComboBox";
            this.numberOfPlayerComboBox.Size = new System.Drawing.Size(305, 29);
            this.numberOfPlayerComboBox.TabIndex = 7;
            this.numberOfPlayerComboBox.UseSelectable = true;
            this.numberOfPlayerComboBox.SelectedIndexChanged += new System.EventHandler(this.numberOfPlayerComboBox_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.Location = new System.Drawing.Point(3, 256);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(145, 130);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Audience Size : ";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfPlayerLabel
            // 
            this.numberOfPlayerLabel.AutoSize = true;
            this.numberOfPlayerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOfPlayerLabel.Location = new System.Drawing.Point(3, 128);
            this.numberOfPlayerLabel.Name = "numberOfPlayerLabel";
            this.numberOfPlayerLabel.Size = new System.Drawing.Size(145, 128);
            this.numberOfPlayerLabel.TabIndex = 2;
            this.numberOfPlayerLabel.Text = "Number of Players : ";
            this.numberOfPlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionTypeLabel
            // 
            this.QuestionTypeLabel.AutoSize = true;
            this.QuestionTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.QuestionTypeLabel.Name = "QuestionTypeLabel";
            this.QuestionTypeLabel.Size = new System.Drawing.Size(145, 128);
            this.QuestionTypeLabel.TabIndex = 0;
            this.QuestionTypeLabel.Text = "Question Type : ";
            this.QuestionTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionTypeComboBox.FormattingEnabled = true;
            this.questionTypeComboBox.ItemHeight = 23;
            this.questionTypeComboBox.Location = new System.Drawing.Point(161, 50);
            this.questionTypeComboBox.Margin = new System.Windows.Forms.Padding(10, 50, 10, 0);
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(305, 29);
            this.questionTypeComboBox.TabIndex = 6;
            this.questionTypeComboBox.UseSelectable = true;
            this.questionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.questionTypeComboBox_SelectedIndexChanged);
            // 
            // homeButtonTableLayoutPanel
            // 
            this.homeButtonTableLayoutPanel.ColumnCount = 1;
            this.homeButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.homeButtonTableLayoutPanel.Controls.Add(this.startGameButton, 0, 1);
            this.homeButtonTableLayoutPanel.Controls.Add(this.exitButton, 0, 2);
            this.homeButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeButtonTableLayoutPanel.Location = new System.Drawing.Point(481, 4);
            this.homeButtonTableLayoutPanel.Name = "homeButtonTableLayoutPanel";
            this.homeButtonTableLayoutPanel.RowCount = 4;
            this.homeButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.homeButtonTableLayoutPanel.Size = new System.Drawing.Size(253, 380);
            this.homeButtonTableLayoutPanel.TabIndex = 1;
            // 
            // startGameButton
            // 
            this.startGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startGameButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.startGameButton.Location = new System.Drawing.Point(10, 105);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(10);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(233, 75);
            this.startGameButton.TabIndex = 0;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseSelectable = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exitButton.Location = new System.Drawing.Point(10, 200);
            this.exitButton.Margin = new System.Windows.Forms.Padding(10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(233, 75);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseSelectable = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomeTableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "HomeUI";
            this.Size = new System.Drawing.Size(738, 388);
            this.HomeTableLayoutPanel.ResumeLayout(false);
            this.playSettingTableLayoutPanel.ResumeLayout(false);
            this.playSettingTableLayoutPanel.PerformLayout();
            this.homeButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel HomeTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel playSettingTableLayoutPanel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel numberOfPlayerLabel;
        private MetroFramework.Controls.MetroLabel QuestionTypeLabel;
        private System.Windows.Forms.TableLayoutPanel homeButtonTableLayoutPanel;
        private MetroFramework.Controls.MetroButton startGameButton;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroComboBox audienceSizeComboBox;
        private MetroFramework.Controls.MetroComboBox numberOfPlayerComboBox;
        private MetroFramework.Controls.MetroComboBox questionTypeComboBox;
    }
}
