namespace test
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
            this.openXML = new System.Windows.Forms.Button();
            this.saveXML = new System.Windows.Forms.Button();
            this.infoHTML = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openXML
            // 
            this.openXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.openXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openXML.FlatAppearance.BorderSize = 0;
            this.openXML.Location = new System.Drawing.Point(86, 12);
            this.openXML.Name = "openXML";
            this.openXML.Size = new System.Drawing.Size(95, 33);
            this.openXML.TabIndex = 0;
            this.openXML.Text = "Открыть XML";
            this.openXML.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.openXML.UseVisualStyleBackColor = false;
            this.openXML.Click += new System.EventHandler(this.openXML_Click);
            // 
            // saveXML
            // 
            this.saveXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(124)))), ((int)(((byte)(49)))));
            this.saveXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveXML.FlatAppearance.BorderSize = 0;
            this.saveXML.Location = new System.Drawing.Point(198, 12);
            this.saveXML.Name = "saveXML";
            this.saveXML.Size = new System.Drawing.Size(126, 33);
            this.saveXML.TabIndex = 1;
            this.saveXML.Text = "Сохранить XML";
            this.saveXML.UseVisualStyleBackColor = false;
            // 
            // infoHTML
            // 
            this.infoHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(173)))), ((int)(((byte)(71)))));
            this.infoHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoHTML.FlatAppearance.BorderSize = 0;
            this.infoHTML.Location = new System.Drawing.Point(537, 12);
            this.infoHTML.Name = "infoHTML";
            this.infoHTML.Size = new System.Drawing.Size(127, 33);
            this.infoHTML.TabIndex = 2;
            this.infoHTML.Text = "Отчёт в HTML";
            this.infoHTML.UseVisualStyleBackColor = false;
            this.infoHTML.Click += new System.EventHandler(this.infoHTML_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.Desktop;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.ForeColor = System.Drawing.SystemColors.Control;
            this.delete.Location = new System.Drawing.Point(86, 51);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 33);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить запись";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(233, 51);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(127, 33);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 191);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.infoHTML);
            this.Controls.Add(this.saveXML);
            this.Controls.Add(this.openXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openXML;
        private System.Windows.Forms.Button saveXML;
        private System.Windows.Forms.Button infoHTML;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

