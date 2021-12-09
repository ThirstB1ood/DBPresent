using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Certificate
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public Certificate(
            int doctorId,
            string description,
            DateTime date)
        {
            DoctorId = doctorId;
            Description = description;
            Date = date;
        }


    }
}
