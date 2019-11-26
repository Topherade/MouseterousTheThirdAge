using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MouseterousTheThirdAge
{
    public class ProfessionObject : INotifyPropertyChanged
    {
        public string _Profession;
        public string _Modifier;
        public string _BonusCard;
        public string _Skill1;
        public string _Skill2;
        public string _FlavorText;
        public string _ImageURL;//to be added if pictures are going to be found / used

        public string Profession
        {
            get
            {
                return this._Profession;
            }
            set
            {
                if (value != this._Profession)
                {
                    this._Profession = value;
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
        public string Skill1
        {
            get
            {
                return this._Skill1;
            }
            set
            {
                if (value != this._Skill1)
                {
                    this._Skill1 = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Skill2
        {
            get
            {
                return this._Skill2;
            }
            set
            {
                if (value != this._Skill2)
                {
                    this._Skill2 = value;
                    NotifyPropertyChanged();
                }
            }
        }
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
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class ProfessionLibrary
    {
        public List<ProfessionObject> Professions {get; set; }
    }
}