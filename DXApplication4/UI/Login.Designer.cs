namespace SistemaLibreria.UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CancelarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AceptarSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ClaveTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsuarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClaveTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.CancelarSimpleButton);
            this.layoutControl1.Controls.Add(this.AceptarSimpleButton);
            this.layoutControl1.Controls.Add(this.ClaveTextEdit);
            this.layoutControl1.Controls.Add(this.UsuarioTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(511, 189);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CancelarSimpleButton
            // 
            this.CancelarSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarSimpleButton.Location = new System.Drawing.Point(257, 64);
            this.CancelarSimpleButton.Name = "CancelarSimpleButton";
            this.CancelarSimpleButton.Size = new System.Drawing.Size(242, 27);
            this.CancelarSimpleButton.StyleController = this.layoutControl1;
            this.CancelarSimpleButton.TabIndex = 7;
            this.CancelarSimpleButton.Text = "Cancelar";
            this.CancelarSimpleButton.Click += new System.EventHandler(this.CancelarSimpleButton_Click);
            // 
            // AceptarSimpleButton
            // 
            this.AceptarSimpleButton.Location = new System.Drawing.Point(12, 64);
            this.AceptarSimpleButton.Name = "AceptarSimpleButton";
            this.AceptarSimpleButton.Size = new System.Drawing.Size(241, 27);
            this.AceptarSimpleButton.StyleController = this.layoutControl1;
            this.AceptarSimpleButton.TabIndex = 6;
            this.AceptarSimpleButton.Text = "Aceptar";
            this.AceptarSimpleButton.Click += new System.EventHandler(this.AceptarSimpleButton_Click);
            // 
            // ClaveTextEdit
            // 
            this.ClaveTextEdit.Location = new System.Drawing.Point(58, 38);
            this.ClaveTextEdit.Name = "ClaveTextEdit";
            this.ClaveTextEdit.Properties.PasswordChar = '*';
            this.ClaveTextEdit.Size = new System.Drawing.Size(441, 22);
            this.ClaveTextEdit.StyleController = this.layoutControl1;
            this.ClaveTextEdit.TabIndex = 5;
            // 
            // UsuarioTextEdit
            // 
            this.UsuarioTextEdit.Location = new System.Drawing.Point(58, 12);
            this.UsuarioTextEdit.Name = "UsuarioTextEdit";
            this.UsuarioTextEdit.Size = new System.Drawing.Size(441, 22);
            this.UsuarioTextEdit.StyleController = this.layoutControl1;
            this.UsuarioTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(511, 189);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.UsuarioTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(491, 26);
            this.layoutControlItem1.Text = "Usuario";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(43, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(245, 83);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(246, 86);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ClaveTextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(491, 26);
            this.layoutControlItem2.Text = "Clave";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.AceptarSimpleButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(245, 117);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CancelarSimpleButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(245, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(246, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 189);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClaveTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton CancelarSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AceptarSimpleButton;
        private DevExpress.XtraEditors.TextEdit ClaveTextEdit;
        private DevExpress.XtraEditors.TextEdit UsuarioTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

