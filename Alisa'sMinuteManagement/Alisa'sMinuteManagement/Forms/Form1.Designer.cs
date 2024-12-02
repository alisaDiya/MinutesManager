namespace Alisa_sMinuteManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCaptureMeeting = new MaterialSkin.Controls.MaterialButton();
            btnManageMeetingItem = new MaterialSkin.Controls.MaterialButton();
            btnExitButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnCaptureMeeting
            // 
            btnCaptureMeeting.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCaptureMeeting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCaptureMeeting.Depth = 0;
            btnCaptureMeeting.HighEmphasis = true;
            btnCaptureMeeting.Icon = null;
            btnCaptureMeeting.Location = new Point(308, 155);
            btnCaptureMeeting.Margin = new Padding(4, 6, 4, 6);
            btnCaptureMeeting.MouseState = MaterialSkin.MouseState.HOVER;
            btnCaptureMeeting.Name = "btnCaptureMeeting";
            btnCaptureMeeting.NoAccentTextColor = Color.Empty;
            btnCaptureMeeting.Size = new Size(189, 36);
            btnCaptureMeeting.TabIndex = 0;
            btnCaptureMeeting.Text = "Capture new meeting";
            btnCaptureMeeting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCaptureMeeting.UseAccentColor = false;
            btnCaptureMeeting.UseVisualStyleBackColor = true;
          
            // 
            // btnManageMeetingItem
            // 
            btnManageMeetingItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageMeetingItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnManageMeetingItem.Depth = 0;
            btnManageMeetingItem.HighEmphasis = true;
            btnManageMeetingItem.Icon = null;
            btnManageMeetingItem.Location = new Point(308, 203);
            btnManageMeetingItem.Margin = new Padding(4, 6, 4, 6);
            btnManageMeetingItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnManageMeetingItem.Name = "btnManageMeetingItem";
            btnManageMeetingItem.NoAccentTextColor = Color.Empty;
            btnManageMeetingItem.Size = new Size(197, 36);
            btnManageMeetingItem.TabIndex = 1;
            btnManageMeetingItem.Text = "Manage Meeting Items";
            btnManageMeetingItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnManageMeetingItem.UseAccentColor = false;
            btnManageMeetingItem.UseVisualStyleBackColor = true;
           
            // 
            // btnExitButton
            // 
            btnExitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExitButton.Depth = 0;
            btnExitButton.HighEmphasis = true;
            btnExitButton.Icon = null;
            btnExitButton.Location = new Point(334, 251);
            btnExitButton.Margin = new Padding(4, 6, 4, 6);
            btnExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            btnExitButton.Name = "btnExitButton";
            btnExitButton.NoAccentTextColor = Color.Empty;
            btnExitButton.Size = new Size(150, 36);
            btnExitButton.TabIndex = 2;
            btnExitButton.Text = "Exit Application";
            btnExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExitButton.UseAccentColor = false;
            btnExitButton.UseVisualStyleBackColor = true;
            btnExitButton.Click += btnExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitButton);
            Controls.Add(btnManageMeetingItem);
            Controls.Add(btnCaptureMeeting);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCaptureMeeting;
        private MaterialSkin.Controls.MaterialButton btnManageMeetingItem;
        private MaterialSkin.Controls.MaterialButton btnExitButton;
    }
}
