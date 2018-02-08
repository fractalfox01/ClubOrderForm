namespace Chapter10Ex7
{
    partial class Form1
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTypeList = new System.Windows.Forms.Label();
            this.lblShirtSize = new System.Windows.Forms.Label();
            this.lblShirtColor = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.LightCyan;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(70, 25);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(464, 29);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Welcome To The Computer Club Form";
            // 
            // lblTypeList
            // 
            this.lblTypeList.AutoSize = true;
            this.lblTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeList.Location = new System.Drawing.Point(53, 92);
            this.lblTypeList.Name = "lblTypeList";
            this.lblTypeList.Size = new System.Drawing.Size(57, 24);
            this.lblTypeList.TabIndex = 1;
            this.lblTypeList.Text = "Type";
            // 
            // lblShirtSize
            // 
            this.lblShirtSize.AutoSize = true;
            this.lblShirtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirtSize.Location = new System.Drawing.Point(211, 92);
            this.lblShirtSize.Name = "lblShirtSize";
            this.lblShirtSize.Size = new System.Drawing.Size(50, 24);
            this.lblShirtSize.TabIndex = 2;
            this.lblShirtSize.Text = "Size";
            // 
            // lblShirtColor
            // 
            this.lblShirtColor.AutoSize = true;
            this.lblShirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirtColor.Location = new System.Drawing.Point(357, 92);
            this.lblShirtColor.Name = "lblShirtColor";
            this.lblShirtColor.Size = new System.Drawing.Size(60, 24);
            this.lblShirtColor.TabIndex = 3;
            this.lblShirtColor.Text = "Color";
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteCustomSource.AddRange(new string[] {
            "Regular_Tee",
            "V-neck_Tee",
            "Long-Sleve",
            "Hoodie",
            ""});
            this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.White;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Regular_Tee",
            "V-neck_Tee",
            "Long-Sleve",
            "Hoodie"});
            this.cmbType.Location = new System.Drawing.Point(23, 119);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 28);
            this.cmbType.TabIndex = 4;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.AutoCompleteCustomSource.AddRange(new string[] {
            "White",
            "Black",
            "Blue",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Purple",
            "Grey"});
            this.cmbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbColor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.ForeColor = System.Drawing.Color.White;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Blue",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Purple",
            "Grey"});
            this.cmbColor.Location = new System.Drawing.Point(330, 119);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 28);
            this.cmbColor.TabIndex = 5;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.AutoCompleteCustomSource.AddRange(new string[] {
            "XS\tExtra-small",
            "S\tSmall",
            "M\tMedium",
            "L\tLarge",
            "XL\tExtra-Large",
            "XXL\tExtraExtra-Large"});
            this.cmbSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSize.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.ForeColor = System.Drawing.Color.White;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Extra-small",
            "Small",
            "Medium",
            "Large",
            "Extra-Large",
            "ExtraExtra-Large"});
            this.cmbSize.Location = new System.Drawing.Point(165, 119);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(149, 28);
            this.cmbSize.TabIndex = 6;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(485, 92);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 24);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // cmbAmount
            // 
            this.cmbAmount.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAmount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAmount.ForeColor = System.Drawing.Color.White;
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbAmount.Location = new System.Drawing.Point(500, 119);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(50, 28);
            this.cmbAmount.TabIndex = 8;
            this.cmbAmount.SelectedIndexChanged += new System.EventHandler(this.cmbAmount_SelectedIndexChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(10, 211);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(139, 24);
            this.lblSelected.TabIndex = 9;
            this.lblSelected.Text = "Current Order";
            // 
            // lstSelected
            // 
            this.lstSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.ItemHeight = 20;
            this.lstSelected.Location = new System.Drawing.Point(14, 238);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(222, 124);
            this.lstSelected.TabIndex = 10;
            this.lstSelected.SelectedIndexChanged += new System.EventHandler(this.lstSelected_SelectedIndexChanged);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(253, 271);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(130, 51);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 571);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblShirtColor);
            this.Controls.Add(this.lblShirtSize);
            this.Controls.Add(this.lblTypeList);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTypeList;
        private System.Windows.Forms.Label lblShirtSize;
        private System.Windows.Forms.Label lblShirtColor;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

