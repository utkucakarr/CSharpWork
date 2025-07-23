using System;
using System.Collections.Generic;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemandCreditManager demandCreditManager = new DemandCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            HousesCreditManager housesCreditManager = new HousesCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(demandCreditManager);
            applicationManager.Apply(vehicleCreditManager);
            applicationManager.Apply(housesCreditManager);
            Console.WriteLine("*******************************************");

            // Liste olarak hesaplama yapmak için
            List<ICreditManager> creditManagers = new List<ICreditManager>() {demandCreditManager, vehicleCreditManager };

            applicationManager.KrediOnBilgilendirmesiYap(creditManagers);
        }
    }
}
