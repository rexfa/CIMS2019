using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIMS2019.EF.Domain;
using CIMS2019.Models;
using CIMS2019.Services;
namespace CIMS2019.Controllers
{
    public class InfoCollectController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerExpectationService _customerExpectationService;
        public InfoCollectController(ICustomerService customerService,ICustomerExpectationService customerExpectationService)
        {
            _customerService = customerService;
            _customerExpectationService = customerExpectationService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(string str)
        {
            return Redirect("http://u.vivatech.cn/h/6601");
        }
        [HttpGet]
        public IActionResult CreateAll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAll(InputAllDataModel model)
        {
            DateTime dateTime = DateTime.Now;
            Customer customer = _customerService.GetCustomerByIDNumber(model.IDNumber);
            if (customer == null)
            {
                customer = new Customer()
                {
                    Avatar = "",
                    CreatedOn = dateTime,
                    CustomerName = model.CustomerName,
                    Fever = 0,
                    IDNumber = model.IDNumber,
                    IsDeleted = false,
                    LoginName = model.PhoneNumber,
                    CPassword = "000000",
                    PhoneNumber = model.PhoneNumber,
                    Salt = "0000"
                };
                _customerService.InsertCustomer(customer);
            }
            CustomerExpectation customerExpectation = new CustomerExpectation()
            {
                CreatedOn = dateTime,
                CustomerId = customer.Id,
                CustomerTypeId = (int)model.customerType,
                ExpectedLoanAmount = model.ExpectedLoanAmount,
                ExpectedLoanTime = model.ExpectedLoanTime,
                WorkingAddress = model.WorkingAddress,
                HavingCreditCardCarLoan = model.HavingCreditCardCarLoan,
                HavingLifeInsurance = model.HavingLifeInsurance,
                HavingRealEstate = model.HavingRealEstate
            };
            _customerExpectationService.InsertCustomerExpectation(customerExpectation);

            if (model.customerType == Models.Enum.CustomerType.工作)
            {
                CustomerHired customerHired = new CustomerHired()
                {
                    CEId = customerExpectation.Id,
                    CompanyName = model.CompanyName,
                    CreatedOn = dateTime,
                    HavingSIHF = model.HavingSIHF,
                    HousingFundBase =model.HousingFundBase,
                    SalaryAfterTax = model.SalaryAfterTax,
                    SocialInsuranceBase = model.SocialInsuranceBase
                };
                _customerExpectationService.InsertCustomerHired(customerHired);
            }
            else if (model.customerType == Models.Enum.CustomerType.自雇)
            {
                CustomerSelfEmployed customerSelfEmployed = new CustomerSelfEmployed()
                {
                    CEId = customerExpectation.Id,
                    CreatedOn = dateTime,
                    CompanyName = model.CompanyName,
                    AnnualTaxAmount = model.AnnualTaxAmount,
                    AnnualTurnover = model.AnnualTurnover,
                    AnnualVATInvoiceAmount = model.AnnualVATInvoiceAmount
                };
                _customerExpectationService.InsertCustomerSelfEmployed(customerSelfEmployed);
            }
            if(model.HavingCreditCardCarLoan)
            {
                CCreditCardCarLoan cCreditCardCarLoan = new CCreditCardCarLoan()
                {
                    CEId = customerExpectation.Id,
                    CreatedOn = dateTime,
                    MonthlyAmount = model.CCLMonthlyAmount
                };
                _customerExpectationService.InsertCCreditCardCarLoan(cCreditCardCarLoan);
            }
            if(model.HavingLifeInsurance)
            {                
                List<CLifeInsurance> cLives = new List<CLifeInsurance>();
                CLifeInsurance cLifeInsurance0 = new CLifeInsurance()
                {
                    CEId = customerExpectation.Id,
                    CreatedOn = dateTime,
                    AnnualPremium = model.AnnualPremium0,
                    EarliestEffectiveTime = model.EarliestEffectiveTime0,
                    LifeInsuranceCompany = model.LifeInsuranceCompany0
                };
                cLives.Add(cLifeInsurance0);
                if (model.AnnualPremium1 > 0.0M)
                {
                    CLifeInsurance cLifeInsurance1 = new CLifeInsurance()
                    {
                        CEId = customerExpectation.Id,
                        CreatedOn = dateTime,
                        AnnualPremium = model.AnnualPremium1,
                        EarliestEffectiveTime = model.EarliestEffectiveTime1,
                        LifeInsuranceCompany = model.LifeInsuranceCompany1
                    };
                    cLives.Add(cLifeInsurance1);
                }
                if (model.AnnualPremium2 > 0.0M)
                {
                    CLifeInsurance cLifeInsurance2 = new CLifeInsurance()
                    {
                        CEId = customerExpectation.Id,
                        CreatedOn = dateTime,
                        AnnualPremium = model.AnnualPremium2,
                        EarliestEffectiveTime = model.EarliestEffectiveTime2,
                        LifeInsuranceCompany = model.LifeInsuranceCompany2
                    };
                    cLives.Add(cLifeInsurance2);
                }
                _customerExpectationService.InsertCLifeInsurances(cLives);
            }
            if(model.HavingRealEstate)
            {
                CRealEstate cRealEstate = new CRealEstate()
                {
                    CEId = customerExpectation.Id,
                    BankName = model.BankName,
                    CreatedOn = dateTime,
                    LoanTypeId = (int)model.realEstateLoanType,
                    MonthlyPayment = model.MonthlyPayment,
                    NumberOfRepayments = model.NumberOfRepayments,
                    PropertyNatureId = (int)model.realEstatePropertyNature,
                    RealEstateAddress = model.RealEstateAddress,
                    RealEstateValue = model.RealEstateValue
                };
                _customerExpectationService.InsertCRealEstate(cRealEstate);
            }

            return Redirect("http://u.vivatech.cn/h/6601");
        }
    }
}