namespace CashRegister
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
            this.canadashopLabel = new System.Windows.Forms.Label();
            this.flagLabel = new System.Windows.Forms.Label();
            this.hockeyLabel = new System.Windows.Forms.Label();
            this.iglooLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.blankLabel1 = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderdLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.flagtextBox = new System.Windows.Forms.TextBox();
            this.hockeytextBox = new System.Windows.Forms.TextBox();
            this.iglootextBox = new System.Windows.Forms.TextBox();
            this.tenderedtextBox = new System.Windows.Forms.TextBox();
            this.reciptcanadashopLabel = new System.Windows.Forms.Label();
            this.ordernumberLabel = new System.Windows.Forms.Label();
            this.receiptflagLabel = new System.Windows.Forms.Label();
            this.receipthockeyLabel = new System.Windows.Forms.Label();
            this.receiptiglooLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subtotalreceiptLabel = new System.Windows.Forms.Label();
            this.taxreceiptLabel = new System.Windows.Forms.Label();
            this.totalreceiptLabel = new System.Windows.Forms.Label();
            this.changereceiptLabel = new System.Windows.Forms.Label();
            this.tenderedreceiptLabel = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.numofflagreciptLabel = new System.Windows.Forms.Label();
            this.numofhockeyreciptLabel = new System.Windows.Forms.Label();
            this.numofiglooreciptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // canadashopLabel
            // 
            this.canadashopLabel.BackColor = System.Drawing.Color.Red;
            this.canadashopLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canadashopLabel.Location = new System.Drawing.Point(-6, -6);
            this.canadashopLabel.Name = "canadashopLabel";
            this.canadashopLabel.Size = new System.Drawing.Size(658, 65);
            this.canadashopLabel.TabIndex = 0;
            this.canadashopLabel.Text = "The Canada Shop";
            this.canadashopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.Location = new System.Drawing.Point(48, 97);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(81, 13);
            this.flagLabel.TabIndex = 1;
            this.flagLabel.Text = "Number of flags";
            // 
            // hockeyLabel
            // 
            this.hockeyLabel.AutoSize = true;
            this.hockeyLabel.Location = new System.Drawing.Point(48, 135);
            this.hockeyLabel.Name = "hockeyLabel";
            this.hockeyLabel.Size = new System.Drawing.Size(128, 13);
            this.hockeyLabel.TabIndex = 2;
            this.hockeyLabel.Text = "Number of Hockey Sticks";
            // 
            // iglooLabel
            // 
            this.iglooLabel.AutoSize = true;
            this.iglooLabel.Location = new System.Drawing.Point(48, 169);
            this.iglooLabel.Name = "iglooLabel";
            this.iglooLabel.Size = new System.Drawing.Size(87, 13);
            this.iglooLabel.TabIndex = 3;
            this.iglooLabel.Text = "Number of Igloos";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(101, 205);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(154, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate eh?";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(51, 241);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(53, 13);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(51, 271);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(51, 303);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total";
            // 
            // blankLabel1
            // 
            this.blankLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.blankLabel1.Location = new System.Drawing.Point(323, 73);
            this.blankLabel1.Name = "blankLabel1";
            this.blankLabel1.Size = new System.Drawing.Size(14, 362);
            this.blankLabel1.TabIndex = 14;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtotalOutput.Location = new System.Drawing.Point(193, 231);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 23);
            this.subtotalOutput.TabIndex = 15;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxOutput.Location = new System.Drawing.Point(196, 261);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 23);
            this.taxOutput.TabIndex = 16;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalOutput.Location = new System.Drawing.Point(196, 293);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 17;
            // 
            // tenderdLabel
            // 
            this.tenderdLabel.AutoSize = true;
            this.tenderdLabel.Location = new System.Drawing.Point(51, 333);
            this.tenderdLabel.Name = "tenderdLabel";
            this.tenderdLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderdLabel.TabIndex = 18;
            this.tenderdLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(101, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(154, 23);
            this.changeButton.TabIndex = 20;
            this.changeButton.Text = "Change eh?";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(51, 384);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(43, 13);
            this.changeLabel.TabIndex = 21;
            this.changeLabel.Text = "change";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeOutput.Location = new System.Drawing.Point(196, 384);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 23);
            this.changeOutput.TabIndex = 22;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(101, 412);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(154, 23);
            this.receiptButton.TabIndex = 23;
            this.receiptButton.Text = "Receipt eh?";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // flagtextBox
            // 
            this.flagtextBox.Location = new System.Drawing.Point(199, 97);
            this.flagtextBox.Name = "flagtextBox";
            this.flagtextBox.Size = new System.Drawing.Size(100, 20);
            this.flagtextBox.TabIndex = 24;
            // 
            // hockeytextBox
            // 
            this.hockeytextBox.Location = new System.Drawing.Point(199, 132);
            this.hockeytextBox.Name = "hockeytextBox";
            this.hockeytextBox.Size = new System.Drawing.Size(100, 20);
            this.hockeytextBox.TabIndex = 25;
            // 
            // iglootextBox
            // 
            this.iglootextBox.Location = new System.Drawing.Point(199, 166);
            this.iglootextBox.Name = "iglootextBox";
            this.iglootextBox.Size = new System.Drawing.Size(100, 20);
            this.iglootextBox.TabIndex = 26;
            // 
            // tenderedtextBox
            // 
            this.tenderedtextBox.Location = new System.Drawing.Point(196, 333);
            this.tenderedtextBox.Name = "tenderedtextBox";
            this.tenderedtextBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedtextBox.TabIndex = 27;
            // 
            // reciptcanadashopLabel
            // 
            this.reciptcanadashopLabel.BackColor = System.Drawing.Color.Transparent;
            this.reciptcanadashopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reciptcanadashopLabel.Location = new System.Drawing.Point(358, 102);
            this.reciptcanadashopLabel.Name = "reciptcanadashopLabel";
            this.reciptcanadashopLabel.Size = new System.Drawing.Size(250, 23);
            this.reciptcanadashopLabel.TabIndex = 28;
            this.reciptcanadashopLabel.Text = "The Canada Shop eh?";
            // 
            // ordernumberLabel
            // 
            this.ordernumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.ordernumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordernumberLabel.Location = new System.Drawing.Point(358, 125);
            this.ordernumberLabel.Name = "ordernumberLabel";
            this.ordernumberLabel.Size = new System.Drawing.Size(250, 23);
            this.ordernumberLabel.TabIndex = 29;
            this.ordernumberLabel.Text = "Order Number eh?";
            this.ordernumberLabel.Click += new System.EventHandler(this.ordernumberLabel_Click);
            // 
            // receiptflagLabel
            // 
            this.receiptflagLabel.BackColor = System.Drawing.Color.Transparent;
            this.receiptflagLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptflagLabel.Location = new System.Drawing.Point(358, 159);
            this.receiptflagLabel.Name = "receiptflagLabel";
            this.receiptflagLabel.Size = new System.Drawing.Size(116, 23);
            this.receiptflagLabel.TabIndex = 30;
            this.receiptflagLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // receipthockeyLabel
            // 
            this.receipthockeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.receipthockeyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.receipthockeyLabel.Location = new System.Drawing.Point(358, 194);
            this.receipthockeyLabel.Name = "receipthockeyLabel";
            this.receipthockeyLabel.Size = new System.Drawing.Size(116, 23);
            this.receipthockeyLabel.TabIndex = 31;
            this.receipthockeyLabel.Click += new System.EventHandler(this.receipthockeyLabel_Click);
            // 
            // receiptiglooLabel
            // 
            this.receiptiglooLabel.BackColor = System.Drawing.Color.Transparent;
            this.receiptiglooLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.receiptiglooLabel.Location = new System.Drawing.Point(358, 231);
            this.receiptiglooLabel.Name = "receiptiglooLabel";
            this.receiptiglooLabel.Size = new System.Drawing.Size(116, 23);
            this.receiptiglooLabel.TabIndex = 32;
            this.receiptiglooLabel.Click += new System.EventHandler(this.receiptiglooLabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(323, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 20);
            this.label1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(621, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 362);
            this.label3.TabIndex = 34;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(323, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 23);
            this.label4.TabIndex = 35;
            // 
            // subtotalreceiptLabel
            // 
            this.subtotalreceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalreceiptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtotalreceiptLabel.Location = new System.Drawing.Point(358, 271);
            this.subtotalreceiptLabel.Name = "subtotalreceiptLabel";
            this.subtotalreceiptLabel.Size = new System.Drawing.Size(250, 23);
            this.subtotalreceiptLabel.TabIndex = 36;
            this.subtotalreceiptLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // taxreceiptLabel
            // 
            this.taxreceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxreceiptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxreceiptLabel.Location = new System.Drawing.Point(358, 303);
            this.taxreceiptLabel.Name = "taxreceiptLabel";
            this.taxreceiptLabel.Size = new System.Drawing.Size(250, 23);
            this.taxreceiptLabel.TabIndex = 37;
            this.taxreceiptLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // totalreceiptLabel
            // 
            this.totalreceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalreceiptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalreceiptLabel.Location = new System.Drawing.Point(358, 333);
            this.totalreceiptLabel.Name = "totalreceiptLabel";
            this.totalreceiptLabel.Size = new System.Drawing.Size(250, 23);
            this.totalreceiptLabel.TabIndex = 38;
            // 
            // changereceiptLabel
            // 
            this.changereceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.changereceiptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changereceiptLabel.Location = new System.Drawing.Point(358, 389);
            this.changereceiptLabel.Name = "changereceiptLabel";
            this.changereceiptLabel.Size = new System.Drawing.Size(250, 23);
            this.changereceiptLabel.TabIndex = 39;
            // 
            // tenderedreceiptLabel
            // 
            this.tenderedreceiptLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedreceiptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tenderedreceiptLabel.Location = new System.Drawing.Point(358, 364);
            this.tenderedreceiptLabel.Name = "tenderedreceiptLabel";
            this.tenderedreceiptLabel.Size = new System.Drawing.Size(250, 23);
            this.tenderedreceiptLabel.TabIndex = 40;
            // 
            // neworderButton
            // 
            this.neworderButton.Location = new System.Drawing.Point(101, 62);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(154, 23);
            this.neworderButton.TabIndex = 41;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // numofflagreciptLabel
            // 
            this.numofflagreciptLabel.BackColor = System.Drawing.Color.Transparent;
            this.numofflagreciptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numofflagreciptLabel.Location = new System.Drawing.Point(480, 159);
            this.numofflagreciptLabel.Name = "numofflagreciptLabel";
            this.numofflagreciptLabel.Size = new System.Drawing.Size(135, 23);
            this.numofflagreciptLabel.TabIndex = 42;
            // 
            // numofhockeyreciptLabel
            // 
            this.numofhockeyreciptLabel.BackColor = System.Drawing.Color.Transparent;
            this.numofhockeyreciptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numofhockeyreciptLabel.Location = new System.Drawing.Point(480, 194);
            this.numofhockeyreciptLabel.Name = "numofhockeyreciptLabel";
            this.numofhockeyreciptLabel.Size = new System.Drawing.Size(135, 23);
            this.numofhockeyreciptLabel.TabIndex = 43;
            // 
            // numofiglooreciptLabel
            // 
            this.numofiglooreciptLabel.BackColor = System.Drawing.Color.Transparent;
            this.numofiglooreciptLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numofiglooreciptLabel.Location = new System.Drawing.Point(480, 231);
            this.numofiglooreciptLabel.Name = "numofiglooreciptLabel";
            this.numofiglooreciptLabel.Size = new System.Drawing.Size(135, 23);
            this.numofiglooreciptLabel.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(647, 447);
            this.Controls.Add(this.numofiglooreciptLabel);
            this.Controls.Add(this.numofhockeyreciptLabel);
            this.Controls.Add(this.numofflagreciptLabel);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.tenderedreceiptLabel);
            this.Controls.Add(this.changereceiptLabel);
            this.Controls.Add(this.totalreceiptLabel);
            this.Controls.Add(this.taxreceiptLabel);
            this.Controls.Add(this.subtotalreceiptLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptiglooLabel);
            this.Controls.Add(this.receipthockeyLabel);
            this.Controls.Add(this.receiptflagLabel);
            this.Controls.Add(this.ordernumberLabel);
            this.Controls.Add(this.reciptcanadashopLabel);
            this.Controls.Add(this.tenderedtextBox);
            this.Controls.Add(this.iglootextBox);
            this.Controls.Add(this.hockeytextBox);
            this.Controls.Add(this.flagtextBox);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderdLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.blankLabel1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.iglooLabel);
            this.Controls.Add(this.hockeyLabel);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.canadashopLabel);
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label canadashopLabel;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.Label hockeyLabel;
        private System.Windows.Forms.Label iglooLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label blankLabel1;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderdLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.TextBox flagtextBox;
        private System.Windows.Forms.TextBox hockeytextBox;
        private System.Windows.Forms.TextBox iglootextBox;
        private System.Windows.Forms.TextBox tenderedtextBox;
        private System.Windows.Forms.Label reciptcanadashopLabel;
        private System.Windows.Forms.Label ordernumberLabel;
        private System.Windows.Forms.Label receiptflagLabel;
        private System.Windows.Forms.Label receipthockeyLabel;
        private System.Windows.Forms.Label receiptiglooLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subtotalreceiptLabel;
        private System.Windows.Forms.Label taxreceiptLabel;
        private System.Windows.Forms.Label totalreceiptLabel;
        private System.Windows.Forms.Label changereceiptLabel;
        private System.Windows.Forms.Label tenderedreceiptLabel;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label numofflagreciptLabel;
        private System.Windows.Forms.Label numofhockeyreciptLabel;
        private System.Windows.Forms.Label numofiglooreciptLabel;
    }
}

