import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiService } from '../service/api.service';
import { Subscription } from 'rxjs';
import { CustomerCreditCardDetailsModel } from '../models/CustomerCeditCardDetailsModel';
import { Mapper } from '../utility/mapper';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  serviceSubscription: Subscription;
  customerCreditCardDetailsList: CustomerCreditCardDetailsModel[] = [];
  constructor(private apiService: ApiService,http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console.error(error));
  }

  ngOnInit() {

  }

  loadCustomerCreditCardDetails() {
    const api = "api/EligibilityCheck/saveEligibilityCheck";

    this.serviceSubscription = this.apiService.getData(api).subscribe(
      response => {
        if (response !== undefined && response !== null) {
          this.customerCreditCardDetailsList = Mapper.mapCustomerCreditCardDetailsList(response);
          
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
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
