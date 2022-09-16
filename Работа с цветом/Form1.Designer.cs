
namespace Работа_с_цветом
{
    partial class Form1
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
            this.PicterMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isxod_pic = new System.Windows.Forms.PictureBox();
            this.zhel_pic = new System.Windows.Forms.PictureBox();
            this.isxod_text = new System.Windows.Forms.TextBox();
            this.zhel_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Perekrasbutton = new System.Windows.Forms.Button();
            this.DialogPalitra = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.TrackBar();
            this.Green = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.Dopysk = new System.Windows.Forms.TrackBar();
            this.Proz = new System.Windows.Forms.TrackBar();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.ishod = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.Rot_up = new System.Windows.Forms.Button();
            this.Rot_left = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осветлитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.затемнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Red_text = new System.Windows.Forms.TextBox();
            this.Green_text = new System.Windows.Forms.TextBox();
            this.Blue_text = new System.Windows.Forms.TextBox();
            this.Dopysk_text = new System.Windows.Forms.TextBox();
            this.Proz_text = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicterMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isxod_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhel_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dopysk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicterMain
            // 
            this.PicterMain.BackColor = System.Drawing.Color.MistyRose;
            this.PicterMain.Location = new System.Drawing.Point(0, 23);
            this.PicterMain.Name = "PicterMain";
            this.PicterMain.Size = new System.Drawing.Size(561, 493);
            this.PicterMain.TabIndex = 0;
            this.PicterMain.TabStop = false;
            this.PicterMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicterMain_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Желаемый цвет";
            // 
            // isxod_pic
            // 
            this.isxod_pic.Location = new System.Drawing.Point(622, 57);
            this.isxod_pic.Name = "isxod_pic";
            this.isxod_pic.Size = new System.Drawing.Size(51, 41);
            this.isxod_pic.TabIndex = 3;
            this.isxod_pic.TabStop = false;
            // 
            // zhel_pic
            // 
            this.zhel_pic.Location = new System.Drawing.Point(622, 135);
            this.zhel_pic.Name = "zhel_pic";
            this.zhel_pic.Size = new System.Drawing.Size(51, 41);
            this.zhel_pic.TabIndex = 4;
            this.zhel_pic.TabStop = false;
            // 
            // isxod_text
            // 
            this.isxod_text.Location = new System.Drawing.Point(679, 67);
            this.isxod_text.Name = "isxod_text";
            this.isxod_text.Size = new System.Drawing.Size(185, 20);
            this.isxod_text.TabIndex = 5;
            // 
            // zhel_text
            // 
            this.zhel_text.Location = new System.Drawing.Point(679, 144);
            this.zhel_text.Name = "zhel_text";
            this.zhel_text.Size = new System.Drawing.Size(185, 20);
            this.zhel_text.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Красный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Зеленый";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(712, 327);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(38, 13);
            this.lable5.TabIndex = 9;
            this.lable5.Text = "Синий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Допуск";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Прозрачность";
            // 
            // Perekrasbutton
            // 
            this.Perekrasbutton.Location = new System.Drawing.Point(870, 48);
            this.Perekrasbutton.Name = "Perekrasbutton";
            this.Perekrasbutton.Size = new System.Drawing.Size(89, 57);
            this.Perekrasbutton.TabIndex = 12;
            this.Perekrasbutton.Text = "Перекрасить";
            this.Perekrasbutton.UseVisualStyleBackColor = true;
            this.Perekrasbutton.Click += new System.EventHandler(this.perekrasit_Click);
            // 
            // DialogPalitra
            // 
            this.DialogPalitra.Location = new System.Drawing.Point(870, 126);
            this.DialogPalitra.Name = "DialogPalitra";
            this.DialogPalitra.Size = new System.Drawing.Size(89, 59);
            this.DialogPalitra.TabIndex = 13;
            this.DialogPalitra.Text = "Палитра";
            this.DialogPalitra.UseVisualStyleBackColor = true;
            this.DialogPalitra.Click += new System.EventHandler(this.Palitra_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(648, 215);
            this.Red.Maximum = 255;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(167, 45);
            this.Red.TabIndex = 14;
            this.Red.Scroll += new System.EventHandler(this.Red_Scroll);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(648, 279);
            this.Green.Maximum = 255;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(167, 45);
            this.Green.TabIndex = 15;
            this.Green.Scroll += new System.EventHandler(this.Green_Scroll);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(648, 343);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(167, 45);
            this.Blue.TabIndex = 16;
            this.Blue.Scroll += new System.EventHandler(this.Blue_Scroll);
            // 
            // Dopysk
            // 
            this.Dopysk.Location = new System.Drawing.Point(648, 407);
            this.Dopysk.Maximum = 100;
            this.Dopysk.Name = "Dopysk";
            this.Dopysk.Size = new System.Drawing.Size(167, 45);
            this.Dopysk.TabIndex = 17;
            this.Dopysk.Scroll += new System.EventHandler(this.Dopysk_Scroll);
            // 
            // Proz
            // 
            this.Proz.Location = new System.Drawing.Point(648, 471);
            this.Proz.Maximum = 255;
            this.Proz.Name = "Proz";
            this.Proz.Size = new System.Drawing.Size(167, 45);
            this.Proz.TabIndex = 18;
            this.Proz.Scroll += new System.EventHandler(this.Proz_Scroll);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(566, 37);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(25, 21);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.zoomup_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(566, 64);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(25, 21);
            this.minus.TabIndex = 20;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.zuumout_Click);
            // 
            // ishod
            // 
            this.ishod.Location = new System.Drawing.Point(566, 91);
            this.ishod.Name = "ishod";
            this.ishod.Size = new System.Drawing.Size(25, 21);
            this.ishod.TabIndex = 21;
            this.ishod.Text = "i";
            this.ishod.UseVisualStyleBackColor = true;
            this.ishod.Click += new System.EventHandler(this.ishod_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(566, 226);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(25, 21);
            this.clear.TabIndex = 22;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(566, 118);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(25, 21);
            this.right.TabIndex = 22;
            this.right.Text = "R";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(566, 145);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(25, 21);
            this.left.TabIndex = 23;
            this.left.Text = "L";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // Rot_up
            // 
            this.Rot_up.Location = new System.Drawing.Point(566, 172);
            this.Rot_up.Name = "Rot_up";
            this.Rot_up.Size = new System.Drawing.Size(25, 21);
            this.Rot_up.TabIndex = 24;
            this.Rot_up.Text = "_";
            this.Rot_up.UseVisualStyleBackColor = true;
            this.Rot_up.Click += new System.EventHandler(this.Rot_up_Click);
            // 
            // Rot_left
            // 
            this.Rot_left.Location = new System.Drawing.Point(566, 199);
            this.Rot_left.Name = "Rot_left";
            this.Rot_left.Size = new System.Drawing.Size(25, 21);
            this.Rot_left.TabIndex = 25;
            this.Rot_left.Text = "|";
            this.Rot_left.UseVisualStyleBackColor = true;
            this.Rot_left.Click += new System.EventHandler(this.Rot_left_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.эффектыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКартинкуToolStripMenuItem,
            this.сохранитьКартинкуToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // загрузитьКартинкуToolStripMenuItem
            // 
            this.загрузитьКартинкуToolStripMenuItem.Name = "загрузитьКартинкуToolStripMenuItem";
            this.загрузитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.загрузитьКартинкуToolStripMenuItem.Text = "Загрузить картинку";
            this.загрузитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКартинкуToolStripMenuItem_Click);
            // 
            // сохранитьКартинкуToolStripMenuItem
            // 
            this.сохранитьКартинкуToolStripMenuItem.Name = "сохранитьКартинкуToolStripMenuItem";
            this.сохранитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.сохранитьКартинкуToolStripMenuItem.Text = "Сохранить картинку";
            this.сохранитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКартинкуToolStripMenuItem_Click);
            // 
            // эффектыToolStripMenuItem
            // 
            this.эффектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чернобелыйToolStripMenuItem,
            this.негативToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.осветлитьToolStripMenuItem,
            this.затемнитьToolStripMenuItem});
            this.эффектыToolStripMenuItem.Name = "эффектыToolStripMenuItem";
            this.эффектыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.эффектыToolStripMenuItem.Text = "Эффекты";
            // 
            // чернобелыйToolStripMenuItem
            // 
            this.чернобелыйToolStripMenuItem.Name = "чернобелыйToolStripMenuItem";
            this.чернобелыйToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.чернобелыйToolStripMenuItem.Text = "Черно-белый";
            this.чернобелыйToolStripMenuItem.Click += new System.EventHandler(this.чернобелыйToolStripMenuItem_Click);
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            this.негативToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.негативToolStripMenuItem.Text = "Негатив";
            this.негативToolStripMenuItem.Click += new System.EventHandler(this.негативToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // осветлитьToolStripMenuItem
            // 
            this.осветлитьToolStripMenuItem.Name = "осветлитьToolStripMenuItem";
            this.осветлитьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.осветлитьToolStripMenuItem.Text = "Осветлить";
            this.осветлитьToolStripMenuItem.Click += new System.EventHandler(this.осветлитьToolStripMenuItem_Click);
            // 
            // затемнитьToolStripMenuItem
            // 
            this.затемнитьToolStripMenuItem.Name = "затемнитьToolStripMenuItem";
            this.затемнитьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.затемнитьToolStripMenuItem.Text = "Затемнить";
            this.затемнитьToolStripMenuItem.Click += new System.EventHandler(this.затемнитьToolStripMenuItem_Click);
            // 
            // Red_text
            // 
            this.Red_text.Location = new System.Drawing.Point(844, 215);
            this.Red_text.Name = "Red_text";
            this.Red_text.Size = new System.Drawing.Size(114, 20);
            this.Red_text.TabIndex = 27;
            // 
            // Green_text
            // 
            this.Green_text.Location = new System.Drawing.Point(844, 279);
            this.Green_text.Name = "Green_text";
            this.Green_text.Size = new System.Drawing.Size(114, 20);
            this.Green_text.TabIndex = 28;
            // 
            // Blue_text
            // 
            this.Blue_text.Location = new System.Drawing.Point(844, 343);
            this.Blue_text.Name = "Blue_text";
            this.Blue_text.Size = new System.Drawing.Size(114, 20);
            this.Blue_text.TabIndex = 29;
            // 
            // Dopysk_text
            // 
            this.Dopysk_text.Location = new System.Drawing.Point(845, 407);
            this.Dopysk_text.Name = "Dopysk_text";
            this.Dopysk_text.Size = new System.Drawing.Size(114, 20);
            this.Dopysk_text.TabIndex = 30;
            // 
            // Proz_text
            // 
            this.Proz_text.Location = new System.Drawing.Point(844, 471);
            this.Proz_text.Name = "Proz_text";
            this.Proz_text.Size = new System.Drawing.Size(114, 20);
            this.Proz_text.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(977, 523);
            this.Controls.Add(this.Proz_text);
            this.Controls.Add(this.Dopysk_text);
            this.Controls.Add(this.Blue_text);
            this.Controls.Add(this.Green_text);
            this.Controls.Add(this.Red_text);
            this.Controls.Add(this.Rot_left);
            this.Controls.Add(this.Rot_up);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ishod);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Proz);
            this.Controls.Add(this.Dopysk);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.DialogPalitra);
            this.Controls.Add(this.Perekrasbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lable5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zhel_text);
            this.Controls.Add(this.isxod_text);
            this.Controls.Add(this.zhel_pic);
            this.Controls.Add(this.isxod_pic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicterMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Color";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicterMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isxod_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhel_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dopysk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicterMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox isxod_pic;
        private System.Windows.Forms.PictureBox zhel_pic;
        private System.Windows.Forms.TextBox isxod_text;
        private System.Windows.Forms.TextBox zhel_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Perekrasbutton;
        private System.Windows.Forms.Button DialogPalitra;
        private System.Windows.Forms.TrackBar Red;
        private System.Windows.Forms.TrackBar Green;
        private System.Windows.Forms.TrackBar Blue;
        private System.Windows.Forms.TrackBar Dopysk;
        private System.Windows.Forms.TrackBar Proz;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button ishod;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button Rot_up;
        private System.Windows.Forms.Button Rot_left;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКартинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКартинкуToolStripMenuItem;
        private System.Windows.Forms.TextBox Red_text;
        private System.Windows.Forms.TextBox Green_text;
        private System.Windows.Forms.TextBox Blue_text;
        private System.Windows.Forms.TextBox Dopysk_text;
        private System.Windows.Forms.TextBox Proz_text;
        private System.Windows.Forms.ToolStripMenuItem эффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осветлитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem затемнитьToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

