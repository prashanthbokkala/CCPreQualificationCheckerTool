import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { ApiService } from './../service/api.service';
import { Router } from '@angular/router';
import { EligibilityCheckerModel } from './../models/EligibilityCheckerModel';
import { catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';

@Component({
  selector: 'app-eligibility-checker',
  templateUrl: './eligibility-checker.component.html'
})
export class EligibilityCheckerComponent {
  eligibilityCheckerModel = new EligibilityCheckerModel();
  submitted = false;
    baseUrll: string;
  constructor(private apiService: ApiService, private router: Router, private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrll = baseUrl;
  }

  onSubmit() {
    const SERVER_URL = this.baseUrll + "api/CustomerDetails";
  //  this.submitted = true;
  //  //this.loading = true;
    const requestOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/x-www-form-urlencoded',
      })
    };
    let requestPayLoad: HttpParams = new HttpParams();
    requestPayLoad = requestPayLoad.append('Params', JSON.stringify(this.eligibilityCheckerModel));
    this.http.post<EligibilityCheckerModel[]>(SERVER_URL, requestPayLoad.toString(), requestOptions).subscribe(
      res => {
        this.router.navigate(['/counter']);
      },
      error => console.error(error));


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

  reset() {
    this.eligibilityCheckerModel = new EligibilityCheckerModel();
  }
}
