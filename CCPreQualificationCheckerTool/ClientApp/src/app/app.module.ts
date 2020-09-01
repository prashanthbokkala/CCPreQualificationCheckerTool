import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { EligibilityCheckerComponent } from './eligibility-checker/eligibility-checker.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { NotEligibleComponent } from './not-eligible/not-eligible.component';
import { EligibleCardsComponent } from './eligible-cards/eligible-cards.component';
import { StoreData } from './utility/store-data';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    EligibilityCheckerComponent,
    FetchDataComponent,
    NotEligibleComponent,
    EligibleCardsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'eligibility-checker', component: EligibilityCheckerComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'not-eligible', component: NotEligibleComponent },
      { path: 'eligible-cards', component: EligibleCardsComponent },
    ])
  ],
  providers: [StoreData],
  bootstrap: [AppComponent]
})
export class AppModule { }
