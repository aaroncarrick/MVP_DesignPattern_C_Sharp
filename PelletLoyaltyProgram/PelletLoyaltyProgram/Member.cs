using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PelletLoyaltyProgram
{
    public class Member
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string StartDate { get; set; }
        public int LifeTimePelletCount { get; set; }
        public int CurrentPelletCount { get; set; }
        public string Status { get; set; }
        public bool HasMetPelletThreshHold { get; set; }


        public Member()
        {
            Firstname = "";
            Lastname = "";
            PhoneNumber = "";
            StartDate = "";
            LifeTimePelletCount = 0;
            CurrentPelletCount = 0;
            Status = "";
            HasMetPelletThreshHold = false;
        }
    }
}
