using WpfApp1.Bibliotheque.BusinessLogic;
using WpfApp1.Bibliotheque.DAL;
using WpfApp1.DAL;
using WpfApp1.DTO;

namespace WpfApp1.Tests
{
    public class HachageBusinessLogicTests

    {
        

        #region VerifMotDePasse
        [Fact]
        public async Task VerifMotDePasse_MotDePasse_RetourneVrai()
        {
            // Arrange
            string MotDePasse = "159";
            string MotDePasseHacher = "$2a$11$ASvLQsMtChy8x0vv2EDxz.ck5PZXnx5WhmXP";
            HachageBusinessLogic hachageBL=new HachageBusinessLogic();

            // Act
            bool estBonMotDePasse = hachageBL.VerifMotDePasse(MotDePasse,MotDePasseHacher);

            // Assert
            Assert.True(estBonMotDePasse);
        }
        #endregion

    }
}