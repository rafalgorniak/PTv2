using System;
using PresentationLayer.viewmodel;
using PresentationLayer.model;
using System.Windows;

namespace PresentationLayer
{
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (s, e) => DataContext = viewModel;
        }
    }
}
