
namespace JustUI_Test
{
	partial class JUITestForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private JustUI.JUICheckBox juiCheckBox1;
		private JustUI.JUICheckBox juiCheckBox2;
		private JustUI.JUIButton juiButton1;
		private JustUI.JUIButton juiButton2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private JustUI.JUIButton juiButton3;
		private System.Windows.Forms.TextBox textBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.juiCheckBox1 = new JustUI.JUICheckBox();
			this.juiCheckBox2 = new JustUI.JUICheckBox();
			this.juiButton1 = new JustUI.JUIButton();
			this.juiButton2 = new JustUI.JUIButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.juiButton3 = new JustUI.JUIButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TITLE
			// 
			this.TITLE.Location = new System.Drawing.Point(1, 1);
			this.TITLE.Size = new System.Drawing.Size(463, 23);
			this.TITLE.Text = "Just UI Title(It is draggable)";
			// 
			// X
			// 
			this.X.FlatAppearance.BorderSize = 0;
			this.X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.X.Location = new System.Drawing.Point(487, 1);
			// 
			// _
			// 
			this._.FlatAppearance.BorderSize = 0;
			this._.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
			this._.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this._.Location = new System.Drawing.Point(464, 1);
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
			"This is Just UI Example",
			"It shows basic",
			"implemented controls",
			"which have Just UI",
			"look. Also There is",
			"Just UI MessageBox,",
			"which will appear after",
			"you close this window."});
			this.listBox1.Location = new System.Drawing.Point(1, 27);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(127, 312);
			this.listBox1.TabIndex = 3;
			// 
			// juiCheckBox1
			// 
			this.juiCheckBox1.AutoSize = true;
			this.juiCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.juiCheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.juiCheckBox1.Location = new System.Drawing.Point(134, 31);
			this.juiCheckBox1.Name = "juiCheckBox1";
			this.juiCheckBox1.Size = new System.Drawing.Size(116, 17);
			this.juiCheckBox1.TabIndex = 4;
			this.juiCheckBox1.Text = "Just UI Checkbox 1";
			this.juiCheckBox1.UseVisualStyleBackColor = true;
			// 
			// juiCheckBox2
			// 
			this.juiCheckBox2.AutoSize = true;
			this.juiCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.juiCheckBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.juiCheckBox2.Location = new System.Drawing.Point(134, 57);
			this.juiCheckBox2.Name = "juiCheckBox2";
			this.juiCheckBox2.Size = new System.Drawing.Size(116, 17);
			this.juiCheckBox2.TabIndex = 5;
			this.juiCheckBox2.Text = "Just UI Checkbox 2";
			this.juiCheckBox2.UseVisualStyleBackColor = true;
			// 
			// juiButton1
			// 
			this.juiButton1.AutoSize = true;
			this.juiButton1.FlatAppearance.BorderSize = 0;
			this.juiButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
			this.juiButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.juiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.juiButton1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.juiButton1.Location = new System.Drawing.Point(3, 351);
			this.juiButton1.Name = "juiButton1";
			this.juiButton1.Size = new System.Drawing.Size(125, 23);
			this.juiButton1.TabIndex = 6;
			this.juiButton1.TabStop = false;
			this.juiButton1.Text = "Just UI Button Yes/OK";
			this.juiButton1.UseVisualStyleBackColor = true;
			// 
			// juiButton2
			// 
			this.juiButton2.AutoSize = true;
			this.juiButton2.FlatAppearance.BorderSize = 0;
			this.juiButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
			this.juiButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.juiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.juiButton2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.juiButton2.Location = new System.Drawing.Point(366, 351);
			this.juiButton2.Name = "juiButton2";
			this.juiButton2.Size = new System.Drawing.Size(141, 23);
			this.juiButton2.TabIndex = 7;
			this.juiButton2.TabStop = false;
			this.juiButton2.Text = "Just UI Button NO/Cancel";
			this.juiButton2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Flat textbox, but it doesn\'t",
			"have borders, so it is not ",
			"very suitable for Just UI"});
			this.comboBox1.Location = new System.Drawing.Point(306, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(158, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"I need to make:",
			"Just UI combobox."});
			this.comboBox2.Location = new System.Drawing.Point(306, 30);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(158, 21);
			this.comboBox2.TabIndex = 9;
			// 
			// juiButton3
			// 
			this.juiButton3.AutoSize = true;
			this.juiButton3.FlatAppearance.BorderSize = 0;
			this.juiButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
			this.juiButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
			this.juiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.juiButton3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.juiButton3.Location = new System.Drawing.Point(186, 351);
			this.juiButton3.Name = "juiButton3";
			this.juiButton3.Size = new System.Drawing.Size(141, 23);
			this.juiButton3.TabIndex = 10;
			this.juiButton3.TabStop = false;
			this.juiButton3.Text = "Just UI Normal Button";
			this.juiButton3.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(134, 80);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(330, 259);
			this.textBox1.TabIndex = 11;
			this.textBox1.Text = "TextBox just with the  BorderStyle set to Fixed Single, looks like Just UI :)\r\n";
			// 
			// JUITestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 377);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.juiButton3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.juiButton2);
			this.Controls.Add(this.juiButton1);
			this.Controls.Add(this.juiCheckBox2);
			this.Controls.Add(this.juiCheckBox1);
			this.Controls.Add(this.listBox1);
			this.Name = "JUITestForm";
			this.Text = "Form1";
			this.Controls.SetChildIndex(this.listBox1, 0);
			this.Controls.SetChildIndex(this.juiCheckBox1, 0);
			this.Controls.SetChildIndex(this.juiCheckBox2, 0);
			this.Controls.SetChildIndex(this.juiButton1, 0);
			this.Controls.SetChildIndex(this.juiButton2, 0);
			this.Controls.SetChildIndex(this.comboBox1, 0);
			this.Controls.SetChildIndex(this.comboBox2, 0);
			this.Controls.SetChildIndex(this.TITLE, 0);
			this.Controls.SetChildIndex(this._, 0);
			this.Controls.SetChildIndex(this.X, 0);
			this.Controls.SetChildIndex(this.juiButton3, 0);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
