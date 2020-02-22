using System.Drawing;

namespace SuperHero_Duel_GUI
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
            this.attack_button = new System.Windows.Forms.Button();
            this.action_label = new System.Windows.Forms.Label();
            this.hero_health_label = new System.Windows.Forms.Label();
            this.villian_health_label = new System.Windows.Forms.Label();
            this.greeting_label = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.my_timer = new System.Windows.Forms.Timer(this.components);
            this.villian_picture_box = new System.Windows.Forms.PictureBox();
            this.hero_picture_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.villian_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // attack_button
            // 
            this.attack_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attack_button.Location = new System.Drawing.Point(643, 497);
            this.attack_button.Name = "attack_button";
            this.attack_button.Size = new System.Drawing.Size(75, 23);
            this.attack_button.TabIndex = 3;
            this.attack_button.Text = "Attack";
            this.attack_button.UseVisualStyleBackColor = true;
            this.attack_button.Click += new System.EventHandler(this.Attack_button_ClickAsync);
            // 
            // action_label
            // 
            this.action_label.BackColor = System.Drawing.Color.Transparent;
            this.action_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_label.ForeColor = System.Drawing.SystemColors.Control;
            this.action_label.Location = new System.Drawing.Point(504, 35);
            this.action_label.Name = "action_label";
            this.action_label.Size = new System.Drawing.Size(347, 229);
            this.action_label.TabIndex = 6;
            this.action_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hero_health_label
            // 
            this.hero_health_label.AutoSize = true;
            this.hero_health_label.BackColor = System.Drawing.Color.Transparent;
            this.hero_health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hero_health_label.ForeColor = System.Drawing.SystemColors.Control;
            this.hero_health_label.Location = new System.Drawing.Point(12, 9);
            this.hero_health_label.Name = "hero_health_label";
            this.hero_health_label.Size = new System.Drawing.Size(74, 25);
            this.hero_health_label.TabIndex = 7;
            this.hero_health_label.Text = "Health";
            this.hero_health_label.Visible = false;
            // 
            // villian_health_label
            // 
            this.villian_health_label.AutoSize = true;
            this.villian_health_label.BackColor = System.Drawing.Color.Transparent;
            this.villian_health_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villian_health_label.ForeColor = System.Drawing.SystemColors.Control;
            this.villian_health_label.Location = new System.Drawing.Point(1119, 9);
            this.villian_health_label.Name = "villian_health_label";
            this.villian_health_label.Size = new System.Drawing.Size(74, 25);
            this.villian_health_label.TabIndex = 8;
            this.villian_health_label.Text = "Health";
            this.villian_health_label.Visible = false;
            // 
            // greeting_label
            // 
            this.greeting_label.AutoSize = true;
            this.greeting_label.BackColor = System.Drawing.Color.Transparent;
            this.greeting_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting_label.ForeColor = System.Drawing.SystemColors.Control;
            this.greeting_label.Location = new System.Drawing.Point(606, 9);
            this.greeting_label.Name = "greeting_label";
            this.greeting_label.Size = new System.Drawing.Size(145, 26);
            this.greeting_label.TabIndex = 9;
            this.greeting_label.Text = "Who will win?";
            this.greeting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reset_button
            // 
            this.reset_button.Enabled = false;
            this.reset_button.Location = new System.Drawing.Point(643, 468);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 10;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Visible = false;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // my_timer
            // 
            this.my_timer.Enabled = true;
            this.my_timer.Interval = 1000;
            // 
            // villian_picture_box
            // 
            this.villian_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.villian_picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.villian_picture_box.Image = global::SuperHero_Duel_GUI.Properties.Resources.than_stand;
            this.villian_picture_box.Location = new System.Drawing.Point(897, 308);
            this.villian_picture_box.Name = "villian_picture_box";
            this.villian_picture_box.Size = new System.Drawing.Size(376, 229);
            this.villian_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.villian_picture_box.TabIndex = 5;
            this.villian_picture_box.TabStop = false;
            // 
            // hero_picture_box
            // 
            this.hero_picture_box.BackColor = System.Drawing.Color.Transparent;
            this.hero_picture_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hero_picture_box.Image = global::SuperHero_Duel_GUI.Properties.Resources.captitan_carton_intro;
            this.hero_picture_box.Location = new System.Drawing.Point(88, 308);
            this.hero_picture_box.Name = "hero_picture_box";
            this.hero_picture_box.Size = new System.Drawing.Size(362, 229);
            this.hero_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hero_picture_box.TabIndex = 4;
            this.hero_picture_box.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperHero_Duel_GUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 539);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.greeting_label);
            this.Controls.Add(this.villian_health_label);
            this.Controls.Add(this.hero_health_label);
            this.Controls.Add(this.action_label);
            this.Controls.Add(this.villian_picture_box);
            this.Controls.Add(this.hero_picture_box);
            this.Controls.Add(this.attack_button);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1363, 578);
            this.MinimumSize = new System.Drawing.Size(1363, 578);
            this.Name = "Form1";
            this.Text = "Super Hero Duel";
            ((System.ComponentModel.ISupportInitialize)(this.villian_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button attack_button;
        private System.Windows.Forms.PictureBox hero_picture_box;
        private System.Windows.Forms.PictureBox villian_picture_box;
        private System.Windows.Forms.Label action_label;

        private System.Windows.Forms.Label hero_health_label;
        private System.Windows.Forms.Label villian_health_label;
        private System.Windows.Forms.Label greeting_label;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Timer my_timer;
    }
}

