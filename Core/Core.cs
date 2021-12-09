using DatabaseContext;
using DatabaseModels;


namespace database
{
    public class Core
    {

        public Context context;

        public Core()
        {
            context = new Context();
        }

        public void AddToDB(string name, int id)
        {
            context.Add(new Doctor(id, name));
            context.SaveChanges();
        }

        public void AddToDB(string name)
        {
            context.Add(new Specialization(name));
            context.SaveChanges();
        }

        public void AddToDB(int id, string description, DateTime date)
        {
            context.Add(new Certificate(id, description, date.ToUniversalTime()));
            context.SaveChanges();
        }

        public void ChangeInDB(int id, string description, DateTime date, int changeId)
        {
            var certificate = context.Certificates
                .Where(c => c.Id == changeId)
                .FirstOrDefault();

            if(certificate != null)
            {
                certificate.Id = id;
                certificate.Description = description;
                certificate.Date = date;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("not valid index certificate");
            }
        }

        public void ChangeInDB(string name, int changeId)
        {
            var specialization = context.Specializations
                .Where(c => c.Id == changeId)
                .FirstOrDefault();

            if (specialization != null)
            {
                specialization.Name = name;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("not valid index specialization");
            }
        }

        public void ChangeInDB(string name, int id, int changeId)
        {
            var doctor = context.Doctors
                .Where(c => c.Id == changeId)
                .FirstOrDefault();

            if (doctor != null)
            {
                doctor.Name = name;
                doctor.Id = id;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("not valid index doctor");
            }
        }

        public void RemoveFromDb(object databaseItem, int removeId)
        {
            switch (databaseItem)
            {
                case "Doctor":
                    var doctor = context.Doctors
                        .Where(c => c.Id == removeId)
                        .FirstOrDefault();
                    if(doctor != null)
                        context.Doctors.Remove(doctor);
                    while (context.Certificates.Any(c => c.DoctorId == removeId))
                    {
                        var removeCertificate = context.Certificates.Where(c => c.DoctorId == removeId).FirstOrDefault();
                        if (removeCertificate != null)
                            RemoveFromDb("Certificate", removeCertificate.Id);
                    }
                    break;
                case "Specialization":
                    var specialization = context.Specializations
                        .Where(c => c.Id == removeId)
                        .FirstOrDefault();
                    if (specialization != null)
                        context.Specializations.Remove(specialization);
                    while(context.Doctors.Any(c => c.SpecializationId == removeId))
                    {
                        var removeDoctor = context.Doctors.Where(c => c.SpecializationId == removeId).FirstOrDefault();
                        if (removeDoctor != null)
                            RemoveFromDb("Doctor", removeDoctor.Id);
                    }
                    break;
                case "Certificate":
                    var certificate = context.Certificates
                        .Where(c => c.Id == removeId)
                        .FirstOrDefault();
                    if (certificate != null)
                        context.Certificates.Remove(certificate);
                    break;
            }
            context.SaveChanges();
        }

        public int SearchDoctors(int id)
        {
            return context.Doctors.Count(c => c.SpecializationId == id);
        }

        public string SearchSpecializations(int id)
        {
            var specialization = context.Specializations.Where(c => c.Id == id).FirstOrDefault();
            if (specialization != null)
                return specialization.Name;
            else
            {
                throw new Exception("No this id specialization");
            }
        }

        public DateTime SearchDate(int id)
        {
            var certificate = context.Certificates.Where(c => c.Id == id).FirstOrDefault();
            if (certificate != null)
                return certificate.Date;
            else
            {
                throw new Exception("No this id certificate");
            }
        }
    }
}