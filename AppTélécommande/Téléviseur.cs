using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTélécommande
{
    public class Téléviseur
    {
        //  Canal
        public const int DÉFAUT_CANAL = 10;
        public const int MIN_CANAL = 2;
        public const int MAX_CANAL = 125;
        //  Volume
        public const int DÉFAUT_VOLUME = 15;
        public const int MIN_VOLUME = 0;
        public const int MAX_VOLUME = 50;
        // ModeImage
        public const int NB_MODE_IMAGE = 3;

        // Champs 
        int m_canal;
        int m_indexModeImage;
        int m_indexSource;
        ModeImage[] m_tabModeImage = 
        { 
            new ModeImage("Sport", 88, 57, 52, 0, 10), 
            new ModeImage("Jeu", 100, 72, 48, -2, 4), 
            new ModeImage("Cinéma", 77, 44, 40, 2, 1) 
        };
        string[] m_tabSources = { "HDMI 1", "HDMI 2","HDMI 3","Netflix","Prime","Crave","YouTube","TV"};
        int m_volume;

        // Proprietés
        public int Canal
        {
            get { return m_canal; }
            set {m_canal = value;}
        }

        public int IndexModeImage
        {
            get { return m_indexModeImage; }
            set { m_indexModeImage = value; }
        }


        public int IndexSource
        {
            get { return m_indexSource; }
            set { m_indexSource = value; }
        }

        public ModeImage ModeImageCourant
        {
            get { return m_tabModeImage[m_indexModeImage]; }
        }

        public int NbSources
        {
            get { return m_tabSources.Length; }
        }

        public string Source
        {
            get { return m_tabSources[m_indexSource]; }
        }

        public bool Sourdine { get; set; }

        public int Volume
        {
            get { return m_volume; }
            set { m_volume = value; }
        }


        // Constructeurs

        public Téléviseur()
        {
            m_canal = DÉFAUT_CANAL;
            m_volume = DÉFAUT_VOLUME;
            m_indexSource = 0;
            m_indexModeImage = 0;
            Sourdine = false;
        }

        public Téléviseur(int pCanal, int pVolume)
        {
            // Check du canal
            if (pCanal <= MAX_CANAL && pCanal >= MIN_CANAL)
                m_canal = pCanal;
            else
                throw new ArgumentOutOfRangeException();

            // Check du volume
            if (pVolume <= MAX_VOLUME && pVolume >= MIN_VOLUME)
                m_volume = pVolume;
            else
                throw new ArgumentOutOfRangeException();

            m_indexSource = 0;
            m_indexModeImage = 0;
            Sourdine = false;
        }

        public Téléviseur(int pCanal, int pVolume, int pIndexSource, int pIndexModeImage)
        {

            // Check du canal
            if (pCanal <= MAX_CANAL && pCanal >= MIN_CANAL)
                m_canal = pCanal;
            else
                throw new ArgumentOutOfRangeException();

            // Check du volume
            if (pVolume <= MAX_VOLUME && pVolume >= MIN_VOLUME)
                m_volume = pVolume;
            else
                throw new ArgumentOutOfRangeException();

            m_indexSource = pIndexSource;
            m_indexModeImage = pIndexModeImage;
            Sourdine = false;
        }

        // Méthodes



        #region Volume
        public void AugmenterVolume()
        {
            if (m_volume < MAX_VOLUME)
            {
                m_volume++;
                Sourdine = false;
            }
            else 
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void DiminuerVolume()
        {
            if (m_volume > MIN_VOLUME)
            {
                m_volume--;
                Sourdine = false;
            }
            else 
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region Canal
        public void AugmenterCanal()
        {
            Canal++;
            if (Canal == MAX_CANAL + 1) 
                Canal = 2;
            IndexSource = m_tabSources.Length - 1;
        }

        public void DiminuerCanal()
        {
            Canal--;
            if (Canal == MIN_CANAL - 1) 
                Canal = 125;
            IndexSource = m_tabSources.Length - 1;

        }
        #endregion

        #region Gestion des Images
        public void ModeImageSuivant()
        {
            if (m_indexModeImage < NB_MODE_IMAGE - 1)
                m_indexModeImage++;

            else
                m_indexModeImage = 0;
        }
        #endregion






    }
}
