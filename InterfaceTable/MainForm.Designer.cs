namespace InterfaceTable
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountingTab = new System.Windows.Forms.TabControl();
            this.accountingPage = new System.Windows.Forms.TabPage();
            this.accountTable = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionPage = new System.Windows.Forms.TabPage();
            this.conditionsTable = new System.Windows.Forms.DataGridView();
            this.Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCalc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.ComboBox();
            this.total = new System.Windows.Forms.TextBox();
            this.organ = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.dateDocument = new System.Windows.Forms.DateTimePicker();
            this.actNumber = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.formOKUD = new System.Windows.Forms.TextBox();
            this.viewOperation = new System.Windows.Forms.TextBox();
            this.viewOKPD = new System.Windows.Forms.TextBox();
            this.formOKPO = new System.Windows.Forms.TextBox();
            this.spravka = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.totalSumF = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.totalSumEn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountingTab.SuspendLayout();
            this.accountingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).BeginInit();
            this.conditionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsTable)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountingTab
            // 
            this.AccountingTab.Controls.Add(this.accountingPage);
            this.AccountingTab.Controls.Add(this.conditionPage);
            this.AccountingTab.Location = new System.Drawing.Point(12, 125);
            this.AccountingTab.Name = "AccountingTab";
            this.AccountingTab.SelectedIndex = 0;
            this.AccountingTab.Size = new System.Drawing.Size(1062, 443);
            this.AccountingTab.TabIndex = 1;
            this.AccountingTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.AccountingTab_Selected);
            // 
            // accountingPage
            // 
            this.accountingPage.Controls.Add(this.accountTable);
            this.accountingPage.Location = new System.Drawing.Point(4, 22);
            this.accountingPage.Name = "accountingPage";
            this.accountingPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountingPage.Size = new System.Drawing.Size(1054, 417);
            this.accountingPage.TabIndex = 0;
            this.accountingPage.Text = "По ценам реализации";
            this.accountingPage.UseVisualStyleBackColor = true;
            // 
            // accountTable
            // 
            this.accountTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NumberCalc,
            this.Title,
            this.Code,
            this.ColRelise,
            this.CostFact,
            this.SumFact});
            this.accountTable.Location = new System.Drawing.Point(6, 6);
            this.accountTable.Name = "accountTable";
            this.accountTable.Size = new System.Drawing.Size(1042, 405);
            this.accountTable.TabIndex = 0;
            this.accountTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTable_CellContentClick);
            this.accountTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTable_CellValueChanged);
            this.accountTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.accountTable_RowsAdded);
            this.accountTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.accountTable_UserDeletingRow);
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер по порядку";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // NumberCalc
            // 
            this.NumberCalc.HeaderText = "Номер калькуляционной карточки";
            this.NumberCalc.Name = "NumberCalc";
            this.NumberCalc.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Recname";
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColRelise
            // 
            this.ColRelise.HeaderText = "Количество, шт.";
            this.ColRelise.Name = "ColRelise";
            // 
            // CostFact
            // 
            this.CostFact.HeaderText = "Цена, руб., коп.";
            this.CostFact.Name = "CostFact";
            // 
            // SumFact
            // 
            this.SumFact.HeaderText = "Сумма, руб., коп.";
            this.SumFact.Name = "SumFact";
            this.SumFact.ReadOnly = true;
            // 
            // conditionPage
            // 
            this.conditionPage.Controls.Add(this.conditionsTable);
            this.conditionPage.Location = new System.Drawing.Point(4, 22);
            this.conditionPage.Name = "conditionPage";
            this.conditionPage.Padding = new System.Windows.Forms.Padding(3);
            this.conditionPage.Size = new System.Drawing.Size(1054, 417);
            this.conditionPage.TabIndex = 1;
            this.conditionPage.Text = "По ценам производства";
            this.conditionPage.UseVisualStyleBackColor = true;
            // 
            // conditionsTable
            // 
            this.conditionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conditionsTable.ColumnHeadersHeight = 47;
            this.conditionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.conditionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number1,
            this.NumberCalc1,
            this.Title1,
            this.Code1,
            this.CostEnter,
            this.SumEnter,
            this.Note});
            this.conditionsTable.Location = new System.Drawing.Point(6, 6);
            this.conditionsTable.Name = "conditionsTable";
            this.conditionsTable.Size = new System.Drawing.Size(1042, 405);
            this.conditionsTable.TabIndex = 1;
            this.conditionsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.conditionsTable_CellValueChanged);
            this.conditionsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.conditionsTable_RowsAdded);
            this.conditionsTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.conditionsTable_UserDeletingRow);
            // 
            // Number1
            // 
            this.Number1.FillWeight = 0.5577361F;
            this.Number1.HeaderText = "Номер по порядку";
            this.Number1.MinimumWidth = 100;
            this.Number1.Name = "Number1";
            this.Number1.ReadOnly = true;
            // 
            // NumberCalc1
            // 
            this.NumberCalc1.FillWeight = 0.5577361F;
            this.NumberCalc1.HeaderText = "Номер калькуляционной карточки";
            this.NumberCalc1.MinimumWidth = 100;
            this.NumberCalc1.Name = "NumberCalc1";
            this.NumberCalc1.ReadOnly = true;
            // 
            // Title1
            // 
            this.Title1.FillWeight = 0.5121986F;
            this.Title1.HeaderText = "Наименование";
            this.Title1.MinimumWidth = 100;
            this.Title1.Name = "Title1";
            // 
            // Code1
            // 
            this.Code1.FillWeight = 0.5040212F;
            this.Code1.HeaderText = "Код";
            this.Code1.MinimumWidth = 100;
            this.Code1.Name = "Code1";
            this.Code1.ReadOnly = true;
            this.Code1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CostEnter
            // 
            this.CostEnter.FillWeight = 8.837507F;
            this.CostEnter.HeaderText = "Цена, руб., коп.";
            this.CostEnter.MinimumWidth = 100;
            this.CostEnter.Name = "CostEnter";
            // 
            // SumEnter
            // 
            this.SumEnter.FillWeight = 1.98269F;
            this.SumEnter.HeaderText = "Сумма, руб., коп.";
            this.SumEnter.MinimumWidth = 100;
            this.SumEnter.Name = "SumEnter";
            this.SumEnter.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.FillWeight = 71.98159F;
            this.Note.HeaderText = "Примечание";
            this.Note.MinimumWidth = 200;
            this.Note.Name = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(330, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Акт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Структурное подразделение";
            // 
            // division
            // 
            this.division.FormattingEnabled = true;
            this.division.Items.AddRange(new object[] {
            "Столовая",
            "Ресторан",
            "Кафе",
            "Бистро"});
            this.division.Location = new System.Drawing.Point(166, 26);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(121, 21);
            this.division.TabIndex = 6;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(91, 50);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(97, 20);
            this.total.TabIndex = 13;
            // 
            // organ
            // 
            this.organ.FormattingEnabled = true;
            this.organ.Items.AddRange(new object[] {
            "OOO \"Ростелеком\"",
            "OOO \"Печки-лавочки\"",
            "OOO \"Вилка-ложка\""});
            this.organ.Location = new System.Drawing.Point(166, 60);
            this.organ.Name = "organ";
            this.organ.Size = new System.Drawing.Size(121, 21);
            this.organ.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Организация";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Location = new System.Drawing.Point(917, 616);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(118, 35);
            this.btnToExcel.TabIndex = 20;
            this.btnToExcel.Text = "Экспорт Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // dateDocument
            // 
            this.dateDocument.Location = new System.Drawing.Point(428, 40);
            this.dateDocument.Name = "dateDocument";
            this.dateDocument.Size = new System.Drawing.Size(158, 20);
            this.dateDocument.TabIndex = 23;
            // 
            // actNumber
            // 
            this.actNumber.Location = new System.Drawing.Point(373, 40);
            this.actNumber.Mask = "00000";
            this.actNumber.Name = "actNumber";
            this.actNumber.Size = new System.Drawing.Size(38, 20);
            this.actNumber.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(406, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "за наличный расчет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(320, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "о реализации готовых изделий кухни ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "документа";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Номер";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "составления";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(653, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Вид операции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Вид деятельности по ОКПД";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Форма по ОКПО";
            // 
            // formOKUD
            // 
            this.formOKUD.Enabled = false;
            this.formOKUD.Location = new System.Drawing.Point(813, 6);
            this.formOKUD.Name = "formOKUD";
            this.formOKUD.ReadOnly = true;
            this.formOKUD.Size = new System.Drawing.Size(100, 20);
            this.formOKUD.TabIndex = 4;
            this.formOKUD.Visible = false;
            // 
            // viewOperation
            // 
            this.viewOperation.Location = new System.Drawing.Point(813, 91);
            this.viewOperation.Name = "viewOperation";
            this.viewOperation.Size = new System.Drawing.Size(100, 20);
            this.viewOperation.TabIndex = 2;
            // 
            // viewOKPD
            // 
            this.viewOKPD.Location = new System.Drawing.Point(813, 60);
            this.viewOKPD.Name = "viewOKPD";
            this.viewOKPD.Size = new System.Drawing.Size(100, 20);
            this.viewOKPD.TabIndex = 1;
            // 
            // formOKPO
            // 
            this.formOKPO.Location = new System.Drawing.Point(813, 31);
            this.formOKPO.Name = "formOKPO";
            this.formOKPO.Size = new System.Drawing.Size(100, 20);
            this.formOKPO.TabIndex = 0;
            this.formOKPO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // spravka
            // 
            this.spravka.Location = new System.Drawing.Point(948, 73);
            this.spravka.Name = "spravka";
            this.spravka.Size = new System.Drawing.Size(116, 46);
            this.spravka.TabIndex = 28;
            this.spravka.Text = "Справка";
            this.spravka.UseVisualStyleBackColor = true;
            this.spravka.Click += new System.EventHandler(this.spravka_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 52);
            this.button2.TabIndex = 30;
            this.button2.Text = "Расшифровка подписей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // totalSumF
            // 
            this.totalSumF.Enabled = false;
            this.totalSumF.Location = new System.Drawing.Point(306, 50);
            this.totalSumF.Name = "totalSumF";
            this.totalSumF.ReadOnly = true;
            this.totalSumF.Size = new System.Drawing.Size(100, 20);
            this.totalSumF.TabIndex = 29;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.totalSumEn);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.total);
            this.groupBox5.Controls.Add(this.totalSumF);
            this.groupBox5.Location = new System.Drawing.Point(136, 574);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(719, 113);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Итого";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(484, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Сумма по ценам производства, руб., коп.";
            // 
            // totalSumEn
            // 
            this.totalSumEn.Enabled = false;
            this.totalSumEn.Location = new System.Drawing.Point(547, 50);
            this.totalSumEn.Name = "totalSumEn";
            this.totalSumEn.ReadOnly = true;
            this.totalSumEn.Size = new System.Drawing.Size(100, 20);
            this.totalSumEn.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Сумма по ценам фактической реализации, руб., коп.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Количество, шт.";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(198, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Сумма прописью";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 691);
            this.Controls.Add(this.formOKUD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.viewOperation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spravka);
            this.Controls.Add(this.viewOKPD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.formOKPO);
            this.Controls.Add(this.division);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.organ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateDocument);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.actNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.AccountingTab);
            this.Location = new System.Drawing.Point(0, -400);
            this.Name = "MainForm";
            this.Text = "Акт о реализации готовых изделий кухни за наличный расчет ";
            this.AccountingTab.ResumeLayout(false);
            this.accountingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).EndInit();
            this.conditionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conditionsTable)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AccountingTab;
        private System.Windows.Forms.TabPage accountingPage;
        private System.Windows.Forms.DataGridView accountTable;
        private System.Windows.Forms.TabPage conditionPage;
        private System.Windows.Forms.DataGridView conditionsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox division;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.ComboBox organ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.DateTimePicker dateDocument;
        private System.Windows.Forms.MaskedTextBox actNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox formOKUD;
        private System.Windows.Forms.TextBox viewOperation;
        private System.Windows.Forms.TextBox viewOKPD;
        private System.Windows.Forms.TextBox formOKPO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button spravka;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox totalSumF;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalSumEn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCalc;
        private System.Windows.Forms.DataGridViewComboBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelise;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCalc1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

