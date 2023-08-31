using Accessibility;
using KB11675_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB11675_WpfApp1.Model;
internal class PrefectureAndCity : ObservableObject
{
    private String _prefectureCode = "";

    public String PrefectureCode
    {
        get { return _prefectureCode; }
        set
        {
            if (_prefectureCode != value)
            {
                _prefectureCode = value;
                CityCode = "";
                OnPropertyChanged();
            }
        }
    }

    private String _cityCode = "";

    public String CityCode
    {
        get { return _cityCode; }
        set { _cityCode = value; OnPropertyChanged(); }
    }


    public PrefectureAndCity()
    {
    }
}