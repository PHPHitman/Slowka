using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Slowka;
using Slowka.WordClass;
namespace Tests
{

    [TestClass]
    public class Tests
    {

        /// <summary>
        /// Check fields are empty, if yes return true
        /// </summary>
        [TestMethod]

        public void CheckFieldsEmpty_FieldsAreEmpty_ReturnTrue()
        {

            string word = null, translate = null, choosenLang = null, choosenCat = null;
            AddWords addw = new AddWords();
            var result = addw.CheckAreFieldsEmpty(word, translate, choosenLang, choosenCat);

            Assert.IsTrue(result);

        }
        /// <summary>
        /// Check fields are empty, if not return false
        /// </summary>
        [TestMethod]

        public void CheckFieldsEmpty_FieldsAreFilled_ReturnFalse()
        {
            string word = "Bus", translate = "Autobus", choosenLang = "Angielski", choosenCat = "Przedmioty";
            AddWords addw = new AddWords();
            var result = addw.CheckAreFieldsEmpty(word, translate, choosenLang, choosenCat);

            Assert.IsFalse(result);
        }
        /// <summary>
        /// Save word into database
        /// If success return true
        /// 
        /// </summary>
        [TestMethod]

        public void SaveWord_WordIsSaved_ReturnTrue() 
        {
            string connstr = "Data Source=DESKTOP-0FF2I00;Initial Catalog=Slowka;Integrated Security=True";
            AddWords addw = new AddWords();
            UserWords word = new UserWords()
            {
                Slowko = "Plane",
                Tlumaczenie = "Samolot",
                Kategoria = "Przedmioty",
                Jezyk = "Angielski"
            };
            bool x = addw.SaveWord(word, connstr);
            Assert.IsTrue(x);
        }
    }
}
