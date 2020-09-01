"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Mapper = void 0;
var CustomerCeditCardDetailsModel_1 = require("../models/CustomerCeditCardDetailsModel");
var Mapper = /** @class */ (function () {
    function Mapper() {
    }
    Mapper.mapCustomerCreditCardDetails = function (response) {
        var customerCreditCardDetails = new CustomerCeditCardDetailsModel_1.CustomerCreditCardDetailsModel;
        customerCreditCardDetails.firstName = response['firstName'];
        customerCreditCardDetails.lastName = response['lastName'];
        customerCreditCardDetails.annualIncome = response['annualIncome'];
        customerCreditCardDetails.dateofBirth = response['dateofBirth'];
        customerCreditCardDetails.bankName = response['bankName'];
        customerCreditCardDetails.cardType = response['cardType'];
        customerCreditCardDetails.apr = response['apr'];
        customerCreditCardDetails.message = response['message'];
        customerCreditCardDetails.image = response['image'];
        customerCreditCardDetails.isEligible = response['isEligible'];
        return customerCreditCardDetails;
    };
    return Mapper;
}());
exports.Mapper = Mapper;
//# sourceMappingURL=mapper.js.map