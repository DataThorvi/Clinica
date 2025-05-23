namespace Clinica
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
            button2 = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            label13 = new Label();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView4 = new DataGridView();
            tabPage3 = new TabPage();
            button3 = new Button();
            dataGridView5 = new DataGridView();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dataGridView6 = new DataGridView();
            tabPage4 = new TabPage();
            dataGridView7 = new DataGridView();
            label10 = new Label();
            tabPage5 = new TabPage();
            dataGridView8 = new DataGridView();
            label11 = new Label();
            tabPage6 = new TabPage();
            dataGridView9 = new DataGridView();
            label12 = new Label();
            tabPage7 = new TabPage();
            dataGridView10 = new DataGridView();
            button4 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView10).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(915, 639);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(907, 606);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пациенты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(441, 297);
            button2.Name = "button2";
            button2.Size = new Size(346, 41);
            button2.TabIndex = 7;
            button2.Text = "Информация о приёме пациента";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(211, 297);
            button1.Name = "button1";
            button1.Size = new Size(221, 41);
            button1.TabIndex = 6;
            button1.Text = "Последний визит пациента";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.PaleGreen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(82, 344);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(705, 222);
            dataGridView2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 297);
            label3.Name = "label3";
            label3.Size = new Size(199, 28);
            label3.TabIndex = 4;
            label3.Text = "Визиты пациента";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(395, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 33);
            label2.Name = "label2";
            label2.Size = new Size(221, 20);
            label2.TabIndex = 2;
            label2.Text = "Поиск пациента по названию:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 1;
            label1.Text = "Пациенты";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(82, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(695, 196);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dataGridView4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(907, 606);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Доктора";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(382, 287);
            label13.Name = "label13";
            label13.Size = new Size(211, 28);
            label13.TabIndex = 12;
            label13.Text = "Доктора и приёмы";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.PaleGreen;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(139, 320);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(705, 222);
            dataGridView3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 287);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 23);
            label5.Name = "label5";
            label5.Size = new Size(211, 20);
            label5.TabIndex = 8;
            label5.Text = "Поиск доктора по названию:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(76, 16);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 7;
            label6.Text = "Доктора";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.PaleGreen;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(139, 57);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(695, 196);
            dataGridView4.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(dataGridView5);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(dataGridView6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(907, 606);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Услуги";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(283, 284);
            button3.Name = "button3";
            button3.Size = new Size(208, 40);
            button3.TabIndex = 12;
            button3.Text = "Журнал услуг";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = Color.PaleGreen;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(129, 344);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(705, 222);
            dataGridView5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(63, 287);
            label7.Name = "label7";
            label7.Size = new Size(198, 28);
            label7.TabIndex = 10;
            label7.Text = "Сделки на услугу";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 27);
            textBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 23);
            label8.Name = "label8";
            label8.Size = new Size(200, 20);
            label8.TabIndex = 8;
            label8.Text = "Поиск  по названию услуги";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(76, 16);
            label9.Name = "label9";
            label9.Size = new Size(85, 28);
            label9.TabIndex = 7;
            label9.Text = "Услуги";
            // 
            // dataGridView6
            // 
            dataGridView6.BackgroundColor = Color.PaleGreen;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(139, 57);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(695, 196);
            dataGridView6.TabIndex = 6;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView7);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(907, 606);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Приёмы";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.BackgroundColor = Color.PaleGreen;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(70, 106);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.Size = new Size(705, 377);
            dataGridView7.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(70, 56);
            label10.Name = "label10";
            label10.Size = new Size(99, 28);
            label10.TabIndex = 12;
            label10.Text = "Приёмы";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridView8);
            tabPage5.Controls.Add(label11);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(907, 606);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Медецинские карты";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.BackgroundColor = Color.PaleGreen;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(101, 123);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 51;
            dataGridView8.Size = new Size(705, 377);
            dataGridView8.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(101, 73);
            label11.Name = "label11";
            label11.Size = new Size(229, 28);
            label11.TabIndex = 14;
            label11.Text = "Медецинские карты";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridView9);
            tabPage6.Controls.Add(label12);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(907, 606);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Диспансерное наблюдение";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView9
            // 
            dataGridView9.BackgroundColor = Color.PaleGreen;
            dataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView9.Location = new Point(101, 123);
            dataGridView9.Name = "dataGridView9";
            dataGridView9.RowHeadersWidth = 51;
            dataGridView9.Size = new Size(705, 377);
            dataGridView9.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(101, 73);
            label12.Name = "label12";
            label12.Size = new Size(309, 28);
            label12.TabIndex = 14;
            label12.Text = "Диспансерное наблюдение";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dataGridView10);
            tabPage7.Controls.Add(button4);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(907, 606);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Форма \"справка\"";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            dataGridView10.BackgroundColor = Color.PaleGreen;
            dataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView10.Location = new Point(111, 85);
            dataGridView10.Name = "dataGridView10";
            dataGridView10.RowHeadersWidth = 51;
            dataGridView10.Size = new Size(642, 342);
            dataGridView10.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(252, 475);
            button4.Name = "button4";
            button4.Size = new Size(318, 64);
            button4.TabIndex = 0;
            button4.Text = "Добавить отчёт в Word";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 711);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).EndInit();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView6;
        private DataGridView dataGridView7;
        private Label label10;
        private DataGridView dataGridView8;
        private Label label11;
        private DataGridView dataGridView9;
        private Label label12;
        private Label label13;
        private TabPage tabPage7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView10;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}
