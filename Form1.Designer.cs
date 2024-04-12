namespace DrawingsUIRebarColumnsFootings
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCatalogColumn = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.ColumnsMaterialsTextBox = new System.Windows.Forms.TextBox();
            this.profileCatalogColumn = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.ColumnsProfileTextBox = new System.Windows.Forms.TextBox();
            this.textBox_PadFooting_size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCatalogPadFooting = new Tekla.Structures.Dialog.UIControls.MaterialCatalog();
            this.PadFootingMaterialtextBox = new System.Windows.Forms.TextBox();
            this.CreateColumnsAndPadFootings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OpenDrawingButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EditOpenDrawingButton = new System.Windows.Forms.Button();
            this.DrawingTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateDrawingButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCatalogColumn
            // 
            this.structuresExtender.SetAttributeName(this.materialCatalogColumn, null);
            this.structuresExtender.SetAttributeTypeName(this.materialCatalogColumn, null);
            this.materialCatalogColumn.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.materialCatalogColumn, null);
            this.materialCatalogColumn.ButtonText = "Select column material";
            this.materialCatalogColumn.Location = new System.Drawing.Point(54, 63);
            this.materialCatalogColumn.Name = "materialCatalogColumn";
            this.materialCatalogColumn.SelectedMaterial = "";
            this.materialCatalogColumn.Size = new System.Drawing.Size(152, 27);
            this.materialCatalogColumn.TabIndex = 0;
            this.materialCatalogColumn.SelectClicked += new System.EventHandler(this.materialCatalogColumn_SelectClicked);
            this.materialCatalogColumn.SelectionDone += new System.EventHandler(this.materialCatalogColumn_SelectionDone);
            // 
            // ColumnsMaterialsTextBox
            // 
            this.structuresExtender.SetAttributeName(this.ColumnsMaterialsTextBox, "Column.Material");
            this.structuresExtender.SetAttributeTypeName(this.ColumnsMaterialsTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.ColumnsMaterialsTextBox, null);
            this.ColumnsMaterialsTextBox.Location = new System.Drawing.Point(230, 63);
            this.ColumnsMaterialsTextBox.Name = "ColumnsMaterialsTextBox";
            this.ColumnsMaterialsTextBox.Size = new System.Drawing.Size(133, 20);
            this.ColumnsMaterialsTextBox.TabIndex = 1;
            // 
            // profileCatalogColumn
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalogColumn, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalogColumn, null);
            this.profileCatalogColumn.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalogColumn, null);
            this.profileCatalogColumn.ButtonText = "Select column profile";
            this.profileCatalogColumn.Location = new System.Drawing.Point(54, 115);
            this.profileCatalogColumn.Name = "profileCatalogColumn";
            this.profileCatalogColumn.SelectedProfile = "";
            this.profileCatalogColumn.Size = new System.Drawing.Size(152, 27);
            this.profileCatalogColumn.TabIndex = 2;
            this.profileCatalogColumn.SelectClicked += new System.EventHandler(this.profileCatalogColumn_SelectClicked);
            this.profileCatalogColumn.SelectionDone += new System.EventHandler(this.profileCatalogColumn_SelectionDone);
            // 
            // ColumnsProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.ColumnsProfileTextBox, "Column.Profile");
            this.structuresExtender.SetAttributeTypeName(this.ColumnsProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.ColumnsProfileTextBox, null);
            this.ColumnsProfileTextBox.Location = new System.Drawing.Point(230, 121);
            this.ColumnsProfileTextBox.Name = "ColumnsProfileTextBox";
            this.ColumnsProfileTextBox.Size = new System.Drawing.Size(135, 20);
            this.ColumnsProfileTextBox.TabIndex = 3;
            // 
            // textBox_PadFooting_size
            // 
            this.structuresExtender.SetAttributeName(this.textBox_PadFooting_size, null);
            this.structuresExtender.SetAttributeTypeName(this.textBox_PadFooting_size, null);
            this.structuresExtender.SetBindPropertyName(this.textBox_PadFooting_size, null);
            this.textBox_PadFooting_size.Location = new System.Drawing.Point(230, 179);
            this.textBox_PadFooting_size.Name = "textBox_PadFooting_size";
            this.textBox_PadFooting_size.Size = new System.Drawing.Size(135, 20);
            this.textBox_PadFooting_size.TabIndex = 4;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(82, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pad footing size";
            // 
            // materialCatalogPadFooting
            // 
            this.structuresExtender.SetAttributeName(this.materialCatalogPadFooting, null);
            this.structuresExtender.SetAttributeTypeName(this.materialCatalogPadFooting, null);
            this.materialCatalogPadFooting.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.materialCatalogPadFooting, null);
            this.materialCatalogPadFooting.ButtonText = "Select pad footing material";
            this.materialCatalogPadFooting.Location = new System.Drawing.Point(54, 230);
            this.materialCatalogPadFooting.Name = "materialCatalogPadFooting";
            this.materialCatalogPadFooting.SelectedMaterial = "";
            this.materialCatalogPadFooting.Size = new System.Drawing.Size(152, 27);
            this.materialCatalogPadFooting.TabIndex = 6;
            this.materialCatalogPadFooting.SelectClicked += new System.EventHandler(this.materialCatalogPadFooting_SelectClicked);
            this.materialCatalogPadFooting.SelectionDone += new System.EventHandler(this.materialCatalogPadFooting_SelectionDone);
            // 
            // PadFootingMaterialtextBox
            // 
            this.structuresExtender.SetAttributeName(this.PadFootingMaterialtextBox, "Pad_Footing.Material");
            this.structuresExtender.SetAttributeTypeName(this.PadFootingMaterialtextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.PadFootingMaterialtextBox, null);
            this.PadFootingMaterialtextBox.Location = new System.Drawing.Point(230, 230);
            this.PadFootingMaterialtextBox.Name = "PadFootingMaterialtextBox";
            this.PadFootingMaterialtextBox.Size = new System.Drawing.Size(135, 20);
            this.PadFootingMaterialtextBox.TabIndex = 7;
            // 
            // CreateColumnsAndPadFootings
            // 
            this.structuresExtender.SetAttributeName(this.CreateColumnsAndPadFootings, null);
            this.structuresExtender.SetAttributeTypeName(this.CreateColumnsAndPadFootings, null);
            this.structuresExtender.SetBindPropertyName(this.CreateColumnsAndPadFootings, null);
            this.CreateColumnsAndPadFootings.Location = new System.Drawing.Point(100, 280);
            this.CreateColumnsAndPadFootings.Name = "CreateColumnsAndPadFootings";
            this.CreateColumnsAndPadFootings.Size = new System.Drawing.Size(207, 23);
            this.CreateColumnsAndPadFootings.TabIndex = 8;
            this.CreateColumnsAndPadFootings.Text = "Create columns and pad footings";
            this.CreateColumnsAndPadFootings.UseVisualStyleBackColor = true;
            this.CreateColumnsAndPadFootings.Click += new System.EventHandler(this.CreateColumnsAndPadFootings_Click);
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.OpenDrawingButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EditOpenDrawingButton);
            this.groupBox1.Controls.Add(this.DrawingTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 195);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawings";
            // 
            // listView1
            // 
            this.structuresExtender.SetAttributeName(this.listView1, null);
            this.structuresExtender.SetAttributeTypeName(this.listView1, null);
            this.structuresExtender.SetBindPropertyName(this.listView1, null);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(76, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 80);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // OpenDrawingButton
            // 
            this.structuresExtender.SetAttributeName(this.OpenDrawingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.OpenDrawingButton, null);
            this.structuresExtender.SetBindPropertyName(this.OpenDrawingButton, null);
            this.OpenDrawingButton.Location = new System.Drawing.Point(321, 133);
            this.OpenDrawingButton.Name = "OpenDrawingButton";
            this.OpenDrawingButton.Size = new System.Drawing.Size(115, 23);
            this.OpenDrawingButton.TabIndex = 11;
            this.OpenDrawingButton.Text = "Open drawing";
            this.OpenDrawingButton.UseVisualStyleBackColor = true;
            this.OpenDrawingButton.Click += new System.EventHandler(this.OpenDrawingButton_Click);
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Drawing list:";
            // 
            // EditOpenDrawingButton
            // 
            this.structuresExtender.SetAttributeName(this.EditOpenDrawingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.EditOpenDrawingButton, null);
            this.structuresExtender.SetBindPropertyName(this.EditOpenDrawingButton, null);
            this.EditOpenDrawingButton.Location = new System.Drawing.Point(9, 71);
            this.EditOpenDrawingButton.Name = "EditOpenDrawingButton";
            this.EditOpenDrawingButton.Size = new System.Drawing.Size(162, 23);
            this.EditOpenDrawingButton.TabIndex = 8;
            this.EditOpenDrawingButton.Text = "Edit drawing";
            this.EditOpenDrawingButton.UseVisualStyleBackColor = true;
            this.EditOpenDrawingButton.Click += new System.EventHandler(this.EditOpenDrawingButton_Click);
            // 
            // DrawingTextBox
            // 
            this.structuresExtender.SetAttributeName(this.DrawingTextBox, "DrawingTextBox");
            this.structuresExtender.SetAttributeTypeName(this.DrawingTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.DrawingTextBox, null);
            this.DrawingTextBox.Location = new System.Drawing.Point(61, 37);
            this.DrawingTextBox.Name = "DrawingTextBox";
            this.DrawingTextBox.Size = new System.Drawing.Size(244, 20);
            this.DrawingTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "View file:";
            // 
            // CreateDrawingButton
            // 
            this.structuresExtender.SetAttributeName(this.CreateDrawingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.CreateDrawingButton, null);
            this.structuresExtender.SetBindPropertyName(this.CreateDrawingButton, null);
            this.CreateDrawingButton.Location = new System.Drawing.Point(111, 327);
            this.CreateDrawingButton.Name = "CreateDrawingButton";
            this.CreateDrawingButton.Size = new System.Drawing.Size(196, 23);
            this.CreateDrawingButton.TabIndex = 10;
            this.CreateDrawingButton.Text = "Create drawing...";
            this.CreateDrawingButton.UseVisualStyleBackColor = true;
            this.CreateDrawingButton.Click += new System.EventHandler(this.CreateDrawingButton_Click);
            // 
            // Form1
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(517, 574);
            this.Controls.Add(this.CreateDrawingButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateColumnsAndPadFootings);
            this.Controls.Add(this.PadFootingMaterialtextBox);
            this.Controls.Add(this.materialCatalogPadFooting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PadFooting_size);
            this.Controls.Add(this.ColumnsProfileTextBox);
            this.Controls.Add(this.profileCatalogColumn);
            this.Controls.Add(this.ColumnsMaterialsTextBox);
            this.Controls.Add(this.materialCatalogColumn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalogColumn;
        private System.Windows.Forms.TextBox ColumnsMaterialsTextBox;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalogColumn;
        private System.Windows.Forms.TextBox ColumnsProfileTextBox;
        private System.Windows.Forms.TextBox textBox_PadFooting_size;
        private System.Windows.Forms.Label label1;
        private Tekla.Structures.Dialog.UIControls.MaterialCatalog materialCatalogPadFooting;
        private System.Windows.Forms.TextBox PadFootingMaterialtextBox;
        private System.Windows.Forms.Button CreateColumnsAndPadFootings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DrawingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditOpenDrawingButton;
        private System.Windows.Forms.Button CreateDrawingButton;
        private System.Windows.Forms.Button OpenDrawingButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
    }
}

