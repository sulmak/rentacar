namespace rentacar.View;

public partial class MainPage : ContentPage
{

	ObservableCollection<BloodGroup> bloodGroups;	
	public MainPage()
	{
		InitializeComponent();


        bloodGroups=new ObservableCollection<BloodGroup>();
        bloodGroups.Add(new BloodGroup {Id="001" ,Code="",Description="A Positive"});
        bloodGroups.Add(new BloodGroup {Id="001" ,Code="B+",Description="B Positive"});
        bloodGroups.Add(new BloodGroup {Id="001" ,Code="AB+",Description="AB Positive"});
        bloodGroups.Add(new BloodGroup {Id="001" ,Code="O+",Description= "O Positive" });

        mylist.ItemsSource = bloodGroups;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        bloodGroups.Add(new BloodGroup { Id = "006", Code = "ABB+", Description = "A Positive" });
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Random rn = new Random();

        bloodGroups[0].Code = rn.Next(1,100).ToString();
        
       
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //mylist.ItemsSource = null;
        //mylist.ItemsSource = bloodGroups;
    }
}

public class BloodGroup : INotifyPropertyChanged
{
    public string Id { get; set; }
    public string Description { get; set; }


    private string _code=string.Empty;
    public string Code
    {
        get { return _code; }
        set
        {
            if (_code == value)
                return;
            _code = value;
            OnPropertyChanged(nameof(Code));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged(string name)
    {
        if (PropertyChanged == null)
            return;

        PropertyChanged(this, new PropertyChangedEventArgs(name));
    
    }
}

