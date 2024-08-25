

using eAppointment.Domain.Entities;
using eAppointment.Domain.Repositories;
using eAppointment.Infrastructure.Context;
using GenericRepository;

namespace eAppointment.Infrastructure.Repositories
{
    internal class AppointmentRepository:Repository<Appointment,ApplicationDbContext>,IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
    internal class PatientRepository : Repository<Patient, ApplicationDbContext>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
    internal class DoctorRepository : Repository<Doctor, ApplicationDbContext>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
