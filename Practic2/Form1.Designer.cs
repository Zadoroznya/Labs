namespace Practic2
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			AlcoholCountBox = new NumericUpDown();
			label3 = new Label();
			AlcoholPriceBox = new TextBox();
			label2 = new Label();
			AlcoholTypeBox = new ComboBox();
			label1 = new Label();
			tabPage2 = new TabPage();
			AdditionalCountBox = new NumericUpDown();
			label4 = new Label();
			AdditionalPriceBox = new TextBox();
			label5 = new Label();
			AdditionalTypeBox = new ComboBox();
			label6 = new Label();
			flowLayoutPanel1 = new FlowLayoutPanel();
			BuyButton = new Button();
			CancelButton = new Button();
			CloseButton = new Button();
			ResultBox = new TextBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AlcoholCountBox).BeginInit();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AdditionalCountBox).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Left;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(382, 450);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(AlcoholCountBox);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(AlcoholPriceBox);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(AlcoholTypeBox);
			tabPage1.Controls.Add(label1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(374, 422);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Алкоголь";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// AlcoholCountBox
			// 
			AlcoholCountBox.Location = new Point(8, 109);
			AlcoholCountBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			AlcoholCountBox.Name = "AlcoholCountBox";
			AlcoholCountBox.Size = new Size(121, 23);
			AlcoholCountBox.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(8, 91);
			label3.Name = "label3";
			label3.Size = new Size(56, 15);
			label3.TabIndex = 4;
			label3.Text = "Кількість";
			// 
			// AlcoholPriceBox
			// 
			AlcoholPriceBox.Location = new Point(8, 65);
			AlcoholPriceBox.Name = "AlcoholPriceBox";
			AlcoholPriceBox.ReadOnly = true;
			AlcoholPriceBox.Size = new Size(121, 23);
			AlcoholPriceBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(8, 47);
			label2.Name = "label2";
			label2.Size = new Size(89, 15);
			label2.TabIndex = 2;
			label2.Text = "Вартість сорту:";
			// 
			// AlcoholTypeBox
			// 
			AlcoholTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
			AlcoholTypeBox.FormattingEnabled = true;
			AlcoholTypeBox.Location = new Point(8, 21);
			AlcoholTypeBox.Name = "AlcoholTypeBox";
			AlcoholTypeBox.Size = new Size(121, 23);
			AlcoholTypeBox.TabIndex = 1;
			AlcoholTypeBox.SelectedIndexChanged += AlcoholTypeBox_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(8, 3);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 0;
			label1.Text = "Сорт пива";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(AdditionalCountBox);
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(AdditionalPriceBox);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(AdditionalTypeBox);
			tabPage2.Controls.Add(label6);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(374, 422);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "До алкоголю";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// AdditionalCountBox
			// 
			AdditionalCountBox.Location = new Point(8, 109);
			AdditionalCountBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			AdditionalCountBox.Name = "AdditionalCountBox";
			AdditionalCountBox.Size = new Size(121, 23);
			AdditionalCountBox.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(8, 91);
			label4.Name = "label4";
			label4.Size = new Size(56, 15);
			label4.TabIndex = 10;
			label4.Text = "Кількість";
			// 
			// AdditionalPriceBox
			// 
			AdditionalPriceBox.Location = new Point(8, 65);
			AdditionalPriceBox.Name = "AdditionalPriceBox";
			AdditionalPriceBox.ReadOnly = true;
			AdditionalPriceBox.Size = new Size(121, 23);
			AdditionalPriceBox.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(8, 47);
			label5.Name = "label5";
			label5.Size = new Size(52, 15);
			label5.TabIndex = 8;
			label5.Text = "Вартість";
			// 
			// AdditionalTypeBox
			// 
			AdditionalTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
			AdditionalTypeBox.FormattingEnabled = true;
			AdditionalTypeBox.Location = new Point(8, 21);
			AdditionalTypeBox.Name = "AdditionalTypeBox";
			AdditionalTypeBox.Size = new Size(121, 23);
			AdditionalTypeBox.TabIndex = 7;
			AdditionalTypeBox.SelectedIndexChanged += AdditionalTypeBox_SelectedIndexChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(8, 3);
			label6.Name = "label6";
			label6.Size = new Size(51, 15);
			label6.TabIndex = 6;
			label6.Text = "До пива";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(BuyButton);
			flowLayoutPanel1.Controls.Add(CancelButton);
			flowLayoutPanel1.Controls.Add(CloseButton);
			flowLayoutPanel1.Dock = DockStyle.Top;
			flowLayoutPanel1.Location = new Point(382, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(218, 197);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// BuyButton
			// 
			BuyButton.Location = new Point(3, 3);
			BuyButton.Name = "BuyButton";
			BuyButton.Size = new Size(100, 51);
			BuyButton.TabIndex = 0;
			BuyButton.Text = "Замовити";
			BuyButton.UseVisualStyleBackColor = true;
			BuyButton.Click += BuyButton_Click;
			// 
			// CancelButton
			// 
			CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			CancelButton.Location = new Point(109, 3);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new Size(100, 51);
			CancelButton.TabIndex = 1;
			CancelButton.Text = "Відмінити";
			CancelButton.UseVisualStyleBackColor = true;
			CancelButton.Click += CancelButton_Click;
			// 
			// CloseButton
			// 
			CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			CloseButton.Location = new Point(3, 60);
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(206, 51);
			CloseButton.TabIndex = 2;
			CloseButton.Text = "Вихід";
			CloseButton.UseVisualStyleBackColor = true;
			CloseButton.Click += CloseButton_Click;
			// 
			// ResultBox
			// 
			ResultBox.Dock = DockStyle.Fill;
			ResultBox.Location = new Point(382, 197);
			ResultBox.Multiline = true;
			ResultBox.Name = "ResultBox";
			ResultBox.ReadOnly = true;
			ResultBox.Size = new Size(218, 253);
			ResultBox.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(600, 450);
			Controls.Add(ResultBox);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(tabControl1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Практична робота №2";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)AlcoholCountBox).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)AdditionalCountBox).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private ComboBox AlcoholTypeBox;
		private Label label1;
		private TextBox AlcoholPriceBox;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button BuyButton;
		private Button CancelButton;
		private Button CloseButton;
		private TextBox ResultBox;
		private NumericUpDown AlcoholCountBox;
		private Label label3;
		private NumericUpDown AdditionalCountBox;
		private Label label4;
		private TextBox AdditionalPriceBox;
		private Label label5;
		private ComboBox AdditionalTypeBox;
		private Label label6;
	}
}
