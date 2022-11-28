namespace mobemboTestmobile.Controls;

public partial class MyShell : ShellContent
{
	public MyShell()
	{
		InitializeComponent();
	}
    public static readonly BindableProperty TextColorProperty =
  BindableProperty.Create("TextColor", typeof(Color), typeof(MyShell), null);


    public Color TextColor
    {
        get { return (Color)GetValue(TextColorProperty); }
        set { SetValue(TextColorProperty, value); }
    }
}
