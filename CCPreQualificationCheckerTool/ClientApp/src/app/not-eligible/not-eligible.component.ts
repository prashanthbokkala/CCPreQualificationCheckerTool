import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { ApiService } from './../service/api.service';
import { Router } from '@angular/router';
import { EligibilityCheckerModel } from './../models/EligibilityCheckerModel';
import { catchError } from 'rxjs/operators';
import { Subscription, throwError } from 'rxjs';

@Component({
  selector: 'app-not-eligible',
  templateUrl: './not-eligible.component.html'
})
export class NotEligibleComponent {
}
