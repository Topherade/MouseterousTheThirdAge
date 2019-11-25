using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MouseterousTheThirdAge
{
    public class AttributeObject : INotifyPropertyChanged
    {
        public static string ImageURL { get; set; }
        public static string FlavorText { get; set; }
        public static string Name { get; set; }
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
    public class StrengthAttribute : AttributeObject 
    {
        public static new string Name { get; set; } = "Strength";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Strength.png";
    }
    public class DexterityAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Dexterity";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Dexterity.png";
    }
    public class IntelligenceAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Intelligence";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Intelligence.png";
    }
    public class WisdomAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Wisdom";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Wisdom.png";
    }
    public class SpirtualityAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Spirtuality";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Spirtuality.png";
    }
    public class CharismaAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Charisma";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Charisma.png";
    }
    public class ConstitutionAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Constitution";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Constitution.png";
    }
    public class LuckAttribute : AttributeObject
    {
        public static new string Name { get; set; } = "Luck";
        public static new string ImageURL { get; set; } = "/Assets/Attributes/Luck.png";
    }

    public class AttributeSet : INotifyPropertyChanged
    {
        private StrengthAttribute _Strength;
        private DexterityAttribute _Dexterity;
        private IntelligenceAttribute _Intelligence;
        private WisdomAttribute _Wisdom;
        private SpirtualityAttribute _Spirtuality;
        private CharismaAttribute _Charisma;
        private ConstitutionAttribute _Constitution;
        private LuckAttribute _Luck;
        public StrengthAttribute Strength 
        {
            get
            {
                return this._Strength;
            } 
            set
            {
                if(value != this._Strength)
                {
                    this._Strength = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public  DexterityAttribute Dexterity
        {
            get
            {
                return this._Dexterity;
            }
            set
            {
                if (value != this._Dexterity)
                {
                    this._Dexterity = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public  IntelligenceAttribute Intelligence
        {
            get
            {
                return this._Intelligence;
            }
            set
            {
                if (value != this._Intelligence)
                {
                    this._Intelligence = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public  WisdomAttribute Wisdom
        {
            get
            {
                return this._Wisdom;
            }
            set
            {
                if (value != this._Wisdom)
                {
                    this._Wisdom = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public SpirtualityAttribute Spirtuality
        {
            get
            {
                return this._Spirtuality;
            }
            set
            {
                if (value != this._Spirtuality)
                {
                    this._Spirtuality = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public  CharismaAttribute Charisma
        {
            get
            {
                return this._Charisma;
            }
            set
            {
                if (value != this._Charisma)
                {
                    this._Charisma = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public ConstitutionAttribute Constitution
        {
            get
            {
                return this._Constitution;
            }
            set
            {
                if (value != this._Constitution)
                {
                    this._Constitution = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public  LuckAttribute Luck
        {
            get
            {
                return this._Luck;
            }
            set
            {
                if (value != this._Luck)
                {
                    this._Luck = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public IEnumerable<AttributeObject> ToIEnumerableAttributeObject()
        {
            List<AttributeObject> attributeSet = new List<AttributeObject>();
            attributeSet.Add(this.Strength);
            attributeSet.Add(this.Dexterity);
            attributeSet.Add(this.Intelligence);
            attributeSet.Add(this.Wisdom);
            attributeSet.Add(this.Charisma);
            attributeSet.Add(this.Spirtuality);
            attributeSet.Add(this.Constitution);
            attributeSet.Add(this.Luck);
            return attributeSet;
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