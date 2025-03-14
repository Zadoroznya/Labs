namespace Practic4
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
			groupBox2 = new GroupBox();
			ResumeBox = new TextBox();
			GenerateResumeButton = new Button();
			groupBox1 = new GroupBox();
			DeleteSkinButton = new Button();
			PhoneBox = new MaskedTextBox();
			SkillBox = new ListBox();
			AddSkillButton = new Button();
			AddSkillBox = new TextBox();
			label6 = new Label();
			EmailBox = new TextBox();
			label5 = new Label();
			label4 = new Label();
			MiddleNameBox = new TextBox();
			label3 = new Label();
			FirstNameBox = new TextBox();
			label2 = new Label();
			LastNameBox = new TextBox();
			label1 = new Label();
			tabPage2 = new TabPage();
			groupBox4 = new GroupBox();
			RegisterResultBox = new TextBox();
			groupBox3 = new GroupBox();
			MonthBox = new ComboBox();
			CityBirthBox = new ComboBox();
			label13 = new Label();
			DateBox = new NumericUpDown();
			YearBox = new NumericUpDown();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			ClearRegisterButton = new Button();
			RegisterButton = new Button();
			EmailRegisterBox = new TextBox();
			label10 = new Label();
			LastNameRegisterBox = new TextBox();
			label11 = new Label();
			FirstNameRegisterBox = new TextBox();
			label12 = new Label();
			tabPage3 = new TabPage();
			groupBox6 = new GroupBox();
			groupBox5 = new GroupBox();
			EducationBox = new CheckedListBox();
			label14 = new Label();
			Task3ResultBox = new TextBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)DateBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)YearBox).BeginInit();
			tabPage3.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox5.SuspendLayout();
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
			tabPage1.Controls.Add(groupBox2);
			tabPage1.Controls.Add(groupBox1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(792, 422);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Завдання №1";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(ResumeBox);
			groupBox2.Controls.Add(GenerateResumeButton);
			groupBox2.Dock = DockStyle.Right;
			groupBox2.Location = new Point(321, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(468, 416);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Результат";
			// 
			// ResumeBox
			// 
			ResumeBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ResumeBox.Location = new Point(6, 66);
			ResumeBox.Multiline = true;
			ResumeBox.Name = "ResumeBox";
			ResumeBox.ReadOnly = true;
			ResumeBox.Size = new Size(456, 344);
			ResumeBox.TabIndex = 1;
			// 
			// GenerateResumeButton
			// 
			GenerateResumeButton.Location = new Point(6, 22);
			GenerateResumeButton.Name = "GenerateResumeButton";
			GenerateResumeButton.Size = new Size(120, 38);
			GenerateResumeButton.TabIndex = 0;
			GenerateResumeButton.Text = "Згенерувати";
			GenerateResumeButton.UseVisualStyleBackColor = true;
			GenerateResumeButton.Click += GenerateResumeButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(DeleteSkinButton);
			groupBox1.Controls.Add(PhoneBox);
			groupBox1.Controls.Add(SkillBox);
			groupBox1.Controls.Add(AddSkillButton);
			groupBox1.Controls.Add(AddSkillBox);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(EmailBox);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(MiddleNameBox);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(FirstNameBox);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(LastNameBox);
			groupBox1.Controls.Add(label1);
			groupBox1.Dock = DockStyle.Left;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(312, 416);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Вхідні дані";
			// 
			// DeleteSkinButton
			// 
			DeleteSkinButton.Location = new Point(231, 286);
			DeleteSkinButton.Name = "DeleteSkinButton";
			DeleteSkinButton.Size = new Size(75, 75);
			DeleteSkinButton.TabIndex = 11;
			DeleteSkinButton.Text = "Видалити";
			DeleteSkinButton.UseVisualStyleBackColor = true;
			DeleteSkinButton.Click += DeleteSkinButton_Click;
			// 
			// PhoneBox
			// 
			PhoneBox.Location = new Point(6, 169);
			PhoneBox.Mask = "+(000) 00-000-00-00";
			PhoneBox.Name = "PhoneBox";
			PhoneBox.Size = new Size(139, 23);
			PhoneBox.TabIndex = 6;
			// 
			// SkillBox
			// 
			SkillBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			SkillBox.FormattingEnabled = true;
			SkillBox.ItemHeight = 15;
			SkillBox.Location = new Point(6, 286);
			SkillBox.Name = "SkillBox";
			SkillBox.Size = new Size(220, 124);
			SkillBox.TabIndex = 10;
			// 
			// AddSkillButton
			// 
			AddSkillButton.Location = new Point(151, 256);
			AddSkillButton.Name = "AddSkillButton";
			AddSkillButton.Size = new Size(75, 23);
			AddSkillButton.TabIndex = 8;
			AddSkillButton.Text = "Додати";
			AddSkillButton.UseVisualStyleBackColor = true;
			AddSkillButton.Click += AddSkillButton_Click;
			// 
			// AddSkillBox
			// 
			AddSkillBox.Location = new Point(6, 257);
			AddSkillBox.Name = "AddSkillBox";
			AddSkillBox.Size = new Size(139, 23);
			AddSkillBox.TabIndex = 8;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 239);
			label6.Name = "label6";
			label6.Size = new Size(94, 15);
			label6.TabIndex = 10;
			label6.Text = "Додати навичку";
			// 
			// EmailBox
			// 
			EmailBox.Location = new Point(6, 213);
			EmailBox.Name = "EmailBox";
			EmailBox.Size = new Size(139, 23);
			EmailBox.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 195);
			label5.Name = "label5";
			label5.Size = new Size(36, 15);
			label5.TabIndex = 8;
			label5.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 151);
			label4.Name = "label4";
			label4.Size = new Size(55, 15);
			label4.TabIndex = 6;
			label4.Text = "Телефон";
			// 
			// MiddleNameBox
			// 
			MiddleNameBox.Location = new Point(6, 125);
			MiddleNameBox.Name = "MiddleNameBox";
			MiddleNameBox.Size = new Size(139, 23);
			MiddleNameBox.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 107);
			label3.Name = "label3";
			label3.Size = new Size(74, 15);
			label3.TabIndex = 4;
			label3.Text = "По-батькові";
			// 
			// FirstNameBox
			// 
			FirstNameBox.Location = new Point(6, 81);
			FirstNameBox.Name = "FirstNameBox";
			FirstNameBox.Size = new Size(139, 23);
			FirstNameBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 63);
			label2.Name = "label2";
			label2.Size = new Size(28, 15);
			label2.TabIndex = 2;
			label2.Text = "Ім'я";
			// 
			// LastNameBox
			// 
			LastNameBox.Location = new Point(6, 37);
			LastNameBox.Name = "LastNameBox";
			LastNameBox.Size = new Size(139, 23);
			LastNameBox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(61, 15);
			label1.TabIndex = 0;
			label1.Text = "Прізвище";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(groupBox4);
			tabPage2.Controls.Add(groupBox3);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(792, 422);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Завдання №2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(RegisterResultBox);
			groupBox4.Dock = DockStyle.Fill;
			groupBox4.Location = new Point(346, 3);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(443, 416);
			groupBox4.TabIndex = 5;
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
			groupBox3.Controls.Add(MonthBox);
			groupBox3.Controls.Add(CityBirthBox);
			groupBox3.Controls.Add(label13);
			groupBox3.Controls.Add(DateBox);
			groupBox3.Controls.Add(YearBox);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(label8);
			groupBox3.Controls.Add(label9);
			groupBox3.Controls.Add(ClearRegisterButton);
			groupBox3.Controls.Add(RegisterButton);
			groupBox3.Controls.Add(EmailRegisterBox);
			groupBox3.Controls.Add(label10);
			groupBox3.Controls.Add(LastNameRegisterBox);
			groupBox3.Controls.Add(label11);
			groupBox3.Controls.Add(FirstNameRegisterBox);
			groupBox3.Controls.Add(label12);
			groupBox3.Dock = DockStyle.Left;
			groupBox3.Location = new Point(3, 3);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(343, 416);
			groupBox3.TabIndex = 4;
			groupBox3.TabStop = false;
			groupBox3.Text = "Реєстрація";
			// 
			// MonthBox
			// 
			MonthBox.DropDownStyle = ComboBoxStyle.DropDownList;
			MonthBox.FormattingEnabled = true;
			MonthBox.Items.AddRange(new object[] { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" });
			MonthBox.Location = new Point(106, 84);
			MonthBox.Name = "MonthBox";
			MonthBox.Size = new Size(117, 23);
			MonthBox.TabIndex = 4;
			MonthBox.SelectedIndexChanged += MonthBox_SelectedIndexChanged;
			// 
			// CityBirthBox
			// 
			CityBirthBox.DropDownStyle = ComboBoxStyle.DropDownList;
			CityBirthBox.FormattingEnabled = true;
			CityBirthBox.Items.AddRange(new object[] { "Київ", "Полтава", "Львів", "Харків", "Житомир", "Одеса", "Миколаїв", "Херсон", "Рівне", "Луцьк", "Ужгород" });
			CityBirthBox.Location = new Point(6, 172);
			CityBirthBox.Name = "CityBirthBox";
			CityBirthBox.Size = new Size(150, 23);
			CityBirthBox.TabIndex = 7;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(6, 154);
			label13.Name = "label13";
			label13.Size = new Size(110, 15);
			label13.TabIndex = 17;
			label13.Text = "Місто народження";
			// 
			// DateBox
			// 
			DateBox.Location = new Point(229, 84);
			DateBox.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
			DateBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			DateBox.Name = "DateBox";
			DateBox.Size = new Size(103, 23);
			DateBox.TabIndex = 5;
			DateBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// YearBox
			// 
			YearBox.Location = new Point(6, 84);
			YearBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
			YearBox.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
			YearBox.Name = "YearBox";
			YearBox.Size = new Size(94, 23);
			YearBox.TabIndex = 3;
			YearBox.Value = new decimal(new int[] { 1980, 0, 0, 0 });
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(229, 66);
			label7.Name = "label7";
			label7.Size = new Size(103, 15);
			label7.TabIndex = 13;
			label7.Text = "Дата народження";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(106, 66);
			label8.Name = "label8";
			label8.Size = new Size(117, 15);
			label8.TabIndex = 12;
			label8.Text = "Місяць народження";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 66);
			label9.Name = "label9";
			label9.Size = new Size(94, 15);
			label9.TabIndex = 11;
			label9.Text = "Рік народження";
			// 
			// ClearRegisterButton
			// 
			ClearRegisterButton.Location = new Point(3, 247);
			ClearRegisterButton.Name = "ClearRegisterButton";
			ClearRegisterButton.Size = new Size(326, 40);
			ClearRegisterButton.TabIndex = 9;
			ClearRegisterButton.Text = "Очистити";
			ClearRegisterButton.UseVisualStyleBackColor = true;
			ClearRegisterButton.Click += ClearRegisterButton_Click;
			// 
			// RegisterButton
			// 
			RegisterButton.Location = new Point(3, 201);
			RegisterButton.Name = "RegisterButton";
			RegisterButton.Size = new Size(329, 40);
			RegisterButton.TabIndex = 8;
			RegisterButton.Text = "Реєстрація";
			RegisterButton.UseVisualStyleBackColor = true;
			RegisterButton.Click += RegisterButton_Click;
			// 
			// EmailRegisterBox
			// 
			EmailRegisterBox.Location = new Point(6, 128);
			EmailRegisterBox.Name = "EmailRegisterBox";
			EmailRegisterBox.Size = new Size(220, 23);
			EmailRegisterBox.TabIndex = 6;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(6, 110);
			label10.Name = "label10";
			label10.Size = new Size(36, 15);
			label10.TabIndex = 7;
			label10.Text = "Email";
			// 
			// LastNameRegisterBox
			// 
			LastNameRegisterBox.Location = new Point(162, 40);
			LastNameRegisterBox.Name = "LastNameRegisterBox";
			LastNameRegisterBox.Size = new Size(150, 23);
			LastNameRegisterBox.TabIndex = 2;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(162, 19);
			label11.Name = "label11";
			label11.Size = new Size(61, 15);
			label11.TabIndex = 2;
			label11.Text = "Прізвище";
			// 
			// FirstNameRegisterBox
			// 
			FirstNameRegisterBox.Location = new Point(6, 40);
			FirstNameRegisterBox.Name = "FirstNameRegisterBox";
			FirstNameRegisterBox.Size = new Size(150, 23);
			FirstNameRegisterBox.TabIndex = 1;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(6, 22);
			label12.Name = "label12";
			label12.Size = new Size(28, 15);
			label12.TabIndex = 0;
			label12.Text = "Ім'я";
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(groupBox6);
			tabPage3.Controls.Add(groupBox5);
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
			groupBox6.Controls.Add(Task3ResultBox);
			groupBox6.Dock = DockStyle.Right;
			groupBox6.Location = new Point(291, 3);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(498, 416);
			groupBox6.TabIndex = 1;
			groupBox6.TabStop = false;
			groupBox6.Text = "Результат";
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(EducationBox);
			groupBox5.Controls.Add(label14);
			groupBox5.Dock = DockStyle.Left;
			groupBox5.Location = new Point(3, 3);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(282, 416);
			groupBox5.TabIndex = 0;
			groupBox5.TabStop = false;
			groupBox5.Text = "Вхідні дані";
			// 
			// EducationBox
			// 
			EducationBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			EducationBox.FormattingEnabled = true;
			EducationBox.Items.AddRange(new object[] { "Адміністрування комп’ютерних систем і мереж", "Веб-орієнтована розробка програмного забезпечення", "Дослідження операцій", "Інструментальні засоби захисту інформації в корпоративних мережах", "Методи та засоби аналізу багатовимірних даних", "Комп’ютерна графіка", "Криптографічні методи захисту інформації", "Мережі наступного покоління", "Мікропроцесорна техніка", "Мова програмування Java", "Основи ігрової графіки", "Основи наукових досліджень", "Основи розпізнавання зображень", "Програмування в ОС Android", "Програмування для мобільних пристроїв", "Програмування мовою Pyton", "Розробка комп’ютерних ігор", "Сервіс-орієнтована архітектура програмного забезпечення", "Сучасні технології проектування графічного інтерфейсу користувача (WPF)", "Теорія інформації та кодування", "Технології розподілених систем та паралельних обчислень (окрім спеціальності 121 “Інженерія програмного забезпечення”)", "Технологія ASP.Net", "Технології хмарних обчислень", "Цифрова обробка сигналів", "Якість програмного забезпечення та тестування (окрім спеціальності 121 “Інженерія програмного забезпечення”)", "Економіка ІТ-індустрії" });
			EducationBox.Location = new Point(6, 37);
			EducationBox.Name = "EducationBox";
			EducationBox.Size = new Size(270, 364);
			EducationBox.TabIndex = 1;
			EducationBox.CheckOnClick = true;
			EducationBox.ItemCheck += EducationBox_ItemCheck;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(6, 19);
			label14.Name = "label14";
			label14.Size = new Size(111, 15);
			label14.TabIndex = 0;
			label14.Text = "Перелік дисциплін";
			// 
			// Task3ResultBox
			// 
			Task3ResultBox.Dock = DockStyle.Fill;
			Task3ResultBox.Location = new Point(3, 19);
			Task3ResultBox.Multiline = true;
			Task3ResultBox.Name = "Task3ResultBox";
			Task3ResultBox.ReadOnly = true;
			Task3ResultBox.Size = new Size(492, 394);
			Task3ResultBox.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Name = "Form1";
			Text = "Практична робота №4";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			tabPage2.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)DateBox).EndInit();
			((System.ComponentModel.ISupportInitialize)YearBox).EndInit();
			tabPage3.ResumeLayout(false);
			groupBox6.ResumeLayout(false);
			groupBox6.PerformLayout();
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private GroupBox groupBox2;
		private GroupBox groupBox1;
		private TextBox FirstNameBox;
		private Label label2;
		private TextBox LastNameBox;
		private Label label1;
		private TextBox EmailBox;
		private Label label5;
		private Label label4;
		private TextBox MiddleNameBox;
		private Label label3;
		private ListBox SkillBox;
		private Button AddSkillButton;
		private TextBox AddSkillBox;
		private Label label6;
		private Button GenerateResumeButton;
		private TextBox ResumeBox;
		private MaskedTextBox PhoneBox;
		private Button DeleteSkinButton;
		private GroupBox groupBox4;
		private TextBox RegisterResultBox;
		private GroupBox groupBox3;
		private NumericUpDown DateBox;
		private NumericUpDown YearBox;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button ClearRegisterButton;
		private Button RegisterButton;
		private TextBox EmailRegisterBox;
		private Label label10;
		private TextBox LastNameRegisterBox;
		private Label label11;
		private TextBox FirstNameRegisterBox;
		private Label label12;
		private ComboBox CityBirthBox;
		private Label label13;
		private ComboBox MonthBox;
		private GroupBox groupBox6;
		private GroupBox groupBox5;
		private CheckedListBox EducationBox;
		private Label label14;
		private TextBox Task3ResultBox;
	}
}
