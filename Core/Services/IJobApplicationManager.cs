using OOP_HRSystem.Core.Entities;

namespace OOP_HRSystem.Core.Services
{
    internal interface IJobApplicationManager
    {
        void AddApplication(Applicant applicant, int vacancyId);
        void RemoveApplication(Applicant applicant, int vacancyId);
    }
}