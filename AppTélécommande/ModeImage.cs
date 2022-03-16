using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTélécommande
{
    /// <summary>
    /// Sélection de mode image 
    /// </summary>
    public class ModeImage
    {


        #region Constantes
        /// <summary>
        /// Valeur luminosité par défault
        /// </summary>
        public const int DÉFAUT_LUMINOSITÉ = 75;

        /// <summary>
        /// Valeur contraste par défault
        /// </summary>
        public const int DÉFAUT_CONTRASTE = 65;

        /// <summary>
        /// Valeur couleur par défault
        /// </summary>
        public const int DÉFAUT_COULEUR = 50;

        /// <summary>
        /// Valeur teinte par défault
        /// </summary>
        public const int DÉFAUT_TEINTE = 0;


        /// <summary>
        /// Valeur netteté par défault
        /// </summary>
        public const int DÉFAUT_NETTETÉ = 5;

        #endregion

        #region Champs
        /// <summary>
        /// Mémorise le contraste actuel
        /// </summary>
        private int m_contraste;

        /// <summary>
        /// Mémorise la couleur actuelle
        /// </summary>
        private int m_couleur;

        /// <summary>
        /// Mémorise la luminosité actuelle
        /// </summary>
        private int m_luminosité;

        /// <summary>
        /// Mémosire la netteté actuelle
        /// </summary>
        private int m_netteté;

        /// <summary>
        /// Mémorise la teinte actuelle
        /// </summary>
        private int m_teinte;
        #endregion

        #region Propriétés

        /// <summary>
        /// Obtient le contraste actuel et permet de lui définir un autre valeur.
        /// </summary>
        public int Contraste
        {
            get { return m_contraste; }
            set
            {
                ValiderValeur(0, 100, value);
                m_contraste = value;
            }
        }

        /// <summary>
        /// Obtient la couleur actuelle et permet de lui définir un autre valeur.
        /// </summary>
        public int Couleur
        {
            get { return m_couleur; }
            set
            {
                ValiderValeur(0, 100, value);
                m_couleur = value;
            }
        }


        /// <summary>
        /// Obtient la luminosité actuelle et permet de lui définir un autre valeur.
        /// </summary>
        public int Luminosité
        {
            get { return m_luminosité; }
            set
            {
                ValiderValeur(0, 100, value);
                m_luminosité = value;

            }
        }


        /// <summary>
        /// Obtient la netteté actuelle et permet de lui définir un autre valeur.
        /// </summary>
        public int Netteté
        {
            get { return m_netteté; }
            set
            {
                ValiderValeur(0, 10, value);
                m_netteté = value;
            }
        }

        /// <summary>
        /// Obtient le nom actuel.
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Obtient la teinte actuelle et permet de lui définir un autre valeur.
        /// </summary>
        public int Teinte
        {
            get { return m_teinte; }
            set
            {

                ValiderValeur(-10, 10, value);
                m_teinte = value;

            }
        }


        #endregion

        #region Constructeurs
        public ModeImage(string pNom)
        {
            Nom = pNom;
            m_contraste = DÉFAUT_CONTRASTE;
            m_couleur = DÉFAUT_COULEUR;
            m_luminosité = DÉFAUT_LUMINOSITÉ;
            m_netteté = DÉFAUT_NETTETÉ;
            m_teinte = DÉFAUT_TEINTE;
        }

        public ModeImage(string pNom, int pLuminosité, int pContraste, int pCouleur, int pTeinte, int pNetteté)
        {
            Nom = pNom;
            Contraste = pContraste;
            Couleur = pCouleur;
            Luminosité = pLuminosité;
            Netteté = pNetteté;
            Teinte = pTeinte;
        }


        #endregion


        #region Méthodes

        private void ValiderValeur(int pMin, int pMax, int pValeur)
        {
            if (pValeur > pMax || pValeur < pMin)
            {
                throw new ArgumentOutOfRangeException("Valeur pas dans la limite accepté!");
            }

        }


        #endregion


    }
}
