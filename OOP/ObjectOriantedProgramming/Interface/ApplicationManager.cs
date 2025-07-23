using System.Collections.Generic;

namespace Interface
{
    // Başvuru manager
    internal class ApplicationManager
    {
        public void Apply(ICreditManager creditManager)
        {
            //Başvuran bilgilerini değerlendirme.

            // Böyle birşey yaparsak bütün başvuruları konut kredisine bağımlı hale getiriyoruz.
            //HousesCreditManager housesCreditManager = new HousesCreditManager();

            creditManager.Calculate();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
