namespace XMLParser
{
    partial class XMLForm
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
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.cityCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeCheckBox = new System.Windows.Forms.CheckBox();
            this.isoCheckBox = new System.Windows.Forms.CheckBox();
            this.formatCheckBox = new System.Windows.Forms.CheckBox();
            this.qualityCheckBox = new System.Windows.Forms.CheckBox();
            this.qualityBox = new System.Windows.Forms.ComboBox();
            this.domBtn = new System.Windows.Forms.RadioButton();
            this.saxBtn = new System.Windows.Forms.RadioButton();
            this.linqBtn = new System.Windows.Forms.RadioButton();
            this.resultsBox = new System.Windows.Forms.RichTextBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.transformBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.isoBox = new System.Windows.Forms.ComboBox();
            this.formatBox = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.authorBox = new System.Windows.Forms.ComboBox();
            this.authorCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateCheckBox.Location = new System.Drawing.Point(12, 60);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(80, 32);
            this.dateCheckBox.TabIndex = 1;
            this.dateCheckBox.Text = "Дата";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // cityCheckBox
            // 
            this.cityCheckBox.AutoSize = true;
            this.cityCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityCheckBox.Location = new System.Drawing.Point(12, 108);
            this.cityCheckBox.Name = "cityCheckBox";
            this.cityCheckBox.Size = new System.Drawing.Size(90, 32);
            this.cityCheckBox.TabIndex = 2;
            this.cityCheckBox.Text = "Місто";
            this.cityCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cityCheckBox.UseVisualStyleBackColor = true;
            // 
            // sizeCheckBox
            // 
            this.sizeCheckBox.AutoSize = true;
            this.sizeCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeCheckBox.Location = new System.Drawing.Point(12, 156);
            this.sizeCheckBox.Name = "sizeCheckBox";
            this.sizeCheckBox.Size = new System.Drawing.Size(144, 32);
            this.sizeCheckBox.TabIndex = 3;
            this.sizeCheckBox.Text = "Розмір (мб)";
            this.sizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // isoCheckBox
            // 
            this.isoCheckBox.AutoSize = true;
            this.isoCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isoCheckBox.Location = new System.Drawing.Point(12, 206);
            this.isoCheckBox.Name = "isoCheckBox";
            this.isoCheckBox.Size = new System.Drawing.Size(69, 32);
            this.isoCheckBox.TabIndex = 4;
            this.isoCheckBox.Text = "ISO";
            this.isoCheckBox.UseVisualStyleBackColor = true;
            // 
            // formatCheckBox
            // 
            this.formatCheckBox.AutoSize = true;
            this.formatCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formatCheckBox.Location = new System.Drawing.Point(12, 257);
            this.formatCheckBox.Name = "formatCheckBox";
            this.formatCheckBox.Size = new System.Drawing.Size(109, 32);
            this.formatCheckBox.TabIndex = 5;
            this.formatCheckBox.Text = "Формат";
            this.formatCheckBox.UseVisualStyleBackColor = true;
            // 
            // qualityCheckBox
            // 
            this.qualityCheckBox.AutoSize = true;
            this.qualityCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qualityCheckBox.Location = new System.Drawing.Point(12, 308);
            this.qualityCheckBox.Name = "qualityCheckBox";
            this.qualityCheckBox.Size = new System.Drawing.Size(92, 32);
            this.qualityCheckBox.TabIndex = 6;
            this.qualityCheckBox.Text = "Якість";
            this.qualityCheckBox.UseVisualStyleBackColor = true;
            // 
            // qualityBox
            // 
            this.qualityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualityBox.FormattingEnabled = true;
            this.qualityBox.Location = new System.Drawing.Point(185, 307);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(182, 33);
            this.qualityBox.Sorted = true;
            this.qualityBox.TabIndex = 7;
            // 
            // domBtn
            // 
            this.domBtn.AutoSize = true;
            this.domBtn.Checked = true;
            this.domBtn.Location = new System.Drawing.Point(27, 387);
            this.domBtn.Name = "domBtn";
            this.domBtn.Size = new System.Drawing.Size(80, 29);
            this.domBtn.TabIndex = 8;
            this.domBtn.TabStop = true;
            this.domBtn.Text = "DOM";
            this.domBtn.UseVisualStyleBackColor = true;
            // 
            // saxBtn
            // 
            this.saxBtn.AutoSize = true;
            this.saxBtn.Location = new System.Drawing.Point(123, 387);
            this.saxBtn.Name = "saxBtn";
            this.saxBtn.Size = new System.Drawing.Size(70, 29);
            this.saxBtn.TabIndex = 9;
            this.saxBtn.Text = "SAX";
            this.saxBtn.UseVisualStyleBackColor = true;
            // 
            // linqBtn
            // 
            this.linqBtn.AutoSize = true;
            this.linqBtn.Location = new System.Drawing.Point(204, 387);
            this.linqBtn.Name = "linqBtn";
            this.linqBtn.Size = new System.Drawing.Size(139, 29);
            this.linqBtn.TabIndex = 10;
            this.linqBtn.Text = "LINQ to XML";
            this.linqBtn.UseVisualStyleBackColor = true;
            // 
            // resultsBox
            // 
            this.resultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsBox.Location = new System.Drawing.Point(395, 12);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(637, 587);
            this.resultsBox.TabIndex = 11;
            this.resultsBox.Text = "";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(13, 524);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(167, 34);
            this.findBtn.TabIndex = 12;
            this.findBtn.Text = "Знайти";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // transformBtn
            // 
            this.transformBtn.Location = new System.Drawing.Point(200, 524);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(167, 34);
            this.transformBtn.TabIndex = 13;
            this.transformBtn.Text = "Трансформувати";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(46, 472);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(259, 34);
            this.fileBtn.TabIndex = 16;
            this.fileBtn.Text = "Завантажити файл";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Завантажити файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // isoBox
            // 
            this.isoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isoBox.FormattingEnabled = true;
            this.isoBox.Location = new System.Drawing.Point(185, 207);
            this.isoBox.Name = "isoBox";
            this.isoBox.Size = new System.Drawing.Size(182, 33);
            this.isoBox.Sorted = true;
            this.isoBox.TabIndex = 7;
            // 
            // formatBox
            // 
            this.formatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatBox.FormattingEnabled = true;
            this.formatBox.Location = new System.Drawing.Point(185, 256);
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(182, 33);
            this.formatBox.Sorted = true;
            this.formatBox.TabIndex = 7;
            // 
            // sizeBox
            // 
            this.sizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(185, 156);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(182, 33);
            this.sizeBox.Sorted = true;
            this.sizeBox.TabIndex = 7;
            // 
            // cityBox
            // 
            this.cityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(185, 107);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(182, 33);
            this.cityBox.Sorted = true;
            this.cityBox.TabIndex = 7;
            // 
            // dateBox
            // 
            this.dateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(185, 59);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(182, 33);
            this.dateBox.Sorted = true;
            this.dateBox.TabIndex = 7;
            // 
            // authorBox
            // 
            this.authorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorBox.FormattingEnabled = true;
            this.authorBox.Location = new System.Drawing.Point(185, 15);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(182, 33);
            this.authorBox.Sorted = true;
            this.authorBox.TabIndex = 7;
            // 
            // authorCheckBox
            // 
            this.authorCheckBox.AutoSize = true;
            this.authorCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorCheckBox.Location = new System.Drawing.Point(12, 16);
            this.authorCheckBox.Name = "authorCheckBox";
            this.authorCheckBox.Size = new System.Drawing.Size(94, 32);
            this.authorCheckBox.TabIndex = 1;
            this.authorCheckBox.Text = "Автор";
            this.authorCheckBox.UseVisualStyleBackColor = true;
            // 
            // XMLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 611);
            this.Controls.Add(this.authorCheckBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.isoBox);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.transformBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.linqBtn);
            this.Controls.Add(this.saxBtn);
            this.Controls.Add(this.domBtn);
            this.Controls.Add(this.qualityBox);
            this.Controls.Add(this.qualityCheckBox);
            this.Controls.Add(this.formatCheckBox);
            this.Controls.Add(this.isoCheckBox);
            this.Controls.Add(this.sizeCheckBox);
            this.Controls.Add(this.cityCheckBox);
            this.Controls.Add(this.dateCheckBox);
            this.Name = "XMLForm";
            this.Text = "Фото";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox cityCheckBox;
        private System.Windows.Forms.CheckBox sizeCheckBox;
        private System.Windows.Forms.CheckBox isoCheckBox;
        private System.Windows.Forms.CheckBox formatCheckBox;
        private System.Windows.Forms.CheckBox qualityCheckBox;
        private System.Windows.Forms.ComboBox qualityBox;
        private System.Windows.Forms.RadioButton domBtn;
        private System.Windows.Forms.RadioButton saxBtn;
        private System.Windows.Forms.RadioButton linqBtn;
        private System.Windows.Forms.RichTextBox resultsBox;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button transformBtn;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox isoBox;
        private System.Windows.Forms.ComboBox formatBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.ComboBox authorBox;
        private System.Windows.Forms.CheckBox authorCheckBox;
    }
}

