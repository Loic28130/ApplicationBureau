using WpfApp1.DTO;

namespace WpfApp1.BusinessLogic
{
    public class ClientBusinessLogic
    {
        public void Inscription(ClientDto clientDto)
        {
            var clientDal = new ClientDAL();

            clientDal.Insert(clientDto);
        }
    }


}
