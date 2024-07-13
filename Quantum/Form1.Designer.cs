namespace Quantum
{
    partial class Form1 : Form
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
            Speechbutton = new Button();
            richTextBox1 = new RichTextBox();
            voicomboBox = new ComboBox();
            SpeedtrackBar = new TrackBar();
            VolumetrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)SpeedtrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumetrackBar).BeginInit();
            SuspendLayout();
            // 
            // Speechbutton
            // 
            Speechbutton.BackColor = SystemColors.Control;
            Speechbutton.ForeColor = SystemColors.MenuText;
            Speechbutton.Location = new Point(12, 12);
            Speechbutton.Name = "Speechbutton";
            Speechbutton.Size = new Size(92, 31);
            Speechbutton.TabIndex = 0;
            Speechbutton.Text = "Speech";
            Speechbutton.UseVisualStyleBackColor = false;
            Speechbutton.Click += Speechbutton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(459, 207);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // voicomboBox
            // 
            voicomboBox.FormattingEnabled = true;
            voicomboBox.Items.AddRange(new object[] { "Male", "Female" });
            voicomboBox.Location = new Point(350, 12);
            voicomboBox.Name = "voicomboBox";
            voicomboBox.Size = new Size(121, 23);
            voicomboBox.TabIndex = 2;
            voicomboBox.Text = "Male";
            voicomboBox.SelectedIndexChanged += voicomboBox_SelectedIndexChanged;
            // 
            // SpeedtrackBar
            // 
            SpeedtrackBar.Location = new Point(57, 271);
            SpeedtrackBar.Minimum = -10;
            SpeedtrackBar.Name = "SpeedtrackBar";
            SpeedtrackBar.Size = new Size(104, 45);
            SpeedtrackBar.TabIndex = 3;
            // 
            // VolumetrackBar
            // 
            VolumetrackBar.Location = new Point(367, 273);
            VolumetrackBar.Maximum = 100;
            VolumetrackBar.Minimum = 10;
            VolumetrackBar.Name = "VolumetrackBar";
            VolumetrackBar.Size = new Size(104, 45);
            VolumetrackBar.TabIndex = 4;
            VolumetrackBar.Value = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Speed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 281);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Volume";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(483, 330);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(VolumetrackBar);
            Controls.Add(SpeedtrackBar);
            Controls.Add(voicomboBox);
            Controls.Add(richTextBox1);
            Controls.Add(Speechbutton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text to Speech";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SpeedtrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumetrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Speechbutton;
        private RichTextBox richTextBox1;
        private ComboBox voicomboBox;
        private TrackBar SpeedtrackBar;
        private TrackBar VolumetrackBar;
        private Label label1;
        private Label label2;
    }
}
