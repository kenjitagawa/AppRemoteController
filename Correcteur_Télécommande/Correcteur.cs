// Pour "activer" un groupe de tests, enlever le commentaire en avant du #define

#define TestsClasseModeImage
#define TestsClasseTéléviseur
//#define TestsFormulaire

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using AppTélécommande;

namespace TestTravailPratique2
{
    [TestClass]
    public class Correcteur
    {
        public static string m_version = "Correcteur H21.1.0";


        #region Attributs de tests supplémentaires

        #region Variables et propriétés
        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #endregion

        private static int m_totalScore;
        private static int m_maxScore;
        private static string[] m_tabSources = { "HDMI 1", "HDMI 2", "HDMI 3", "Netflix", "Prime", "Crave", "YouTube", "TV" };
        //ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            m_totalScore = 0;
            m_maxScore = 0;
        }
        //
        //ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            StreamWriter ficScore = new StreamWriter("../../../Score.txt");
            ficScore.Write("AppTélécommande" + "\n");
            ficScore.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            ficScore.Write("\nRésultat de la correction\n\nScore : " + m_totalScore + "/" + m_maxScore, Correcteur.m_version, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ficScore.Close();
        }

        #endregion

        #region Tests de la classe ModeImage
#if TestsClasseModeImage
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 1 paramètre de la classe ModeImage
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T01_MI_Constructeur1Param()
        {
            m_maxScore += 5;

            string nom = "XYZ";
            ModeImage target = new ModeImage(nom);
            Assert.AreEqual("XYZ", target.Nom);
            Assert.AreEqual(ModeImage.DÉFAUT_LUMINOSITÉ, target.Luminosité);
            Assert.AreEqual(ModeImage.DÉFAUT_CONTRASTE, target.Contraste);
            Assert.AreEqual(ModeImage.DÉFAUT_COULEUR, target.Couleur);
            Assert.AreEqual(ModeImage.DÉFAUT_TEINTE, target.Teinte);
            Assert.AreEqual(ModeImage.DÉFAUT_NETTETÉ, target.Netteté);
            m_totalScore += 5;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs valides
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T02_MI_Constructeur6Params()
        {
            m_maxScore += 10;

            ModeImage target = new ModeImage("XYZ",98,99,100,9,10);
            Assert.AreEqual("XYZ", target.Nom);
            Assert.AreEqual(98, target.Luminosité);
            Assert.AreEqual(99, target.Contraste);
            Assert.AreEqual(100, target.Couleur);
            Assert.AreEqual(9, target.Teinte);
            Assert.AreEqual(10, target.Netteté);
            m_totalScore += 2;


            target = new ModeImage("ABC", 100,0,1,10,0);
            Assert.AreEqual("ABC", target.Nom);
            Assert.AreEqual(100, target.Luminosité);
            Assert.AreEqual(0, target.Contraste);
            Assert.AreEqual(1, target.Couleur);
            Assert.AreEqual(10, target.Teinte);
            Assert.AreEqual(0, target.Netteté);
            m_totalScore += 2;

            target = new ModeImage("PCX", 0, 1, 2, -10, 5);
            Assert.AreEqual("PCX", target.Nom);
            Assert.AreEqual(0, target.Luminosité);
            Assert.AreEqual(1, target.Contraste);
            Assert.AreEqual(2, target.Couleur);
            Assert.AreEqual(-10, target.Teinte);
            Assert.AreEqual(5, target.Netteté);
            m_totalScore += 2;

            target = new ModeImage("ZQXD", 1, 100, 0, 0, 7);
            Assert.AreEqual("ZQXD", target.Nom);
            Assert.AreEqual(1, target.Luminosité);
            Assert.AreEqual(100, target.Contraste);
            Assert.AreEqual(0, target.Couleur);
            Assert.AreEqual(0, target.Teinte);
            Assert.AreEqual(7, target.Netteté);
            m_totalScore += 2;

            target = new ModeImage("allo", ModeImage.DÉFAUT_LUMINOSITÉ, ModeImage.DÉFAUT_CONTRASTE, ModeImage.DÉFAUT_COULEUR, ModeImage.DÉFAUT_TEINTE, ModeImage.DÉFAUT_NETTETÉ);
            Assert.AreEqual("allo", target.Nom);
            Assert.AreEqual(ModeImage.DÉFAUT_LUMINOSITÉ, target.Luminosité);
            Assert.AreEqual(ModeImage.DÉFAUT_CONTRASTE, target.Contraste);
            Assert.AreEqual(ModeImage.DÉFAUT_COULEUR, target.Couleur);
            Assert.AreEqual(ModeImage.DÉFAUT_TEINTE, target.Teinte);
            Assert.AreEqual(ModeImage.DÉFAUT_NETTETÉ, target.Netteté);
            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T03_MI_Const6ParamsLimitesLuminosité()
        {
            m_maxScore += 4;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", -1, 0, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 101, 0, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 4) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T04_MI_Const6ParamsLimitesContraste()
        {
            m_maxScore += 4;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, -1, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 101, 0, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 4) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T05_MI_Const6ParamsLimitesCouleur()
        {
            m_maxScore += 4;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, -1, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 101, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 4) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T06_MI_Const6ParamsLimitesTeinte()
        {
            m_maxScore += 4;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, -11, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 11, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 4) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur à 6 paramètres de la classe ModeImage avec des valeurs non valides
        ///</summary>
        [TestMethod()]
        public void T07_MI_Const6ParamsLimitesNetteté()
        {
            m_maxScore += 4;
            int pts = 0;

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, -1);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                ModeImage target = new ModeImage("", 0, 0, 0, 0, 11);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }


            if (pts != 4) Assert.Fail("ArgumentOutOfRangeException attendue");
            m_totalScore += pts;
        }
#endif
        #endregion

        #region Tests de la classe Téléviseur
#if TestsClasseTéléviseur
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur sans paramètre de la classe Téléviseur
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T08_TV_ConstructeurSansParam()
        {
            m_maxScore += 4;

            Téléviseur target = new Téléviseur();

            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME, target.Volume);
            Assert.AreEqual(false, target.Sourdine);
            Assert.AreEqual(0, target.IndexSource);
            Assert.AreEqual(0, target.IndexModeImage);
            Assert.AreEqual(m_tabSources[0], target.Source);
            Assert.IsTrue(ModeImageIdentique(PremierModeImage, target.ModeImageCourant));

            m_totalScore += 4;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 2 paramètres de la classe Téléviseur
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T17_TV_Constructeur2Params()
        {
            m_maxScore += 4;

            Téléviseur target = new Téléviseur(Téléviseur.DÉFAUT_CANAL,Téléviseur.DÉFAUT_VOLUME);
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME, target.Volume);
            m_totalScore += 1;

            target = new Téléviseur(Téléviseur.MAX_CANAL,Téléviseur.MAX_VOLUME);
            Assert.AreEqual(Téléviseur.MAX_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.MAX_VOLUME, target.Volume);
            m_totalScore += 1;

            target = new Téléviseur(Téléviseur.MIN_CANAL, Téléviseur.MIN_VOLUME);
            Assert.AreEqual(Téléviseur.MIN_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.MIN_VOLUME, target.Volume);
            m_totalScore += 1;

            Assert.AreEqual(false, target.Sourdine);
            Assert.AreEqual(0, target.IndexSource);
            Assert.AreEqual(0, target.IndexModeImage);
            Assert.AreEqual(m_tabSources[0], target.Source);

            Assert.IsTrue(ModeImageIdentique(PremierModeImage, target.ModeImageCourant));

            m_totalScore += 1;
        }
        private bool ModeImageIdentique(ModeImage pMode1,ModeImage pMode2)
        {
            if (pMode1.Nom != pMode2.Nom)
                return false;
            if (pMode1.Luminosité != pMode2.Luminosité)
                return false;
            if (pMode1.Contraste != pMode2.Contraste)
                return false;
            if (pMode1.Couleur != pMode2.Couleur)
                return false;
            if (pMode1.Teinte != pMode2.Teinte)
                return false;
            if (pMode1.Netteté != pMode2.Netteté)
                return false;
            return true;
        }
        private ModeImage PremierModeImage
        {
            get { return new ModeImage("Sport", 88, 57, 52, 0, 10); }
        }
        private ModeImage DeuxièmeModeImage
        {
            get { return new ModeImage("Jeu", 100, 72, 48, -2, 4); }
        }
        private ModeImage DernierModeImage
        {
            get { return new ModeImage("Cinéma", 77, 44, 40, 2, 1); }
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 2 paramètres pour le canal avec des valeurs hors limites
        ///</summary>
        [TestMethod()]
        public void T18_TV_Constructeur2ParamsLimiteCanal()
        {
            m_maxScore += 3;
            int pts = 0;
            Téléviseur target;

            try
            {
                target = new Téléviseur(Téléviseur.MAX_CANAL + 1, Téléviseur.DÉFAUT_VOLUME);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                target = new Téléviseur(Téléviseur.MIN_CANAL - 1, Téléviseur.DÉFAUT_VOLUME);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            if (pts != 3)
                Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 2 paramètres pour le volume avec des valeurs hors limites
        ///</summary>
        [TestMethod()]
        public void T19_TV_Constructeur2ParamsLimiteVolume()
        {
            m_maxScore += 3;
            int pts = 0;
            Téléviseur target;

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.MAX_VOLUME + 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.MIN_VOLUME - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            if (pts != 3)
                Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }


        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 4 paramètres de la classe Téléviseur
        /// Test également les accesseurs en lecture des propriétés
        ///</summary>
        [TestMethod()]
        public void T24_TV_Constructeur4Params()
        {
            m_maxScore += 5;

            Téléviseur target;

            target = new Téléviseur(Téléviseur.MAX_CANAL, Téléviseur.MAX_VOLUME, 0, 0);
            Assert.AreEqual(Téléviseur.MAX_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.MAX_VOLUME, target.Volume);

            target = new Téléviseur(Téléviseur.MIN_CANAL, Téléviseur.MIN_VOLUME, 0, 0);
            Assert.AreEqual(Téléviseur.MIN_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.MIN_VOLUME, target.Volume);

            Assert.AreEqual(false, target.Sourdine);
            Assert.AreEqual(0, target.IndexSource);
            Assert.AreEqual(0, target.IndexModeImage);
            Assert.AreEqual(m_tabSources[0], target.Source);
            Assert.IsTrue(ModeImageIdentique(PremierModeImage, target.ModeImageCourant));



            m_totalScore += 1;

            target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.DÉFAUT_VOLUME, m_tabSources.Length -1,0);
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME, target.Volume);
            Assert.AreEqual(false, target.Sourdine);
            Assert.AreEqual(m_tabSources.Length - 1, target.IndexSource);
            Assert.AreEqual(0, target.IndexModeImage);
            Assert.AreEqual(m_tabSources[m_tabSources.Length - 1], target.Source);
            Assert.IsTrue(ModeImageIdentique(PremierModeImage, target.ModeImageCourant));


            m_totalScore += 2;

            target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.DÉFAUT_VOLUME, 0, Téléviseur.NB_MODE_IMAGE - 1);
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL, target.Canal);
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME, target.Volume);
            Assert.AreEqual(false, target.Sourdine);
            Assert.AreEqual(0, target.IndexSource);
            Assert.AreEqual(Téléviseur.NB_MODE_IMAGE - 1, target.IndexModeImage);
            Assert.AreEqual(m_tabSources[0], target.Source);
            Assert.IsTrue(ModeImageIdentique(DernierModeImage, target.ModeImageCourant));


            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 4 paramètres pour le canal avec des valeurs hors limites
        ///</summary>
        [TestMethod()]
        public void T25_TV_Constructeur4ParamsLimiteCanal()
        {
            m_maxScore += 3;
            int pts = 0;
            Téléviseur target;

            try
            {
                target = new Téléviseur(Téléviseur.MAX_CANAL + 1, Téléviseur.DÉFAUT_VOLUME, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                target = new Téléviseur(Téléviseur.MIN_CANAL - 1, Téléviseur.DÉFAUT_VOLUME, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            if (pts != 3)
                Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 4 paramètres pour le volume avec des valeurs hors limites
        ///</summary>
        [TestMethod()]
        public void T26_TV_Constructeur4ParamsLimiteVolume()
        {
            m_maxScore += 3;
            int pts = 0;
            Téléviseur target;

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.MAX_VOLUME + 1, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.MIN_VOLUME - 1, 0, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            if (pts != 3)
                Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 4 paramètres pour la source avec des valeurs hors limites
        ///</summary>
        [TestMethod()]
        public void T27_TV_Constructeur4ParamsLimiteIndexSource()
        {
            m_maxScore += 3;
            int pts = 0;
            Téléviseur target;

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.DÉFAUT_VOLUME, -1, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.DÉFAUT_VOLUME, m_tabSources.Length, 0);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            if (pts != 3)
                Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Test du constructeur avec 4 paramètres pour la source avec des valeurs hors limites
        ///</summary>
        [TestMethod()]
        public void T28_TV_Constructeur4ParamsLimiteIndexModeImage()
        {
            m_maxScore += 3;
            int pts = 0;
            Téléviseur target;

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.DÉFAUT_VOLUME + 1, 0, -1);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            try
            {
                target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.DÉFAUT_VOLUME + 1, 0, Téléviseur.NB_MODE_IMAGE);
            }
            catch (ArgumentOutOfRangeException)
            {
                pts += 1;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }

            if (pts != 3)
                Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la propriété automatique Sourdine
        ///</summary>
        [TestMethod()]
        public void T09_TV_Sourdine()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur();
            target.Sourdine = true;
            Assert.AreEqual(true, target.Sourdine);
            target.Sourdine = false;
            Assert.AreEqual(false, target.Sourdine);
            m_totalScore += 2;
        }


        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour augmenter le volume ainsi que l'accesseur de la propriété
        /// Note : Augmenter le volume enlève automatiquement la sourdine
        ///</summary>
        [TestMethod()]
        public void T10_TV_AugmenterVolume()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur();
            target.Sourdine = true;
            target.AugmenterVolume();

            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME + 1, target.Volume);
            Assert.IsFalse(target.Sourdine);
            m_totalScore += 2;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour diminuer le volume ainsi que l'accesseur de la propriété
        ///</summary>
        [TestMethod()]
        public void T11_TV_DiminuerVolume()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur();

            target.DiminuerVolume();
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME - 1, target.Volume);
            m_totalScore += 2;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour augmenter le canal ainsi que l'accesseur de la propriété
        /// Note : Augmenter le canal force la source à devenir TV
        ///</summary>
        [TestMethod()]
        public void T12_TV_AugmenterCanal()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur();

            target.AugmenterCanal();
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL + 1, target.Canal);
            Assert.AreEqual(m_tabSources.Length - 1, target.IndexSource);

            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour diminuer le canal ainsi que l'accesseur de la propriété
        /// Note : Diminuer le canal force la source à devenir TV
        ///</summary>
        [TestMethod()]
        public void T13_TV_DimninuerCanal()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur();

            target.DiminuerCanal();
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL - 1, target.Canal);
            Assert.AreEqual(m_tabSources.Length - 1, target.IndexSource);

            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour augmenter le volume ainsi que l'accesseur de la propriété
        ///</summary>
        [TestMethod()]
        public void T20_TV_AugmenterVolumeLimite()
        {
            m_maxScore += 2;

            int pts = 0;
            Téléviseur target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.MAX_VOLUME);
            try
            {
                target.AugmenterVolume();
            }
            catch (ArgumentOutOfRangeException)
            {
                pts = 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }
            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour diminuer le volume ainsi que l'accesseur de la propriété
        ///</summary>
        [TestMethod()]
        public void T21_TV_DiminuerVolumeLimite()
        {
            m_maxScore += 2;

            int pts = 0;
            Téléviseur target = new Téléviseur(Téléviseur.DÉFAUT_CANAL, Téléviseur.MIN_VOLUME);
            try
            {
                target.DiminuerVolume();
            }
            catch (ArgumentOutOfRangeException)
            {
                pts = 2;
            }
            catch (Exception)
            {
                Assert.Fail("ArgumentOutOfRangeException attendue");
            }
            if (pts != 2) Assert.Fail("ArgumentOutOfRangeException attendue");

            m_totalScore += pts;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour augmenter le canal ainsi que l'accesseur de la propriété
        ///</summary>
        [TestMethod()]
        public void T22_TV_AugmenterCanalLimite()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur(Téléviseur.MAX_CANAL, Téléviseur.DÉFAUT_VOLUME);
            target.AugmenterCanal();
            Assert.AreEqual(Téléviseur.MIN_CANAL, target.Canal);
            m_totalScore += 2;
        }


        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la méthode pour diminuer le canal ainsi que l'accesseur de la propriété
        ///</summary>
        [TestMethod()]
        public void T23_TV_DiminuerCanalLimite()
        {
            m_maxScore += 2;
            Téléviseur target = new Téléviseur(Téléviseur.MIN_CANAL, Téléviseur.DÉFAUT_VOLUME);
            target.DiminuerCanal();
            Assert.AreEqual(Téléviseur.MAX_CANAL, target.Canal);
            m_totalScore += 2;
        }


        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le passage au deuxième mode image 
        ///</summary>
        [TestMethod()]
        public void T14_TV_PasserAuDeuxièmeMode()
        {
            m_maxScore += 2;

            Téléviseur target = new Téléviseur();

            target.ModeImageSuivant();
            Assert.AreEqual("Jeu", target.ModeImageCourant.Nom);
            Assert.AreEqual(100, target.ModeImageCourant.Luminosité);
            Assert.AreEqual(72, target.ModeImageCourant.Contraste);
            Assert.AreEqual(48, target.ModeImageCourant.Couleur);
            Assert.AreEqual(-2, target.ModeImageCourant.Teinte);
            Assert.AreEqual(4, target.ModeImageCourant.Netteté);

            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le passage au troisième mode image
        ///</summary>
        [TestMethod()]
        public void T15_TV_PasserAuTroisièmeMode()
        {
            m_maxScore += 2;

            Téléviseur target = new Téléviseur();

            target.ModeImageSuivant();
            target.ModeImageSuivant();
            Assert.AreEqual("Cinéma", target.ModeImageCourant.Nom);
            Assert.AreEqual(77, target.ModeImageCourant.Luminosité);
            Assert.AreEqual(44, target.ModeImageCourant.Contraste);
            Assert.AreEqual(40, target.ModeImageCourant.Couleur);
            Assert.AreEqual(2, target.ModeImageCourant.Teinte);
            Assert.AreEqual(1, target.ModeImageCourant.Netteté);

            m_totalScore += 2;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le retour au premier mode image
        ///</summary>
        [TestMethod()]
        public void T16_TV_RetourAuPremimerMode()
        {
            m_maxScore += 2;

            Téléviseur target = new Téléviseur();

            target.ModeImageSuivant();
            target.ModeImageSuivant();
            target.ModeImageSuivant();
            Assert.AreEqual("Sport", target.ModeImageCourant.Nom);
            Assert.AreEqual(88, target.ModeImageCourant.Luminosité);
            Assert.AreEqual(57, target.ModeImageCourant.Contraste);
            Assert.AreEqual(52, target.ModeImageCourant.Couleur);
            Assert.AreEqual(0, target.ModeImageCourant.Teinte);
            Assert.AreEqual(10, target.ModeImageCourant.Netteté);

            m_totalScore += 2;
        }
#endif
        #endregion

        #region Tests du formulaire principal
#if TestsFormulaire
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste l'état initial du formulaire principal
        ///</summary>
        [TestMethod()]
        public void T29_Frm_ÉtatInitial()
        {
            m_maxScore += 2;
            FrmPrincipal target = new FrmPrincipal();

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("OFF", target.lblÉtatSourdine.Text);
            Assert.AreEqual(target.LeTéléviseur.Canal, target.vsiCanal.Value);
            Assert.AreEqual(target.LeTéléviseur.Volume, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            m_totalScore += 2;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste l'état initial du formulaire principal
        ///</summary>
        [TestMethod()]
        public void T30_Frm_ModifierLaSource()
        {
            m_maxScore += 2;
            FrmPrincipal target = new FrmPrincipal();
            target.Show();

            target.cboSourceCourante.SelectedIndex = 1;

            Assert.AreEqual(1, target.LeTéléviseur.IndexSource);
            Assert.AreEqual(target.cboSourceCourante.Text, target.LeTéléviseur.Source);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("OFF", target.lblÉtatSourdine.Text);
            Assert.AreEqual(target.LeTéléviseur.Canal, target.vsiCanal.Value);
            Assert.AreEqual(target.LeTéléviseur.Volume, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);
            target.Hide();

            m_totalScore += 2;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le passage au prochain mode
        ///</summary>
        [TestMethod()]
        public void T31_Frm_PasserAuProchainMode()
        {
            m_maxScore += 2;

            FrmPrincipal target = new FrmPrincipal();

            for (int cpt = 0; cpt < Téléviseur.NB_MODE_IMAGE; cpt++)
            {
                target.BtnModeImageSuivant_Click(target, EventArgs.Empty);

                Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
                Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
                Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
                Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
                Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
                Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);
            }

            m_totalScore += 2;
        }
        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste la mémorisation des ajustements du ModeImage courant
        ///</summary>
        [TestMethod()]
        public void T32_Frm_MémoriserLesAjustements()
        {
            m_maxScore += 1;
            FrmPrincipal target = new FrmPrincipal();

            target.vsiLuminosité.Value = 3;
            target.vsiContraste.Value = 6;
            target.vsiCouleur.Value = 9;
            target.vsiTeinte.Value = -4;
            target.vsiNetteté.Value = 8;

            target.BtnMémoriser_Click(target, EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            m_totalScore += 1;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste les boutons pour augmenter et diminuer le volume
        ///</summary>
        [TestMethod()]
        public void T33_Frm_AugmenterDiminuerVolume()
        {
            m_maxScore += 1;
            FrmPrincipal target = new FrmPrincipal();

            target.LeTéléviseur.Sourdine = true;
            target.BtnVolumePlus_Click(target,EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("OFF", target.lblÉtatSourdine.Text);
            Assert.AreEqual(target.LeTéléviseur.Canal, target.vsiCanal.Value);
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME + 1, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            target.LeTéléviseur.Sourdine = true;
            target.BtnVolumeMoins_Click(target,EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("ON", target.lblÉtatSourdine.Text);
            Assert.AreEqual(target.LeTéléviseur.Canal, target.vsiCanal.Value);
            Assert.AreEqual(Téléviseur.DÉFAUT_VOLUME, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            m_totalScore += 1;
        }


        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste les boutons pour augmenter et diminuer le volume
        ///</summary>
        [TestMethod()]
        public void T34_Frm_AugmenterDiminuerCanal()
        {
            m_maxScore += 1;
            FrmPrincipal target = new FrmPrincipal();

            target.BtnCanalPlus_Click(target, EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("OFF", target.lblÉtatSourdine.Text);
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL + 1, target.vsiCanal.Value);
            Assert.AreEqual(target.LeTéléviseur.Volume, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            target.BtnCanalMoins_Click(target, EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("OFF", target.lblÉtatSourdine.Text);
            Assert.AreEqual(Téléviseur.DÉFAUT_CANAL, target.vsiCanal.Value);
            Assert.AreEqual(target.LeTéléviseur.Volume, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            m_totalScore += 1;
        }

        ///-------------------------------------------------------------------------------
        /// <summary>
        /// Teste le fonctionnement du bouton sourdine
        ///</summary>
        [TestMethod()]
        public void T35_Frm_ModifierLétatDeLaSourdine()
        {
            m_maxScore += 1;
            FrmPrincipal target = new FrmPrincipal();

            target.BtnSourdine_Click(target, EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("ON", target.lblÉtatSourdine.Text);
            Assert.AreEqual(target.LeTéléviseur.Canal, target.vsiCanal.Value);
            Assert.AreEqual(target.LeTéléviseur.Volume, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            target.BtnSourdine_Click(target, EventArgs.Empty);

            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Nom, target.lblNomModeImage.Text);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Luminosité, target.vsiLuminosité.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Contraste, target.vsiContraste.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Couleur, target.vsiCouleur.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Teinte, target.vsiTeinte.Value);
            Assert.AreEqual(target.LeTéléviseur.ModeImageCourant.Netteté, target.vsiNetteté.Value);

            Assert.AreEqual("OFF", target.lblÉtatSourdine.Text);
            Assert.AreEqual(target.LeTéléviseur.Canal, target.vsiCanal.Value);
            Assert.AreEqual(target.LeTéléviseur.Volume, target.vsiVolume.Value);
            Assert.AreEqual(target.LeTéléviseur.Source, target.cboSourceCourante.Text);

            m_totalScore += 1;
        }
#endif
        #endregion
    }
}
