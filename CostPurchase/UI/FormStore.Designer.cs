namespace CostPurchase
{
    partial class FormStore
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
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddGoods = new System.Windows.Forms.Button();
            this.textBoxGoodsName = new System.Windows.Forms.TextBox();
            this.labelGoodsPrice = new System.Windows.Forms.Label();
            this.textBoxGoodsPrice = new System.Windows.Forms.TextBox();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.GoodsList = new System.Windows.Forms.CheckedListBox();
            this.labelGoodsName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(614, 12);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(161, 66);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.TabStop = false;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(614, 356);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 66);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Закрыть";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddGoods
            // 
            this.buttonAddGoods.Location = new System.Drawing.Point(12, 356);
            this.buttonAddGoods.Name = "buttonAddGoods";
            this.buttonAddGoods.Size = new System.Drawing.Size(161, 66);
            this.buttonAddGoods.TabIndex = 3;
            this.buttonAddGoods.TabStop = false;
            this.buttonAddGoods.Text = "Добавить товар";
            this.buttonAddGoods.UseVisualStyleBackColor = true;
            this.buttonAddGoods.Click += new System.EventHandler(this.buttonAddGoods_Click);
            // 
            // textBoxGoodsName
            // 
            this.textBoxGoodsName.Location = new System.Drawing.Point(202, 400);
            this.textBoxGoodsName.Name = "textBoxGoodsName";
            this.textBoxGoodsName.Size = new System.Drawing.Size(224, 22);
            this.textBoxGoodsName.TabIndex = 5;
            this.textBoxGoodsName.TabStop = false;
            // 
            // labelGoodsPrice
            // 
            this.labelGoodsPrice.AutoSize = true;
            this.labelGoodsPrice.Location = new System.Drawing.Point(473, 356);
            this.labelGoodsPrice.Name = "labelGoodsPrice";
            this.labelGoodsPrice.Size = new System.Drawing.Size(90, 16);
            this.labelGoodsPrice.TabIndex = 6;
            this.labelGoodsPrice.Text = "Цена товара";
            // 
            // textBoxGoodsPrice
            // 
            this.textBoxGoodsPrice.Location = new System.Drawing.Point(458, 400);
            this.textBoxGoodsPrice.Name = "textBoxGoodsPrice";
            this.textBoxGoodsPrice.Size = new System.Drawing.Size(129, 22);
            this.textBoxGoodsPrice.TabIndex = 7;
            this.textBoxGoodsPrice.TabStop = false;
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.ItemHeight = 29;
            this.listBoxPrice.Location = new System.Drawing.Point(458, 12);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(134, 323);
            this.listBoxPrice.TabIndex = 8;
            this.listBoxPrice.TabStop = false;
            // 
            // GoodsList
            // 
            this.GoodsList.CheckOnClick = true;
            this.GoodsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GoodsList.FormattingEnabled = true;
            this.GoodsList.HorizontalScrollbar = true;
            this.GoodsList.Location = new System.Drawing.Point(12, 12);
            this.GoodsList.Name = "GoodsList";
            this.GoodsList.Size = new System.Drawing.Size(404, 323);
            this.GoodsList.TabIndex = 9;
            this.GoodsList.TabStop = false;
            // 
            // labelGoodsName
            // 
            this.labelGoodsName.AutoSize = true;
            this.labelGoodsName.Location = new System.Drawing.Point(232, 356);
            this.labelGoodsName.Name = "labelGoodsName";
            this.labelGoodsName.Size = new System.Drawing.Size(156, 16);
            this.labelGoodsName.TabIndex = 10;
            this.labelGoodsName.Text = "Наименование товара";
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGoodsName);
            this.Controls.Add(this.GoodsList);
            this.Controls.Add(this.listBoxPrice);
            this.Controls.Add(this.textBoxGoodsPrice);
            this.Controls.Add(this.labelGoodsPrice);
            this.Controls.Add(this.textBoxGoodsName);
            this.Controls.Add(this.buttonAddGoods);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBuy);
            this.Name = "FormStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddGoods;
        private System.Windows.Forms.TextBox textBoxGoodsName;
        private System.Windows.Forms.Label labelGoodsPrice;
        private System.Windows.Forms.TextBox textBoxGoodsPrice;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.CheckedListBox GoodsList;
        private System.Windows.Forms.Label labelGoodsName;
    }
}