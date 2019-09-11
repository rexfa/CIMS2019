using System.Collections.Generic;
using CIMS2019.EF.Domain;

namespace CIMS2019.Services
{
    public interface ICustomerExpectationService
    {
        CustomerExpectation InsertCustomerExpectation(CustomerExpectation customerExpectation);
        void InsertLoanExtensionInformation(CustomerExpectation customerExpectation, 
            CCreditCardCarLoan cCreditCardCarLoan,
            IList<CLifeInsurance> cLifeInsurances,
            IList<CRealEstate> cRealEstates, 
            CustomerHired customerHired,
            CustomerSelfEmployed customerSelfEmployed);


    }
}
