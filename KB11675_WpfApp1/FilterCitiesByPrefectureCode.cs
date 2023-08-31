using Infragistics.Windows.DataPresenter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KB11675_WpfApp1;
internal class FilterCitiesByPrefectureCode : IMultiValueConverter
{
    /*
    values に渡されてくる中身
    <MultiBinding Converter="{StaticResource filterCitiesByPrefectureCode}" Mode="OneWay">
        <!-- DataContext（ここでのDataContextはDataRecord） -->
        <Binding/>
        <!-- 同じ行のPrefectureCode -->
        <Binding Path="DataItem.PrefectureCode"/>
    </MultiBinding>
     * */
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        // 渡されてきた values が期待した通りかどうかチェックし、
        // 期待していないものが来た場合は何もしない。
        if (values == null || values.Length != 2
            || values[0].GetType() != typeof(DataRecord)
            || values[1].GetType() != typeof(String))
        {
            return Binding.DoNothing;
        }

        // values から DataRecord と PrefectureCode を取得する。
        // さらに、DataRecord からパスをたどって XamDataGrid のデータコンテキストを取り出し、
        // そこから全ての市のリストを取得する。
        var dataRecord = (DataRecord)values[0];
        var prefectureCode = (String)values[1];
        var allCities = (dataRecord.DataPresenter.DataContext as MainWindowViewModel)?.Cities;

        // 同じ PrefectureCode の市のみを取り出し、返す。
        return allCities?.Where(city => city.PrefectureCode == prefectureCode).ToList() ?? Binding.DoNothing;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}