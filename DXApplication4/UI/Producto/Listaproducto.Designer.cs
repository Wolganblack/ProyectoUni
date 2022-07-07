namespace SistemaLibreria.UI.Producto
{
    partial class ListaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProducto));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControlProducto = new DevExpress.XtraGrid.GridControl();
            this.ListaProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ListaProductoxpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.UnitOfWork1 = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.MarcaXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NuevoBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ImprimiroExportarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExportExcelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductoxpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GridControlProducto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 178);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1007, 358);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GridControlProducto
            // 
            this.GridControlProducto.DataSource = this.ListaProductoBindingSource1;
            this.GridControlProducto.Location = new System.Drawing.Point(12, 12);
            this.GridControlProducto.MainView = this.gridView1;
            this.GridControlProducto.Name = "GridControlProducto";
            this.GridControlProducto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.MarcaRepositoryItemLookUpEdit});
            this.GridControlProducto.Size = new System.Drawing.Size(983, 334);
            this.GridControlProducto.TabIndex = 4;
            this.GridControlProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ListaProductoBindingSource1
            // 
            this.ListaProductoBindingSource1.DataSource = this.ListaProductoxpCollection;
            // 
            // ListaProductoxpCollection
            // 
            this.ListaProductoxpCollection.ObjectType = typeof(ModeloDatos.ORM.Producto);
            this.ListaProductoxpCollection.Session = this.UnitOfWork1;
            // 
            // UnitOfWork1
            // 
            this.UnitOfWork1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.UnitOfWork1.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre,
            this.colDescripcion,
            this.colColor,
            this.colExistencias,
            this.colCosto,
            this.colPrecioVenta,
            this.gridColumn1});
            this.gridView1.GridControl = this.GridControlProducto;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 2;
            // 
            // colExistencias
            // 
            this.colExistencias.FieldName = "Existencias";
            this.colExistencias.Name = "colExistencias";
            this.colExistencias.Visible = true;
            this.colExistencias.VisibleIndex = 3;
            // 
            // colCosto
            // 
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 4;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.FieldName = "PrecioVenta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.Visible = true;
            this.colPrecioVenta.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Marca";
            this.gridColumn1.ColumnEdit = this.MarcaRepositoryItemLookUpEdit;
            this.gridColumn1.FieldName = "MarcaId!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // MarcaRepositoryItemLookUpEdit
            // 
            this.MarcaRepositoryItemLookUpEdit.AutoHeight = false;
            this.MarcaRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MarcaRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.MarcaRepositoryItemLookUpEdit.DataSource = this.MarcaXpCollection;
            this.MarcaRepositoryItemLookUpEdit.DisplayMember = "Nombre";
            this.MarcaRepositoryItemLookUpEdit.Name = "MarcaRepositoryItemLookUpEdit";
            this.MarcaRepositoryItemLookUpEdit.ValueMember = "Id";
            // 
            // MarcaXpCollection
            // 
            this.MarcaXpCollection.ObjectType = typeof(ModeloDatos.ORM.Marca);
            this.MarcaXpCollection.Session = this.UnitOfWork1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1007, 358);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridControlProducto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(987, 338);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 536);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1007, 37);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NuevoBarButtonItem,
            this.EliminarBarButtonItem,
            this.ImprimiroExportarBarButtonItem,
            this.ExportExcelBarButtonItem,
            this.EditarBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1007, 178);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // NuevoBarButtonItem
            // 
            this.NuevoBarButtonItem.Caption = "Nuevo";
            this.NuevoBarButtonItem.Id = 4;
            this.NuevoBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NuevoBarButtonItem.ImageOptions.Image")));
            this.NuevoBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NuevoBarButtonItem.ImageOptions.LargeImage")));
            this.NuevoBarButtonItem.Name = "NuevoBarButtonItem";
            this.NuevoBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NuevoProductoBarButtonItem_ItemClick);
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
            // ExportExcelBarButtonItem
            // 
            this.ExportExcelBarButtonItem.Caption = "Exportar a excel";
            this.ExportExcelBarButtonItem.Id = 7;
            this.ExportExcelBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExportExcelBarButtonItem.ImageOptions.Image")));
            this.ExportExcelBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ExportExcelBarButtonItem.ImageOptions.LargeImage")));
            this.ExportExcelBarButtonItem.Name = "ExportExcelBarButtonItem";
            this.ExportExcelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExportExcelBarButtonItem_ItemClick);
            // 
            // EditarBarButtonItem
            // 
            this.EditarBarButtonItem.Caption = "Editar";
            this.EditarBarButtonItem.Id = 8;
            this.EditarBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItem.ImageOptions.Image")));
            this.EditarBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItem.ImageOptions.LargeImage")));
            this.EditarBarButtonItem.Name = "EditarBarButtonItem";
            this.EditarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditarBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.NuevoBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EditarBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.EliminarBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.ImprimiroExportarBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.ExportExcelBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 573);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaProducto";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Listaproducto";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductoxpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitOfWork1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Xpo.UnitOfWork UnitOfWork1;
        private DevExpress.Xpo.XPCollection ListaProductoxpCollection;
        private DevExpress.XtraGrid.GridControl GridControlProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencias;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit MarcaRepositoryItemLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPCollection MarcaXpCollection;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem NuevoBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem EliminarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ImprimiroExportarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExportExcelBarButtonItem;
        private System.Windows.Forms.BindingSource ListaProductoBindingSource1;
        private DevExpress.XtraBars.BarButtonItem EditarBarButtonItem;
    }
}