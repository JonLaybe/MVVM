using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace WpfApp22
{
    class ViewModel : INotifyPropertyChanged
    {
        Model model;
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            model = new Model();
        }

        void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _text;
        private string _text2;
        private byte _r, _g, _b;
        SolidColorBrush _solidColor;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                Text2 = model.Reverce(_text);
                Notify("Text");
            }
        }
        public string Text2
        {
            get { return _text2; }
            set
            {
                _text2 = value;
                Notify("Text2");
            }
        }
        public byte R
        {
            get { return _r; }
            set
            {
                _r = value;
                SolorColor = new SolidColorBrush(Color.FromRgb(_r, _g, _b));
                Notify("R");
            }
        }
        public byte G
        {
            get { return _g; }
            set
            {
                _g = value;
                SolorColor = new SolidColorBrush(Color.FromRgb(_r, _g, _b));
                Notify("G");
            }
        }
        public byte B
        {
            get { return _b; }
            set
            {
                _b = value;
                SolorColor = new SolidColorBrush(Color.FromRgb(_r, _g, _b));
                Notify("B");
            }
        }
        public SolidColorBrush SolorColor
        {
            get { return _solidColor; }
            set
            {
                _solidColor = value;
                Notify("SolorColor");
            }
        }
        public ICommand ButtonClick
        {
            get { return new ButtonCommand(new Action(() =>
            {
                MessageBox.Show("Hello world)");
            }));
            }
        }
        public ICommand ButtonClick2
        {
            get
            {
                return new ButtonCommand(new Action(() =>
                {
                    MessageBox.Show("Hello world(");
                }));
            }
        }
    }
}
