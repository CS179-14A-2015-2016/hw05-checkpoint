namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.paddle2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.paddle1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ball2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ball1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.paddle2,
            this.paddle1,
            this.ball2,
            this.ball1});
            this.shapeContainer1.Size = new System.Drawing.Size(504, 281);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.paddle2.BorderWidth = 20;
            this.paddle2.Name = "paddle2";
            this.paddle2.X1 = 460;
            this.paddle2.X2 = 460;
            this.paddle2.Y1 = 75;
            this.paddle2.Y2 = 175;
            // 
            // paddle1
            // 
            this.paddle1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.paddle1.BorderWidth = 20;
            this.paddle1.Name = "paddle1";
            this.paddle1.X1 = 24;
            this.paddle1.X2 = 24;
            this.paddle1.Y1 = 75;
            this.paddle1.Y2 = 175;
            // 
            // ball2
            // 
            this.ball2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ball2.Location = new System.Drawing.Point(122, 120);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(10, 10);
            // 
            // ball1
            // 
            this.ball1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ball1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ball1.Location = new System.Drawing.Point(65, 124);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(10, 10);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(504, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "V E C T O R pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ball1;
        private Microsoft.VisualBasic.PowerPacks.LineShape paddle2;
        private Microsoft.VisualBasic.PowerPacks.LineShape paddle1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ball2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

