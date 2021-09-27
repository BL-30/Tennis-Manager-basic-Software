using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;



namespace ClubTennis
{
    [TestClass]
    public class UnitTest1
    {
        protected double InitCout()
        {
            //Le cout est un double entre 30 et 60 €
            Random gen = new Random();
            return gen.Next(30, 60);
        }

        protected double InitCotisation(string villeM,string villeC,string Type,bool compet)
        {
            double cotisation = 0;

            if (villeM == villeC)
            {
                if (Type == "Enfant")
                {
                    cotisation = 130.0;
                }
                else
                {
                    cotisation = 200.0;
                }
            }
            else
            {
                if (Type == "Enfant")
                {
                    cotisation = 180.0;
                }
                else
                {
                    cotisation = 280.0;
                }

            }

            if (compet)
            {
                cotisation += 20;
            }
            return cotisation;


        }


        //test de la methode permettant d'assigner un cout aléatoire entre 30 et 60€ pour une competition
        [TestMethod]
        public void TestInitCout()
        {
            double res =InitCout();
            bool test = false;

            if(res>=30 && res < 60)
            {
                test = true;
            }

            Assert.IsTrue(test);
        }

        //test de la methode permettant de calculer la cotisation à payer en fonction de son adresse son age et si il est competiteur
        [TestMethod]
        public void TestInitCotisation()
        {
            double res = InitCotisation("Lyon","Lyon","Adulte",true);

            Assert.AreEqual(220, res);
        }
    }
}
