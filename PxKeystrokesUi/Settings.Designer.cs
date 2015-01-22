﻿namespace PxKeystrokesUi
{
    partial class Settings
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
            this.button_backcolor = new System.Windows.Forms.Button();
            this.button_textcolor = new System.Windows.Forms.Button();
            this.slider_opacity = new System.Windows.Forms.TrackBar();
            this.label_opacity = new System.Windows.Forms.Label();
            this.label_fontsize = new System.Windows.Forms.Label();
            this.slider_fontsize = new System.Windows.Forms.TrackBar();
            this.rb_align_left = new System.Windows.Forms.RadioButton();
            this.rb_align_center = new System.Windows.Forms.RadioButton();
            this.rb_align_right = new System.Windows.Forms.RadioButton();
            this.groupBox_text_alignment = new System.Windows.Forms.GroupBox();
            this.gb_textdir = new System.Windows.Forms.GroupBox();
            this.rb_td_up = new System.Windows.Forms.RadioButton();
            this.rb_td_down = new System.Windows.Forms.RadioButton();
            this.gb_style = new System.Windows.Forms.GroupBox();
            this.rb_style_slide = new System.Windows.Forms.RadioButton();
            this.rb_style_noani = new System.Windows.Forms.RadioButton();
            this.gb_text = new System.Windows.Forms.GroupBox();
            this.button_textfont = new System.Windows.Forms.Button();
            this.gb_background = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picker_textcolor = new System.Windows.Forms.ColorDialog();
            this.picker_backcolor = new System.Windows.Forms.ColorDialog();
            this.fontDialog_text = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.slider_opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_fontsize)).BeginInit();
            this.groupBox_text_alignment.SuspendLayout();
            this.gb_textdir.SuspendLayout();
            this.gb_style.SuspendLayout();
            this.gb_text.SuspendLayout();
            this.gb_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_backcolor
            // 
            this.button_backcolor.Location = new System.Drawing.Point(6, 19);
            this.button_backcolor.Name = "button_backcolor";
            this.button_backcolor.Size = new System.Drawing.Size(171, 23);
            this.button_backcolor.TabIndex = 25;
            this.button_backcolor.Text = "Background color";
            this.button_backcolor.UseVisualStyleBackColor = true;
            this.button_backcolor.Click += new System.EventHandler(this.button_backcolor_Click);
            // 
            // button_textcolor
            // 
            this.button_textcolor.Location = new System.Drawing.Point(6, 19);
            this.button_textcolor.Name = "button_textcolor";
            this.button_textcolor.Size = new System.Drawing.Size(80, 23);
            this.button_textcolor.TabIndex = 24;
            this.button_textcolor.Text = "Text color";
            this.button_textcolor.UseVisualStyleBackColor = true;
            this.button_textcolor.Click += new System.EventHandler(this.button_textcolor_Click);
            // 
            // slider_opacity
            // 
            this.slider_opacity.Location = new System.Drawing.Point(68, 55);
            this.slider_opacity.Maximum = 100;
            this.slider_opacity.Minimum = 10;
            this.slider_opacity.Name = "slider_opacity";
            this.slider_opacity.Size = new System.Drawing.Size(104, 45);
            this.slider_opacity.TabIndex = 17;
            this.slider_opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_opacity.Value = 80;
            this.slider_opacity.Scroll += new System.EventHandler(this.slider_opacity_Scroll);
            // 
            // label_opacity
            // 
            this.label_opacity.AutoSize = true;
            this.label_opacity.Location = new System.Drawing.Point(16, 55);
            this.label_opacity.Name = "label_opacity";
            this.label_opacity.Size = new System.Drawing.Size(43, 13);
            this.label_opacity.TabIndex = 16;
            this.label_opacity.Text = "Opacity";
            // 
            // label_fontsize
            // 
            this.label_fontsize.AutoSize = true;
            this.label_fontsize.Location = new System.Drawing.Point(16, 58);
            this.label_fontsize.Name = "label_fontsize";
            this.label_fontsize.Size = new System.Drawing.Size(46, 13);
            this.label_fontsize.TabIndex = 15;
            this.label_fontsize.Text = "Fontsize";
            // 
            // slider_fontsize
            // 
            this.slider_fontsize.Location = new System.Drawing.Point(68, 55);
            this.slider_fontsize.Maximum = 3000;
            this.slider_fontsize.Minimum = 800;
            this.slider_fontsize.Name = "slider_fontsize";
            this.slider_fontsize.Size = new System.Drawing.Size(104, 45);
            this.slider_fontsize.TabIndex = 14;
            this.slider_fontsize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_fontsize.Value = 800;
            this.slider_fontsize.Scroll += new System.EventHandler(this.slider_fontsize_Scroll);
            // 
            // rb_align_left
            // 
            this.rb_align_left.AutoSize = true;
            this.rb_align_left.Location = new System.Drawing.Point(6, 19);
            this.rb_align_left.Name = "rb_align_left";
            this.rb_align_left.Size = new System.Drawing.Size(39, 17);
            this.rb_align_left.TabIndex = 26;
            this.rb_align_left.TabStop = true;
            this.rb_align_left.Text = "left";
            this.rb_align_left.UseVisualStyleBackColor = true;
            this.rb_align_left.CheckedChanged += new System.EventHandler(this.rb_align_left_CheckedChanged);
            // 
            // rb_align_center
            // 
            this.rb_align_center.AutoSize = true;
            this.rb_align_center.Location = new System.Drawing.Point(49, 42);
            this.rb_align_center.Name = "rb_align_center";
            this.rb_align_center.Size = new System.Drawing.Size(55, 17);
            this.rb_align_center.TabIndex = 27;
            this.rb_align_center.TabStop = true;
            this.rb_align_center.Text = "center";
            this.rb_align_center.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_align_center.UseVisualStyleBackColor = true;
            this.rb_align_center.CheckedChanged += new System.EventHandler(this.rb_align_center_CheckedChanged);
            // 
            // rb_align_right
            // 
            this.rb_align_right.AutoSize = true;
            this.rb_align_right.Location = new System.Drawing.Point(99, 65);
            this.rb_align_right.Name = "rb_align_right";
            this.rb_align_right.Size = new System.Drawing.Size(45, 17);
            this.rb_align_right.TabIndex = 28;
            this.rb_align_right.TabStop = true;
            this.rb_align_right.Text = "right";
            this.rb_align_right.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_align_right.UseVisualStyleBackColor = true;
            this.rb_align_right.CheckedChanged += new System.EventHandler(this.rb_align_right_CheckedChanged);
            // 
            // groupBox_text_alignment
            // 
            this.groupBox_text_alignment.Controls.Add(this.rb_align_left);
            this.groupBox_text_alignment.Controls.Add(this.rb_align_right);
            this.groupBox_text_alignment.Controls.Add(this.rb_align_center);
            this.groupBox_text_alignment.Location = new System.Drawing.Point(12, 12);
            this.groupBox_text_alignment.Name = "groupBox_text_alignment";
            this.groupBox_text_alignment.Size = new System.Drawing.Size(150, 89);
            this.groupBox_text_alignment.TabIndex = 29;
            this.groupBox_text_alignment.TabStop = false;
            this.groupBox_text_alignment.Text = "Text Alignment";
            // 
            // gb_textdir
            // 
            this.gb_textdir.Controls.Add(this.rb_td_up);
            this.gb_textdir.Controls.Add(this.rb_td_down);
            this.gb_textdir.Location = new System.Drawing.Point(13, 108);
            this.gb_textdir.Name = "gb_textdir";
            this.gb_textdir.Size = new System.Drawing.Size(149, 63);
            this.gb_textdir.TabIndex = 30;
            this.gb_textdir.TabStop = false;
            this.gb_textdir.Text = "Text Direction";
            // 
            // rb_td_up
            // 
            this.rb_td_up.AutoSize = true;
            this.rb_td_up.Location = new System.Drawing.Point(7, 39);
            this.rb_td_up.Name = "rb_td_up";
            this.rb_td_up.Size = new System.Drawing.Size(37, 17);
            this.rb_td_up.TabIndex = 1;
            this.rb_td_up.TabStop = true;
            this.rb_td_up.Text = "up";
            this.rb_td_up.UseVisualStyleBackColor = true;
            this.rb_td_up.CheckedChanged += new System.EventHandler(this.rb_td_up_CheckedChanged);
            // 
            // rb_td_down
            // 
            this.rb_td_down.AutoSize = true;
            this.rb_td_down.Location = new System.Drawing.Point(7, 16);
            this.rb_td_down.Name = "rb_td_down";
            this.rb_td_down.Size = new System.Drawing.Size(51, 17);
            this.rb_td_down.TabIndex = 0;
            this.rb_td_down.TabStop = true;
            this.rb_td_down.Text = "down";
            this.rb_td_down.UseVisualStyleBackColor = true;
            this.rb_td_down.CheckedChanged += new System.EventHandler(this.rb_td_down_CheckedChanged);
            // 
            // gb_style
            // 
            this.gb_style.Controls.Add(this.rb_style_slide);
            this.gb_style.Controls.Add(this.rb_style_noani);
            this.gb_style.Location = new System.Drawing.Point(12, 178);
            this.gb_style.Name = "gb_style";
            this.gb_style.Size = new System.Drawing.Size(150, 71);
            this.gb_style.TabIndex = 31;
            this.gb_style.TabStop = false;
            this.gb_style.Text = "Style";
            // 
            // rb_style_slide
            // 
            this.rb_style_slide.AutoSize = true;
            this.rb_style_slide.Location = new System.Drawing.Point(8, 42);
            this.rb_style_slide.Name = "rb_style_slide";
            this.rb_style_slide.Size = new System.Drawing.Size(46, 17);
            this.rb_style_slide.TabIndex = 3;
            this.rb_style_slide.TabStop = true;
            this.rb_style_slide.Text = "slide";
            this.rb_style_slide.UseVisualStyleBackColor = true;
            this.rb_style_slide.CheckedChanged += new System.EventHandler(this.rb_style_slide_CheckedChanged);
            // 
            // rb_style_noani
            // 
            this.rb_style_noani.AutoSize = true;
            this.rb_style_noani.Location = new System.Drawing.Point(8, 19);
            this.rb_style_noani.Name = "rb_style_noani";
            this.rb_style_noani.Size = new System.Drawing.Size(85, 17);
            this.rb_style_noani.TabIndex = 2;
            this.rb_style_noani.TabStop = true;
            this.rb_style_noani.Text = "no animation";
            this.rb_style_noani.UseVisualStyleBackColor = true;
            this.rb_style_noani.CheckedChanged += new System.EventHandler(this.rb_style_noani_CheckedChanged);
            // 
            // gb_text
            // 
            this.gb_text.Controls.Add(this.button_textfont);
            this.gb_text.Controls.Add(this.button_textcolor);
            this.gb_text.Controls.Add(this.slider_fontsize);
            this.gb_text.Controls.Add(this.label_fontsize);
            this.gb_text.Location = new System.Drawing.Point(168, 12);
            this.gb_text.Name = "gb_text";
            this.gb_text.Size = new System.Drawing.Size(183, 110);
            this.gb_text.TabIndex = 32;
            this.gb_text.TabStop = false;
            this.gb_text.Text = "Text";
            // 
            // button_textfont
            // 
            this.button_textfont.Location = new System.Drawing.Point(92, 19);
            this.button_textfont.Name = "button_textfont";
            this.button_textfont.Size = new System.Drawing.Size(80, 23);
            this.button_textfont.TabIndex = 25;
            this.button_textfont.Text = "Text font";
            this.button_textfont.UseVisualStyleBackColor = true;
            this.button_textfont.Click += new System.EventHandler(this.button_textfont_Click);
            // 
            // gb_background
            // 
            this.gb_background.Controls.Add(this.button_backcolor);
            this.gb_background.Controls.Add(this.slider_opacity);
            this.gb_background.Controls.Add(this.label_opacity);
            this.gb_background.Location = new System.Drawing.Point(168, 128);
            this.gb_background.Name = "gb_background";
            this.gb_background.Size = new System.Drawing.Size(183, 109);
            this.gb_background.TabIndex = 33;
            this.gb_background.TabStop = false;
            this.gb_background.Text = "Background";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Press Ctrl + Shift + Alt to reveal setting buttons";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(10, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(241, 13);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Issues? Want to have a look at the source code?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 345);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_background);
            this.Controls.Add(this.gb_text);
            this.Controls.Add(this.gb_style);
            this.Controls.Add(this.gb_textdir);
            this.Controls.Add(this.groupBox_text_alignment);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.slider_opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_fontsize)).EndInit();
            this.groupBox_text_alignment.ResumeLayout(false);
            this.groupBox_text_alignment.PerformLayout();
            this.gb_textdir.ResumeLayout(false);
            this.gb_textdir.PerformLayout();
            this.gb_style.ResumeLayout(false);
            this.gb_style.PerformLayout();
            this.gb_text.ResumeLayout(false);
            this.gb_text.PerformLayout();
            this.gb_background.ResumeLayout(false);
            this.gb_background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_backcolor;
        private System.Windows.Forms.Button button_textcolor;
        private System.Windows.Forms.TrackBar slider_opacity;
        private System.Windows.Forms.Label label_opacity;
        private System.Windows.Forms.Label label_fontsize;
        private System.Windows.Forms.TrackBar slider_fontsize;
        private System.Windows.Forms.RadioButton rb_align_left;
        private System.Windows.Forms.RadioButton rb_align_center;
        private System.Windows.Forms.RadioButton rb_align_right;
        private System.Windows.Forms.GroupBox groupBox_text_alignment;
        private System.Windows.Forms.GroupBox gb_textdir;
        private System.Windows.Forms.RadioButton rb_td_up;
        private System.Windows.Forms.RadioButton rb_td_down;
        private System.Windows.Forms.GroupBox gb_style;
        private System.Windows.Forms.RadioButton rb_style_slide;
        private System.Windows.Forms.RadioButton rb_style_noani;
        private System.Windows.Forms.GroupBox gb_text;
        private System.Windows.Forms.Button button_textfont;
        private System.Windows.Forms.GroupBox gb_background;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ColorDialog picker_textcolor;
        private System.Windows.Forms.ColorDialog picker_backcolor;
        private System.Windows.Forms.FontDialog fontDialog_text;
    }
}