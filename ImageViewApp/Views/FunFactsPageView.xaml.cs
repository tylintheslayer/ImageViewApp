using ImageViewApp.ViewModels;

namespace ImageViewApp.Views;

public partial class FunFactsPageView : ContentPage
{
    FunFactsPageViewModel _viewModel;

    public FunFactsPageView(FunFactsPageViewModel vm)
    {
        InitializeComponent();

        _viewModel = vm;

        BindingContext = _viewModel;
    }
}