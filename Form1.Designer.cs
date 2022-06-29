
namespace Easy_Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fetchWeather = new System.Windows.Forms.Button();
            this.userLocationBox = new System.Windows.Forms.TextBox();
            this.howToLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fetchWeather
            // 
            this.fetchWeather.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fetchWeather.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fetchWeather.Location = new System.Drawing.Point(210, 151);
            this.fetchWeather.Name = "fetchWeather";
            this.fetchWeather.Size = new System.Drawing.Size(183, 50);
            this.fetchWeather.TabIndex = 0;
            this.fetchWeather.Text = "Get Weather";
            this.fetchWeather.UseVisualStyleBackColor = true;
            this.fetchWeather.Click += new System.EventHandler(this.fetchWeather_Click);
            // 
            // userLocationBox
            // 
            this.userLocationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userLocationBox.Location = new System.Drawing.Point(67, 95);
            this.userLocationBox.Name = "userLocationBox";
            this.userLocationBox.Size = new System.Drawing.Size(466, 23);
            this.userLocationBox.TabIndex = 1;
            this.userLocationBox.TextChanged += new System.EventHandler(this.userLocationBox_TextChanged);
            this.userLocationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userLocationBox_KeyPress);
            // 
            // howToLabel
            // 
            this.howToLabel.AutoSize = true;
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.howToLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.howToLabel.Location = new System.Drawing.Point(67, 25);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(458, 38);
            this.howToLabel.TabIndex = 2;
            this.howToLabel.Text = "Enter a ZIP Code or type a City/Town name then press Get Weather \r\nor press the E" +
    "nter Key";
            this.howToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.howToLabel.Click += new System.EventHandler(this.howToLabel_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultsLabel.Location = new System.Drawing.Point(39, 25);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(527, 137);
            this.resultsLabel.TabIndex = 3;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resultsLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 237);
            this.Controls.Add(this.howToLabel);
            this.Controls.Add(this.userLocationBox);
            this.Controls.Add(this.fetchWeather);
            this.Controls.Add(this.resultsLabel);
            this.Name = "Form1";
            this.Text = "Easy Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchWeather;
        private System.Windows.Forms.TextBox userLocationBox;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}

