using KB11675_WpfApp1.Infrastructure;
using KB11675_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB11675_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    // 都道府県のリストを保持するプロパティ
    private List<Prefecture> _prefectures;
    public List<Prefecture> Prefectures
    {
        get { return _prefectures; }
        set { _prefectures = value; OnPropertyChanged(); }
    }

    // すべての市区町村のリストを保持するプロパティ
    private List<City> _cities;
    public List<City> Cities
    {
        get { return _cities; }
        set { _cities = value; OnPropertyChanged(); }
    }

    private ObservableCollection<PrefectureAndCity> _prefecturesAndCities;
    public ObservableCollection<PrefectureAndCity> PrefecturesAndCities
    {
        get { return _prefecturesAndCities; }
        set { _prefecturesAndCities = value; }
    }

    public MainWindowViewModel()
    {
        _prefectures = new()
        {
            new() { PrefectureCode = "13", PrefectureName = "東京都"},
            new() { PrefectureCode = "14", PrefectureName = "神奈川県"},
            new() { PrefectureCode = "27", PrefectureName = "大阪府"},
        };

        _cities = new()
        {
            new() { CityCode = "13101", CityName = "千代田区", PrefectureCode = "13" },
            new() { CityCode = "13102", CityName = "中央区", PrefectureCode = "13" },
            new() { CityCode = "13103", CityName = "港区", PrefectureCode = "13" },
            new() { CityCode = "14100", CityName = "横浜市", PrefectureCode = "14" },
            new() { CityCode = "14130", CityName = "川崎市", PrefectureCode = "14" },
            new() { CityCode = "14150", CityName = "相模原市", PrefectureCode = "14" },
            new() { CityCode = "27100", CityName = "大阪市", PrefectureCode = "27" },
            new() { CityCode = "27140", CityName = "堺市", PrefectureCode = "27" },
            new() { CityCode = "27202", CityName = "岸和田市", PrefectureCode = "27" },
        };

        Random rnd = new Random();

        _prefecturesAndCities = new(Enumerable.Range(1, 50).Select(index =>
        {
            var city = _cities[rnd.Next(_cities.Count)];
            return new PrefectureAndCity()
            {
                PrefectureCode = city.PrefectureCode,
                CityCode = city.CityCode,
            };
        }).ToList<PrefectureAndCity>());
    }
}
