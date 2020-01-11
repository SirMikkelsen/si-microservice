using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuveyApp.Model
{
    public class SuveyItem
    {
        public int ID { get; set; }
        public enum GeographicaLocation { DK, JP, US, DE };
        public enum Gender { Male, Female, other };
        public enum Age { Kids, Adult18, Adult26, Adult30, Adult40, Adult50, Old };
        public int NumberOFKids { get; set; }
        public int BookingEXperince { get; set; }
        public int SatisfactionWitHStaff { get; set; }
        public int SatisfactionWithFood { get; set; }
        public int SatisfactionWithCleaning { get; set; }
        public string OtherComments { get; set; }
    }
}
