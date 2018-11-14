namespace Reservations
{
    partial class frmReservation
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
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblNumNights = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtNumNights = new System.Windows.Forms.TextBox();
            this.txtPricePerNight = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(94, 91);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(167, 32);
            this.lblArrival.TabIndex = 7;
            this.lblArrival.Text = "Arrival date:";
            this.lblArrival.Click += new System.EventHandler(this.lblArrival_Click);
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(54, 188);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(212, 32);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Departure date:";
            // 
            // lblNumNights
            // 
            this.lblNumNights.AutoSize = true;
            this.lblNumNights.Location = new System.Drawing.Point(30, 302);
            this.lblNumNights.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumNights.Name = "lblNumNights";
            this.lblNumNights.Size = new System.Drawing.Size(238, 32);
            this.lblNumNights.TabIndex = 9;
            this.lblNumNights.Text = "Number of nights:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(62, 409);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(206, 32);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price per night:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(104, 531);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(156, 32);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total price:";
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(274, 85);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(6);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(196, 38);
            this.txtArrival.TabIndex = 0;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(274, 182);
            this.txtDeparture.Margin = new System.Windows.Forms.Padding(6);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(196, 38);
            this.txtDeparture.TabIndex = 1;
            // 
            // txtNumNights
            // 
            this.txtNumNights.Enabled = false;
            this.txtNumNights.Location = new System.Drawing.Point(274, 296);
            this.txtNumNights.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumNights.Name = "txtNumNights";
            this.txtNumNights.Size = new System.Drawing.Size(196, 38);
            this.txtNumNights.TabIndex = 3;
            // 
            // txtPricePerNight
            // 
            this.txtPricePerNight.Enabled = false;
            this.txtPricePerNight.Location = new System.Drawing.Point(274, 403);
            this.txtPricePerNight.Margin = new System.Windows.Forms.Padding(6);
            this.txtPricePerNight.Name = "txtPricePerNight";
            this.txtPricePerNight.Size = new System.Drawing.Size(196, 38);
            this.txtPricePerNight.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(274, 531);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 38);
            this.txtTotal.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 653);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(196, 83);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 653);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 83);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 783);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPricePerNight);
            this.Controls.Add(this.txtNumNights);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNumNights);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblArrival);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmReservation";
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblNumNights;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtNumNights;
        private System.Windows.Forms.TextBox txtPricePerNight;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

