using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KB11675_WpfApp1.Infrastructure;
internal class ObservableObject : INotifyPropertyChanged
{
#nullable enable
    protected ObservableObject()
    {

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] String? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

#nullable disable
}