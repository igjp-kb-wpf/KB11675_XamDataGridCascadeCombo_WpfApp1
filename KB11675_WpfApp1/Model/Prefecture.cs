using KB11675_WpfApp1.Infrastructure;
using System;
using System.Windows.Documents;

namespace KB11675_WpfApp1.Model;
internal class Prefecture : ObservableObject
{
    private String _prefectureCode = "";

    public String PrefectureCode
    {
        get { return _prefectureCode; }
        set
        {
            _prefectureCode = value;
            OnPropertyChanged();
        }
    }

    private String _prefectureName = "";

    public String PrefectureName
    {
        get { return _prefectureName; }
        set { _prefectureName = value; OnPropertyChanged(); }
    }

    public Prefecture()
    {
    }
}
