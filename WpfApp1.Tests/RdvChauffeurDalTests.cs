using WpfApp1.Bibliotheque.DAL;
using WpfApp1.DAL;
using WpfApp1.DTO;

namespace WpfApp1.Tests
{
    public class RdvChauffeurDalTests
    {
        RdvChauffeurDal rdvDal = new RdvChauffeurDal();

        #region ListRvdChauffeur
        [Fact]
        public async Task ListRdv_RetourneRdv()
        {
            // Arrange

            // Act
            var rdvs = rdvDal.ListRvdChauffeur();

            // Assert
            Assert.True(rdvs.Any());
        }
        #endregion

    }
}