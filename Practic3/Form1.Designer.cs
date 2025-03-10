namespace Practic3
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
			groupBox4 = new GroupBox();
			RegisterResultBox = new TextBox();
			groupBox3 = new GroupBox();
			DateBox = new NumericUpDown();
			MonthBox = new NumericUpDown();
			YearBox = new NumericUpDown();
			label4 = new Label();
			label3 = new Label();
			label1 = new Label();
			ClearRegisterButton = new Button();
			RegisterButton = new Button();
			EmailBox = new TextBox();
			label9 = new Label();
			LastNameBox = new TextBox();
			label7 = new Label();
			FirstNameBox = new TextBox();
			label6 = new Label();
			tabPage2 = new TabPage();
			groupBox5 = new GroupBox();
			RadioGroupBox = new GroupBox();
			RadButtonType1 = new RadioButton();
			RadButtonType2 = new RadioButton();
			RadButtonType3 = new RadioButton();
			label2 = new Label();
			Task2CountBox = new NumericUpDown();
			CalculateButton = new Button();
			groupBox2 = new GroupBox();
			ResultBox2 = new TextBox();
			tabPage3 = new TabPage();
			groupBox6 = new GroupBox();
			AutoResultBox = new TextBox();
			groupBox1 = new GroupBox();
			AutoCancelButton = new Button();
			BuyButton = new Button();
			OptionsGroup = new GroupBox();
			AutopilotBox = new CheckBox();
			InsideBox = new CheckBox();
			GlassBox = new CheckBox();
			EngineBox = new CheckBox();
			AirGasBox = new CheckBox();
			WheelBox = new CheckBox();
			ColorBox = new CheckBox();
			AutoPrice = new TextBox();
			label8 = new Label();
			label5 = new Label();
			AutoListBox = new ComboBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DateBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)MonthBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)YearBox).BeginInit();
			tabPage2.SuspendLayout();
			groupBox5.SuspendLayout();
			RadioGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Task2CountBox).BeginInit();
			groupBox2.SuspendLayout();
			tabPage3.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox1.SuspendLayout();
			OptionsGroup.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(800, 450);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(groupBox4);
			tabPage1.Controls.Add(groupBox3);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(792, 422);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Завдання №1";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(RegisterResultBox);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(346, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(443, 416);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "Результат";
			// 
			// RegisterResultBox
			// 
			RegisterResultBox.Dock = DockStyle.Fill;
			RegisterResultBox.Location = new Point(3, 19);
			RegisterResultBox.Multiline = true;
			RegisterResultBox.Name = "RegisterResultBox";
			RegisterResultBox.ReadOnly = true;
			RegisterResultBox.Size = new Size(437, 394);
			RegisterResultBox.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(DateBox);
			groupBox3.Controls.Add(MonthBox);
			groupBox3.Controls.Add(YearBox);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(label1);
			groupBox3.Controls.Add(ClearRegisterButton);
			groupBox3.Controls.Add(RegisterButton);
			groupBox3.Controls.Add(EmailBox);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(LastNameBox);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(FirstNameBox);
			groupBox3.Controls.Add(label6);
			groupBox3.Dock = DockStyle.Left;
			groupBox3.Location = new Point(3, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(343, 416);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Реєстрація";
			// 
			// DateBox
			// 
			DateBox.Location = new Point(229, 84);
			DateBox.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			DateBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			DateBox.Name = "DateBox";
			DateBox.Size = new Size(103, 23);
			DateBox.TabIndex = 16;
			DateBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// MonthBox
			// 
			MonthBox.Location = new Point(106, 84);
			MonthBox.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
			MonthBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			MonthBox.Name = "MonthBox";
			MonthBox.Size = new Size(117, 23);
			MonthBox.TabIndex = 15;
			MonthBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
			MonthBox.ValueChanged += MonthBox_ValueChanged;
			// 
			// YearBox
			// 
			YearBox.Location = new Point(6, 84);
			YearBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
			YearBox.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
			YearBox.Name = "YearBox";
			YearBox.Size = new Size(94, 23);
			YearBox.TabIndex = 14;
			YearBox.Value = new decimal(new int[] { 1980, 0, 0, 0 });
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(229, 66);
			label4.Name = "label4";
			label4.Size = new Size(103, 15);
			label4.TabIndex = 13;
			label4.Text = "Дата народження";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(106, 66);
			label3.Name = "label3";
			label3.Size = new Size(117, 15);
			label3.TabIndex = 12;
			label3.Text = "Місяць народження";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 66);
			label1.Name = "label1";
			label1.Size = new Size(94, 15);
			label1.TabIndex = 11;
			label1.Text = "Рік народження";
			// 
			// ClearRegisterButton
			// 
			ClearRegisterButton.Location = new Point(6, 203);
			ClearRegisterButton.Name = "ClearRegisterButton";
			ClearRegisterButton.Size = new Size(326, 40);
			ClearRegisterButton.TabIndex = 10;
			ClearRegisterButton.Text = "Очистити";
			ClearRegisterButton.UseVisualStyleBackColor = true;
			ClearRegisterButton.Click += ClearRegisterButton_Click;
			// 
			// RegisterButton
			// 
			RegisterButton.Location = new Point(6, 157);
			RegisterButton.Name = "RegisterButton";
			RegisterButton.Size = new Size(329, 40);
			RegisterButton.TabIndex = 9;
			RegisterButton.Text = "Реєстрація";
			RegisterButton.UseVisualStyleBackColor = true;
			RegisterButton.Click += RegisterButton_Click;
			// 
			// EmailBox
			// 
			EmailBox.Location = new Point(6, 128);
			EmailBox.Name = "EmailBox";
			EmailBox.Size = new Size(220, 23);
			EmailBox.TabIndex = 8;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 110);
			label9.Name = "label9";
			label9.Size = new Size(36, 15);
			label9.TabIndex = 7;
			label9.Text = "Email";
			// 
			// LastNameBox
			// 
			LastNameBox.Location = new Point(162, 40);
			LastNameBox.Name = "LastNameBox";
			LastNameBox.Size = new Size(150, 23);
			LastNameBox.TabIndex = 3;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(162, 19);
			label7.Name = "label7";
			label7.Size = new Size(61, 15);
			label7.TabIndex = 2;
			label7.Text = "Прізвище";
			// 
			// FirstNameBox
			// 
			FirstNameBox.Location = new Point(6, 40);
			FirstNameBox.Name = "FirstNameBox";
			FirstNameBox.Size = new Size(150, 23);
			FirstNameBox.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 22);
			label6.Name = "label6";
			label6.Size = new Size(28, 15);
			label6.TabIndex = 0;
			label6.Text = "Ім'я";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(groupBox5);
			tabPage2.Controls.Add(groupBox2);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(792, 422);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Завдання №2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(RadioGroupBox);
			groupBox5.Controls.Add(label2);
			groupBox5.Controls.Add(Task2CountBox);
			groupBox5.Controls.Add(CalculateButton);
			groupBox5.Dock = DockStyle.Left;
			groupBox5.Location = new Point(3, 3);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(337, 416);
			groupBox5.TabIndex = 10;
			groupBox5.TabStop = false;
			groupBox5.Text = "Вхідні дані";
			// 
			// RadioGroupBox
			// 
			RadioGroupBox.Controls.Add(RadButtonType1);
			RadioGroupBox.Controls.Add(RadButtonType2);
			RadioGroupBox.Controls.Add(RadButtonType3);
			RadioGroupBox.Location = new Point(15, 22);
			RadioGroupBox.Name = "RadioGroupBox";
			RadioGroupBox.Size = new Size(200, 95);
			RadioGroupBox.TabIndex = 8;
			RadioGroupBox.TabStop = false;
			RadioGroupBox.Text = "Тип друку";
			// 
			// RadButtonType1
			// 
			RadButtonType1.AutoSize = true;
			RadButtonType1.Checked = true;
			RadButtonType1.Location = new Point(6, 20);
			RadButtonType1.Name = "RadButtonType1";
			RadButtonType1.Size = new Size(97, 19);
			RadButtonType1.TabIndex = 0;
			RadButtonType1.TabStop = true;
			RadButtonType1.Text = "9х12 - 15 грн.";
			RadButtonType1.UseVisualStyleBackColor = true;
			// 
			// RadButtonType2
			// 
			RadButtonType2.AutoSize = true;
			RadButtonType2.Location = new Point(6, 45);
			RadButtonType2.Name = "RadButtonType2";
			RadButtonType2.Size = new Size(103, 19);
			RadButtonType2.TabIndex = 2;
			RadButtonType2.Text = "12х15 - 25 грн.";
			RadButtonType2.UseVisualStyleBackColor = true;
			// 
			// RadButtonType3
			// 
			RadButtonType3.AutoSize = true;
			RadButtonType3.Location = new Point(6, 70);
			RadButtonType3.Name = "RadButtonType3";
			RadButtonType3.Size = new Size(103, 19);
			RadButtonType3.TabIndex = 3;
			RadButtonType3.Text = "18х24 - 40 грн.";
			RadButtonType3.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 120);
			label2.Name = "label2";
			label2.Size = new Size(56, 15);
			label2.TabIndex = 4;
			label2.Text = "Кількість";
			// 
			// Task2CountBox
			// 
			Task2CountBox.Location = new Point(15, 138);
			Task2CountBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			Task2CountBox.Name = "Task2CountBox";
			Task2CountBox.Size = new Size(120, 23);
			Task2CountBox.TabIndex = 5;
			// 
			// CalculateButton
			// 
			CalculateButton.Location = new Point(15, 167);
			CalculateButton.Name = "CalculateButton";
			CalculateButton.Size = new Size(120, 30);
			CalculateButton.TabIndex = 6;
			CalculateButton.Text = "Розрахувати";
			CalculateButton.UseVisualStyleBackColor = true;
			CalculateButton.Click += CalculateButton_Click;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(ResultBox2);
			groupBox2.Location = new Point(346, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(438, 416);
			groupBox2.TabIndex = 9;
			groupBox2.TabStop = false;
			groupBox2.Text = "Результат";
			// 
			// ResultBox2
			// 
			ResultBox2.Dock = DockStyle.Fill;
			ResultBox2.Location = new Point(3, 19);
			ResultBox2.Multiline = true;
			ResultBox2.Name = "ResultBox2";
			ResultBox2.ReadOnly = true;
			ResultBox2.Size = new Size(432, 394);
			ResultBox2.TabIndex = 7;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(groupBox6);
			tabPage3.Controls.Add(groupBox1);
			tabPage3.Location = new Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(792, 422);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Завдання №3";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(AutoResultBox);
			groupBox6.Dock = DockStyle.Right;
			groupBox6.Location = new Point(312, 3);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(477, 416);
			groupBox6.TabIndex = 3;
			groupBox6.TabStop = false;
			groupBox6.Text = "Результат";
			// 
			// AutoResultBox
			// 
			AutoResultBox.Dock = DockStyle.Fill;
			AutoResultBox.Location = new Point(3, 19);
			AutoResultBox.Multiline = true;
			AutoResultBox.Name = "AutoResultBox";
			AutoResultBox.ReadOnly = true;
			AutoResultBox.Size = new Size(471, 394);
			AutoResultBox.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(AutoCancelButton);
			groupBox1.Controls.Add(BuyButton);
			groupBox1.Controls.Add(OptionsGroup);
			groupBox1.Controls.Add(AutoPrice);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(AutoListBox);
			groupBox1.Dock = DockStyle.Left;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(303, 416);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Вхідні дані";
			// 
			// AutoCancelButton
			// 
			AutoCancelButton.Location = new Point(190, 368);
			AutoCancelButton.Name = "AutoCancelButton";
			AutoCancelButton.Size = new Size(107, 42);
			AutoCancelButton.TabIndex = 7;
			AutoCancelButton.Text = "Скасувати";
			AutoCancelButton.UseVisualStyleBackColor = true;
			AutoCancelButton.Click += AutoCancelButton_Click;
			// 
			// BuyButton
			// 
			BuyButton.Location = new Point(6, 368);
			BuyButton.Name = "BuyButton";
			BuyButton.Size = new Size(107, 42);
			BuyButton.TabIndex = 6;
			BuyButton.Text = "Придбати";
			BuyButton.UseVisualStyleBackColor = true;
			BuyButton.Click += BuyButton_Click;
			// 
			// OptionsGroup
			// 
			OptionsGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			OptionsGroup.Controls.Add(AutopilotBox);
			OptionsGroup.Controls.Add(InsideBox);
			OptionsGroup.Controls.Add(GlassBox);
			OptionsGroup.Controls.Add(EngineBox);
			OptionsGroup.Controls.Add(AirGasBox);
			OptionsGroup.Controls.Add(WheelBox);
			OptionsGroup.Controls.Add(ColorBox);
			OptionsGroup.Location = new Point(6, 110);
			OptionsGroup.Name = "OptionsGroup";
			OptionsGroup.Size = new Size(291, 252);
			OptionsGroup.TabIndex = 5;
			OptionsGroup.TabStop = false;
			OptionsGroup.Text = "Опції";
			// 
			// AutopilotBox
			// 
			AutopilotBox.AutoSize = true;
			AutopilotBox.Location = new Point(6, 172);
			AutopilotBox.Name = "AutopilotBox";
			AutopilotBox.Size = new Size(152, 19);
			AutopilotBox.TabIndex = 10;
			AutopilotBox.Text = "Автопілот (+7 500 грн.)";
			AutopilotBox.UseVisualStyleBackColor = true;
			// 
			// InsideBox
			// 
			InsideBox.AutoSize = true;
			InsideBox.Location = new Point(6, 147);
			InsideBox.Name = "InsideBox";
			InsideBox.Size = new Size(222, 19);
			InsideBox.TabIndex = 9;
			InsideBox.Text = "Салон преміум класу (+15 000 грн.)";
			InsideBox.UseVisualStyleBackColor = true;
			// 
			// GlassBox
			// 
			GlassBox.AutoSize = true;
			GlassBox.Location = new Point(6, 122);
			GlassBox.Name = "GlassBox";
			GlassBox.Size = new Size(183, 19);
			GlassBox.TabIndex = 8;
			GlassBox.Text = "Тонування скла (+1 000 грн.)";
			GlassBox.UseVisualStyleBackColor = true;
			// 
			// EngineBox
			// 
			EngineBox.AutoSize = true;
			EngineBox.Location = new Point(6, 97);
			EngineBox.Name = "EngineBox";
			EngineBox.Size = new Size(187, 19);
			EngineBox.TabIndex = 7;
			EngineBox.Text = "Тюнінг двигуна (+50 000 грн.)";
			EngineBox.UseVisualStyleBackColor = true;
			// 
			// AirGasBox
			// 
			AirGasBox.AutoSize = true;
			AirGasBox.Location = new Point(6, 72);
			AirGasBox.Name = "AirGasBox";
			AirGasBox.Size = new Size(184, 19);
			AirGasBox.TabIndex = 6;
			AirGasBox.Text = "Тюнінг вихлопу (+2 500 грн.)";
			AirGasBox.UseVisualStyleBackColor = true;
			// 
			// WheelBox
			// 
			WheelBox.AutoSize = true;
			WheelBox.Location = new Point(6, 47);
			WheelBox.Name = "WheelBox";
			WheelBox.Size = new Size(189, 19);
			WheelBox.TabIndex = 5;
			WheelBox.Text = "Зміна типу коліс (+5 000 грн.)";
			WheelBox.UseVisualStyleBackColor = true;
			// 
			// ColorBox
			// 
			ColorBox.AutoSize = true;
			ColorBox.Location = new Point(6, 22);
			ColorBox.Name = "ColorBox";
			ColorBox.Size = new Size(211, 19);
			ColorBox.TabIndex = 4;
			ColorBox.Text = "Зміна кольору авто (+10 000 грн.)";
			ColorBox.UseVisualStyleBackColor = true;
			// 
			// AutoPrice
			// 
			AutoPrice.Location = new Point(6, 81);
			AutoPrice.Name = "AutoPrice";
			AutoPrice.ReadOnly = true;
			AutoPrice.Size = new Size(180, 23);
			AutoPrice.TabIndex = 3;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 63);
			label8.Name = "label8";
			label8.Size = new Size(118, 15);
			label8.TabIndex = 2;
			label8.Text = "Вартість автомобіля";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 19);
			label5.Name = "label5";
			label5.Size = new Size(72, 15);
			label5.TabIndex = 0;
			label5.Text = "Автомобіль";
			// 
			// AutoListBox
			// 
			AutoListBox.DropDownStyle = ComboBoxStyle.DropDownList;
			AutoListBox.FormattingEnabled = true;
			AutoListBox.Location = new Point(6, 37);
			AutoListBox.Name = "AutoListBox";
			AutoListBox.Size = new Size(180, 23);
			AutoListBox.TabIndex = 1;
			AutoListBox.SelectedIndexChanged += AutoListBox_SelectedIndexChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Практична робота №3";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DateBox).EndInit();
			((System.ComponentModel.ISupportInitialize)MonthBox).EndInit();
			((System.ComponentModel.ISupportInitialize)YearBox).EndInit();
			tabPage2.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			RadioGroupBox.ResumeLayout(false);
			RadioGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Task2CountBox).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			tabPage3.ResumeLayout(false);
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			OptionsGroup.ResumeLayout(false);
			OptionsGroup.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private GroupBox groupBox4;
		private TextBox RegisterResultBox;
		private GroupBox groupBox3;
		private Button ClearRegisterButton;
		private Button RegisterButton;
		private TextBox EmailBox;
		private Label label9;
		private TextBox LastNameBox;
		private Label label7;
		private TextBox FirstNameBox;
		private Label label6;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private RadioButton RadButtonType1;
		private RadioButton RadButtonType2;
		private RadioButton RadButtonType3;
		private NumericUpDown Task2CountBox;
		private Label label2;
		private Button CalculateButton;
		private TextBox ResultBox2;
		private GroupBox RadioGroupBox;
		private GroupBox groupBox5;
		private GroupBox groupBox2;
		private NumericUpDown DateBox;
		private NumericUpDown MonthBox;
		private NumericUpDown YearBox;
		private Label label4;
		private Label label3;
		private Label label1;
		private ComboBox AutoListBox;
		private Label label5;
		private GroupBox groupBox1;
		private Label label8;
		private TextBox AutoPrice;
		private Button BuyButton;
		private GroupBox OptionsGroup;
		private CheckBox ColorBox;
		private CheckBox EngineBox;
		private CheckBox AirGasBox;
		private CheckBox WheelBox;
		private CheckBox AutopilotBox;
		private CheckBox InsideBox;
		private CheckBox GlassBox;
		private GroupBox groupBox6;
		private Button AutoCancelButton;
		private TextBox AutoResultBox;
	}
}
