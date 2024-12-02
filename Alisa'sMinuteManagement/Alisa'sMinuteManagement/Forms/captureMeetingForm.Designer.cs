namespace Alisa_sMinuteManagement.Forms
{
    partial class captureMeetingForm
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
            cbMeetingType = new ComboBox();
            dtpMeetingDateTime = new DateTimePicker();
            lvPreviousMeetingItems = new ListView();
            txtNewItemDescription = new TextBox();
            txtStatus = new TextBox();
            txtResponsiblePerson = new TextBox();
            lbNewMeetingItems = new ListBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            btnAddNewItem = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cbMeetingType
            // 
            cbMeetingType.FormattingEnabled = true;
            cbMeetingType.Location = new Point(178, 95);
            cbMeetingType.Name = "cbMeetingType";
            cbMeetingType.Size = new Size(151, 28);
            cbMeetingType.TabIndex = 0;
            // 
            // dtpMeetingDateTime
            // 
            dtpMeetingDateTime.Location = new Point(193, 162);
            dtpMeetingDateTime.Name = "dtpMeetingDateTime";
            dtpMeetingDateTime.Size = new Size(250, 27);
            dtpMeetingDateTime.TabIndex = 1;
            // 
            // lvPreviousMeetingItems
            // 
            lvPreviousMeetingItems.Location = new Point(37, 210);
            lvPreviousMeetingItems.Name = "lvPreviousMeetingItems";
            lvPreviousMeetingItems.Size = new Size(151, 121);
            lvPreviousMeetingItems.TabIndex = 2;
            lvPreviousMeetingItems.UseCompatibleStateImageBehavior = false;
            // 
            // txtNewItemDescription
            // 
            txtNewItemDescription.Location = new Point(522, 162);
            txtNewItemDescription.Name = "txtNewItemDescription";
            txtNewItemDescription.Size = new Size(125, 27);
            txtNewItemDescription.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(629, 223);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 4;
            // 
            // txtResponsiblePerson
            // 
            txtResponsiblePerson.Location = new Point(677, 282);
            txtResponsiblePerson.Name = "txtResponsiblePerson";
            txtResponsiblePerson.Size = new Size(125, 27);
            txtResponsiblePerson.TabIndex = 5;
            // 
            // lbNewMeetingItems
            // 
            lbNewMeetingItems.FormattingEnabled = true;
            lbNewMeetingItems.ItemHeight = 20;
            lbNewMeetingItems.Location = new Point(438, 223);
            lbNewMeetingItems.Name = "lbNewMeetingItems";
            lbNewMeetingItems.Size = new Size(150, 104);
            lbNewMeetingItems.TabIndex = 6;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(67, 384);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(150, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "btnSaveMeeting";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddNewItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddNewItem.Depth = 0;
            btnAddNewItem.HighEmphasis = true;
            btnAddNewItem.Icon = null;
            btnAddNewItem.Location = new Point(438, 375);
            btnAddNewItem.Margin = new Padding(4, 6, 4, 6);
            btnAddNewItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.NoAccentTextColor = Color.Empty;
            btnAddNewItem.Size = new Size(158, 36);
            btnAddNewItem.TabIndex = 8;
            btnAddNewItem.Text = "materialButton2";
            btnAddNewItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddNewItem.UseAccentColor = false;
            btnAddNewItem.UseVisualStyleBackColor = true;
            // 
            // captureMeetingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNewItem);
            Controls.Add(materialButton1);
            Controls.Add(lbNewMeetingItems);
            Controls.Add(txtResponsiblePerson);
            Controls.Add(txtStatus);
            Controls.Add(txtNewItemDescription);
            Controls.Add(lvPreviousMeetingItems);
            Controls.Add(dtpMeetingDateTime);
            Controls.Add(cbMeetingType);
            Name = "captureMeetingForm";
            Text = "captureMeetingForm";
            Load += captureMeetingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMeetingType;
        private DateTimePicker dtpMeetingDateTime;
        private ListView lvPreviousMeetingItems;
        private TextBox txtNewItemDescription;
        private TextBox txtStatus;
        private TextBox txtResponsiblePerson;
        private ListBox lbNewMeetingItems;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnAddNewItem;
    }
}