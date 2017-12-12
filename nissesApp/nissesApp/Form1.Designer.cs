namespace nissesApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label regnrLabel;
            System.Windows.Forms.Label markeLabel;
            System.Windows.Forms.Label modellLabel;
            System.Windows.Forms.Label arsmodellLabel;
            this.nissesDBDataSet = new nissesApp.nissesDBDataSet();
            this.bilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilTableAdapter = new nissesApp.nissesDBDataSetTableAdapters.bilTableAdapter();
            this.tableAdapterManager = new nissesApp.nissesDBDataSetTableAdapters.TableAdapterManager();
            this.bilBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bilBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.regnrTextBox = new System.Windows.Forms.TextBox();
            this.markeTextBox = new System.Windows.Forms.TextBox();
            this.modellTextBox = new System.Windows.Forms.TextBox();
            this.arsmodellTextBox = new System.Windows.Forms.TextBox();
            regnrLabel = new System.Windows.Forms.Label();
            markeLabel = new System.Windows.Forms.Label();
            modellLabel = new System.Windows.Forms.Label();
            arsmodellLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nissesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingNavigator)).BeginInit();
            this.bilBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nissesDBDataSet
            // 
            this.nissesDBDataSet.DataSetName = "nissesDBDataSet";
            this.nissesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilBindingSource
            // 
            this.bilBindingSource.DataMember = "bil";
            this.bilBindingSource.DataSource = this.nissesDBDataSet;
            // 
            // bilTableAdapter
            // 
            this.bilTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bilTableAdapter = this.bilTableAdapter;
            this.tableAdapterManager.UpdateOrder = nissesApp.nissesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bilBindingNavigator
            // 
            this.bilBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bilBindingNavigator.BindingSource = this.bilBindingSource;
            this.bilBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bilBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bilBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bilBindingNavigatorSaveItem});
            this.bilBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bilBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bilBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bilBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bilBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bilBindingNavigator.Name = "bilBindingNavigator";
            this.bilBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bilBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.bilBindingNavigator.TabIndex = 0;
            this.bilBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bilBindingNavigatorSaveItem
            // 
            this.bilBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bilBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bilBindingNavigatorSaveItem.Image")));
            this.bilBindingNavigatorSaveItem.Name = "bilBindingNavigatorSaveItem";
            this.bilBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bilBindingNavigatorSaveItem.Text = "Save Data";
            this.bilBindingNavigatorSaveItem.Click += new System.EventHandler(this.bilBindingNavigatorSaveItem_Click);
            // 
            // regnrLabel
            // 
            regnrLabel.AutoSize = true;
            regnrLabel.Location = new System.Drawing.Point(37, 35);
            regnrLabel.Name = "regnrLabel";
            regnrLabel.Size = new System.Drawing.Size(34, 13);
            regnrLabel.TabIndex = 1;
            regnrLabel.Text = "regnr:";
            // 
            // regnrTextBox
            // 
            this.regnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "regnr", true));
            this.regnrTextBox.Location = new System.Drawing.Point(77, 32);
            this.regnrTextBox.Name = "regnrTextBox";
            this.regnrTextBox.Size = new System.Drawing.Size(100, 20);
            this.regnrTextBox.TabIndex = 2;
            // 
            // markeLabel
            // 
            markeLabel.AutoSize = true;
            markeLabel.Location = new System.Drawing.Point(32, 59);
            markeLabel.Name = "markeLabel";
            markeLabel.Size = new System.Drawing.Size(39, 13);
            markeLabel.TabIndex = 3;
            markeLabel.Text = "marke:";
            // 
            // markeTextBox
            // 
            this.markeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "marke", true));
            this.markeTextBox.Location = new System.Drawing.Point(77, 59);
            this.markeTextBox.Name = "markeTextBox";
            this.markeTextBox.Size = new System.Drawing.Size(100, 20);
            this.markeTextBox.TabIndex = 4;
            // 
            // modellLabel
            // 
            modellLabel.AutoSize = true;
            modellLabel.Location = new System.Drawing.Point(31, 85);
            modellLabel.Name = "modellLabel";
            modellLabel.Size = new System.Drawing.Size(40, 13);
            modellLabel.TabIndex = 5;
            modellLabel.Text = "modell:";
            // 
            // modellTextBox
            // 
            this.modellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "modell", true));
            this.modellTextBox.Location = new System.Drawing.Point(77, 85);
            this.modellTextBox.Name = "modellTextBox";
            this.modellTextBox.Size = new System.Drawing.Size(100, 20);
            this.modellTextBox.TabIndex = 6;
            // 
            // arsmodellLabel
            // 
            arsmodellLabel.AutoSize = true;
            arsmodellLabel.Location = new System.Drawing.Point(17, 114);
            arsmodellLabel.Name = "arsmodellLabel";
            arsmodellLabel.Size = new System.Drawing.Size(54, 13);
            arsmodellLabel.TabIndex = 7;
            arsmodellLabel.Text = "arsmodell:";
            // 
            // arsmodellTextBox
            // 
            this.arsmodellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bilBindingSource, "arsmodell", true));
            this.arsmodellTextBox.Location = new System.Drawing.Point(77, 111);
            this.arsmodellTextBox.Name = "arsmodellTextBox";
            this.arsmodellTextBox.Size = new System.Drawing.Size(100, 20);
            this.arsmodellTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(arsmodellLabel);
            this.Controls.Add(this.arsmodellTextBox);
            this.Controls.Add(modellLabel);
            this.Controls.Add(this.modellTextBox);
            this.Controls.Add(markeLabel);
            this.Controls.Add(this.markeTextBox);
            this.Controls.Add(regnrLabel);
            this.Controls.Add(this.regnrTextBox);
            this.Controls.Add(this.bilBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nissesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilBindingNavigator)).EndInit();
            this.bilBindingNavigator.ResumeLayout(false);
            this.bilBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nissesDBDataSet nissesDBDataSet;
        private System.Windows.Forms.BindingSource bilBindingSource;
        private nissesDBDataSetTableAdapters.bilTableAdapter bilTableAdapter;
        private nissesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bilBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bilBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox regnrTextBox;
        private System.Windows.Forms.TextBox markeTextBox;
        private System.Windows.Forms.TextBox modellTextBox;
        private System.Windows.Forms.TextBox arsmodellTextBox;
    }
}

