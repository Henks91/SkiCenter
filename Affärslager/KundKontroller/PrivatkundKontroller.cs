﻿using Datalager;
using Entiteter.Personer;

namespace Affärslager.KundKontroller
{
    public class PrivatkundKontroller
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public Privatkund RegistreraPrivatKund(string adress, string postnummer, string ort, string telefonnummer, string mailAdress, string personnummer, string förnamn, string efternamn)
        {
            Privatkund privatkund = new Privatkund(adress, postnummer, ort, telefonnummer, mailAdress, personnummer, förnamn, efternamn);
            unitOfWork.PrivatkundRepository.Add(privatkund);
            unitOfWork.Complete();
            return privatkund;
        }

        //public ICollection<Privatkund> SökPrivatKunder (Privatkund input)     Kan komma att användas senare i projektet.
        //{
        //return unitOfWork.PrivatkundRepository.Find(input);
        //}
        public Privatkund SökPrivatkund(string input)
        {
            return unitOfWork.PrivatkundRepository.FirstOrDefault(a => a.Personnummer.Equals(input));
        }

        public ICollection<Privatkund> LäsPrivatKunder()
        {
            return unitOfWork.PrivatkundRepository.GetAll().ToList();
        }

        public void UppdateraPrivatkund(Privatkund privatkund)
        {
            unitOfWork.PrivatkundRepository.Update(privatkund);

        }


    }
}
