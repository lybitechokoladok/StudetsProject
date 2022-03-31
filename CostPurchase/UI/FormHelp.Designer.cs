namespace CostPurchase
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.labelProgramInfo = new System.Windows.Forms.Label();
            this.buttonInfoAdd = new System.Windows.Forms.Button();
            this.labelButtonInfoAdd = new System.Windows.Forms.Label();
            this.buttonInfoBuy = new System.Windows.Forms.Button();
            this.labelButtonInfoBuy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProgramInfo
            // 
            this.labelProgramInfo.AutoSize = true;
            this.labelProgramInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelProgramInfo.Location = new System.Drawing.Point(12, 9);
            this.labelProgramInfo.Name = "labelProgramInfo";
            this.labelProgramInfo.Size = new System.Drawing.Size(725, 174);
            this.labelProgramInfo.TabIndex = 0;
            this.labelProgramInfo.Text = resources.GetString("labelProgramInfo.Text");
            // 
            // buttonInfoAdd
            // 
            this.buttonInfoAdd.Location = new System.Drawing.Point(17, 190);
            this.buttonInfoAdd.Name = "buttonInfoAdd";
            this.buttonInfoAdd.Size = new System.Drawing.Size(161, 66);
            this.buttonInfoAdd.TabIndex = 1;
            this.buttonInfoAdd.TabStop = false;
            this.buttonInfoAdd.Text = "Добавить товар";
            this.buttonInfoAdd.UseVisualStyleBackColor = true;
            // 
            // labelButtonInfoAdd
            // 
            this.labelButtonInfoAdd.AutoSize = true;
            this.labelButtonInfoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelButtonInfoAdd.Location = new System.Drawing.Point(222, 211);
            this.labelButtonInfoAdd.Name = "labelButtonInfoAdd";
            this.labelButtonInfoAdd.Size = new System.Drawing.Size(329, 29);
            this.labelButtonInfoAdd.TabIndex = 2;
            this.labelButtonInfoAdd.Text = "- Добавляет товар в список";
            // 
            // buttonInfoBuy
            // 
            this.buttonInfoBuy.Location = new System.Drawing.Point(17, 285);
            this.buttonInfoBuy.Name = "buttonInfoBuy";
            this.buttonInfoBuy.Size = new System.Drawing.Size(161, 66);
            this.buttonInfoBuy.TabIndex = 3;
            this.buttonInfoBuy.TabStop = false;
            this.buttonInfoBuy.Text = "Купить";
            this.buttonInfoBuy.UseVisualStyleBackColor = true;
            // 
            // labelButtonInfoBuy
            // 
            this.labelButtonInfoBuy.AutoSize = true;
            this.labelButtonInfoBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelButtonInfoBuy.Location = new System.Drawing.Point(222, 293);
            this.labelButtonInfoBuy.Name = "labelButtonInfoBuy";
            this.labelButtonInfoBuy.Size = new System.Drawing.Size(419, 58);
            this.labelButtonInfoBuy.TabIndex = 4;
            this.labelButtonInfoBuy.Text = "- Выводит на экран стоимость всех\r\n выбранных товаров";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelButtonInfoBuy);
            this.Controls.Add(this.buttonInfoBuy);
            this.Controls.Add(this.labelButtonInfoAdd);
            this.Controls.Add(this.buttonInfoAdd);
            this.Controls.Add(this.labelProgramInfo);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProgramInfo;
        private System.Windows.Forms.Button buttonInfoAdd;
        private System.Windows.Forms.Label labelButtonInfoAdd;
        private System.Windows.Forms.Button buttonInfoBuy;
        private System.Windows.Forms.Label labelButtonInfoBuy;
    }
}