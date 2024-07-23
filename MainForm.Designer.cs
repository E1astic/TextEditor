namespace TextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выравниваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морскаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.васильковаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.травянаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.древеснаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морковнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вишнёваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сиреневаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лимоннаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кремоваяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвторахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox_Main = new System.Windows.Forms.RichTextBox();
            this.pictureBox_nextStep = new System.Windows.Forms.PictureBox();
            this.pictureBox_prevStep = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_currentFile = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nextStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prevStep)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редакторToolStripMenuItem,
            this.опцииToolStripMenuItem,
            this.темаToolStripMenuItem,
            this.обАвторахToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.новоеОкноToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(286, 24);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            this.новоеОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.цветToolStripMenuItem,
            this.выравниваниеToolStripMenuItem});
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.редакторToolStripMenuItem.Text = "Редактор";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // выравниваниеToolStripMenuItem
            // 
            this.выравниваниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЛевомуКраюToolStripMenuItem,
            this.поЦентруToolStripMenuItem,
            this.поПравомуКраюToolStripMenuItem});
            this.выравниваниеToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            this.выравниваниеToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.выравниваниеToolStripMenuItem.Text = "Выравнивание";
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            this.поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            this.поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
            this.поЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поЛевомуКраюToolStripMenuItem_Click);
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.поЦентруToolStripMenuItem.Text = "По центру";
            this.поЦентруToolStripMenuItem.Click += new System.EventHandler(this.поЦентруToolStripMenuItem_Click);
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            this.поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            this.поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.поПравомуКраюToolStripMenuItem.Text = "По правому краю";
            this.поПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.поПравомуКраюToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиToolStripMenuItem,
            this.заменитьToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.заменитьToolStripMenuItem.Text = "Заменить";
            this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.светлаяToolStripMenuItem,
            this.темнаяToolStripMenuItem,
            this.контрастнаяToolStripMenuItem,
            this.морскаяToolStripMenuItem,
            this.васильковаяToolStripMenuItem,
            this.травянаяToolStripMenuItem,
            this.древеснаяToolStripMenuItem,
            this.морковнаяToolStripMenuItem,
            this.вишнёваяToolStripMenuItem,
            this.сиреневаяToolStripMenuItem,
            this.лимоннаяToolStripMenuItem,
            this.кремоваяToolStripMenuItem});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // темнаяToolStripMenuItem
            // 
            this.темнаяToolStripMenuItem.Name = "темнаяToolStripMenuItem";
            this.темнаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.темнаяToolStripMenuItem.Text = "Темная";
            this.темнаяToolStripMenuItem.Click += new System.EventHandler(this.темнаяToolStripMenuItem_Click);
            // 
            // контрастнаяToolStripMenuItem
            // 
            this.контрастнаяToolStripMenuItem.Name = "контрастнаяToolStripMenuItem";
            this.контрастнаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.контрастнаяToolStripMenuItem.Text = "Контрастная";
            this.контрастнаяToolStripMenuItem.Click += new System.EventHandler(this.контрастнаяToolStripMenuItem_Click);
            // 
            // морскаяToolStripMenuItem
            // 
            this.морскаяToolStripMenuItem.Name = "морскаяToolStripMenuItem";
            this.морскаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.морскаяToolStripMenuItem.Text = "Морская";
            this.морскаяToolStripMenuItem.Click += new System.EventHandler(this.морскаяToolStripMenuItem_Click);
            // 
            // васильковаяToolStripMenuItem
            // 
            this.васильковаяToolStripMenuItem.Name = "васильковаяToolStripMenuItem";
            this.васильковаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.васильковаяToolStripMenuItem.Text = "Васильковая";
            this.васильковаяToolStripMenuItem.Click += new System.EventHandler(this.васильковаяToolStripMenuItem_Click);
            // 
            // травянаяToolStripMenuItem
            // 
            this.травянаяToolStripMenuItem.Name = "травянаяToolStripMenuItem";
            this.травянаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.травянаяToolStripMenuItem.Text = "Травяная";
            this.травянаяToolStripMenuItem.Click += new System.EventHandler(this.травянаяToolStripMenuItem_Click);
            // 
            // древеснаяToolStripMenuItem
            // 
            this.древеснаяToolStripMenuItem.Name = "древеснаяToolStripMenuItem";
            this.древеснаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.древеснаяToolStripMenuItem.Text = "Древесная";
            this.древеснаяToolStripMenuItem.Click += new System.EventHandler(this.древеснаяToolStripMenuItem_Click);
            // 
            // морковнаяToolStripMenuItem
            // 
            this.морковнаяToolStripMenuItem.Name = "морковнаяToolStripMenuItem";
            this.морковнаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.морковнаяToolStripMenuItem.Text = "Морковная";
            this.морковнаяToolStripMenuItem.Click += new System.EventHandler(this.морковнаяToolStripMenuItem_Click);
            // 
            // вишнёваяToolStripMenuItem
            // 
            this.вишнёваяToolStripMenuItem.Name = "вишнёваяToolStripMenuItem";
            this.вишнёваяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.вишнёваяToolStripMenuItem.Text = "Вишнёвая";
            this.вишнёваяToolStripMenuItem.Click += new System.EventHandler(this.вишнёваяToolStripMenuItem_Click);
            // 
            // сиреневаяToolStripMenuItem
            // 
            this.сиреневаяToolStripMenuItem.Name = "сиреневаяToolStripMenuItem";
            this.сиреневаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.сиреневаяToolStripMenuItem.Text = "Сиреневая";
            this.сиреневаяToolStripMenuItem.Click += new System.EventHandler(this.сиреневаяToolStripMenuItem_Click);
            // 
            // лимоннаяToolStripMenuItem
            // 
            this.лимоннаяToolStripMenuItem.Name = "лимоннаяToolStripMenuItem";
            this.лимоннаяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.лимоннаяToolStripMenuItem.Text = "Лимонная";
            this.лимоннаяToolStripMenuItem.Click += new System.EventHandler(this.лимоннаяToolStripMenuItem_Click);
            // 
            // кремоваяToolStripMenuItem
            // 
            this.кремоваяToolStripMenuItem.Name = "кремоваяToolStripMenuItem";
            this.кремоваяToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.кремоваяToolStripMenuItem.Text = "Кремовая";
            this.кремоваяToolStripMenuItem.Click += new System.EventHandler(this.кремоваяToolStripMenuItem_Click);
            // 
            // обАвторахToolStripMenuItem
            // 
            this.обАвторахToolStripMenuItem.Name = "обАвторахToolStripMenuItem";
            this.обАвторахToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.обАвторахToolStripMenuItem.Text = "Об авторах";
            this.обАвторахToolStripMenuItem.Click += new System.EventHandler(this.обАвторахToolStripMenuItem_Click);
            // 
            // richTextBox_Main
            // 
            this.richTextBox_Main.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Main.Location = new System.Drawing.Point(0, 28);
            this.richTextBox_Main.Name = "richTextBox_Main";
            this.richTextBox_Main.Size = new System.Drawing.Size(800, 422);
            this.richTextBox_Main.TabIndex = 3;
            this.richTextBox_Main.Text = "";
            this.richTextBox_Main.TextChanged += new System.EventHandler(this.richTextBox_Main_TextChanged);
            this.richTextBox_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_Main_MouseUp);
            // 
            // pictureBox_nextStep
            // 
            this.pictureBox_nextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_nextStep.Image = global::TextEditor.Properties.Resources.next_step;
            this.pictureBox_nextStep.Location = new System.Drawing.Point(424, 0);
            this.pictureBox_nextStep.Name = "pictureBox_nextStep";
            this.pictureBox_nextStep.Size = new System.Drawing.Size(38, 28);
            this.pictureBox_nextStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_nextStep.TabIndex = 5;
            this.pictureBox_nextStep.TabStop = false;
            this.pictureBox_nextStep.Click += new System.EventHandler(this.pictureBox_nextStep_Click);
            this.pictureBox_nextStep.MouseEnter += new System.EventHandler(this.pictureBox_nextStep_MouseEnter);
            // 
            // pictureBox_prevStep
            // 
            this.pictureBox_prevStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_prevStep.Image = global::TextEditor.Properties.Resources.prev_step;
            this.pictureBox_prevStep.Location = new System.Drawing.Point(380, 0);
            this.pictureBox_prevStep.Name = "pictureBox_prevStep";
            this.pictureBox_prevStep.Size = new System.Drawing.Size(38, 28);
            this.pictureBox_prevStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_prevStep.TabIndex = 4;
            this.pictureBox_prevStep.TabStop = false;
            this.pictureBox_prevStep.Click += new System.EventHandler(this.pictureBox_prevStep_Click);
            this.pictureBox_prevStep.MouseEnter += new System.EventHandler(this.pictureBox_prevStep_MouseEnter);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.выделитьВсёToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(199, 136);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            this.выделитьВсёToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсёToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // label_currentFile
            // 
            this.label_currentFile.AutoSize = true;
            this.label_currentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_currentFile.Location = new System.Drawing.Point(468, 10);
            this.label_currentFile.Name = "label_currentFile";
            this.label_currentFile.Size = new System.Drawing.Size(90, 15);
            this.label_currentFile.TabIndex = 6;
            this.label_currentFile.Text = "Текущий файл";
            this.label_currentFile.MouseEnter += new System.EventHandler(this.label_currentFile_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_currentFile);
            this.Controls.Add(this.pictureBox_nextStep);
            this.Controls.Add(this.pictureBox_prevStep);
            this.Controls.Add(this.richTextBox_Main);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nextStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prevStep)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвторахToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox_Main;
		private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem контрастнаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem морскаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem васильковаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem травянаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem древеснаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem морковнаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вишнёваяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сиреневаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem лимоннаяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem кремоваяToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_prevStep;
        private System.Windows.Forms.PictureBox pictureBox_nextStep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label label_currentFile;
    }
}

