using MFU_Accounting.BLL.Interfaces;
using MFU_Accounting.DAL.Interfaces;
using MFU_Accounting.Entities;

namespace MFU_Accounting.BLL
{
    public class ModelService : IModelService
    {
        private readonly IModelRepository _modelRepository;

        public ModelService(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public void AddModel(Model model)
        {
            _modelRepository.AddModel(model);
        }

        public List<Model> GetModels()
        {
            return _modelRepository.GetModels();
        }

        public void UpdateBrokenMinuse(int id)
        {
            _modelRepository.UpdateBrokenMinuse(id);
        }

        public void UpdateBrokenPlus(int id)
        {
            _modelRepository.UpdateBrokenPlus(id);
        }

        public void UpdateEmptyMinus(int id)
        {
            _modelRepository.UpdateEmptyMinus(id);
        }

        public void UpdateEmptyPlus(int id)
        {
            _modelRepository.UpdateEmptyPlus(id);
        }

        public void UpdateFueledMinus(int id)
        {
            _modelRepository.UpdateFueledMinus(id);
        }

        public void UpdateFueledPlus(int id)
        {
            _modelRepository.UpdateFueledPlus(id);
        }

        public void DeleteModel(int id)
        {
            _modelRepository.DeleteModel(id);
        }
    }
}
