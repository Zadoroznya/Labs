namespace Practic1
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
			tabControl = new TabControl();
			TaskTab1 = new TabPage();
			groupBox2 = new GroupBox();
			ClearButton = new Button();
			ResultBox = new TextBox();
			CalculateButton = new Button();
			groupBox1 = new GroupBox();
			DistanceBox = new NumericUpDown();
			label5 = new Label();
			label1 = new Label();
			IsCustomDeliveryPrice = new CheckBox();
			ItemSelector = new ComboBox();
			DeliveryPriceBox = new NumericUpDown();
			label2 = new Label();
			label4 = new Label();
			StageLevel = new NumericUpDown();
			ElevatorTypeBox = new ComboBox();
			IsElevatorBox = new CheckBox();
			label3 = new Label();
			TaskTab2 = new TabPage();
			groupBox4 = new GroupBox();
			RegisterResultBox = new TextBox();
			groupBox3 = new GroupBox();
			ClearRegisterButton = new Button();
			RegisterButton = new Button();
			EmailBox = new TextBox();
			label9 = new Label();
			DateBirthPicker = new DateTimePicker();
			label8 = new Label();
			LastNameBox = new TextBox();
			label7 = new Label();
			FirstNameBox = new TextBox();
			label6 = new Label();
			tabControl.SuspendLayout();
			TaskTab1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DistanceBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)DeliveryPriceBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)StageLevel).BeginInit();
			TaskTab2.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl
			// 
			tabControl.Controls.Add(TaskTab1);
			tabControl.Controls.Add(TaskTab2);
			tabControl.Dock = DockStyle.Fill;
			tabControl.Location = new Point(0, 0);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.Size = new Size(800, 450);
			tabControl.TabIndex = 0;
			// 
			// TaskTab1
			// 
			TaskTab1.Controls.Add(groupBox2);
			TaskTab1.Controls.Add(groupBox1);
			TaskTab1.Location = new Point(4, 24);
			TaskTab1.Name = "TaskTab1";
			TaskTab1.Padding = new Padding(3);
			TaskTab1.Size = new Size(792, 422);
			TaskTab1.TabIndex = 0;
			TaskTab1.Text = "Завдання №1";
			TaskTab1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(ClearButton);
			groupBox2.Controls.Add(ResultBox);
			groupBox2.Controls.Add(CalculateButton);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(278, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(511, 416);
			groupBox2.TabIndex = 12;
			groupBox2.TabStop = false;
			groupBox2.Text = "Результат розрахунку";
			// 
			// ClearButton
			// 
			ClearButton.Location = new Point(148, 22);
			ClearButton.Name = "ClearButton";
			ClearButton.Size = new Size(136, 38);
			ClearButton.TabIndex = 2;
			ClearButton.Text = "Очистити";
			ClearButton.UseVisualStyleBackColor = true;
			ClearButton.Click += ClearButton_Click;
			// 
			// ResultBox
			// 
			ResultBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ResultBox.Location = new Point(6, 66);
			ResultBox.Multiline = true;
			ResultBox.Name = "ResultBox";
			ResultBox.ReadOnly = true;
			ResultBox.Size = new Size(499, 344);
			ResultBox.TabIndex = 1;
			// 
			// CalculateButton
			// 
			CalculateButton.Location = new Point(6, 22);
			CalculateButton.Name = "CalculateButton";
			CalculateButton.Size = new Size(136, 38);
			CalculateButton.TabIndex = 0;
			CalculateButton.Text = "Розрахувати вартість";
			CalculateButton.UseVisualStyleBackColor = true;
			CalculateButton.Click += CalculateButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(DistanceBox);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(IsCustomDeliveryPrice);
			groupBox1.Controls.Add(ItemSelector);
			groupBox1.Controls.Add(DeliveryPriceBox);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(StageLevel);
			groupBox1.Controls.Add(ElevatorTypeBox);
			groupBox1.Controls.Add(IsElevatorBox);
			groupBox1.Controls.Add(label3);
			groupBox1.Dock = DockStyle.Left;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(275, 416);
			groupBox1.TabIndex = 11;
			groupBox1.TabStop = false;
			groupBox1.Text = "Вводні дані";
			// 
			// DistanceBox
			// 
			DistanceBox.Location = new Point(3, 263);
			DistanceBox.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
			DistanceBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			DistanceBox.Name = "DistanceBox";
			DistanceBox.Size = new Size(120, 23);
			DistanceBox.TabIndex = 12;
			DistanceBox.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 245);
			label5.Name = "label5";
			label5.Size = new Size(152, 15);
			label5.TabIndex = 11;
			label5.Text = "Відстань (5 км = 1 година):";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(71, 15);
			label1.TabIndex = 0;
			label1.Text = "Тип меблів:";
			// 
			// IsCustomDeliveryPrice
			// 
			IsCustomDeliveryPrice.AutoSize = true;
			IsCustomDeliveryPrice.Location = new Point(6, 179);
			IsCustomDeliveryPrice.Name = "IsCustomDeliveryPrice";
			IsCustomDeliveryPrice.Size = new Size(158, 19);
			IsCustomDeliveryPrice.TabIndex = 10;
			IsCustomDeliveryPrice.Text = "Перевизначити вартість";
			IsCustomDeliveryPrice.UseVisualStyleBackColor = true;
			IsCustomDeliveryPrice.CheckedChanged += IsCustomDeliveryPrice_CheckedChanged;
			// 
			// ItemSelector
			// 
			ItemSelector.DropDownStyle = ComboBoxStyle.DropDownList;
			ItemSelector.FormattingEnabled = true;
			ItemSelector.Location = new Point(6, 37);
			ItemSelector.Name = "ItemSelector";
			ItemSelector.Size = new Size(121, 23);
			ItemSelector.TabIndex = 1;
			ItemSelector.SelectedIndexChanged += ItemSelector_SelectedIndexChanged;
			// 
			// DeliveryPriceBox
			// 
			DeliveryPriceBox.Location = new Point(6, 219);
			DeliveryPriceBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			DeliveryPriceBox.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
			DeliveryPriceBox.Name = "DeliveryPriceBox";
			DeliveryPriceBox.Size = new Size(120, 23);
			DeliveryPriceBox.TabIndex = 9;
			DeliveryPriceBox.Value = new decimal(new int[] { 100, 0, 0, 0 });
			DeliveryPriceBox.ValueChanged += DeliveryPriceBox_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 63);
			label2.Name = "label2";
			label2.Size = new Size(96, 15);
			label2.TabIndex = 2;
			label2.Text = "Номер поверху:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 201);
			label4.Name = "label4";
			label4.Size = new Size(184, 15);
			label4.TabIndex = 8;
			label4.Text = "Вартість однієї години доставки:";
			// 
			// StageLevel
			// 
			StageLevel.Location = new Point(6, 81);
			StageLevel.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			StageLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			StageLevel.Name = "StageLevel";
			StageLevel.Size = new Size(120, 23);
			StageLevel.TabIndex = 3;
			StageLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// ElevatorTypeBox
			// 
			ElevatorTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
			ElevatorTypeBox.FormattingEnabled = true;
			ElevatorTypeBox.Location = new Point(6, 150);
			ElevatorTypeBox.Name = "ElevatorTypeBox";
			ElevatorTypeBox.Size = new Size(121, 23);
			ElevatorTypeBox.TabIndex = 7;
			// 
			// IsElevatorBox
			// 
			IsElevatorBox.AutoSize = true;
			IsElevatorBox.Location = new Point(6, 110);
			IsElevatorBox.Name = "IsElevatorBox";
			IsElevatorBox.Size = new Size(116, 19);
			IsElevatorBox.TabIndex = 5;
			IsElevatorBox.Text = "В наявності ліфт";
			IsElevatorBox.UseVisualStyleBackColor = true;
			IsElevatorBox.CheckedChanged += IsElevatorBox_CheckedChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 132);
			label3.Name = "label3";
			label3.Size = new Size(63, 15);
			label3.TabIndex = 6;
			label3.Text = "Тип ліфту:";
			// 
			// TaskTab2
			// 
			TaskTab2.Controls.Add(groupBox4);
			TaskTab2.Controls.Add(groupBox3);
			TaskTab2.Location = new Point(4, 24);
			TaskTab2.Name = "TaskTab2";
			TaskTab2.Padding = new Padding(3);
			TaskTab2.Size = new Size(792, 422);
			TaskTab2.TabIndex = 1;
			TaskTab2.Text = "Завдання №2";
			TaskTab2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(RegisterResultBox);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(235, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(554, 416);
			groupBox4.TabIndex = 1;
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
			RegisterResultBox.Size = new Size(548, 394);
			RegisterResultBox.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(ClearRegisterButton);
			groupBox3.Controls.Add(RegisterButton);
			groupBox3.Controls.Add(EmailBox);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(DateBirthPicker);
			groupBox3.Controls.Add(label8);
			groupBox3.Controls.Add(LastNameBox);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(FirstNameBox);
			groupBox3.Controls.Add(label6);
			groupBox3.Dock = DockStyle.Left;
			groupBox3.Location = new Point(3, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(232, 416);
			groupBox3.TabIndex = 0;
			groupBox3.TabStop = false;
			groupBox3.Text = "Реєстрація";
			// 
			// ClearRegisterButton
			// 
			ClearRegisterButton.Location = new Point(6, 247);
			ClearRegisterButton.Name = "ClearRegisterButton";
			ClearRegisterButton.Size = new Size(220, 40);
			ClearRegisterButton.TabIndex = 10;
			ClearRegisterButton.Text = "Очистити";
			ClearRegisterButton.UseVisualStyleBackColor = true;
			ClearRegisterButton.Click += ClearRegisterButton_Click;
			// 
			// RegisterButton
			// 
			RegisterButton.Location = new Point(6, 201);
			RegisterButton.Name = "RegisterButton";
			RegisterButton.Size = new Size(220, 40);
			RegisterButton.TabIndex = 9;
			RegisterButton.Text = "Реєстрація";
			RegisterButton.UseVisualStyleBackColor = true;
			RegisterButton.Click += RegisterButton_Click;
			// 
			// EmailBox
			// 
			EmailBox.Location = new Point(6, 172);
			EmailBox.Name = "EmailBox";
			EmailBox.Size = new Size(220, 23);
			EmailBox.TabIndex = 8;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 154);
			label9.Name = "label9";
			label9.Size = new Size(36, 15);
			label9.TabIndex = 7;
			label9.Text = "Email";
			// 
			// DateBirthPicker
			// 
			DateBirthPicker.Location = new Point(6, 128);
			DateBirthPicker.Name = "DateBirthPicker";
			DateBirthPicker.Size = new Size(220, 23);
			DateBirthPicker.TabIndex = 6;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 110);
			label8.Name = "label8";
			label8.Size = new Size(103, 15);
			label8.TabIndex = 5;
			label8.Text = "Дата народження";
			// 
			// LastNameBox
			// 
			LastNameBox.Location = new Point(6, 84);
			LastNameBox.Name = "LastNameBox";
			LastNameBox.Size = new Size(220, 23);
			LastNameBox.TabIndex = 3;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 66);
			label7.Name = "label7";
			label7.Size = new Size(61, 15);
			label7.TabIndex = 2;
			label7.Text = "Прізвище";
			// 
			// FirstNameBox
			// 
			FirstNameBox.Location = new Point(6, 40);
			FirstNameBox.Name = "FirstNameBox";
			FirstNameBox.Size = new Size(220, 23);
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Практична робота №1";
			tabControl.ResumeLayout(false);
			TaskTab1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DistanceBox).EndInit();
			((System.ComponentModel.ISupportInitialize)DeliveryPriceBox).EndInit();
			((System.ComponentModel.ISupportInitialize)StageLevel).EndInit();
			TaskTab2.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl;
		private TabPage TaskTab1;
		private TabPage TaskTab2;
		private ComboBox ItemSelector;
		private Label label1;
		private NumericUpDown StageLevel;
		private Label label2;
		private CheckBox IsCustomDeliveryPrice;
		private NumericUpDown DeliveryPriceBox;
		private Label label4;
		private ComboBox ElevatorTypeBox;
		private Label label3;
		private CheckBox IsElevatorBox;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private Button CalculateButton;
		private TextBox ResultBox;
		private Button ClearButton;
		private NumericUpDown DistanceBox;
		private Label label5;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private TextBox RegisterResultBox;
		private Label label8;
		private TextBox LastNameBox;
		private Label label7;
		private TextBox FirstNameBox;
		private Label label6;
		private DateTimePicker DateBirthPicker;
		private Button ClearRegisterButton;
		private Button RegisterButton;
		private TextBox EmailBox;
		private Label label9;
	}
}
