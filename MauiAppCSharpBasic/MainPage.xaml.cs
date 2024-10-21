using MauiAppCSharpBasic.Classes;

namespace MauiAppCSharpBasic;

public partial class MainPage : ContentPage
{
	Car audi;
	Car nissan;
	bool isFinish = false;

	public MainPage()
	{
		InitializeComponent();

		audi = new Car("A1", 220, 10);
		audi.UsedFuelRate = 10;
		nissan = new Car("S1", 180, 3);
		nissan.UsedFuelRate = 8;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		// audi.Run(10);
		// nissan.Run(5);
		// myLabel.Text = audi.ShowInfo() + "\n" +nissan.ShowInfo();

		if(!this.isFinish)
		{
			var screenwidth = Application.Current.MainPage.Width;
			this.AudiRun(screenwidth);
			this.NissanRun(screenwidth);
			this.myLabel.Text = audi.ShowInfo() + "\n" + nissan.ShowInfo();
			this.isFinish = true;
		}
		else
		{
			ImageCar1.TranslateTo(0,0,0,Easing.Linear);
			ImageCar2.TranslateTo(0,0,0,Easing.Linear);
			this.isFinish = false;
		}
		
    }
	private void AudiRun (double distance)
	{
		var timeuse = audi.RaceTimeUsed(distance);
		ImageCar1.TranslateTo(distance-100,0,timeuse*1000,Easing.Linear);
	}
	
	private void NissanRun (double distance)
	{
		var timeuse = nissan.RaceTimeUsed(distance);
		ImageCar2.TranslateTo(distance-100,0,timeuse*1000,Easing.Linear);
	}
}

