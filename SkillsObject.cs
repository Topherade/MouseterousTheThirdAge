using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MouseterousTheThirdAge
{
    public class SkillsObject : INotifyPropertyChanged
    {

        public static string FlavorText { get; set; }
        public static string SkillName { get; set; }
        public static AttributeObject Modifier { get; set; }
        public static string BonusCard { get; set; }
        public static string ImageURL { get; set; }//to be added if pictures are going to be found / used



        private int _Value;
        public int Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                if (value != this._Value)
                {
                    this._Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}