using HealthSystemManager.Domain.DTO;
using HealthSystemManager.Domain.IRepositories;
using HealthSystemManager.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemManager.Application.Service.SQLServerServices
{
    public class MedicalRecordService : IMedicalRecordsService
    {
        private readonly IMedicalRecordsRepository _repository;

        public MedicalRecordService(IMedicalRecordsRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<MedicalRecordDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(medicalRecord => new MedicalRecordDTO
                {
                    id = medicalRecord.Id,
                    diagnostic = medicalRecord.Diagnostic,
                    medicalAppointment = medicalRecord.MedicalAppointment,
                    medication = medicalRecord.Medication,
                    exam = medicalRecord.Exam,
                    patientId = medicalRecord.PatientId,
                    patient = medicalRecord.Patient
                }).ToList();
        }

        public List<MedicalRecordDTO> FindAllRecords(int id)
        {
            var result = _repository.FindAll()
                .Where(m => m.PatientId == id)                
                .Select(medicalRecord => new MedicalRecordDTO
                {
                    id = medicalRecord.Id,
                    diagnostic = medicalRecord.Diagnostic,
                    medicalAppointment = medicalRecord.MedicalAppointment,
                    medication = medicalRecord.Medication,
                    exam = medicalRecord.Exam,
                    patientId = medicalRecord.PatientId,
                    patient = medicalRecord.Patient,
                })
                .ToList();
            if(result.Count > 0)
                return result;

            return new List<MedicalRecordDTO>();
        }

        public async Task<MedicalRecordDTO> FindById(int id)
        {
            var entity = new MedicalRecordDTO();
            return entity.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(MedicalRecordDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
    }
}
