namespace Alisa_sMinuteManagement.Forms
{
    partial class manageMeetingItemsForm
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cbMeetingType = new ComboBox();
            lbMeetings = new ListBox();
            lvMeetingItems = new ListView();
            btnUpdateItem = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(247, 123);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(97, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Meeting Type";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(111, 167);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(115, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "List of Meetings";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(549, 167);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(175, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Meeting items to change";
            // 
            // cbMeetingType
            // 
            cbMeetingType.FormattingEnabled = true;
            cbMeetingType.Location = new Point(381, 123);
            cbMeetingType.Name = "cbMeetingType";
            cbMeetingType.Size = new Size(151, 28);
            cbMeetingType.TabIndex = 3;
            // 
            // lbMeetings
            // 
            lbMeetings.FormattingEnabled = true;
            lbMeetings.ItemHeight = 20;
            lbMeetings.Location = new Point(46, 196);
            lbMeetings.Name = "lbMeetings";
            lbMeetings.Size = new Size(285, 184);
            lbMeetings.TabIndex = 4;
            // 
            // lvMeetingItems
            // 
            lvMeetingItems.Location = new Point(460, 198);
            lvMeetingItems.Name = "lvMeetingItems";
            lvMeetingItems.Size = new Size(315, 182);
            lvMeetingItems.TabIndex = 5;
            lvMeetingItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateItem.Depth = 0;
            btnUpdateItem.HighEmphasis = true;
            btnUpdateItem.Icon = null;
            btnUpdateItem.Location = new Point(355, 388);
            btnUpdateItem.Margin = new Padding(4, 6, 4, 6);
            btnUpdateItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.NoAccentTextColor = Color.Empty;
            btnUpdateItem.Size = new Size(64, 36);
            btnUpdateItem.TabIndex = 6;
            btnUpdateItem.Text = "Edit";
            btnUpdateItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateItem.UseAccentColor = false;
            btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(312, 85);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(156, 19);
            materialLabel4.TabIndex = 7;
            materialLabel4.Text = "Meeting Management";
            // 
            // manageMeetingItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialLabel4);
            Controls.Add(btnUpdateItem);
            Controls.Add(lvMeetingItems);
            Controls.Add(lbMeetings);
            Controls.Add(cbMeetingType);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Name = "manageMeetingItemsForm";
            Text = "manageMeetingItemsForm";
            Load += manageMeetingItemsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private ComboBox cbMeetingType;
        private ListBox lbMeetings;
        private ListView lvMeetingItems;
        private MaterialSkin.Controls.MaterialButton btnUpdateItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}