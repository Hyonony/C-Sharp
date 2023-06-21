namespace Winform_10
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.SuppliersLabel = new System.Windows.Forms.Label();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.SuppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(12, 9);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(31, 13);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // SuppliersLabel
            // 
            this.SuppliersLabel.AutoSize = true;
            this.SuppliersLabel.Location = new System.Drawing.Point(12, 240);
            this.SuppliersLabel.Name = "SuppliersLabel";
            this.SuppliersLabel.Size = new System.Drawing.Size(50, 13);
            this.SuppliersLabel.TabIndex = 1;
            this.SuppliersLabel.Text = "Suppliers";
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Location = new System.Drawing.Point(486, 9);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(37, 13);
            this.OrdersLabel.TabIndex = 2;
            this.OrdersLabel.Text = "Orders";
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Location = new System.Drawing.Point(12, 25);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.Size = new System.Drawing.Size(468, 189);
            this.ItemsDataGridView.TabIndex = 3;
            // 
            // SuppliersDataGridView
            // 
            this.SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersDataGridView.Location = new System.Drawing.Point(12, 256);
            this.SuppliersDataGridView.Name = "SuppliersDataGridView";
            this.SuppliersDataGridView.Size = new System.Drawing.Size(468, 189);
            this.SuppliersDataGridView.TabIndex = 4;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(489, 25);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(468, 420);
            this.OrdersDataGridView.TabIndex = 5;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(368, 220);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(112, 23);
            this.AddItemButton.TabIndex = 6;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.Location = new System.Drawing.Point(365, 451);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(115, 23);
            this.AddSupplierButton.TabIndex = 7;
            this.AddSupplierButton.Text = "Add Supplier";
            this.AddSupplierButton.UseVisualStyleBackColor = true;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(868, 451);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(89, 23);
            this.AddOrderButton.TabIndex = 8;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(969, 486);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.AddSupplierButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.SuppliersDataGridView);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.OrdersLabel);
            this.Controls.Add(this.SuppliersLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "MainForm";
            this.Text = "Simple ERP";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label SuppliersLabel;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.DataGridView SuppliersDataGridView;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.Button AddOrderButton;

    }
}

