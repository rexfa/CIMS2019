using System.Collections.Generic;
using CIMS2019.EF.Domain;

namespace CIMS2019.Services
{
    public interface ICustomerExpectationService
    {
        CustomerExpectation InsertCustomerExpectation(CustomerExpectation customerExpectation);
        void InsertCCreditCardCarLoan(CCreditCardCarLoan cCreditCardCarLoan);
        void InsertCLifeInsurances(IList<CLifeInsurance> cLifeInsurances);
        void InsertCRealEstate(CRealEstate cRealEstate);
        void InsertCustomerHired(CustomerHired customerHired);
        void InsertCustomerSelfEmployed(CustomerSelfEmployed customerSelfEmployed);
        void InsertLoanExtensionInformation( 
            CCreditCardCarLoan cCreditCardCarLoan,
            IList<CLifeInsurance> cLifeInsurances,
            IList<CRealEstate> cRealEstates, 
            CustomerHired customerHired,
            CustomerSelfEmployed customerSelfEmployed);
        IList<CustomerExpectation> GetCustomerExpectations();

    }
}
