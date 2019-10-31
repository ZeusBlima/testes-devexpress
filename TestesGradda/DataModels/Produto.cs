using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesGradda.DataModels
{
    class Produto : INotifyPropertyChanged
    {
        private string nome;
        private string codigoCategoria;
        private int quantidade;

        public int Id { get; set; }
        public int IdPai { get; set; }
        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                RaisePropertyChanged("Nome");
            }
        }
        public string CodigoCategoria
        {
            get => codigoCategoria;
            set
            {
                codigoCategoria = value;
                RaisePropertyChanged("CodigoCategoria");
            }
        }
        public int Quantidade
        {
            get => quantidade;
            set
            {
                quantidade = value;
                RaisePropertyChanged("Quantidade");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Produto(PropertyChangedEventHandler PropertyChangedEventHandler)
        {
            PropertyChanged += PropertyChangedEventHandler;
        }

        private void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
