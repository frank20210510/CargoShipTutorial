
namespace CargoShipTutorial
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_Cars = new System.Windows.Forms.TrackBar();
            this.track_trainCar = new System.Windows.Forms.TrackBar();
            this.label_cycleCount = new System.Windows.Forms.Label();
            this.label_truckCount = new System.Windows.Forms.Label();
            this.label_carCount = new System.Windows.Forms.Label();
            this.label_trainCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label_shipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CargoShipTutorial.Properties.Resources.cargoship;
            this.pictureBox2.Location = new System.Drawing.Point(102, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(753, 323);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(68, 440);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(271, 45);
            this.track_motorCycles.TabIndex = 2;
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(477, 440);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(269, 45);
            this.track_trucks.TabIndex = 3;
            // 
            // track_Cars
            // 
            this.track_Cars.Location = new System.Drawing.Point(68, 549);
            this.track_Cars.Name = "track_Cars";
            this.track_Cars.Size = new System.Drawing.Size(271, 45);
            this.track_Cars.TabIndex = 4;
            // 
            // track_trainCar
            // 
            this.track_trainCar.Location = new System.Drawing.Point(477, 549);
            this.track_trainCar.Name = "track_trainCar";
            this.track_trainCar.Size = new System.Drawing.Size(269, 45);
            this.track_trainCar.TabIndex = 5;
            // 
            // label_cycleCount
            // 
            this.label_cycleCount.AutoSize = true;
            this.label_cycleCount.Location = new System.Drawing.Point(119, 404);
            this.label_cycleCount.Name = "label_cycleCount";
            this.label_cycleCount.Size = new System.Drawing.Size(33, 12);
            this.label_cycleCount.TabIndex = 6;
            this.label_cycleCount.Text = "label1";
            // 
            // label_truckCount
            // 
            this.label_truckCount.AutoSize = true;
            this.label_truckCount.Location = new System.Drawing.Point(523, 404);
            this.label_truckCount.Name = "label_truckCount";
            this.label_truckCount.Size = new System.Drawing.Size(33, 12);
            this.label_truckCount.TabIndex = 7;
            this.label_truckCount.Text = "label2";
            // 
            // label_carCount
            // 
            this.label_carCount.AutoSize = true;
            this.label_carCount.Location = new System.Drawing.Point(100, 582);
            this.label_carCount.Name = "label_carCount";
            this.label_carCount.Size = new System.Drawing.Size(65, 12);
            this.label_carCount.TabIndex = 8;
            this.label_carCount.Text = "Cars(5 units)";
            // 
            // label_trainCount
            // 
            this.label_trainCount.AutoSize = true;
            this.label_trainCount.Location = new System.Drawing.Point(523, 522);
            this.label_trainCount.Name = "label_trainCount";
            this.label_trainCount.Size = new System.Drawing.Size(33, 12);
            this.label_trainCount.TabIndex = 9;
            this.label_trainCount.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "MotorCycles(3 units)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trucks(11 units)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 582);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Train Cars(17 units)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(249, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(571, 149);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Value = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "NewShip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(213, 292);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(33, 12);
            this.label_shipLabel.TabIndex = 17;
            this.label_shipLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 687);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_trainCount);
            this.Controls.Add(this.label_carCount);
            this.Controls.Add(this.label_truckCount);
            this.Controls.Add(this.label_cycleCount);
            this.Controls.Add(this.track_trainCar);
            this.Controls.Add(this.track_Cars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Load the ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_Cars;
        private System.Windows.Forms.TrackBar track_trainCar;
        private System.Windows.Forms.Label label_cycleCount;
        private System.Windows.Forms.Label label_truckCount;
        private System.Windows.Forms.Label label_carCount;
        private System.Windows.Forms.Label label_trainCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_shipLabel;
    }
}

