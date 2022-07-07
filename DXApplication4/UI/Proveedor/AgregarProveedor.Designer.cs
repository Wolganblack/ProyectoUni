namespace DXApplication4.UI.Provedor
{
    partial class AgregarProveedor
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProveedor));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AgregarProveedorSimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.CedulaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProveedorXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.UnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.NombreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DireccionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RepresentateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCedula = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNombre = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDireccion = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRepresentate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.AgregarProveedorDxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ProovedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CedulaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRepresentate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarProveedorDxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProovedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.AgregarProveedorSimpleButton1);
            this.dataLayoutControl1.Controls.Add(this.CedulaTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NombreTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DireccionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RepresentateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.DataSource = this.ProveedorXpCollection;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(675, 423);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // AgregarProveedorSimpleButton1
            // 
            this.AgregarProveedorSimpleButton1.Location = new System.Drawing.Point(370, 116);
            this.AgregarProveedorSimpleButton1.Name = "AgregarProveedorSimpleButton1";
            this.AgregarProveedorSimpleButton1.Size = new System.Drawing.Size(293, 27);
            this.AgregarProveedorSimpleButton1.StyleController = this.dataLayoutControl1;
            this.AgregarProveedorSimpleButton1.TabIndex = 9;
            this.AgregarProveedorSimpleButton1.Text = "AgregarProvedor";
            this.AgregarProveedorSimpleButton1.Click += new System.EventHandler(this.AgregarProveedorSimpleButton1_Click);
            // 
            // CedulaTextEdit
            // 
            this.CedulaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ProveedorXpCollection, "Cedula", true));
            this.CedulaTextEdit.Location = new System.Drawing.Point(91, 12);
            this.CedulaTextEdit.Name = "CedulaTextEdit";
            this.CedulaTextEdit.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d\\d\\d\\d-\\d\\d\\d\\d[a-zA-Z]";
            this.CedulaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.CedulaTextEdit.Size = new System.Drawing.Size(572, 22);
            this.CedulaTextEdit.StyleController = this.dataLayoutControl1;
            this.CedulaTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.AgregarProveedorDxValidationProvider1.SetValidationRule(this.CedulaTextEdit, conditionValidationRule1);
            this.CedulaTextEdit.EditValueChanged += new System.EventHandler(this.CedulaTextEdit_EditValueChanged);
            this.CedulaTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CedulaTextEdit_KeyDown);
            // 
            // ProveedorXpCollection
            // 
            this.ProveedorXpCollection.DisplayableProperties = "Id;Cedula;Nombre;Direccion;Representate;Email";
            this.ProveedorXpCollection.LoadingEnabled = false;
            this.ProveedorXpCollection.ObjectType = typeof(ModeloDatos.ORM.Proveedor);
            this.ProveedorXpCollection.Session = this.UnitOfWork;
            // 
            // UnitOfWork
            // 
            this.UnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UnitOfWork.TrackPropertiesModifications = false;
            // 
            // NombreTextEdit
            // 
            this.NombreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ProveedorXpCollection, "Nombre", true));
            this.NombreTextEdit.Location = new System.Drawing.Point(91, 38);
            this.NombreTextEdit.Name = "NombreTextEdit";
            this.NombreTextEdit.Size = new System.Drawing.Size(572, 22);
            this.NombreTextEdit.StyleController = this.dataLayoutControl1;
            this.NombreTextEdit.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.AgregarProveedorDxValidationProvider1.SetValidationRule(this.NombreTextEdit, conditionValidationRule2);
            // 
            // DireccionTextEdit
            // 
            this.DireccionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ProveedorXpCollection, "Direccion", true));
            this.DireccionTextEdit.Location = new System.Drawing.Point(91, 64);
            this.DireccionTextEdit.Name = "DireccionTextEdit";
            this.DireccionTextEdit.Size = new System.Drawing.Size(572, 22);
            this.DireccionTextEdit.StyleController = this.dataLayoutControl1;
            this.DireccionTextEdit.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.AgregarProveedorDxValidationProvider1.SetValidationRule(this.DireccionTextEdit, conditionValidationRule3);
            this.DireccionTextEdit.EditValueChanged += new System.EventHandler(this.DireccionTextEdit_EditValueChanged);
            // 
            // RepresentateTextEdit
            // 
            this.RepresentateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ProveedorXpCollection, "Representate", true));
            this.RepresentateTextEdit.Location = new System.Drawing.Point(91, 90);
            this.RepresentateTextEdit.Name = "RepresentateTextEdit";
            this.RepresentateTextEdit.Size = new System.Drawing.Size(572, 22);
            this.RepresentateTextEdit.StyleController = this.dataLayoutControl1;
            this.RepresentateTextEdit.TabIndex = 7;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.AgregarProveedorDxValidationProvider1.SetValidationRule(this.RepresentateTextEdit, conditionValidationRule4);
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ProveedorXpCollection, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(91, 116);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Properties.Mask.EditMask = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.EmailTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.EmailTextEdit.Size = new System.Drawing.Size(234, 22);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 8;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.AgregarProveedorDxValidationProvider1.SetValidationRule(this.EmailTextEdit, conditionValidationRule5);
            this.EmailTextEdit.EditValueChanged += new System.EventHandler(this.EmailTextEdit_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(675, 423);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCedula,
            this.ItemForNombre,
            this.ItemForDireccion,
            this.ItemForRepresentate,
            this.ItemForEmail,
            this.simpleSeparator1,
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(655, 403);
            // 
            // ItemForCedula
            // 
            this.ItemForCedula.Control = this.CedulaTextEdit;
            this.ItemForCedula.Location = new System.Drawing.Point(0, 0);
            this.ItemForCedula.Name = "ItemForCedula";
            this.ItemForCedula.Size = new System.Drawing.Size(655, 26);
            this.ItemForCedula.Text = "Cedula";
            this.ItemForCedula.TextSize = new System.Drawing.Size(76, 16);
            // 
            // ItemForNombre
            // 
            this.ItemForNombre.Control = this.NombreTextEdit;
            this.ItemForNombre.Location = new System.Drawing.Point(0, 26);
            this.ItemForNombre.Name = "ItemForNombre";
            this.ItemForNombre.Size = new System.Drawing.Size(655, 26);
            this.ItemForNombre.Text = "Nombre";
            this.ItemForNombre.TextSize = new System.Drawing.Size(76, 16);
            // 
            // ItemForDireccion
            // 
            this.ItemForDireccion.Control = this.DireccionTextEdit;
            this.ItemForDireccion.Location = new System.Drawing.Point(0, 52);
            this.ItemForDireccion.Name = "ItemForDireccion";
            this.ItemForDireccion.Size = new System.Drawing.Size(655, 26);
            this.ItemForDireccion.Text = "Direccion";
            this.ItemForDireccion.TextSize = new System.Drawing.Size(76, 16);
            // 
            // ItemForRepresentate
            // 
            this.ItemForRepresentate.Control = this.RepresentateTextEdit;
            this.ItemForRepresentate.Location = new System.Drawing.Point(0, 78);
            this.ItemForRepresentate.Name = "ItemForRepresentate";
            this.ItemForRepresentate.Size = new System.Drawing.Size(655, 26);
            this.ItemForRepresentate.Text = "Representate";
            this.ItemForRepresentate.TextSize = new System.Drawing.Size(76, 16);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 104);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(317, 31);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(76, 16);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 135);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(655, 268);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.AgregarProveedorSimpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(358, 104);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(297, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(317, 104);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(41, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ProovedorBindingSource
            // 
            this.ProovedorBindingSource.DataSource = this.ProveedorXpCollection;
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 423);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CedulaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepresentateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRepresentate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarProveedorDxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProovedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.Xpo.XPCollection ProveedorXpCollection;
        private DevExpress.Xpo.UnitOfWork UnitOfWork;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit CedulaTextEdit;
        private DevExpress.XtraEditors.TextEdit NombreTextEdit;
        private DevExpress.XtraEditors.TextEdit DireccionTextEdit;
        private DevExpress.XtraEditors.TextEdit RepresentateTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCedula;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNombre;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDireccion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRepresentate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraEditors.SimpleButton AgregarProveedorSimpleButton1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider AgregarProveedorDxValidationProvider1;
        private System.Windows.Forms.BindingSource ProovedorBindingSource;
    }
}