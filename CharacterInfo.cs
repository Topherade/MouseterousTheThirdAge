using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MouseterousTheThirdAge
{
    public class CharacterInfo : INotifyPropertyChanged
    {
        private int _Health;
        private int _Paranoia;
        private int _Defense;
        private int _MagicDefense;
        private int _ParanoiaShield;
        private string _CharacterName;
        private string _ClanName;
        private AttributeSet _CharacterAttributes;
        public int Health
        {
            get
            {
                return this._Health;
            }
            set
            {
                if (value != this._Health)
                {
                    this._Health = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Paranoia
        {
            get
            {
                return this._Paranoia;
            }
            set
            {
                if (value != this._Paranoia)
                {
                    this._Paranoia = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int Defense
        {
            get
            {
                return this._Defense;
            }
            set
            {
                if (value != this._Defense)
                {
                    this._Defense = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int MagicDefense
        {
            get
            {
                return this._MagicDefense;
            }
            set
            {
                if (value != this._MagicDefense)
                {
                    this._MagicDefense = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int ParanoiaShield
        {
            get
            {
                return this._ParanoiaShield;
            }
            set
            {
                if (value != this._ParanoiaShield)
                {
                    this._ParanoiaShield = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string CharacterName
        {
            get
            {
                return this._CharacterName;
            }
            set
            {
                if (value != this._CharacterName)
                {
                    this._CharacterName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string ClanName
        {
            get
            {
                return this._ClanName;
            }
            set
            {
                if (value != this._ClanName)
                {
                    this._ClanName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public AttributeSet CharacterAttributes
        {
            get
            {
                return this._CharacterAttributes;
            }
            set
            {
                if (value != this._CharacterAttributes)
                {
                    this._CharacterAttributes = value;
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