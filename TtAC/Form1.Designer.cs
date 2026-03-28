namespace TtAC
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
            textBoxTextToVoice = new TextBox();
            comboBoxVoices = new ComboBox();
            trackBarVolume = new TrackBar();
            labelVolume = new Label();
            labelRate = new Label();
            trackBarRate = new TrackBar();
            buttonSave = new Button();
            buttonRead = new Button();
            labelSelectVoice = new Label();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRate).BeginInit();
            SuspendLayout();
            // 
            // textBoxTextToVoice
            // 
            textBoxTextToVoice.BackColor = SystemColors.ControlDark;
            textBoxTextToVoice.BorderStyle = BorderStyle.None;
            textBoxTextToVoice.Font = new Font("Segoe UI", 13F);
            textBoxTextToVoice.Location = new Point(12, 18);
            textBoxTextToVoice.Multiline = true;
            textBoxTextToVoice.Name = "textBoxTextToVoice";
            textBoxTextToVoice.Size = new Size(560, 420);
            textBoxTextToVoice.TabIndex = 0;
            textBoxTextToVoice.Text = "\r\n";
            // 
            // comboBoxVoices
            // 
            comboBoxVoices.BackColor = SystemColors.ScrollBar;
            comboBoxVoices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoices.FormattingEnabled = true;
            comboBoxVoices.Location = new Point(578, 18);
            comboBoxVoices.Name = "comboBoxVoices";
            comboBoxVoices.Size = new Size(210, 23);
            comboBoxVoices.TabIndex = 1;
            comboBoxVoices.SelectedIndexChanged += comboBoxVoices_SelectedIndexChanged;
            // 
            // trackBarVolume
            // 
            trackBarVolume.LargeChange = 1;
            trackBarVolume.Location = new Point(578, 47);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.RightToLeft = RightToLeft.No;
            trackBarVolume.Size = new Size(161, 45);
            trackBarVolume.TabIndex = 2;
            trackBarVolume.Value = 50;
            trackBarVolume.Scroll += tckBarVolume_Scroll;
            // 
            // labelVolume
            // 
            labelVolume.Location = new Point(736, 47);
            labelVolume.MaximumSize = new Size(100, 100);
            labelVolume.MinimumSize = new Size(10, 20);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(60, 28);
            labelVolume.TabIndex = 3;
            labelVolume.Text = "Volume:\r\n50";
            labelVolume.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelRate
            // 
            labelRate.Location = new Point(736, 98);
            labelRate.MaximumSize = new Size(100, 100);
            labelRate.MinimumSize = new Size(10, 20);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(60, 28);
            labelRate.TabIndex = 5;
            labelRate.Text = "Rate:\r\n0";
            labelRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBarRate
            // 
            trackBarRate.LargeChange = 1;
            trackBarRate.Location = new Point(578, 98);
            trackBarRate.Minimum = -10;
            trackBarRate.Name = "trackBarRate";
            trackBarRate.RightToLeft = RightToLeft.No;
            trackBarRate.Size = new Size(161, 45);
            trackBarRate.TabIndex = 4;
            trackBarRate.Scroll += tckBarRate_Scroll;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ControlDark;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 13F);
            buttonSave.Location = new Point(578, 403);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(210, 35);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += btnSave_Click;
            // 
            // buttonRead
            // 
            buttonRead.BackColor = SystemColors.ControlDark;
            buttonRead.FlatAppearance.BorderSize = 0;
            buttonRead.FlatStyle = FlatStyle.Flat;
            buttonRead.Font = new Font("Segoe UI", 13F);
            buttonRead.Location = new Point(578, 362);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(210, 35);
            buttonRead.TabIndex = 10;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = false;
            buttonRead.Click += btnRead_Click;
            // 
            // labelSelectVoice
            // 
            labelSelectVoice.AutoSize = true;
            labelSelectVoice.BackColor = Color.Transparent;
            labelSelectVoice.Location = new Point(648, -5);
            labelSelectVoice.MaximumSize = new Size(100, 100);
            labelSelectVoice.MinimumSize = new Size(10, 20);
            labelSelectVoice.Name = "labelSelectVoice";
            labelSelectVoice.Size = new Size(72, 20);
            labelSelectVoice.TabIndex = 11;
            labelSelectVoice.Text = "Select voice:";
            labelSelectVoice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(578, 321);
            button1.Name = "button1";
            button1.Size = new Size(210, 35);
            button1.TabIndex = 12;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, -5);
            label1.MaximumSize = new Size(100, 100);
            label1.MinimumSize = new Size(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 13;
            label1.Text = "Text to audio:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(labelSelectVoice);
            Controls.Add(buttonRead);
            Controls.Add(buttonSave);
            Controls.Add(labelRate);
            Controls.Add(trackBarRate);
            Controls.Add(labelVolume);
            Controls.Add(trackBarVolume);
            Controls.Add(comboBoxVoices);
            Controls.Add(textBoxTextToVoice);
            Name = "Form1";
            Text = "TtAC";
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTextToVoice;
        private ComboBox comboBoxVoices;
        private TrackBar trackBarVolume;
        private Label labelVolume;
        private Label labelRate;
        private TrackBar trackBarRate;
        private Button buttonSave;
        private Button buttonRead;
        private Label labelSelectVoice;
        private Button button1;
        private Label label1;
    }
}
