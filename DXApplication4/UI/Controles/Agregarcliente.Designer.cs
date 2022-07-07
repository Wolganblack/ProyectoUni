namespace SistemaLibreria.UI.Controles
{
    partial class Agregarcliente
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregarcliente));
            this.UnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ClienteDxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.Emailclitxt = new DevExpress.XtraEditors.TextEdit();
            this.ClienteBiindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.MunicipioSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.XpMunicipioCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Agregarclie1 = new DevExpress.XtraEditors.SimpleButton();
            this.Apellidoclitxt = new DevExpress.XtraEditors.TextEdit();
            this.Nombreclitxt = new DevExpress.XtraEditors.TextEdit();
            this.Cedulatcli = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.DireccionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emailclitxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBiindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XpMunicipioCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apellidoclitxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nombreclitxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cedulatcli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitOfWork
            // 
            this.UnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UnitOfWork.TrackPropertiesModifications = false;
            // 
            // Emailclitxt
            // 
            this.Emailclitxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClienteBiindingSource, "Email", true));
            this.Emailclitxt.Location = new System.Drawing.Point(72, 116);
            this.Emailclitxt.Name = "Emailclitxt";
            this.Emailclitxt.Properties.Mask.EditMask = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.Emailclitxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Emailclitxt.Size = new System.Drawing.Size(535, 22);
            this.Emailclitxt.StyleController = this.layoutControl1;
            this.Emailclitxt.TabIndex = 16;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            this.ClienteDxValidationProvider.SetValidationRule(this.Emailclitxt, conditionValidationRule6);
            this.Emailclitxt.EditValueChanged += new System.EventHandler(this.Emailclitxt_EditValueChanged_1);
            // 
            // ClienteBiindingSource
            // 
            this.ClienteBiindingSource.DataSource = this.ClienteXpCollection;
            // 
            // ClienteXpCollection
            // 
            this.ClienteXpCollection.LoadingEnabled = false;
            this.ClienteXpCollection.ObjectType = typeof(ModeloDatos.ORM.Cliente);
            this.ClienteXpCollection.Session = this.UnitOfWork;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.DireccionTextEdit);
            this.layoutControl1.Controls.Add(this.MunicipioSearchLookUpEdit);
            this.layoutControl1.Controls.Add(this.Agregarclie1);
            this.layoutControl1.Controls.Add(this.Emailclitxt);
            this.layoutControl1.Controls.Add(this.Apellidoclitxt);
            this.layoutControl1.Controls.Add(this.Nombreclitxt);
            this.layoutControl1.Controls.Add(this.Cedulatcli);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(619, 272);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // MunicipioSearchLookUpEdit
            // 
            this.MunicipioSearchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClienteBiindingSource, "MunicipioId!", true));
            this.MunicipioSearchLookUpEdit.Location = new System.Drawing.Point(72, 142);
            this.MunicipioSearchLookUpEdit.Name = "MunicipioSearchLookUpEdit";
            this.MunicipioSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.MunicipioSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MunicipioSearchLookUpEdit.Properties.DataSource = this.XpMunicipioCollection;
            this.MunicipioSearchLookUpEdit.Properties.DisplayMember = "Nombre";
            this.MunicipioSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.MunicipioSearchLookUpEdit.Properties.ValueMember = "This";
            this.MunicipioSearchLookUpEdit.Size = new System.Drawing.Size(535, 22);
            this.MunicipioSearchLookUpEdit.StyleController = this.layoutControl1;
            this.MunicipioSearchLookUpEdit.TabIndex = 18;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.ClienteDxValidationProvider.SetValidationRule(this.MunicipioSearchLookUpEdit, conditionValidationRule2);
            this.MunicipioSearchLookUpEdit.EditValueChanged += new System.EventHandler(this.MunicipioSearchLookUpEdit_EditValueChanged);
            // 
            // XpMunicipioCollection
            // 
            this.XpMunicipioCollection.ObjectType = typeof(ModeloDatos.ORM.Municipio);
            this.XpMunicipioCollection.Session = this.UnitOfWork;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Agregarclie1
            // 
            this.Agregarclie1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarclie1.Appearance.Options.UseFont = true;
            this.Agregarclie1.Location = new System.Drawing.Point(12, 168);
            this.Agregarclie1.Name = "Agregarclie1";
            this.Agregarclie1.Size = new System.Drawing.Size(595, 28);
            this.Agregarclie1.StyleController = this.layoutControl1;
            this.Agregarclie1.TabIndex = 17;
            this.Agregarclie1.Text = "Agregar";
            this.Agregarclie1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Apellidoclitxt
            // 
            this.Apellidoclitxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClienteBiindingSource, "Apellido", true));
            this.Apellidoclitxt.Location = new System.Drawing.Point(72, 64);
            this.Apellidoclitxt.Name = "Apellidoclitxt";
            this.Apellidoclitxt.Size = new System.Drawing.Size(535, 22);
            this.Apellidoclitxt.StyleController = this.layoutControl1;
            this.Apellidoclitxt.TabIndex = 14;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.ClienteDxValidationProvider.SetValidationRule(this.Apellidoclitxt, conditionValidationRule3);
            // 
            // Nombreclitxt
            // 
            this.Nombreclitxt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClienteBiindingSource, "Nombre", true));
            this.Nombreclitxt.Location = new System.Drawing.Point(72, 38);
            this.Nombreclitxt.Name = "Nombreclitxt";
            this.Nombreclitxt.Size = new System.Drawing.Size(535, 22);
            this.Nombreclitxt.StyleController = this.layoutControl1;
            this.Nombreclitxt.TabIndex = 13;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.Value2 = "";
            this.ClienteDxValidationProvider.SetValidationRule(this.Nombreclitxt, conditionValidationRule4);
            // 
            // Cedulatcli
            // 
            this.Cedulatcli.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClienteBiindingSource, "Cedula", true));
            this.Cedulatcli.Location = new System.Drawing.Point(72, 12);
            this.Cedulatcli.Name = "Cedulatcli";
            this.Cedulatcli.Properties.Mask.BeepOnError = true;
            this.Cedulatcli.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d\\d\\d\\d-\\d\\d\\d\\d\\D";
            this.Cedulatcli.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.Cedulatcli.Size = new System.Drawing.Size(535, 22);
            this.Cedulatcli.StyleController = this.layoutControl1;
            this.Cedulatcli.TabIndex = 10;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.ClienteDxValidationProvider.SetValidationRule(this.Cedulatcli, conditionValidationRule5);
            this.Cedulatcli.EditValueChanged += new System.EventHandler(this.Cedulatcli_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(619, 272);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Emailclitxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(599, 26);
            this.layoutControlItem2.Text = "Email";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Agregarclie1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(599, 96);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.Cedulatcli;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(599, 26);
            this.layoutControlItem8.Text = "Cedula";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(57, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.Nombreclitxt;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(599, 26);
            this.layoutControlItem5.Text = "Nombre";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(57, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.MunicipioSearchLookUpEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(599, 26);
            this.layoutControlItem3.Text = "Municipio";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Apellidoclitxt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(599, 26);
            this.layoutControlItem4.Text = "Apellido";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(57, 16);
            // 
            // DireccionTextEdit
            // 
            this.DireccionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ClienteBiindingSource, "Direccion", true));
            this.DireccionTextEdit.Location = new System.Drawing.Point(72, 90);
            this.DireccionTextEdit.Name = "DireccionTextEdit";
            this.DireccionTextEdit.Size = new System.Drawing.Size(535, 22);
            this.DireccionTextEdit.StyleController = this.layoutControl1;
            this.DireccionTextEdit.TabIndex = 19;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.Value1 = "<Null>";
            this.ClienteDxValidationProvider.SetValidationRule(this.DireccionTextEdit, conditionValidationRule1);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.DireccionTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(599, 26);
            this.layoutControlItem6.Text = "Direccion:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(57, 16);
            // 
            // Agregarcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 272);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregarcliente";
            this.Text = "Agregarcliente";
            this.Load += new System.EventHandler(this.Agregarcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteDxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emailclitxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBiindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XpMunicipioCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apellidoclitxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nombreclitxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cedulatcli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DireccionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.UnitOfWork UnitOfWork;
        private DevExpress.Xpo.XPCollection ClienteXpCollection;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ClienteDxValidationProvider;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton Agregarclie1;
        private DevExpress.XtraEditors.TextEdit Emailclitxt;
        private DevExpress.XtraEditors.TextEdit Apellidoclitxt;
        private DevExpress.XtraEditors.TextEdit Nombreclitxt;
        private DevExpress.XtraEditors.TextEdit Cedulatcli;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SearchLookUpEdit MunicipioSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.Xpo.XPCollection XpMunicipioCollection;
        private System.Windows.Forms.BindingSource ClienteBiindingSource;
        private DevExpress.XtraEditors.TextEdit DireccionTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}