import { Component, OnInit } from '@angular/core';
import { PhoneBookService } from '../phone-book.service';
import { Entry } from '../Entry';

@Component({
  selector: 'app-phone-book-entries',
  templateUrl: './phone-book-entries.component.html',
  styleUrls: ['./phone-book-entries.component.css']
})
export class PhoneBookEntriesComponent implements OnInit {

  phonebookEntries : Entry[];
  entrySearch: string = "";

  constructor(private service : PhoneBookService) { }

  ngOnInit(): void {
    this.getEntries();
  }

  onSearch(){
    this.getEntries();
  }

  getEntries(){
    this.service.getEntries(this.entrySearch).subscribe(result => this.phonebookEntries = result);
  }

}
