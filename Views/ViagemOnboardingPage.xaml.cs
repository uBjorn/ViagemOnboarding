using ProjetoViagemOnboarding.ViewModels;
namespace ProjetoViagemOnboarding.Views;

public partial class ViagemOnboardingPage : ContentPage
{
    public ViagemOnboardingPage(OnboardingViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}