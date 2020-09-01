import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
//import { request } from 'http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private SERVER_URL = "http://localhost:44316/api/CustomerDetailsController/";
    RequestHeaders: HttpHeaders;
  baseUrll: string;

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.RequestHeaders = new HttpHeaders();
    this.baseUrll = baseUrl;
  }

  //errorHandler(error: HttpErrorResponse) {
  //  let errorMessage = 'Unknown error!';
  //  if (error.error instanceof ErrorEvent) {
  //    // Client-side errors
  //    errorMessage = `Error: ${error.error.message}`;
  //  } else {
  //    // Server-side errors
  //    errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
  //  }
  //  return throwError(errorMessage);
  //}

  //postData(serviceApi: any, params?: any): Observable<any> {
  //  let requestPayLoad: HttpParams = new HttpParams();
  //  //requestPayLoad = requestPayLoad.append('API', serviceApi);
  //  requestPayLoad = requestPayLoad.append('Params', JSON.stringify(params));

  //  const requestOptions = {
  //    headers: new HttpHeaders({
  //      'Content-Type': 'application/x-www-form-urlencoded',
  //    })
  //  };
  //  let urlll = this.baseUrll + serviceApi;
  //  return this.httpClient.post(serviceApi, requestPayLoad.toString(), requestOptions).pipe(
  //    catchError(error => {
  //      return throwError(error);
  //    }));
  //}

  postData(postData, serviceApi: any): Observable<any> {
    let urlll = this.baseUrll + serviceApi;
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.httpClient.post(urlll,
      JSON.stringify(postData), { responseType: 'json', headers });
  }
  getData(serviceApi: any): Observable<any[]> {
    let urlll = this.baseUrll + serviceApi;
    return this.httpClient.get(urlll) as Observable<any[]>;
  }
  //getData(serviceApi: any, params?: any): Observable<any> {


  //  http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
  //    this.forecasts = result;
  //  }, error => console.error(error));
  //}

  //public getCardTypeEligibleforCustomer(firstname: any, lastname: any, dob: any, annualIncome: any) {
  //  return this.httpClient.get(this.SERVER_URL + firstname + "/" + lastname + "/" + dob + "/" + annualIncome)
  //    .pipe(catchError(this.errorHandler));
  //}
}
