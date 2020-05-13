import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from  '@angular/common/http';

import { AppComponent } from './app.component';
import { AddPhoneBookEntryComponent } from './add-phone-book-entry/add-phone-book-entry.component';
import { PhoneBookEntriesComponent } from './phone-book-entries/phone-book-entries.component';

@NgModule({
  declarations: [
    AppComponent,
    AddPhoneBookEntryComponent,
    PhoneBookEntriesComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
