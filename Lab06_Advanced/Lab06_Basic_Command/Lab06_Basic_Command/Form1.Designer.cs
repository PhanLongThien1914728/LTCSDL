
namespace Lab06_Basic_Command
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.lblNhomThucAn = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 149);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 33);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Lấy danh sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
            this.lvCategory.ContextMenuStrip = this.contextMenuStrip2;
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(0, 188);
            this.lvCategory.MultiSelect = false;
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(549, 307);
            this.lvCategory.TabIndex = 1;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
            // 
            // chID
            // 
            this.chID.Text = "Mã loại";
            this.chID.Width = 98;
            // 
            // chName
            // 
            this.chName.Text = "Tên loại món ăn";
            this.chName.Width = 298;
            // 
            // chType
            // 
            this.chType.Text = "Loại";
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhom.Location = new System.Drawing.Point(12, 13);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(66, 17);
            this.lblMaNhom.TabIndex = 2;
            this.lblMaNhom.Text = "Mã nhóm";
            // 
            // lblNhomThucAn
            // 
            this.lblNhomThucAn.AutoSize = true;
            this.lblNhomThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomThucAn.Location = new System.Drawing.Point(12, 60);
            this.lblNhomThucAn.Name = "lblNhomThucAn";
            this.lblNhomThucAn.Size = new System.Drawing.Size(123, 17);
            this.lblNhomThucAn.TabIndex = 2;
            this.lblNhomThucAn.Text = "Tên nhóm thức ăn";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(12, 108);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(35, 17);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "Loại";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(141, 13);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(268, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(141, 108);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(268, 20);
            this.txtType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(350, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(451, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(200, 70);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(199, 22);
            this.tsmDelete.Text = "Xoá nhóm sản phẩm";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmViewFood
            // 
            this.tsmViewFood.Name = "tsmViewFood";
            this.tsmViewFood.Size = new System.Drawing.Size(199, 22);
            this.tsmViewFood.Text = "Xem danh sách món ăn";
            this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblNhomThucAn);
            this.Controls.Add(this.lblMaNhom);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.Label lblNhomThucAn;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
    }
}

