using System.ComponentModel;

namespace Playground.Wpf.Base
{
    /// <summary>
    /// Base class for Models which implements <see cref="INotifyPropertyChanged"/>
    /// </summary>
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };


        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
