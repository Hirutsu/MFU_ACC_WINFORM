using MFU_Accounting.Entities;

namespace MFU_Accounting.BLL.Interfaces
{
    public interface IModelService
    {
        void AddModel(Model model);
        List<Model> GetModels();
        void UpdateFueledPlus(int id);
        void UpdateFueledMinus(int id);
        void UpdateEmptyPlus(int id);
        void UpdateEmptyMinus(int id);
        void UpdateBrokenPlus(int id);
        void UpdateBrokenMinuse(int id);
        void DeleteModel(int id);
    }
}
