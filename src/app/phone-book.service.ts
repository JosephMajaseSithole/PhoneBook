import { Injectable } from '@angular/core';
import { Entry } from './Entry';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PhoneBookService {

phonebookEntries : Entry[];

 apiBaseUrl: string = 'http://localhost:58903/api/phonebook/'

  constructor(private http: HttpClient) { }

  getEntries(name?: string) : Observable<Entry[]> {
      return this.http.get<Entry[]>(this.apiBaseUrl + '?=' + name);
  }
  addPhoneBookEntry(entry: Entry) {
    this.http.post(this.apiBaseUrl, entry).subscribe(
      (response) => console.log(response),
      (error) => console.log(error)
    )
  }
}
