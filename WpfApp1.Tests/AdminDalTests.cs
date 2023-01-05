using WpfApp1.DAL;
using WpfApp1.DTO;

namespace WpfApp1.Tests
{
    public class AdminDalTests
    {
        AdminDal adminDal = new AdminDal();

        #region Select
        [Fact]
        public void Select_InfoConnexion_RetourneAdminDto()
        {
            // Arrange
            InformationDeConnexionDTO informationDeConnexionDTO = new InformationDeConnexionDTO
            {
                Email = "bo@gmail.com",
                MotDePasse = "159"
            };

            // Act
            AdminDto adminDto = adminDal.Select(informationDeConnexionDTO);

            // Assert
            Assert.NotNull(adminDto);
        }
        
        [Fact]
        public void Select_InfoConnexionIncorrect_RetourneNull()
        {
            // Arrange
            InformationDeConnexionDTO informationDeConnexionDTO = new InformationDeConnexionDTO
            {
                Email = "inconnu",
                MotDePasse = "pouet"
            };

            // Act
            AdminDto adminDto = adminDal.Select(informationDeConnexionDTO);

            // Assert
            Assert.Null(adminDto);
        }

        #endregion
    }
}