namespace Problem01
{
    partial class WorldGDPIncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldGDPIncomeForm));
            this.countryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.countryDataGridView = new System.Windows.Forms.DataGridView();
            this.sortByIncomeAscendingButton = new System.Windows.Forms.Button();
            this.sortByIncomeDescendingButton = new System.Windows.Forms.Button();
            this.sortByNameAscendingButton = new System.Windows.Forms.Button();
            this.totalIncomeButton = new System.Windows.Forms.Button();
            this.averageIncomeButton = new System.Windows.Forms.Button();
            this.highestIncomeButton = new System.Windows.Forms.Button();
            this.lowestIncomeButton = new System.Windows.Forms.Button();
            this.sortByNameDescendingButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldIncomeDataSet = new Problem01.WorldIncomeDataSet();
            this.countryTableAdapter = new Problem01.WorldIncomeDataSetTableAdapters.CountryTableAdapter();
            this.tableAdapterManager = new Problem01.WorldIncomeDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingNavigator)).BeginInit();
            this.countryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldIncomeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // countryBindingNavigator
            // 
            this.countryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countryBindingNavigator.BindingSource = this.countryBindingSource;
            this.countryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.countryBindingNavigatorSaveItem});
            this.countryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countryBindingNavigator.Name = "countryBindingNavigator";
            this.countryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countryBindingNavigator.Size = new System.Drawing.Size(467, 25);
            this.countryBindingNavigator.TabIndex = 0;
            this.countryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // countryBindingNavigatorSaveItem
            // 
            this.countryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorSaveItem.Image")));
            this.countryBindingNavigatorSaveItem.Name = "countryBindingNavigatorSaveItem";
            this.countryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorSaveItem.Text = "Save Data";
            this.countryBindingNavigatorSaveItem.Click += new System.EventHandler(this.countryBindingNavigatorSaveItem_Click);
            // 
            // countryDataGridView
            // 
            this.countryDataGridView.AutoGenerateColumns = false;
            this.countryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.countryDataGridView.DataSource = this.countryBindingSource;
            this.countryDataGridView.Location = new System.Drawing.Point(12, 28);
            this.countryDataGridView.Name = "countryDataGridView";
            this.countryDataGridView.Size = new System.Drawing.Size(265, 290);
            this.countryDataGridView.TabIndex = 1;
            // 
            // sortByIncomeAscendingButton
            // 
            this.sortByIncomeAscendingButton.Location = new System.Drawing.Point(283, 28);
            this.sortByIncomeAscendingButton.Name = "sortByIncomeAscendingButton";
            this.sortByIncomeAscendingButton.Size = new System.Drawing.Size(174, 29);
            this.sortByIncomeAscendingButton.TabIndex = 2;
            this.sortByIncomeAscendingButton.Text = "Sort by Income (ASC)";
            this.sortByIncomeAscendingButton.UseVisualStyleBackColor = true;
            this.sortByIncomeAscendingButton.Click += new System.EventHandler(this.sortByIncomeAscendingButton_Click);
            // 
            // sortByIncomeDescendingButton
            // 
            this.sortByIncomeDescendingButton.Location = new System.Drawing.Point(283, 63);
            this.sortByIncomeDescendingButton.Name = "sortByIncomeDescendingButton";
            this.sortByIncomeDescendingButton.Size = new System.Drawing.Size(174, 30);
            this.sortByIncomeDescendingButton.TabIndex = 3;
            this.sortByIncomeDescendingButton.Text = "Sort by Income (DESC)";
            this.sortByIncomeDescendingButton.UseVisualStyleBackColor = true;
            this.sortByIncomeDescendingButton.Click += new System.EventHandler(this.sortByIncomeDescendingButton_Click);
            // 
            // sortByNameAscendingButton
            // 
            this.sortByNameAscendingButton.Location = new System.Drawing.Point(283, 99);
            this.sortByNameAscendingButton.Name = "sortByNameAscendingButton";
            this.sortByNameAscendingButton.Size = new System.Drawing.Size(174, 31);
            this.sortByNameAscendingButton.TabIndex = 4;
            this.sortByNameAscendingButton.Text = "Sort by Name (ASC)";
            this.sortByNameAscendingButton.UseVisualStyleBackColor = true;
            this.sortByNameAscendingButton.Click += new System.EventHandler(this.sortByNameAscendingButton_Click);
            // 
            // totalIncomeButton
            // 
            this.totalIncomeButton.Location = new System.Drawing.Point(283, 174);
            this.totalIncomeButton.Name = "totalIncomeButton";
            this.totalIncomeButton.Size = new System.Drawing.Size(174, 31);
            this.totalIncomeButton.TabIndex = 5;
            this.totalIncomeButton.Text = "Total Income (All Countries)";
            this.totalIncomeButton.UseVisualStyleBackColor = true;
            this.totalIncomeButton.Click += new System.EventHandler(this.totalIncomeButton_Click);
            // 
            // averageIncomeButton
            // 
            this.averageIncomeButton.Location = new System.Drawing.Point(283, 211);
            this.averageIncomeButton.Name = "averageIncomeButton";
            this.averageIncomeButton.Size = new System.Drawing.Size(174, 31);
            this.averageIncomeButton.TabIndex = 6;
            this.averageIncomeButton.Text = "Average Income (All Countries)";
            this.averageIncomeButton.UseVisualStyleBackColor = true;
            this.averageIncomeButton.Click += new System.EventHandler(this.averageIncomeButton_Click);
            // 
            // highestIncomeButton
            // 
            this.highestIncomeButton.Location = new System.Drawing.Point(283, 248);
            this.highestIncomeButton.Name = "highestIncomeButton";
            this.highestIncomeButton.Size = new System.Drawing.Size(174, 34);
            this.highestIncomeButton.TabIndex = 7;
            this.highestIncomeButton.Text = "Highest Income of Any Country";
            this.highestIncomeButton.UseVisualStyleBackColor = true;
            this.highestIncomeButton.Click += new System.EventHandler(this.highestIncomeButton_Click);
            // 
            // lowestIncomeButton
            // 
            this.lowestIncomeButton.Location = new System.Drawing.Point(283, 288);
            this.lowestIncomeButton.Name = "lowestIncomeButton";
            this.lowestIncomeButton.Size = new System.Drawing.Size(174, 30);
            this.lowestIncomeButton.TabIndex = 8;
            this.lowestIncomeButton.Text = "Lowest Income of Any Country";
            this.lowestIncomeButton.UseVisualStyleBackColor = true;
            this.lowestIncomeButton.Click += new System.EventHandler(this.lowestIncomeButton_Click);
            // 
            // sortByNameDescendingButton
            // 
            this.sortByNameDescendingButton.Location = new System.Drawing.Point(283, 136);
            this.sortByNameDescendingButton.Name = "sortByNameDescendingButton";
            this.sortByNameDescendingButton.Size = new System.Drawing.Size(174, 32);
            this.sortByNameDescendingButton.TabIndex = 9;
            this.sortByNameDescendingButton.Text = "Sort by Name (DESC)";
            this.sortByNameDescendingButton.UseVisualStyleBackColor = true;
            this.sortByNameDescendingButton.Click += new System.EventHandler(this.sortByNameDescendingButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CountryName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CountryName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CountryIncome";
            this.dataGridViewTextBoxColumn2.HeaderText = "CountryIncome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.worldIncomeDataSet;
            // 
            // worldIncomeDataSet
            // 
            this.worldIncomeDataSet.DataSetName = "WorldIncomeDataSet";
            this.worldIncomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryTableAdapter = this.countryTableAdapter;
            this.tableAdapterManager.UpdateOrder = Problem01.WorldIncomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // WorldGDPIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 327);
            this.Controls.Add(this.sortByNameDescendingButton);
            this.Controls.Add(this.lowestIncomeButton);
            this.Controls.Add(this.highestIncomeButton);
            this.Controls.Add(this.averageIncomeButton);
            this.Controls.Add(this.totalIncomeButton);
            this.Controls.Add(this.sortByNameAscendingButton);
            this.Controls.Add(this.sortByIncomeDescendingButton);
            this.Controls.Add(this.sortByIncomeAscendingButton);
            this.Controls.Add(this.countryDataGridView);
            this.Controls.Add(this.countryBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WorldGDPIncomeForm";
            this.Text = "World GDP Income";
            this.Load += new System.EventHandler(this.WorldGDPIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingNavigator)).EndInit();
            this.countryBindingNavigator.ResumeLayout(false);
            this.countryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldIncomeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WorldIncomeDataSet worldIncomeDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private WorldIncomeDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private WorldIncomeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator countryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView countryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button sortByIncomeAscendingButton;
        private System.Windows.Forms.Button sortByIncomeDescendingButton;
        private System.Windows.Forms.Button sortByNameAscendingButton;
        private System.Windows.Forms.Button totalIncomeButton;
        private System.Windows.Forms.Button averageIncomeButton;
        private System.Windows.Forms.Button highestIncomeButton;
        private System.Windows.Forms.Button lowestIncomeButton;
        private System.Windows.Forms.Button sortByNameDescendingButton;
    }
}

