using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RORApp.Model
{
    public class HorseStatus
    {
        public ResponseData ResponseData { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
      
    }

    public class ResponseData
    {
        public bool IsNameAvaialble;
        public Horse Horse { get; set; }
    }
    public class Horse
    {

        
        public string ASBID { get; set; }
        public string CountryName { get; set; }
        public string DamName { get; set; }
        public string DamCountry { get; set; }
        public string DamCountryABR { get; set; }

        public string SireName { get; set; }
        public string SireCountry { get; set; }
        public string SireCountryABR { get; set; }

        public DateTime? FoalDate { get; set; }
        public int Age;
        public string Sex { get; set; }

        public string ColourDescription { get; set; }
        public RegistrationStatusType RegistrationStatusType { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public string OverseasName { get; set; }
        public string NamePrev { get; set; }


        public string EndorsedPeriod { get; set; }
        public DateTime? EndorsedDate { get; set; }        
        public DateTime? VisaExpiryDate { get; set; }

        public int StatusCode { get; set; }
        public string StatusCodeStr { get; set; }

        public string Parentage { get; set; }

        public int? RegistrationNumber { get; set; }
        public string Name { get; set; }


        /// <summary>
        /// Gets or sets horse Trainer details 
        /// </summary>
        public string Trainer { get; set; }

        //public int? CountryCode { get; set; }

        //public int? ColourCode { get; set; }
        //public string LifeNumber { get; set; }
        //public string MicrochipNumberOne { get; set; }
        //public string MicrochipNumberTwo { get; set; }
        //public bool Blinkers { get; set; }
        //public string Breeder { get; set; }
        //public int? SireCode { get; set; }

        //public int? DamCode { get; set; }



        //public int? FoalYear { get; set; }
        //public string Comments { get; set; }
        //public string CommentStud1 { get; set; }
        //public string CommentStud2 { get; set; }



        //public int? GrandSireCode { get; set; }
        //public string GrandSireName { get; set; }
        //public string GrandSireCountry { get; set; }
        //public string GrandSireCountryABR { get; set; }
        //public int? YearToStud { get; set; }
        //public bool LockDownCheck { get; set; }
        //public bool ThoroughbredCheck { get; set; }
        //public string Class { get; set; }
        //public string EndorsedPeriod { get; set; }
        //public DateTime? EndorsedDate { get; set; }
        //public string RegistrationStatus { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        //public int? UserCode { get; set; }
        //public string CountryABR { get; set; }
        //public string HandicapComments { get; set; }
        //public DescribedEnum<RegistrationStatusEnum> RegistrationStatusType { get; set; }
        //public string Parentage { get; set; }
        //public string BreederType { get; set; }
        //public string PedigreeStatus { get; set; }
        //public DateTime? TicPrintedDate { get; set; }
        //public DateTime? CardPrintedDate { get; set; }
        //public DescribedEnum<UpdateTypeEnum> UpdateType { get; set; }
        //public bool ReinsExport { get; set; }
        //public bool Imported { get; set; }
        //public bool Exported { get; set; }
        //public DateTime? FateDate { get; set; }
        //public DescribedEnum<StudbookFateEnum> FateCode { get; set; }
        ////public DateTime? DiedDate { get; set; }
        //public int? FoalNumber { get; set; }
        //public DateTime? HorseAmendedDate { get; set; }



    }

    public class RegistrationStatusType
    {
        public int Value { get; set; }
        public string Code { get; set; }
        public string  Description { get; set; }


        
    }
}


