using KB11675_WpfApp1.Infrastructure;
using System;

namespace KB11675_WpfApp1.Model;
internal class City : ObservableObject
{
    private String _cityCode = "";

    public String CityCode
    {
        get { return _cityCode; }
        set { _cityCode = value; OnPropertyChanged(); }
    }

    private String _cityName = "";

    public String CityName
    {
        get { return _cityName; }
        set { _cityName = value; OnPropertyChanged(); }
    }

    private String _prefectureCode = "";

    public String PrefectureCode
    {
        get { return _prefectureCode; }
        set { _prefectureCode = value; OnPropertyChanged(); }
    }

    public City()
    {
    }
}
