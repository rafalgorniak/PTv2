using ServiceLayer.API;

namespace PresentationLayer.model
{
    public class PresenationModel : ModelInterface
    {
        private ServiceInterface ModelService;
        public PresenationModel(ServiceInterface srv = default(ServiceInterface))
        {   

            this.ModelService = srv == null ? Service_maker.CreateService() : srv;
        }
        public ServiceInterface M_Service { get { return this.ModelService; } }
    }
}
