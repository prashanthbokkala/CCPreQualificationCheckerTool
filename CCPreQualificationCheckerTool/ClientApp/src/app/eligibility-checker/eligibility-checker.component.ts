import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { ApiService } from './../service/api.service';
import { Router } from '@angular/router';
import { EligibilityCheckerModel } from './../models/EligibilityCheckerModel';
import { catchError } from 'rxjs/operators';
import { Subscription, throwError } from 'rxjs';
import { CustomerCreditCardDetailsModel } from '../models/CustomerCeditCardDetailsModel';
import { Mapper } from '../utility/mapper';
import { StoreData } from '../utility/store-data';

@Component({
  selector: 'app-eligibility-checker',
  templateUrl: './eligibility-checker.component.html'
})
export class EligibilityCheckerComponent {
  eligibilityCheckerModel = new EligibilityCheckerModel();
  submitted = false;
  baseUrll: string;
  serviceSubscription: Subscription;
  //customerCreditCardDetails = new CustomerCreditCardDetailsModel();
  constructor(private apiService: ApiService, private router: Router, private storeData: StoreData, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrll = baseUrl;
  }

  onSubmit() {
    const api = "api/EligibilityCheck/saveEligibilityCheck";

    this.serviceSubscription = this.apiService.postData(this.eligibilityCheckerModel, api).subscribe(
      response => {
        if (response !== undefined && response !== null) {
          this.storeData.customerCreditCardDetails = Mapper.mapCustomerCreditCardDetails(response);
          
          this.displayCards();
          //this.router.navigate(['/counter']);
          //this.successMessage = response as string;
          //this.departmentForm.reset();
          //this.loadDepartments();
        }
      },
      error => {
        console.log(error);
      }
    );

  //  const SERVER_URL = "https://localhost:44361/api/EligibilityCheck/saveEligibilityCheck";
  ////  this.submitted = true;
  ////  //this.loading = true;
  //  const requestOptions = {
  //    headers: new HttpHeaders({
  //      'Content-Type': 'application/x-www-form-urlencoded',
  //    })
  //  };
  //  let requestPayLoad: HttpParams = new HttpParams();
  //  requestPayLoad = requestPayLoad.append('Params', JSON.stringify(this.eligibilityCheckerModel));
  //  this.http.post<EligibilityCheckerModel[]>(SERVER_URL, requestPayLoad.toString(), requestOptions).subscribe(
  //    res => {
  //      this.router.navigate(['/counter']);
  //    },
  //    error => console.error(error));
    //tedt

    //const headers = new HttpHeaders().set('content-type', 'application/json');
    //var body = {
    //  Fname: emp.Fname, Lname: emp.Lname, Email: emp.Email
    //}

    //return this.http.post<EligibilityCheckerModel>(this.baseUrll + "api/CustomerDetails", body, { headers })  

  //  this.http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
  //    this.forecasts = result;
  //  }, error => console.error(error));
  //}

    //this.apiService.postData(SERVER_URL, this.eligibilityCheckerModel).subscribe(
    //  response => {
    //    alert('response');
    //    this.router.navigate(['/counter']);
    //  });
    // navigate to another form values on success
    //this.apiService.getCardTypeEligibleforCustomer(this.firstname.value, this.lastname.value,
    //  FormatDate(this.dateofbirth.value), this.annualincome.value).subscribe((data: any) => {
    //    this.loading = false;
        
    //  })
  }

  displayCards() {
    if (this.storeData.customerCreditCardDetails.isEligible) {
      this.router.navigate(['/eligible-cards']);
    }
    else {
      this.router.navigate(['/not-eligible']);
    }
  }

  reset() {
    this.eligibilityCheckerModel = new EligibilityCheckerModel();
  }

  ngOnDestroy() {
    if (this.serviceSubscription !== undefined && this.serviceSubscription !== null) {
      this.serviceSubscription.unsubscribe();
    }
  }
}
