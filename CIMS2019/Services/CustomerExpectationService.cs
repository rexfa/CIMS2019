using System;
using System.Collections.Generic;
using System.Linq;
using CIMS2019.EF;
using CIMS2019.EF.Domain;

namespace CIMS2019.Services
{
    public class CustomerExpectationService : ICustomerExpectationService
    {
        private readonly MysqlContext _mysqlContext;
        private readonly EfRepository<CustomerExpectation> _customerExpectationRepository;
        private readonly EfRepository<CCreditCardCarLoan> _cCreditCardCarLoanRepository;
        private readonly EfRepository<CLifeInsurance> _cLifeInsuranceRepository;
        private readonly EfRepository<CRealEstate> _cRealEstateRepository;
        private readonly EfRepository<CustomerHired> _customerHiredRepository;
        private readonly EfRepository<CustomerSelfEmployed> _customerSelfEmployedRepository;

        public CustomerExpectationService(MysqlContext mysqlContext)
        {
            this._mysqlContext = mysqlContext;
            this._customerExpectationRepository = new EfRepository<CustomerExpectation>(this._mysqlContext);
            this._cCreditCardCarLoanRepository = new EfRepository<CCreditCardCarLoan>(this._mysqlContext);
            this._cLifeInsuranceRepository = new EfRepository<CLifeInsurance>(this._mysqlContext);
            this._cRealEstateRepository = new EfRepository<CRealEstate>(this._mysqlContext);
            this._customerHiredRepository = new EfRepository<CustomerHired>(this._mysqlContext);
            this._customerSelfEmployedRepository = new EfRepository<CustomerSelfEmployed>(this._mysqlContext);
        }
        public CustomerExpectation InsertCustomerExpectation(CustomerExpectation customerExpectation)
        {
            _customerExpectationRepository.Insert(customerExpectation);
            _mysqlContext.SaveChanges();
            return customerExpectation;
        }

        public void InsertLoanExtensionInformation(CustomerExpectation customerExpectation, CCreditCardCarLoan cCreditCardCarLoan, IList<CLifeInsurance> cLifeInsurances,
            IList<CRealEstate> cRealEstates, CustomerHired customerHired, CustomerSelfEmployed customerSelfEmployed)
        {
            throw new NotImplementedException();
        }
    }
}
