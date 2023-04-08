using System;
using System.Windows.Controls;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Commands;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.Model;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Venda.Iterativa.ViewModel
{
    internal sealed class ReceberViewModel : AbstractViewModel
    {
        private PedidoModel _pedido = new PedidoModel();

        public PedidoModel Pedido
        {
            get => _pedido;
            set => SetField(ref _pedido, value);
        }

        //private void TextBox_OnBeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        //{
        //    args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        //}

        public FinalizarPedidoCommand Finalizar { get; private set; } = new FinalizarPedidoCommand();

        public ReceberViewModel(UserControl userControl, IObserver observer, PedidoModel pedido) : base("UMFG | Receber")
        {
            UserControl = userControl;
            MainUserControl = observer;
            Pedido = pedido ?? throw new ArgumentNullException(nameof(pedido));

            Add(observer ?? throw new ArgumentNullException(nameof(observer)));
        }
          
    }
}
