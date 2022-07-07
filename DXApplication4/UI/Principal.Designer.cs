namespace SistemaLibreria.UI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.IconosSharedImageCollection = new DevExpress.Utils.SharedImageCollection(this.components);
            this.ClienteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProveedoresBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProductoBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.RespaldoBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.FacturaBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.InicioRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconosSharedImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconosSharedImageCollection.ImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.IconosSharedImageCollection;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ClienteBarButtonItem,
            this.ProveedoresBarButtonItem,
            this.ProductoBarButtonItem,
            this.barButtonItem1,
            this.RespaldoBarButtonItem,
            this.FacturaBarButtonItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1041, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // IconosSharedImageCollection
            // 
            // 
            // 
            // 
            this.IconosSharedImageCollection.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IconosSharedImageCollection.ImageSource.ImageStream")));
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(0, "add_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(1, "add_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(2, "addfile_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(3, "addfile_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(4, "additem_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(5, "additem_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(6, "apply_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(7, "apply_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(8, "cancel_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(9, "cancel_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(10, "clear_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(11, "clear_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(12, "clearformatting_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(13, "clearformatting_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(14, "cleartablestyle_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(15, "cleartablestyle_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(16, "clip_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(17, "clip_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(18, "close_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(19, "close_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(20, "convert_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(21, "convert_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(22, "converttorange_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(23, "converttorange_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(24, "deletelist_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(25, "deletelist_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(26, "deletelist2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(27, "deletelist2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(28, "down_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(29, "down_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(30, "download_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(31, "download_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(32, "editname_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(33, "editname_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(34, "fill_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(35, "fill_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(36, "formatastable_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(37, "formatastable_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(38, "group_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(39, "group_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(40, "group2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(41, "group2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(42, "hide_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(43, "hide_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(44, "importimage_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(45, "importimage_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(46, "insert_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(47, "insert_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(48, "left_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(49, "left_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(50, "loadfrom_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(51, "loadfrom_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(52, "merge_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(53, "merge_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(54, "new_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(55, "new_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(56, "newtablestyle_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(57, "newtablestyle_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(58, "open_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(59, "open_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(60, "open2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(61, "open2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(62, "openhyperlink_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(63, "openhyperlink_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(64, "reading_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(65, "reading_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(66, "refresh_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(67, "refresh_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(68, "refresh2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(69, "refresh2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(70, "remove_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(71, "remove_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(72, "removeitem_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(73, "removeitem_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(74, "reset_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(75, "reset_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(76, "reset2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(77, "reset2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(78, "right_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(79, "right_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(80, "selectall_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(81, "selectall_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(82, "selectall2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(83, "selectall2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(84, "show_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(85, "show_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(86, "squeeze_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(87, "squeeze_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(88, "stretch_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(89, "stretch_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(90, "switchrowcolumn_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(91, "switchrowcolumn_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(92, "trash_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(93, "trash_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(94, "up2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(95, "up2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(96, "bochangehistory_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(97, "bochangehistory_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(98, "bocontact_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(99, "bocontact_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(100, "bocontact2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(101, "bocontact2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(102, "bocountry_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(103, "bocountry_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(104, "bocustomer_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(105, "bocustomer_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(106, "bodepartment_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(107, "bodepartment_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(108, "bodetails_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(109, "bodetails_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(110, "boemployee_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(111, "boemployee_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(112, "bofileattachment_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(113, "bofileattachment_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(114, "bofolder_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(115, "bofolder_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(116, "bolocalization_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(117, "bolocalization_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(118, "bonote_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(119, "bonote_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(120, "boorder_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(121, "boorder_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(122, "boorderitem_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(123, "boorderitem_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(124, "bopermission_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(125, "bopermission_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(126, "boperson_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(127, "boperson_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(128, "bopivotchart_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(129, "bopivotchart_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(130, "boposition_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(131, "boposition_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(132, "boposition2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(133, "boposition2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(134, "boproduct_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(135, "boproduct_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(136, "boproductgroup_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(137, "boproductgroup_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(138, "boreport_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(139, "boreport_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(140, "boreport2_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(141, "boreport2_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(142, "boresume_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(143, "boresume_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(144, "borole_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(145, "borole_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(146, "borules_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(147, "borules_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(148, "bosale_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(149, "bosale_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(150, "bosaleitem_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(151, "bosaleitem_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(152, "boscheduler_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(153, "boscheduler_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(154, "botask_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(155, "botask_32x32.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(156, "bouser_16x16.png");
            this.IconosSharedImageCollection.ImageSource.Images.SetKeyName(157, "bouser_32x32.png");
            this.IconosSharedImageCollection.ParentControl = this;
            // 
            // ClienteBarButtonItem
            // 
            this.ClienteBarButtonItem.Caption = "Clientes";
            this.ClienteBarButtonItem.Id = 1;
            this.ClienteBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ClienteBarButtonItem.ImageOptions.Image")));
            this.ClienteBarButtonItem.ImageOptions.ImageIndex = 104;
            this.ClienteBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ClienteBarButtonItem.ImageOptions.LargeImage")));
            this.ClienteBarButtonItem.ImageOptions.LargeImageIndex = 104;
            this.ClienteBarButtonItem.Name = "ClienteBarButtonItem";
            this.ClienteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClienteBarButtonItem_ItemClick);
            // 
            // ProveedoresBarButtonItem
            // 
            this.ProveedoresBarButtonItem.Caption = "Proveedores";
            this.ProveedoresBarButtonItem.Id = 2;
            this.ProveedoresBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProveedoresBarButtonItem.ImageOptions.Image")));
            this.ProveedoresBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ProveedoresBarButtonItem.ImageOptions.LargeImage")));
            this.ProveedoresBarButtonItem.Name = "ProveedoresBarButtonItem";
            this.ProveedoresBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProveedoresBarButtonItem_ItemClick);
            // 
            // ProductoBarButtonItem
            // 
            this.ProductoBarButtonItem.Caption = "Producto";
            this.ProductoBarButtonItem.Id = 3;
            this.ProductoBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ProductoBarButtonItem.ImageOptions.Image")));
            this.ProductoBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ProductoBarButtonItem.ImageOptions.LargeImage")));
            this.ProductoBarButtonItem.MergeType = DevExpress.XtraBars.BarMenuMerge.Replace;
            this.ProductoBarButtonItem.Name = "ProductoBarButtonItem";
            this.ProductoBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            this.ProductoBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProductoBarButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Respaldo";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // RespaldoBarButtonItem
            // 
            this.RespaldoBarButtonItem.ActAsDropDown = true;
            this.RespaldoBarButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.RespaldoBarButtonItem.Caption = "Respaldo";
            this.RespaldoBarButtonItem.Id = 2;
            this.RespaldoBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RespaldoBarButtonItem.ImageOptions.Image")));
            this.RespaldoBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("RespaldoBarButtonItem.ImageOptions.LargeImage")));
            this.RespaldoBarButtonItem.Name = "RespaldoBarButtonItem";
            this.RespaldoBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RespaldoBarButtonItem_ItemClick);
            // 
            // FacturaBarButtonItem
            // 
            this.FacturaBarButtonItem.Caption = "Factura";
            this.FacturaBarButtonItem.Id = 3;
            this.FacturaBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FacturaBarButtonItem.ImageOptions.Image")));
            this.FacturaBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FacturaBarButtonItem.ImageOptions.LargeImage")));
            this.FacturaBarButtonItem.Name = "FacturaBarButtonItem";
            this.FacturaBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FacturaBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.InicioRibbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inicio";
            // 
            // InicioRibbonPageGroup
            // 
            this.InicioRibbonPageGroup.ItemLinks.Add(this.ClienteBarButtonItem);
            this.InicioRibbonPageGroup.ItemLinks.Add(this.ProveedoresBarButtonItem);
            this.InicioRibbonPageGroup.ItemLinks.Add(this.ProductoBarButtonItem);
            this.InicioRibbonPageGroup.ItemLinks.Add(this.RespaldoBarButtonItem);
            this.InicioRibbonPageGroup.ItemLinks.Add(this.FacturaBarButtonItem);
            this.InicioRibbonPageGroup.Name = "InicioRibbonPageGroup";
            this.InicioRibbonPageGroup.Text = "`";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 502);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1041, 37);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 539);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconosSharedImageCollection.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconosSharedImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup InicioRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem ClienteBarButtonItem;
        private DevExpress.Utils.SharedImageCollection IconosSharedImageCollection;
        private DevExpress.XtraBars.BarButtonItem ProveedoresBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ProductoBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem RespaldoBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem FacturaBarButtonItem;
    }
}