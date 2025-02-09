﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using soins;


namespace ClassesMetier
{
    public class Intervenant
    {
        protected string nom;
        protected string prenom;

        //Constructeur
        public  Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        //Property
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}

        //Méthode
        public override string ToString()
        {
            return " Intervenant : " + Nom + " - " + Prenom;
        }
        public int GetNbPrestation(List<Prestations> ext)
        {
            return ext.Count;
        }
        public int GetNbPrestationsIE(List<Prestations> ext)
        {
            int i = 0;
            foreach (Prestations prestation in ext)
            {
                if (prestation.IntervenantExterne is IntervenantExterne)
                {
                    i++;
                }
            }
            return i;
        }

    }

    
    
}
