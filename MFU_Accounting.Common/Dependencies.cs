using MFU_Accounting.BLL;
using MFU_Accounting.BLL.Interfaces;
using MFU_Accounting.DAL;
using MFU_Accounting.DAL.Interfaces;

namespace MFU_Accounting.Common
{
    public class Dependencies
    {
        private static IModelRepository _modelRepository;
        public static IModelRepository ModelRepository => _modelRepository ?? (new ModelRepository());

        private static IModelService _modelServce;
        public static IModelService ModelService => _modelServce ?? (new ModelService(ModelRepository));

    }
}