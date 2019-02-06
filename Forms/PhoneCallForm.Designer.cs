namespace Millionaire.Forms
{
    partial class PhoneCallForm
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
            this.components = new System.ComponentModel.Container();
            this.phoneCallFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.phoneListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.jerryButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.friendButton = new System.Windows.Forms.Button();
            this.selectionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.callButton = new System.Windows.Forms.Button();
            this.callLabel = new MetroFramework.Controls.MetroLabel();
            this.callingTimer = new System.Windows.Forms.Timer(this.components);
            this.phoneCallFormTableLayoutPanel.SuspendLayout();
            this.phoneListTableLayoutPanel.SuspendLayout();
            this.selectionTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneCallFormTableLayoutPanel
            // 
            this.phoneCallFormTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.phoneCallFormTableLayoutPanel.ColumnCount = 2;
            this.phoneCallFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.56881F));
            this.phoneCallFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.43119F));
            this.phoneCallFormTableLayoutPanel.Controls.Add(this.phoneListTableLayoutPanel, 0, 0);
            this.phoneCallFormTableLayoutPanel.Controls.Add(this.selectionTableLayoutPanel, 1, 0);
            this.phoneCallFormTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneCallFormTableLayoutPanel.Location = new System.Drawing.Point(20, 60);
            this.phoneCallFormTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneCallFormTableLayoutPanel.Name = "phoneCallFormTableLayoutPanel";
            this.phoneCallFormTableLayoutPanel.RowCount = 1;
            this.phoneCallFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.48837F));
            this.phoneCallFormTableLayoutPanel.Size = new System.Drawing.Size(436, 236);
            this.phoneCallFormTableLayoutPanel.TabIndex = 0;
            // 
            // phoneListTableLayoutPanel
            // 
            this.phoneListTableLayoutPanel.ColumnCount = 1;
            this.phoneListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.phoneListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.phoneListTableLayoutPanel.Controls.Add(this.jerryButton, 0, 2);
            this.phoneListTableLayoutPanel.Controls.Add(this.teacherButton, 0, 1);
            this.phoneListTableLayoutPanel.Controls.Add(this.friendButton, 0, 0);
            this.phoneListTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneListTableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.phoneListTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.phoneListTableLayoutPanel.Name = "phoneListTableLayoutPanel";
            this.phoneListTableLayoutPanel.RowCount = 3;
            this.phoneListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.phoneListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.phoneListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.phoneListTableLayoutPanel.Size = new System.Drawing.Size(141, 234);
            this.phoneListTableLayoutPanel.TabIndex = 0;
            // 
            // jerryButton
            // 
            this.jerryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jerryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jerryButton.Location = new System.Drawing.Point(3, 159);
            this.jerryButton.Name = "jerryButton";
            this.jerryButton.Size = new System.Drawing.Size(135, 72);
            this.jerryButton.TabIndex = 2;
            this.jerryButton.Text = "Jerry ";
            this.jerryButton.UseVisualStyleBackColor = true;
            this.jerryButton.Click += new System.EventHandler(this.jerryButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherButton.Location = new System.Drawing.Point(3, 81);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Size = new System.Drawing.Size(135, 72);
            this.teacherButton.TabIndex = 1;
            this.teacherButton.Text = "Teacher";
            this.teacherButton.UseVisualStyleBackColor = true;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // friendButton
            // 
            this.friendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendButton.Location = new System.Drawing.Point(3, 3);
            this.friendButton.Name = "friendButton";
            this.friendButton.Size = new System.Drawing.Size(135, 72);
            this.friendButton.TabIndex = 0;
            this.friendButton.Text = "Friend";
            this.friendButton.UseVisualStyleBackColor = true;
            this.friendButton.Click += new System.EventHandler(this.friendButton_Click);
            // 
            // selectionTableLayoutPanel
            // 
            this.selectionTableLayoutPanel.ColumnCount = 1;
            this.selectionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectionTableLayoutPanel.Controls.Add(this.callButton, 0, 1);
            this.selectionTableLayoutPanel.Controls.Add(this.callLabel, 0, 0);
            this.selectionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionTableLayoutPanel.Location = new System.Drawing.Point(146, 4);
            this.selectionTableLayoutPanel.Name = "selectionTableLayoutPanel";
            this.selectionTableLayoutPanel.RowCount = 2;
            this.selectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.selectionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.selectionTableLayoutPanel.Size = new System.Drawing.Size(286, 228);
            this.selectionTableLayoutPanel.TabIndex = 1;
            // 
            // callButton
            // 
            this.callButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callButton.Enabled = false;
            this.callButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callButton.Location = new System.Drawing.Point(80, 166);
            this.callButton.Margin = new System.Windows.Forms.Padding(80, 30, 80, 30);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(126, 32);
            this.callButton.TabIndex = 0;
            this.callButton.Text = "Call";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // callLabel
            // 
            this.callLabel.AutoSize = true;
            this.callLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.callLabel.Location = new System.Drawing.Point(15, 0);
            this.callLabel.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.callLabel.Name = "callLabel";
            this.callLabel.Size = new System.Drawing.Size(268, 136);
            this.callLabel.TabIndex = 1;
            this.callLabel.Text = " ";
            this.callLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // callingTimer
            // 
            this.callingTimer.Interval = 5000;
            this.callingTimer.Tick += new System.EventHandler(this.callingTimer_Tick);
            // 
            // PhoneCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 316);
            this.Controls.Add(this.phoneCallFormTableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneCallForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Who do you want to Call ? ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhoneCallForm_FormClosed);
            this.phoneCallFormTableLayoutPanel.ResumeLayout(false);
            this.phoneListTableLayoutPanel.ResumeLayout(false);
            this.selectionTableLayoutPanel.ResumeLayout(false);
            this.selectionTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel phoneCallFormTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel phoneListTableLayoutPanel;
        private System.Windows.Forms.Button friendButton;
        private System.Windows.Forms.Button jerryButton;
        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.TableLayoutPanel selectionTableLayoutPanel;
        private System.Windows.Forms.Button callButton;
        private MetroFramework.Controls.MetroLabel callLabel;
        private System.Windows.Forms.Timer callingTimer;
    }
}