namespace csharp_opencl_rotate_picture
{
    partial class rotationImageByOpenCL
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
            this.boxInformationAboutOpenCL = new System.Windows.Forms.GroupBox();
            this.namesOfDevicesCurrentPlatform = new System.Windows.Forms.ComboBox();
            this.labelDevicesOfCurrentPlatfrom = new System.Windows.Forms.Label();
            this.labelNamesOpenCLPlatfroms = new System.Windows.Forms.Label();
            this.namesOpenCLPlatfroms = new System.Windows.Forms.ComboBox();
            this.informationCurrentPlatfrom = new System.Windows.Forms.ListBox();
            this.labelInfoAboutCurrentPlatfroms = new System.Windows.Forms.Label();
            this.labelInfoAboutDevice = new System.Windows.Forms.Label();
            this.informationAboutDevice = new System.Windows.Forms.ListBox();
            this.boxRotationImage = new System.Windows.Forms.GroupBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.TrackBar();
            this.labelAngleScale = new System.Windows.Forms.Label();
            this.openImgage = new System.Windows.Forms.OpenFileDialog();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.boxInformationAboutOpenCL.SuspendLayout();
            this.boxRotationImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).BeginInit();
            this.SuspendLayout();
            // 
            // boxInformationAboutOpenCL
            // 
            this.boxInformationAboutOpenCL.Controls.Add(this.informationAboutDevice);
            this.boxInformationAboutOpenCL.Controls.Add(this.labelInfoAboutDevice);
            this.boxInformationAboutOpenCL.Controls.Add(this.labelInfoAboutCurrentPlatfroms);
            this.boxInformationAboutOpenCL.Controls.Add(this.informationCurrentPlatfrom);
            this.boxInformationAboutOpenCL.Controls.Add(this.namesOfDevicesCurrentPlatform);
            this.boxInformationAboutOpenCL.Controls.Add(this.labelDevicesOfCurrentPlatfrom);
            this.boxInformationAboutOpenCL.Controls.Add(this.labelNamesOpenCLPlatfroms);
            this.boxInformationAboutOpenCL.Controls.Add(this.namesOpenCLPlatfroms);
            this.boxInformationAboutOpenCL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxInformationAboutOpenCL.Location = new System.Drawing.Point(13, 13);
            this.boxInformationAboutOpenCL.Name = "boxInformationAboutOpenCL";
            this.boxInformationAboutOpenCL.Size = new System.Drawing.Size(374, 562);
            this.boxInformationAboutOpenCL.TabIndex = 1;
            this.boxInformationAboutOpenCL.TabStop = false;
            this.boxInformationAboutOpenCL.Text = "Информация об OpenCL";
            // 
            // namesOfDevicesCurrentPlatform
            // 
            this.namesOfDevicesCurrentPlatform.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesOfDevicesCurrentPlatform.FormattingEnabled = true;
            this.namesOfDevicesCurrentPlatform.Location = new System.Drawing.Point(148, 87);
            this.namesOfDevicesCurrentPlatform.Name = "namesOfDevicesCurrentPlatform";
            this.namesOfDevicesCurrentPlatform.Size = new System.Drawing.Size(205, 24);
            this.namesOfDevicesCurrentPlatform.TabIndex = 3;
            this.namesOfDevicesCurrentPlatform.SelectedIndexChanged += new System.EventHandler(this.namesOfDevicesCurrentPlatform_SelectedIndexChanged);
            // 
            // labelDevicesOfCurrentPlatfrom
            // 
            this.labelDevicesOfCurrentPlatfrom.AutoSize = true;
            this.labelDevicesOfCurrentPlatfrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDevicesOfCurrentPlatfrom.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDevicesOfCurrentPlatfrom.Location = new System.Drawing.Point(25, 97);
            this.labelDevicesOfCurrentPlatfrom.Name = "labelDevicesOfCurrentPlatfrom";
            this.labelDevicesOfCurrentPlatfrom.Size = new System.Drawing.Size(83, 16);
            this.labelDevicesOfCurrentPlatfrom.TabIndex = 2;
            this.labelDevicesOfCurrentPlatfrom.Text = "Устройства";
            // 
            // labelNamesOpenCLPlatfroms
            // 
            this.labelNamesOpenCLPlatfroms.AutoSize = true;
            this.labelNamesOpenCLPlatfroms.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamesOpenCLPlatfroms.Location = new System.Drawing.Point(22, 46);
            this.labelNamesOpenCLPlatfroms.Name = "labelNamesOpenCLPlatfroms";
            this.labelNamesOpenCLPlatfroms.Size = new System.Drawing.Size(87, 16);
            this.labelNamesOpenCLPlatfroms.TabIndex = 1;
            this.labelNamesOpenCLPlatfroms.Text = "Платформы";
            // 
            // namesOpenCLPlatfroms
            // 
            this.namesOpenCLPlatfroms.BackColor = System.Drawing.SystemColors.Window;
            this.namesOpenCLPlatfroms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.namesOpenCLPlatfroms.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namesOpenCLPlatfroms.ForeColor = System.Drawing.Color.Black;
            this.namesOpenCLPlatfroms.FormattingEnabled = true;
            this.namesOpenCLPlatfroms.Location = new System.Drawing.Point(148, 43);
            this.namesOpenCLPlatfroms.Name = "namesOpenCLPlatfroms";
            this.namesOpenCLPlatfroms.Size = new System.Drawing.Size(205, 24);
            this.namesOpenCLPlatfroms.TabIndex = 0;
            this.namesOpenCLPlatfroms.SelectedIndexChanged += new System.EventHandler(this.namesOpenCLPlatfroms_SelectedIndexChanged);
            // 
            // informationCurrentPlatfrom
            // 
            this.informationCurrentPlatfrom.FormattingEnabled = true;
            this.informationCurrentPlatfrom.ItemHeight = 16;
            this.informationCurrentPlatfrom.Location = new System.Drawing.Point(25, 189);
            this.informationCurrentPlatfrom.Name = "informationCurrentPlatfrom";
            this.informationCurrentPlatfrom.Size = new System.Drawing.Size(328, 84);
            this.informationCurrentPlatfrom.TabIndex = 4;
            // 
            // labelInfoAboutCurrentPlatfroms
            // 
            this.labelInfoAboutCurrentPlatfroms.AutoSize = true;
            this.labelInfoAboutCurrentPlatfroms.Location = new System.Drawing.Point(22, 157);
            this.labelInfoAboutCurrentPlatfroms.Name = "labelInfoAboutCurrentPlatfroms";
            this.labelInfoAboutCurrentPlatfroms.Size = new System.Drawing.Size(107, 16);
            this.labelInfoAboutCurrentPlatfroms.TabIndex = 5;
            this.labelInfoAboutCurrentPlatfroms.Text = "Об платформе";
            // 
            // labelInfoAboutDevice
            // 
            this.labelInfoAboutDevice.AutoSize = true;
            this.labelInfoAboutDevice.Location = new System.Drawing.Point(22, 289);
            this.labelInfoAboutDevice.Name = "labelInfoAboutDevice";
            this.labelInfoAboutDevice.Size = new System.Drawing.Size(105, 16);
            this.labelInfoAboutDevice.TabIndex = 6;
            this.labelInfoAboutDevice.Text = "Об устройстве";
            // 
            // informationAboutDevice
            // 
            this.informationAboutDevice.FormattingEnabled = true;
            this.informationAboutDevice.ItemHeight = 16;
            this.informationAboutDevice.Location = new System.Drawing.Point(25, 317);
            this.informationAboutDevice.Name = "informationAboutDevice";
            this.informationAboutDevice.Size = new System.Drawing.Size(328, 132);
            this.informationAboutDevice.TabIndex = 7;
            // 
            // boxRotationImage
            // 
            this.boxRotationImage.Controls.Add(this.labelAngleScale);
            this.boxRotationImage.Controls.Add(this.angle);
            this.boxRotationImage.Controls.Add(this.open);
            this.boxRotationImage.Controls.Add(this.save);
            this.boxRotationImage.Controls.Add(this.image);
            this.boxRotationImage.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxRotationImage.Location = new System.Drawing.Point(393, 13);
            this.boxRotationImage.Name = "boxRotationImage";
            this.boxRotationImage.Size = new System.Drawing.Size(890, 562);
            this.boxRotationImage.TabIndex = 2;
            this.boxRotationImage.TabStop = false;
            this.boxRotationImage.Text = "Поворот изображения";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(24, 24);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(839, 440);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(760, 503);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(103, 35);
            this.save.TabIndex = 1;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(668, 503);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(86, 35);
            this.open.TabIndex = 2;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // angle
            // 
            this.angle.LargeChange = 360;
            this.angle.Location = new System.Drawing.Point(138, 491);
            this.angle.Maximum = 360;
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(524, 56);
            this.angle.TabIndex = 3;
            this.angle.Scroll += new System.EventHandler(this.angle_Scroll);
            // 
            // labelAngleScale
            // 
            this.labelAngleScale.AutoSize = true;
            this.labelAngleScale.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAngleScale.Location = new System.Drawing.Point(19, 491);
            this.labelAngleScale.Name = "labelAngleScale";
            this.labelAngleScale.Size = new System.Drawing.Size(80, 28);
            this.labelAngleScale.TabIndex = 4;
            this.labelAngleScale.Text = "label1";
            // 
            // openImgage
            // 
            this.openImgage.FileName = "openFileDialog1";
            // 
            // rotationImageByOpenCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 581);
            this.Controls.Add(this.boxRotationImage);
            this.Controls.Add(this.boxInformationAboutOpenCL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "rotationImageByOpenCL";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.rotationImageByOpenCL_Activated);
            this.boxInformationAboutOpenCL.ResumeLayout(false);
            this.boxInformationAboutOpenCL.PerformLayout();
            this.boxRotationImage.ResumeLayout(false);
            this.boxRotationImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxInformationAboutOpenCL;
        private System.Windows.Forms.ComboBox namesOpenCLPlatfroms;
        private System.Windows.Forms.Label labelNamesOpenCLPlatfroms;
        private System.Windows.Forms.Label labelDevicesOfCurrentPlatfrom;
        private System.Windows.Forms.ComboBox namesOfDevicesCurrentPlatform;
        private System.Windows.Forms.Label labelInfoAboutCurrentPlatfroms;
        private System.Windows.Forms.ListBox informationCurrentPlatfrom;
        private System.Windows.Forms.Label labelInfoAboutDevice;
        private System.Windows.Forms.ListBox informationAboutDevice;
        private System.Windows.Forms.GroupBox boxRotationImage;
        private System.Windows.Forms.TrackBar angle;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label labelAngleScale;
        private System.Windows.Forms.OpenFileDialog openImgage;
        private System.Windows.Forms.SaveFileDialog saveImage;
    }
}

