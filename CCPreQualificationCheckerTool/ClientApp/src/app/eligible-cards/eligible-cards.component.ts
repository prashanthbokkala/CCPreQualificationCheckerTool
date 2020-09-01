import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { ApiService } from './../service/api.service';
import { Router } from '@angular/router';
import { EligibilityCheckerModel } from './../models/EligibilityCheckerModel';
import { catchError } from 'rxjs/operators';
import { Subscription, throwError } from 'rxjs';
import { StoreData } from '../utility/store-data';

@Component({
  selector: 'app-eligible-cards',
  templateUrl: './eligible-cards.component.html'
})
export class EligibleCardsComponent {
  constructor(private router: Router, private storeData: StoreData,) {
    
  }
  ngOnInit() {
    if (!this.storeData.customerCreditCardDetails) {
      this.router.navigate(['/home']);
    }
  }
}
