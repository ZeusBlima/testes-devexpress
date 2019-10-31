namespace TestesGradda
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnIncrementar = new DevExpress.XtraEditors.SimpleButton();
            this.gridProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rleCategoria = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnIncTreeList = new DevExpress.XtraEditors.SimpleButton();
            this.treeListProdutos = new DevExpress.XtraTreeList.TreeList();
            this.colIdPai = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colId2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNome2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategoria2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQuantidade2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleCategoria)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(768, 514);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(762, 486);
            this.xtraTabPage1.Text = "GridView";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnIncrementar);
            this.groupControl1.Controls.Add(this.gridProdutos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(762, 486);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(645, 456);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(110, 23);
            this.btnIncrementar.TabIndex = 1;
            this.btnIncrementar.Text = "Incrementar Produto";
            this.btnIncrementar.Click += new System.EventHandler(this.BtnIncrementar_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.Location = new System.Drawing.Point(2, 20);
            this.gridProdutos.MainView = this.gridViewProdutos;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rleCategoria});
            this.gridProdutos.Size = new System.Drawing.Size(758, 464);
            this.gridProdutos.TabIndex = 0;
            this.gridProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNome,
            this.colCategoria,
            this.colQuantidade,
            this.colId});
            this.gridViewProdutos.GridControl = this.gridProdutos;
            this.gridViewProdutos.Name = "gridViewProdutos";
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 0;
            this.colNome.Width = 353;
            // 
            // colCategoria
            // 
            this.colCategoria.Caption = "Categoria";
            this.colCategoria.ColumnEdit = this.rleCategoria;
            this.colCategoria.FieldName = "CodigoCategoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 1;
            this.colCategoria.Width = 195;
            // 
            // rleCategoria
            // 
            this.rleCategoria.AutoHeight = false;
            this.rleCategoria.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rleCategoria.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colCodigo", "Código", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rleCategoria.DisplayMember = "Nome";
            this.rleCategoria.Name = "rleCategoria";
            this.rleCategoria.NullText = "";
            this.rleCategoria.ValueMember = "Codigo";
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Quantidade";
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.OptionsColumn.AllowEdit = false;
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 2;
            this.colQuantidade.Width = 194;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(762, 486);
            this.xtraTabPage2.Text = "TreeView";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnIncTreeList);
            this.groupControl2.Controls.Add(this.treeListProdutos);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(762, 486);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnIncTreeList
            // 
            this.btnIncTreeList.Location = new System.Drawing.Point(645, 456);
            this.btnIncTreeList.Name = "btnIncTreeList";
            this.btnIncTreeList.Size = new System.Drawing.Size(110, 23);
            this.btnIncTreeList.TabIndex = 2;
            this.btnIncTreeList.Text = "Incrementar Produto";
            this.btnIncTreeList.Click += new System.EventHandler(this.BtnIncTreeList_Click);
            // 
            // treeListProdutos
            // 
            this.treeListProdutos.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIdPai,
            this.colId2,
            this.colNome2,
            this.colCategoria2,
            this.colQuantidade2});
            this.treeListProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListProdutos.CustomizationFormBounds = new System.Drawing.Rectangle(558, 415, 260, 232);
            this.treeListProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListProdutos.KeyFieldName = "Id";
            this.treeListProdutos.Location = new System.Drawing.Point(2, 20);
            this.treeListProdutos.Name = "treeListProdutos";
            this.treeListProdutos.ParentFieldName = "IdPai";
            this.treeListProdutos.Size = new System.Drawing.Size(758, 464);
            this.treeListProdutos.TabIndex = 0;
            // 
            // colIdPai
            // 
            this.colIdPai.Caption = "IdPai";
            this.colIdPai.FieldName = "IdPai";
            this.colIdPai.Name = "colIdPai";
            // 
            // colId2
            // 
            this.colId2.Caption = "Id";
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 0;
            this.colId2.Width = 107;
            // 
            // colNome2
            // 
            this.colNome2.Caption = "Nome";
            this.colNome2.FieldName = "Nome";
            this.colNome2.Name = "colNome2";
            this.colNome2.Visible = true;
            this.colNome2.VisibleIndex = 1;
            this.colNome2.Width = 211;
            // 
            // colCategoria2
            // 
            this.colCategoria2.Caption = "Categoria";
            this.colCategoria2.ColumnEdit = this.rleCategoria;
            this.colCategoria2.FieldName = "CodigoCategoria";
            this.colCategoria2.Name = "colCategoria2";
            this.colCategoria2.Visible = true;
            this.colCategoria2.VisibleIndex = 2;
            this.colCategoria2.Width = 211;
            // 
            // colQuantidade2
            // 
            this.colQuantidade2.Caption = "Quantidade";
            this.colQuantidade2.FieldName = "Quantidade";
            this.colQuantidade2.Name = "colQuantidade2";
            this.colQuantidade2.OptionsColumn.AllowEdit = false;
            this.colQuantidade2.Visible = true;
            this.colQuantidade2.VisibleIndex = 3;
            this.colQuantidade2.Width = 211;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 514);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rleCategoria)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.TreeList treeListProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rleCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SimpleButton btnIncrementar;
        private DevExpress.XtraEditors.SimpleButton btnIncTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdPai;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNome2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoria2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQuantidade2;
    }
}

