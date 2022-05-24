using ServiceLayer.API;

namespace PresentationLayer
{
    public class PresenationModel : ModelInterface
    {
        private ServiceInterface ModelService;
        public PresenationModel(ServiceInterface srv = default(ServiceInterface))
        {   

            this.ModelService = srv == null ? ServiceFactory.CreateService() : srv;
        }
        public ServiceInterface M_Service { get { return this.ModelService; } }
    }
}
