using MFU_Accounting.Entities;

namespace MFU_Accounting.DAL.Interfaces
{
    public interface IModelRepository
    {
        void AddModel(Model model);
        List<Model> GetModels();
        void UpdateFueledPlus(int id);
        void UpdateFueledMinus(int id);
        void UpdateBrokenMinuse(int id);
        void UpdateBrokenPlus(int id);
        void UpdateEmptyMinus(int id);
        void UpdateEmptyPlus(int id);
        void DeleteModel(int id);
    }
}
