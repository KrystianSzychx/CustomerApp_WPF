using CustomersAppWPF.Data;
using CustomersAppWPF.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;


namespace CustomersAppWPF.View
{
    public partial class CustomersView : UserControl
    {
        private CustomerViewModel _viewModel;

        public CustomersView()
        {
            InitializeComponent();
        }    
    }
}
