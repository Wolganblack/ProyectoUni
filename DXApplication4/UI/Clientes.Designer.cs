namespace SistemaLibreria.UI
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NuevoClienteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.EditarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ImprimiroExportarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExportarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.InicioRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemResourcesComboBox1 = new DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox();
            this.Departamento = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ClientesGridControl = new DevExpress.XtraGrid.GridControl();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.UnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ClientesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicpio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MunicipioRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MunicipioXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartamentoRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.DepartamentoXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.TelefonoItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.TelefonoXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Departamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.NuevoClienteBarButtonItem,
            this.barButtonItem1,
            this.EditarBarButtonItem,
            this.EliminarBarButtonItem,
            this.ImprimiroExportarBarButtonItem,
            this.ExportarBarButtonItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.InicioRibbonPage});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemResourcesComboBox1,
            this.Departamento});
            this.ribbon.Size = new System.Drawing.Size(967, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // NuevoClienteBarButtonItem
            // 
            this.NuevoClienteBarButtonItem.Caption = "Nuevo";
            this.NuevoClienteBarButtonItem.Id = 1;
            this.NuevoClienteBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NuevoClienteBarButtonItem.ImageOptions.Image")));
            this.NuevoClienteBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NuevoClienteBarButtonItem.ImageOptions.LargeImage")));
            this.NuevoClienteBarButtonItem.Name = "NuevoClienteBarButtonItem";
            this.NuevoClienteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NuevoClienteBarButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // EditarBarButtonItem
            // 
            this.EditarBarButtonItem.Caption = "Editar";
            this.EditarBarButtonItem.Id = 4;
            this.EditarBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItem.ImageOptions.Image")));
            this.EditarBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItem.ImageOptions.LargeImage")));
            this.EditarBarButtonItem.Name = "EditarBarButtonItem";
            this.EditarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditarBarButtonItem_ItemClick);
            // 
            // EliminarBarButtonItem
            // 
            this.EliminarBarButtonItem.Caption = "Eliminar";
            this.EliminarBarButtonItem.Id = 5;
            this.EliminarBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBarButtonItem.ImageOptions.Image")));
            this.EliminarBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EliminarBarButtonItem.ImageOptions.LargeImage")));
            this.EliminarBarButtonItem.Name = "EliminarBarButtonItem";
            this.EliminarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EliminarBarButtonItem_ItemClick);
            // 
            // ImprimiroExportarBarButtonItem
            // 
            this.ImprimiroExportarBarButtonItem.Caption = "Imprimir o Exportar";
            this.ImprimiroExportarBarButtonItem.Id = 6;
            this.ImprimiroExportarBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ImprimiroExportarBarButtonItem.ImageOptions.Image")));
            this.ImprimiroExportarBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ImprimiroExportarBarButtonItem.ImageOptions.LargeImage")));
            this.ImprimiroExportarBarButtonItem.Name = "ImprimiroExportarBarButtonItem";
            this.ImprimiroExportarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImprimiroExportarBarButtonItem_ItemClick);
            // 
            // ExportarBarButtonItem
            // 
            this.ExportarBarButtonItem.Caption = "Exportar a EXCEL";
            this.ExportarBarButtonItem.Id = 7;
            this.ExportarBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExportarBarButtonItem.ImageOptions.Image")));
            this.ExportarBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExportarBarButtonItem.ImageOptions.LargeImage")));
            this.ExportarBarButtonItem.Name = "ExportarBarButtonItem";
            this.ExportarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExportarBarButtonItem_ItemClick);
            // 
            // InicioRibbonPage
            // 
            this.InicioRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.InicioRibbonPage.Name = "InicioRibbonPage";
            this.InicioRibbonPage.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.NuevoClienteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EditarBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EliminarBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.ImprimiroExportarBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.ExportarBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemResourcesComboBox1
            // 
            this.repositoryItemResourcesComboBox1.AutoHeight = false;
            this.repositoryItemResourcesComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemResourcesComboBox1.Name = "repositoryItemResourcesComboBox1";
            // 
            // Departamento
            // 
            this.Departamento.AutoHeight = false;
            this.Departamento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Departamento.Name = "Departamento";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 441);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(967, 37);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ClientesGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 178);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 93, 812, 500);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(967, 263);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ClientesGridControl
            // 
            this.ClientesGridControl.DataSource = this.ClientesBindingSource;
            this.ClientesGridControl.Location = new System.Drawing.Point(12, 12);
            this.ClientesGridControl.MainView = this.ClientesGridView;
            this.ClientesGridControl.MenuManager = this.ribbon;
            this.ClientesGridControl.Name = "ClientesGridControl";
            this.ClientesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MunicipioRepositoryItemLookUpEdit,
            this.DepartamentoRepositoryItemLookUpEdit,
            this.TelefonoItemLookUpEdit});
            this.ClientesGridControl.Size = new System.Drawing.Size(943, 239);
            this.ClientesGridControl.TabIndex = 4;
            this.ClientesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ClientesGridView});
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataSource = this.ClienteXpCollection;
            // 
            // ClienteXpCollection
            // 
            this.ClienteXpCollection.ObjectType = typeof(ModeloDatos.ORM.Cliente);
            this.ClienteXpCollection.Session = this.UnitOfWork;
            // 
            // UnitOfWork
            // 
            this.UnitOfWork.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.UnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UnitOfWork.TrackPropertiesModifications = false;
            // 
            // ClientesGridView
            // 
            this.ClientesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre_apellido,
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colDireccion,
            this.colEmail,
            this.colMunicpio,
            this.colDepartamento});
            this.ClientesGridView.GridControl = this.ClientesGridControl;
            this.ClientesGridView.Name = "ClientesGridView";
            this.ClientesGridView.OptionsFind.AlwaysVisible = true;
            this.ClientesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNombre_apellido
            // 
            this.colNombre_apellido.FieldName = "Nombre_apellido";
            this.colNombre_apellido.Name = "colNombre_apellido";
            this.colNombre_apellido.Visible = true;
            this.colNombre_apellido.VisibleIndex = 0;
            // 
            // colCedula
            // 
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 3;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colMunicpio
            // 
            this.colMunicpio.Caption = "Municipio";
            this.colMunicpio.ColumnEdit = this.MunicipioRepositoryItemLookUpEdit;
            this.colMunicpio.FieldName = "MunicipioId!Key";
            this.colMunicpio.Name = "colMunicpio";
            this.colMunicpio.Visible = true;
            this.colMunicpio.VisibleIndex = 6;
            // 
            // MunicipioRepositoryItemLookUpEdit
            // 
            this.MunicipioRepositoryItemLookUpEdit.AutoHeight = false;
            this.MunicipioRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MunicipioRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.MunicipioRepositoryItemLookUpEdit.DataSource = this.MunicipioXpCollection;
            this.MunicipioRepositoryItemLookUpEdit.DisplayMember = "Nombre";
            this.MunicipioRepositoryItemLookUpEdit.Name = "MunicipioRepositoryItemLookUpEdit";
            this.MunicipioRepositoryItemLookUpEdit.ValueMember = "Id";
            // 
            // MunicipioXpCollection
            // 
            this.MunicipioXpCollection.ObjectType = typeof(ModeloDatos.ORM.Municipio);
            this.MunicipioXpCollection.Session = this.UnitOfWork;
            // 
            // colDepartamento
            // 
            this.colDepartamento.Caption = "Departamento";
            this.colDepartamento.ColumnEdit = this.DepartamentoRepositoryItemLookUpEdit;
            this.colDepartamento.FieldName = "MunicipioId.DepartamentoId.Id";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 7;
            // 
            // DepartamentoRepositoryItemLookUpEdit
            // 
            this.DepartamentoRepositoryItemLookUpEdit.AutoHeight = false;
            this.DepartamentoRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartamentoRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.DepartamentoRepositoryItemLookUpEdit.DataSource = this.DepartamentoXpCollection;
            this.DepartamentoRepositoryItemLookUpEdit.DisplayMember = "Nombre";
            this.DepartamentoRepositoryItemLookUpEdit.Name = "DepartamentoRepositoryItemLookUpEdit";
            this.DepartamentoRepositoryItemLookUpEdit.ValueMember = "Id";
            // 
            // DepartamentoXpCollection
            // 
            this.DepartamentoXpCollection.ObjectType = typeof(ModeloDatos.ORM.Departamento);
            this.DepartamentoXpCollection.Session = this.UnitOfWork;
            // 
            // TelefonoItemLookUpEdit
            // 
            this.TelefonoItemLookUpEdit.AutoHeight = false;
            this.TelefonoItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TelefonoItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Numero", "Numero", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.TelefonoItemLookUpEdit.DataSource = this.TelefonoXpCollection;
            this.TelefonoItemLookUpEdit.DisplayMember = "Numero";
            this.TelefonoItemLookUpEdit.Name = "TelefonoItemLookUpEdit";
            this.TelefonoItemLookUpEdit.ValueMember = "Id";
            // 
            // TelefonoXpCollection
            // 
            this.TelefonoXpCollection.ObjectType = typeof(ModeloDatos.ORM.Telefono);
            this.TelefonoXpCollection.Session = this.UnitOfWork;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(967, 263);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ClientesGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(947, 243);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 478);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemResourcesComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Departamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MunicipioXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem NuevoClienteBarButtonItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl ClientesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ClientesGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.UnitOfWork UnitOfWork;
        private DevExpress.Xpo.XPCollection ClienteXpCollection;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_apellido;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicpio;
        private DevExpress.Xpo.XPCollection MunicipioXpCollection;
        private DevExpress.Xpo.XPCollection DepartamentoXpCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MunicipioRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraScheduler.UI.RepositoryItemResourcesComboBox repositoryItemResourcesComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Departamento;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DepartamentoRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit TelefonoItemLookUpEdit;
        private DevExpress.Xpo.XPCollection TelefonoXpCollection;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem EditarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem EliminarBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage InicioRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private DevExpress.XtraBars.BarButtonItem ImprimiroExportarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExportarBarButtonItem;
    }
}