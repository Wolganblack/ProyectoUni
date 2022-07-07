namespace SistemaLibreria.UI.Facturas
{
    partial class ListaFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFacturas));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ListaFacturaGridControl = new DevExpress.XtraGrid.GridControl();
            this.ListaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListaFacturaXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.ListaFacturaUnitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ListaFacturaGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ClienteXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NuevobarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.EditarBarButtonItemB = new DevExpress.XtraBars.BarButtonItem();
            this.EliminarBarButtonItemB = new DevExpress.XtraBars.BarButtonItem();
            this.ImprimirBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ExcelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.detalleFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaUnitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ListaFacturaGridControl);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 178);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(959, 263);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ListaFacturaGridControl
            // 
            this.ListaFacturaGridControl.DataSource = this.ListaFacturaBindingSource;
            this.ListaFacturaGridControl.Location = new System.Drawing.Point(12, 12);
            this.ListaFacturaGridControl.MainView = this.ListaFacturaGridView;
            this.ListaFacturaGridControl.MenuManager = this.ribbonControl1;
            this.ListaFacturaGridControl.Name = "ListaFacturaGridControl";
            this.ListaFacturaGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.ListaFacturaGridControl.Size = new System.Drawing.Size(935, 239);
            this.ListaFacturaGridControl.TabIndex = 4;
            this.ListaFacturaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ListaFacturaGridView});
            // 
            // ListaFacturaBindingSource
            // 
            this.ListaFacturaBindingSource.DataSource = this.ListaFacturaXpCollection;
            // 
            // ListaFacturaXpCollection
            // 
            this.ListaFacturaXpCollection.ObjectType = typeof(ModeloDatos.ORM.Factura);
            this.ListaFacturaXpCollection.Session = this.ListaFacturaUnitOfWork;
            // 
            // ListaFacturaUnitOfWork
            // 
            this.ListaFacturaUnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.ListaFacturaUnitOfWork.TrackPropertiesModifications = false;
            // 
            // ListaFacturaGridView
            // 
            this.ListaFacturaGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNumero,
            this.colFecha,
            this.colTotal,
            this.gridColumn1,
            this.gridColumn2});
            this.ListaFacturaGridView.GridControl = this.ListaFacturaGridControl;
            this.ListaFacturaGridView.Name = "ListaFacturaGridView";
            this.ListaFacturaGridView.OptionsFind.AlwaysVisible = true;
            // 
            // colId
            // 
            this.colId.Caption = "Numero";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "TotalFactura";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cliente";
            this.gridColumn1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn1.FieldName = "ClienteId.Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre_apellido", "Nombre_apellido", 119, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DataSource = this.ClienteXpCollection;
            this.repositoryItemLookUpEdit1.DisplayMember = "Nombre_apellido";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // ClienteXpCollection
            // 
            this.ClienteXpCollection.ObjectType = typeof(ModeloDatos.ORM.Cliente);
            this.ClienteXpCollection.Session = this.ListaFacturaUnitOfWork;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ClienteId!Key";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NuevobarButtonItem,
            this.EditarBarButtonItemB,
            this.EliminarBarButtonItemB,
            this.ImprimirBarButtonItem,
            this.ExcelBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(959, 178);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // NuevobarButtonItem
            // 
            this.NuevobarButtonItem.Caption = "Nuevo";
            this.NuevobarButtonItem.Id = 1;
            this.NuevobarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NuevobarButtonItem.ImageOptions.Image")));
            this.NuevobarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NuevobarButtonItem.ImageOptions.LargeImage")));
            this.NuevobarButtonItem.Name = "NuevobarButtonItem";
            this.NuevobarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NuevobarButtonItem_ItemClick);
            // 
            // EditarBarButtonItemB
            // 
            this.EditarBarButtonItemB.Caption = "Editar";
            this.EditarBarButtonItemB.Id = 3;
            this.EditarBarButtonItemB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItemB.ImageOptions.Image")));
            this.EditarBarButtonItemB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EditarBarButtonItemB.ImageOptions.LargeImage")));
            this.EditarBarButtonItemB.Name = "EditarBarButtonItemB";
            this.EditarBarButtonItemB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditarBarButtonItemB_ItemClick);
            // 
            // EliminarBarButtonItemB
            // 
            this.EliminarBarButtonItemB.Caption = "Eliminar";
            this.EliminarBarButtonItemB.Id = 4;
            this.EliminarBarButtonItemB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBarButtonItemB.ImageOptions.Image")));
            this.EliminarBarButtonItemB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EliminarBarButtonItemB.ImageOptions.LargeImage")));
            this.EliminarBarButtonItemB.Name = "EliminarBarButtonItemB";
            this.EliminarBarButtonItemB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EliminarBarButtonItemB_ItemClick);
            // 
            // ImprimirBarButtonItem
            // 
            this.ImprimirBarButtonItem.Caption = "Imprimir reporte pdf o excel";
            this.ImprimirBarButtonItem.Id = 7;
            this.ImprimirBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirBarButtonItem.ImageOptions.Image")));
            this.ImprimirBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ImprimirBarButtonItem.ImageOptions.LargeImage")));
            this.ImprimirBarButtonItem.Name = "ImprimirBarButtonItem";
            this.ImprimirBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImprimirBarButtonItem_ItemClick);
            // 
            // ExcelBarButtonItem
            // 
            this.ExcelBarButtonItem.Caption = "Exportar a Excel";
            this.ExcelBarButtonItem.Id = 8;
            this.ExcelBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExcelBarButtonItem.ImageOptions.Image")));
            this.ExcelBarButtonItem.Name = "ExcelBarButtonItem";
            this.ExcelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExcelBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // RibbonPageGroup1
            // 
            this.RibbonPageGroup1.ItemLinks.Add(this.NuevobarButtonItem);
            this.RibbonPageGroup1.ItemLinks.Add(this.EditarBarButtonItemB);
            this.RibbonPageGroup1.ItemLinks.Add(this.EliminarBarButtonItemB);
            this.RibbonPageGroup1.ItemLinks.Add(this.ImprimirBarButtonItem);
            this.RibbonPageGroup1.ItemLinks.Add(this.ExcelBarButtonItem);
            this.RibbonPageGroup1.Name = "RibbonPageGroup1";
            this.RibbonPageGroup1.Text = "Acciones";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 441);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(959, 37);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(959, 263);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ListaFacturaGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(939, 243);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // detalleFacturasBindingSource
            // 
            this.detalleFacturasBindingSource.DataMember = "DetalleFacturas";
            this.detalleFacturasBindingSource.DataSource = this.ListaFacturaBindingSource;
            // 
            // ListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 478);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaFacturas";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaUnitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFacturaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Xpo.UnitOfWork ListaFacturaUnitOfWork;
        private DevExpress.Xpo.XPCollection ListaFacturaXpCollection;
        private System.Windows.Forms.BindingSource ListaFacturaBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraGrid.GridControl ListaFacturaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ListaFacturaGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem NuevobarButtonItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource detalleFacturasBindingSource;
        private DevExpress.XtraBars.BarButtonItem EditarBarButtonItemB;
        private DevExpress.XtraBars.BarButtonItem EliminarBarButtonItemB;
        private DevExpress.XtraBars.BarButtonItem ImprimirBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ExcelBarButtonItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.Xpo.XPCollection ClienteXpCollection;
    }
}