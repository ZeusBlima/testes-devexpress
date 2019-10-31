using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesGradda
{
    public partial class MainForm : Form
    {
        private List<DataModels.Produto> produtos;
        private List<DataModels.Categoria> categorias;
        public MainForm()
        {
            InitializeComponent();
            CarregarCategorias();
            CarregarProdutos();

        }

        private void CarregarProdutos()
        {
            produtos = new List<DataModels.Produto>();

            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 1, IdPai = 0, Nome = "Microondas", CodigoCategoria = "1", Quantidade = 0 });
            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 2, IdPai = 1, Nome = "Batedeira", CodigoCategoria = "1", Quantidade = 1 });

            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 3, IdPai = 1, Nome = "Mesa", CodigoCategoria = "2", Quantidade = 1 });
            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 4, IdPai = 0, Nome = "Cadeira", CodigoCategoria = "2", Quantidade = 2 });

            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 5, IdPai = 2, Nome = "Blusa", CodigoCategoria = "3", Quantidade = 3 });
            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 6, IdPai = 2, Nome = "Sapato", CodigoCategoria = "3", Quantidade = 5 });

            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 7, IdPai = 2, Nome = "Feijao", CodigoCategoria = "4", Quantidade = 8 });
            produtos.Add(new DataModels.Produto(produtos_PropertyChanged) { Id = 8, IdPai = 0, Nome = "Arroz", CodigoCategoria = "4", Quantidade = 13 });

            gridProdutos.DataSource = produtos;

            treeListProdutos.DataSource = produtos;
            
        }

        private void CarregarCategorias()
        {
            categorias = new List<DataModels.Categoria>();
            categorias.Add(new DataModels.Categoria() { Codigo = "1", Nome = "Eletrodomésticos" });
            categorias.Add(new DataModels.Categoria() { Codigo = "2", Nome = "Móveis" });
            categorias.Add(new DataModels.Categoria() { Codigo = "3", Nome = "Vestuário" });
            categorias.Add(new DataModels.Categoria() { Codigo = "4", Nome = "Alimentos" });

            rleCategoria.DataSource = categorias;
        }

        private void BtnIncrementar_Click(object sender, EventArgs e)
        {
            DataModels.Produto p = (DataModels.Produto)gridViewProdutos.GetFocusedRow();
            p.Quantidade++;
            gridViewProdutos.UpdateCurrentRow();
        }

        private void BtnIncTreeList_Click(object sender, EventArgs e)
        {
            DataModels.Produto p = (DataModels.Produto)treeListProdutos.GetFocusedRow();
            p.Quantidade++;
            treeListProdutos.Refresh();
        }

        private static void produtos_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }
    }
}
