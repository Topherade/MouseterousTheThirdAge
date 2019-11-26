using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MouseterousTheThirdAge
{
    public class SkillsObject : INotifyPropertyChanged
    {

        public string _FlavorText;
        public string _SkillName;
        public string _Modifier;
        public string _BonusCard;
        public string _ImageURL;//to be added if pictures are going to be found / used
        private int _Value;
        public string FlavorText
        {
            get
            {
                return this._FlavorText;
            }
            set
            {
                if (value != this._FlavorText)
                {
                    this._FlavorText = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string SkillName
        {
            get
            {
                return this._SkillName;
            }
            set
            {
                if (value != this._SkillName)
                {
                    this._SkillName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Modifier
        {
            get
            {
                return this._Modifier;
            }
            set
            {
                if (value != this._Modifier)
                {
                    this._Modifier = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string BonusCard
        {
            get
            {
                return this._BonusCard;
            }
            set
            {
                if (value != this._BonusCard)
                {
                    this._BonusCard = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string ImageURL
        {
            get
            {
                return this._ImageURL;
            }
            set
            {
                if (value != this._ImageURL)
                {
                    this._ImageURL = value;
                    NotifyPropertyChanged();
                }
            }
        }
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