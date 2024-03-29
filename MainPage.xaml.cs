﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MouseterousTheThirdAge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public CharacterInfo gCharacterInfo;
        public MainPage()
        {
            this.InitializeComponent();
            setCharacterInfo();
            setMainPagBindings();

        }

        private void setCharacterInfo()
        {
            if (this.gCharacterInfo == null)
            {
                this.gCharacterInfo = new CharacterInfo();
            }
            SetAttributeInfo(this.gCharacterInfo);
            SetDefensesInfo(this.gCharacterInfo);
            SetProfessionInfo(this.gCharacterInfo);
        }
        private void SetAttributeInfo(CharacterInfo CharacterInfo)
        {
            Random randomNumGen = new Random();
            CharacterInfo.CharacterAttributes = new AttributeSet();
            CharacterInfo.CharacterAttributes.Strength = new StrengthAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Dexterity = new DexterityAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Intelligence = new IntelligenceAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Wisdom = new WisdomAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Spirtuality = new SpirtualityAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Charisma = new CharismaAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Constitution = new ConstitutionAttribute { Value = randomNumGen.Next(3, 18) };
            CharacterInfo.CharacterAttributes.Luck = new LuckAttribute { Value = randomNumGen.Next(3, 18) };
        }
        private void SetDefensesInfo(CharacterInfo gCharacterInfo)
        {
            Random randomNumGen = new Random();
            this.DataContext = gCharacterInfo;
            this.gCharacterInfo.Health = randomNumGen.Next(1, 999);
            this.gCharacterInfo.Paranoia = randomNumGen.Next(1, 999);
            this.gCharacterInfo.Defense = randomNumGen.Next(0, 999);
            this.gCharacterInfo.MagicDefense = randomNumGen.Next(0, 999);
            this.gCharacterInfo.ParanoiaShield = randomNumGen.Next(0, 999);
        }

        private void SetProfessionInfo(CharacterInfo gCharacterInfo)
        {
            Random randomNumGen = new Random();
            gCharacterInfo.CharacterProfession = new ProfessionObject();
            this.DataContext = gCharacterInfo.CharacterProfession;
            ProfessionLibrary lprofessionList = null;
            using (StreamReader r = new StreamReader("Assets/BaseData/ProfessionData.json"))
            {
                string json = r.ReadToEnd();
                lprofessionList = JsonConvert.DeserializeObject<ProfessionLibrary>(json);
            }
            ProfessionObject chosenProfession = lprofessionList.Professions[randomNumGen.Next(0, lprofessionList.Professions.Count - 1)];
            gCharacterInfo.CharacterProfession.BonusCard = chosenProfession.BonusCard;
            gCharacterInfo.CharacterProfession.FlavorText = chosenProfession.FlavorText;
            gCharacterInfo.CharacterProfession.ImageURL = chosenProfession.ImageURL;
            gCharacterInfo.CharacterProfession.Modifier = chosenProfession.Modifier;
            gCharacterInfo.CharacterProfession.Profession = chosenProfession.Profession;
            gCharacterInfo.CharacterProfession.Skill1 = chosenProfession.Skill1;
            gCharacterInfo.CharacterProfession.Skill2 = chosenProfession.Skill2;
        }



        private void setMainPagBindings()
        {
            Attributes.ItemsSource = gCharacterInfo.CharacterAttributes.ToIEnumerableAttributeObject();
            //todo figureout how to get initial values to load
        }

        private void ClanTabButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ItemsTabButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CharacterTabButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AbilitiesTabButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Head_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = gCharacterInfo;
            this.gCharacterInfo.ParanoiaShield = 0;
        }

        private void Body_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = gCharacterInfo;
            this.gCharacterInfo.Health = 0;
        }

        private void Pants_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Boots_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightWeapon_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = gCharacterInfo;
            this.gCharacterInfo.MagicDefense = 0;
        }

        private void LeftWeapon_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = gCharacterInfo;
            this.gCharacterInfo.Defense = 0;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Necklace_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Accessory2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Accessory1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
