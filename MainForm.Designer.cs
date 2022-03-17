
namespace MatrixSample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrix1Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrix2Grid = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.task1Button = new System.Windows.Forms.Button();
            this.task2Button = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFirstButton = new System.Windows.Forms.Button();
            this.saveSecondButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix1Grid
            // 
            this.matrix1Grid.AllowUserToAddRows = false;
            this.matrix1Grid.AllowUserToDeleteRows = false;
            this.matrix1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix1Grid.Location = new System.Drawing.Point(29, 42);
            this.matrix1Grid.Margin = new System.Windows.Forms.Padding(4);
            this.matrix1Grid.Name = "matrix1Grid";
            this.matrix1Grid.RowHeadersWidth = 51;
            this.matrix1Grid.Size = new System.Drawing.Size(524, 222);
            this.matrix1Grid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrix 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrix 2";
            // 
            // matrix2Grid
            // 
            this.matrix2Grid.AllowUserToAddRows = false;
            this.matrix2Grid.AllowUserToDeleteRows = false;
            this.matrix2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix2Grid.Location = new System.Drawing.Point(29, 299);
            this.matrix2Grid.Margin = new System.Windows.Forms.Padding(4);
            this.matrix2Grid.Name = "matrix2Grid";
            this.matrix2Grid.RowHeadersWidth = 51;
            this.matrix2Grid.Size = new System.Drawing.Size(524, 231);
            this.matrix2Grid.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(612, 99);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(120, 28);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // task1Button
            // 
            this.task1Button.Enabled = false;
            this.task1Button.Location = new System.Drawing.Point(612, 348);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(120, 28);
            this.task1Button.TabIndex = 5;
            this.task1Button.Text = "Task 1";
            this.task1Button.UseVisualStyleBackColor = true;
            this.task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // task2Button
            // 
            this.task2Button.Enabled = false;
            this.task2Button.Location = new System.Drawing.Point(612, 419);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(120, 28);
            this.task2Button.TabIndex = 6;
            this.task2Button.Text = "Task 2";
            this.task2Button.UseVisualStyleBackColor = true;
            this.task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files|*.txt";
            // 
            // saveFirstButton
            // 
            this.saveFirstButton.Enabled = false;
            this.saveFirstButton.Location = new System.Drawing.Point(612, 166);
            this.saveFirstButton.Name = "saveFirstButton";
            this.saveFirstButton.Size = new System.Drawing.Size(120, 28);
            this.saveFirstButton.TabIndex = 7;
            this.saveFirstButton.Text = "Save first";
            this.saveFirstButton.UseVisualStyleBackColor = true;
            this.saveFirstButton.Click += new System.EventHandler(this.SaveFirstButton_Click);
            // 
            // saveSecondButton
            // 
            this.saveSecondButton.Enabled = false;
            this.saveSecondButton.Location = new System.Drawing.Point(612, 236);
            this.saveSecondButton.Name = "saveSecondButton";
            this.saveSecondButton.Size = new System.Drawing.Size(120, 28);
            this.saveSecondButton.TabIndex = 8;
            this.saveSecondButton.Text = "Save second";
            this.saveSecondButton.UseVisualStyleBackColor = true;
            this.saveSecondButton.Click += new System.EventHandler(this.SaveFirstButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 554);
            this.Controls.Add(this.saveSecondButton);
            this.Controls.Add(this.saveFirstButton);
            this.Controls.Add(this.task2Button);
            this.Controls.Add(this.task1Button);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrix2Grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrix1Grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatrixSample";
            ((System.ComponentModel.ISupportInitialize)(this.matrix1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix1Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView matrix2Grid;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveFirstButton;
        private System.Windows.Forms.Button saveSecondButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

