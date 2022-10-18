using ExempleImageBlob.Vues;

namespace ExempleImageBlob;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ImageVue();
	}
}
