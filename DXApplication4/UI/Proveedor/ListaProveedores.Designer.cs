namespace SistemaLibreria.UI.Proveedor
{
    partial class ListaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProveedores));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControlProveedores = new DevExpress.XtraGrid.GridControl();
            this.ListarProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.UnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ProveedoresGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepresentate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NuevoBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExcelBarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ImprimirBarButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.EditarBarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Inicio = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GridControlProveedores);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 178);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(959, 340);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GridControlProveedores
            // 
            this.GridControlProveedores.DataSource = this.ListarProveedoresBindingSource;
            this.GridControlProveedores.Location = new System.Drawing.Point(12, 12);
            this.GridControlProveedores.MainView = this.ProveedoresGridView;
            this.GridControlProveedores.Name = "GridControlProveedores";
            this.GridControlProveedores.Size = new System.Drawing.Size(935, 316);
            this.GridControlProveedores.TabIndex = 7;
            this.GridControlProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProveedoresGridView});
            // 
            // ListarProveedoresBindingSource
            // 
            this.ListarProveedoresBindingSource.DataSource = this.ProveedorXpCollection;
            // 
            // ProveedorXpCollection
            // 
            this.ProveedorXpCollection.ObjectType = typeof(ModeloDatos.ORM.Proveedor);
            this.ProveedorXpCollection.Session = this.UnitOfWork;
            // 
            // UnitOfWork
            // 
            this.UnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UnitOfWork.TrackPropertiesModifications = false;
            // 
            // ProveedoresGridView
            // 
            this.ProveedoresGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCedula,
            this.colNombre,
            this.colDireccion,
            this.colRepresentate,
            this.colEmail});
            this.ProveedoresGridView.GridControl = this.GridControlProveedores;
            this.ProveedoresGridView.Name = "ProveedoresGridView";
            this.ProveedoresGridView.OptionsFind.AlwaysVisible = true;
            this.ProveedoresGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
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
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 3;
            // 
            // colRepresentate
            // 
            this.colRepresentate.FieldName = "Representate";
            this.colRepresentate.Name = "colRepresentate";
            this.colRepresentate.Visible = true;
            this.colRepresentate.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(959, 340);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridControlProveedores;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(939, 320);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NuevoBarButtonItem,
            this.EliminarBarButtonItem,
            this.ExcelBarButtonItem1,
            this.ImprimirBarButtonItem2,
            this.EditarBarButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(959, 178);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // NuevoBarButtonItem
            // 
            this.NuevoBarButtonItem.Caption = "Nuevo";
            this.NuevoBarButtonItem.Id = 1;
            this.NuevoBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NuevoBarButtonItem.ImageOptions.Image")));
            this.NuevoBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NuevoBarButtonItem.ImageOptions.LargeImage")));
            this.NuevoBarButtonItem.Name = "NuevoBarButtonItem";
            this.NuevoBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NuevoBarButtonItem_ItemClick);
            // 
            // EliminarBarButtonItem
            // 
            this.EliminarBarButtonItem.Caption = "Eliminar";
            this.EliminarBarButtonItem.Id = 2;
            this.EliminarBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBarButtonItem.ImageOptions.Image")));
            this.EliminarBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EliminarBarButtonItem.ImageOptions.LargeImage")));
            this.EliminarBarButtonItem.Name = "EliminarBarButtonItem";
            this.EliminarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EliminarBarButtonItem_ItemClick);
            // 
            // ExcelBarButtonItem1
            // 
            this.ExcelBarButtonItem1.Caption = "Exportar a Excel";
            this.ExcelBarButtonItem1.Id = 5;
            this.ExcelBarButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExcelBarButtonItem1.ImageOptions.Image")));
            this.ExcelBarButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExcelBarButtonItem1.ImageOptions.LargeImage")));
            this.ExcelBarButtonItem1.Name = "ExcelBarButtonItem1";
            this.ExcelBarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExcelBarButtonItem1_ItemClick);
            // 
            // ImprimirBarButtonItem2
            // 
            this.ImprimirBarButtonItem2.Caption = "Imprimir reporte pdf o excel";
            this.ImprimirBarButtonItem2.Id = 6;
            this.ImprimirBarButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirBarButtonItem2.ImageOptions.Image")));
            this.ImprimirBarButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ImprimirBarButtonItem2.ImageOptions.LargeImage")));
            this.ImprimirBarButtonItem2.Name = "ImprimirBarButtonItem2";
            this.ImprimirBarButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImprimirBarButtonItem2_ItemClick);
            // 
            // EditarBarButtonItem1
            // 
            this.EditarBarButtonItem1.Caption = "Editar";
            this.EditarBarButtonItem1.Id = 7;
            this.EditarBarButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItem1.ImageOptions.Image")));
            this.EditarBarButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItem1.ImageOptions.LargeImage")));
            this.EditarBarButtonItem1.Name = "EditarBarButtonItem1";
            this.EditarBarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditarBarButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Inicio});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // Inicio
            // 
            this.Inicio.ItemLinks.Add(this.NuevoBarButtonItem);
            this.Inicio.ItemLinks.Add(this.EditarBarButtonItem1);
            this.Inicio.ItemLinks.Add(this.EliminarBarButtonItem);
            this.Inicio.ItemLinks.Add(this.ImprimirBarButtonItem2);
            this.Inicio.ItemLinks.Add(this.ExcelBarButtonItem1);
            this.Inicio.Name = "Inicio";
            this.Inicio.Text = "Acciones";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 518);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(959, 37);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 555);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaProveedores";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.ListaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Xpo.XPCollection ProveedorXpCollection;
        private DevExpress.Xpo.UnitOfWork UnitOfWork;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Inicio;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem NuevoBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem EliminarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExcelBarButtonItem1;
        private DevExpress.XtraBars.BarButtonItem ImprimirBarButtonItem2;
        private System.Windows.Forms.BindingSource ListarProveedoresBindingSource;
        private DevExpress.XtraBars.BarButtonItem EditarBarButtonItem1;
        private DevExpress.XtraGrid.GridControl GridControlProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView ProveedoresGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colRepresentate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}