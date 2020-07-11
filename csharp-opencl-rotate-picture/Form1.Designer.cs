namespace csharp_opencl_rotate_picture
{
    partial class RotationImageByOpenCL
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
            this.BoxInformationAboutOpenCL = new System.Windows.Forms.GroupBox();
            this.InformationAboutDevice = new System.Windows.Forms.ListBox();
            this.LabelInfoAboutDevice = new System.Windows.Forms.Label();
            this.LabelInfoAboutCurrentPlatfroms = new System.Windows.Forms.Label();
            this.InformationCurrentPlatfrom = new System.Windows.Forms.ListBox();
            this.NamesOfDevicesCurrentPlatform = new System.Windows.Forms.ComboBox();
            this.LabelDevicesOfCurrentPlatfrom = new System.Windows.Forms.Label();
            this.LabelNamesOpenCLPlatfroms = new System.Windows.Forms.Label();
            this.NamesOpenCLPlatfroms = new System.Windows.Forms.ComboBox();
            this.BoxRotationImage = new System.Windows.Forms.GroupBox();
            this.LabelAngleScale = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TrackBar();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ImageRotates = new System.Windows.Forms.PictureBox();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.SaveImage = new System.Windows.Forms.SaveFileDialog();
            this.BoxInformationAboutOpenCL.SuspendLayout();
            this.BoxRotationImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRotates)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxInformationAboutOpenCL
            // 
            this.BoxInformationAboutOpenCL.Controls.Add(this.InformationAboutDevice);
            this.BoxInformationAboutOpenCL.Controls.Add(this.LabelInfoAboutDevice);
            this.BoxInformationAboutOpenCL.Controls.Add(this.LabelInfoAboutCurrentPlatfroms);
            this.BoxInformationAboutOpenCL.Controls.Add(this.InformationCurrentPlatfrom);
            this.BoxInformationAboutOpenCL.Controls.Add(this.NamesOfDevicesCurrentPlatform);
            this.BoxInformationAboutOpenCL.Controls.Add(this.LabelDevicesOfCurrentPlatfrom);
            this.BoxInformationAboutOpenCL.Controls.Add(this.LabelNamesOpenCLPlatfroms);
            this.BoxInformationAboutOpenCL.Controls.Add(this.NamesOpenCLPlatfroms);
            this.BoxInformationAboutOpenCL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxInformationAboutOpenCL.Location = new System.Drawing.Point(13, 13);
            this.BoxInformationAboutOpenCL.Name = "BoxInformationAboutOpenCL";
            this.BoxInformationAboutOpenCL.Size = new System.Drawing.Size(374, 562);
            this.BoxInformationAboutOpenCL.TabIndex = 1;
            this.BoxInformationAboutOpenCL.TabStop = false;
            this.BoxInformationAboutOpenCL.Text = "Информация об OpenCL";
            // 
            // InformationAboutDevice
            // 
            this.InformationAboutDevice.FormattingEnabled = true;
            this.InformationAboutDevice.ItemHeight = 16;
            this.InformationAboutDevice.Location = new System.Drawing.Point(25, 317);
            this.InformationAboutDevice.Name = "InformationAboutDevice";
            this.InformationAboutDevice.Size = new System.Drawing.Size(328, 132);
            this.InformationAboutDevice.TabIndex = 7;
            // 
            // LabelInfoAboutDevice
            // 
            this.LabelInfoAboutDevice.AutoSize = true;
            this.LabelInfoAboutDevice.Location = new System.Drawing.Point(22, 289);
            this.LabelInfoAboutDevice.Name = "LabelInfoAboutDevice";
            this.LabelInfoAboutDevice.Size = new System.Drawing.Size(105, 16);
            this.LabelInfoAboutDevice.TabIndex = 6;
            this.LabelInfoAboutDevice.Text = "Об устройстве";
            // 
            // LabelInfoAboutCurrentPlatfroms
            // 
            this.LabelInfoAboutCurrentPlatfroms.AutoSize = true;
            this.LabelInfoAboutCurrentPlatfroms.Location = new System.Drawing.Point(22, 157);
            this.LabelInfoAboutCurrentPlatfroms.Name = "LabelInfoAboutCurrentPlatfroms";
            this.LabelInfoAboutCurrentPlatfroms.Size = new System.Drawing.Size(107, 16);
            this.LabelInfoAboutCurrentPlatfroms.TabIndex = 5;
            this.LabelInfoAboutCurrentPlatfroms.Text = "Об платформе";
            // 
            // InformationCurrentPlatfrom
            // 
            this.InformationCurrentPlatfrom.FormattingEnabled = true;
            this.InformationCurrentPlatfrom.ItemHeight = 16;
            this.InformationCurrentPlatfrom.Location = new System.Drawing.Point(25, 189);
            this.InformationCurrentPlatfrom.Name = "InformationCurrentPlatfrom";
            this.InformationCurrentPlatfrom.Size = new System.Drawing.Size(328, 84);
            this.InformationCurrentPlatfrom.TabIndex = 4;
            // 
            // NamesOfDevicesCurrentPlatform
            // 
            this.NamesOfDevicesCurrentPlatform.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamesOfDevicesCurrentPlatform.FormattingEnabled = true;
            this.NamesOfDevicesCurrentPlatform.Location = new System.Drawing.Point(148, 87);
            this.NamesOfDevicesCurrentPlatform.Name = "NamesOfDevicesCurrentPlatform";
            this.NamesOfDevicesCurrentPlatform.Size = new System.Drawing.Size(205, 24);
            this.NamesOfDevicesCurrentPlatform.TabIndex = 3;
            this.NamesOfDevicesCurrentPlatform.SelectedIndexChanged += new System.EventHandler(this.NamesOfDevicesCurrentPlatform_SelectedIndexChanged);
            // 
            // LabelDevicesOfCurrentPlatfrom
            // 
            this.LabelDevicesOfCurrentPlatfrom.AutoSize = true;
            this.LabelDevicesOfCurrentPlatfrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDevicesOfCurrentPlatfrom.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDevicesOfCurrentPlatfrom.Location = new System.Drawing.Point(25, 97);
            this.LabelDevicesOfCurrentPlatfrom.Name = "LabelDevicesOfCurrentPlatfrom";
            this.LabelDevicesOfCurrentPlatfrom.Size = new System.Drawing.Size(83, 16);
            this.LabelDevicesOfCurrentPlatfrom.TabIndex = 2;
            this.LabelDevicesOfCurrentPlatfrom.Text = "Устройства";
            // 
            // LabelNamesOpenCLPlatfroms
            // 
            this.LabelNamesOpenCLPlatfroms.AutoSize = true;
            this.LabelNamesOpenCLPlatfroms.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNamesOpenCLPlatfroms.Location = new System.Drawing.Point(22, 46);
            this.LabelNamesOpenCLPlatfroms.Name = "LabelNamesOpenCLPlatfroms";
            this.LabelNamesOpenCLPlatfroms.Size = new System.Drawing.Size(87, 16);
            this.LabelNamesOpenCLPlatfroms.TabIndex = 1;
            this.LabelNamesOpenCLPlatfroms.Text = "Платформы";
            // 
            // NamesOpenCLPlatfroms
            // 
            this.NamesOpenCLPlatfroms.BackColor = System.Drawing.SystemColors.Window;
            this.NamesOpenCLPlatfroms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NamesOpenCLPlatfroms.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamesOpenCLPlatfroms.ForeColor = System.Drawing.Color.Black;
            this.NamesOpenCLPlatfroms.FormattingEnabled = true;
            this.NamesOpenCLPlatfroms.Location = new System.Drawing.Point(148, 43);
            this.NamesOpenCLPlatfroms.Name = "NamesOpenCLPlatfroms";
            this.NamesOpenCLPlatfroms.Size = new System.Drawing.Size(205, 24);
            this.NamesOpenCLPlatfroms.TabIndex = 0;
            this.NamesOpenCLPlatfroms.SelectedIndexChanged += new System.EventHandler(this.NamesOpenCLPlatfroms_SelectedIndexChanged);
            // 
            // BoxRotationImage
            // 
            this.BoxRotationImage.Controls.Add(this.LabelAngleScale);
            this.BoxRotationImage.Controls.Add(this.Angle);
            this.BoxRotationImage.Controls.Add(this.Open);
            this.BoxRotationImage.Controls.Add(this.Save);
            this.BoxRotationImage.Controls.Add(this.ImageRotates);
            this.BoxRotationImage.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxRotationImage.Location = new System.Drawing.Point(393, 13);
            this.BoxRotationImage.Name = "BoxRotationImage";
            this.BoxRotationImage.Size = new System.Drawing.Size(890, 562);
            this.BoxRotationImage.TabIndex = 2;
            this.BoxRotationImage.TabStop = false;
            this.BoxRotationImage.Text = "Поворот изображения";
            // 
            // LabelAngleScale
            // 
            this.LabelAngleScale.AutoSize = true;
            this.LabelAngleScale.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAngleScale.Location = new System.Drawing.Point(19, 491);
            this.LabelAngleScale.Name = "LabelAngleScale";
            this.LabelAngleScale.Size = new System.Drawing.Size(80, 28);
            this.LabelAngleScale.TabIndex = 4;
            this.LabelAngleScale.Text = "label1";
            // 
            // Angle
            // 
            this.Angle.LargeChange = 360;
            this.Angle.Location = new System.Drawing.Point(138, 491);
            this.Angle.Maximum = 360;
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(524, 56);
            this.Angle.TabIndex = 3;
            this.Angle.Scroll += new System.EventHandler(this.Angle_Scroll);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(668, 503);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(86, 35);
            this.Open.TabIndex = 2;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(760, 503);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 35);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ImageRotates
            // 
            this.ImageRotates.Location = new System.Drawing.Point(24, 24);
            this.ImageRotates.Name = "ImageRotates";
            this.ImageRotates.Size = new System.Drawing.Size(839, 440);
            this.ImageRotates.TabIndex = 0;
            this.ImageRotates.TabStop = false;
            this.ImageRotates.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageRotates_Paint);
            // 
            // OpenImage
            // 
            this.OpenImage.FileName = "openFileDialog1";
            // 
            // RotationImageByOpenCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 581);
            this.Controls.Add(this.BoxRotationImage);
            this.Controls.Add(this.BoxInformationAboutOpenCL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RotationImageByOpenCL";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.RotationImageByOpenCL_Activated);
            this.BoxInformationAboutOpenCL.ResumeLayout(false);
            this.BoxInformationAboutOpenCL.PerformLayout();
            this.BoxRotationImage.ResumeLayout(false);
            this.BoxRotationImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRotates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxInformationAboutOpenCL;
        private System.Windows.Forms.ComboBox NamesOpenCLPlatfroms;
        private System.Windows.Forms.Label LabelNamesOpenCLPlatfroms;
        private System.Windows.Forms.Label LabelDevicesOfCurrentPlatfrom;
        private System.Windows.Forms.ComboBox NamesOfDevicesCurrentPlatform;
        private System.Windows.Forms.Label LabelInfoAboutCurrentPlatfroms;
        private System.Windows.Forms.ListBox InformationCurrentPlatfrom;
        private System.Windows.Forms.Label LabelInfoAboutDevice;
        private System.Windows.Forms.ListBox InformationAboutDevice;
        private System.Windows.Forms.GroupBox BoxRotationImage;
        private System.Windows.Forms.TrackBar Angle;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.PictureBox ImageRotates;
        private System.Windows.Forms.Label LabelAngleScale;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.SaveFileDialog SaveImage;
    }
}

