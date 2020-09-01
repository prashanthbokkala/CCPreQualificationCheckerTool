import { CustomerCreditCardDetailsModel } from "../models/CustomerCeditCardDetailsModel";

export class Mapper {
  static mapCustomerCreditCardDetails(response: CustomerCreditCardDetailsModel) {
    const customerCreditCardDetails = new CustomerCreditCardDetailsModel;
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
  }

  static mapCustomerCreditCardDetailsList(response: CustomerCreditCardDetailsModel[]) {
    const customerCreditCardDetailsList: CustomerCreditCardDetailsModel[] = [];
    if (response !== undefined && response !== null) {
      response.forEach(department => {
        const customerCreditCardDetails = new CustomerCreditCardDetailsModel();
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
        customerCreditCardDetailsList.push(customerCreditCardDetails);
      });
    }
    return customerCreditCardDetailsList;
  }
}
