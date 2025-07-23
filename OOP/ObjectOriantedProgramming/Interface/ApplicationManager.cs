using System.Collections.Generic;

namespace Interface
{
    // Başvuru manager
    internal class ApplicationManager
    {
        // Method injection
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {

            //Başvuran bilgilerini değerlendirme.

            // Böyle birşey yaparsak bütün başvuruları konut kredisine bağımlı hale getiriyoruz.
            //HousesCreditManager housesCreditManager = new HousesCreditManager();

            creditManager.Calculate();
            loggerService.Log();
        }

        public void DoCreditCardInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
