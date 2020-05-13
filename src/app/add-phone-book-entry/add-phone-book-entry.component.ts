import { Component, OnInit, ViewChild } from '@angular/core';
import { Entry } from '../Entry';
import { PhoneBookService } from '../phone-book.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-phone-book-entry',
  templateUrl: './add-phone-book-entry.component.html',
  styleUrls: ['./add-phone-book-entry.component.css']
})
export class AddPhoneBookEntryComponent implements OnInit {

  @ViewChild('addEntryForm') mytemplateForm : NgForm;
  
  constructor(private service: PhoneBookService) { }

  ngOnInit(): void {
  }

  onSubmit(entry: Entry, event : Event){
    event.preventDefault();
    this.service.addPhoneBookEntry(entry);
    this.mytemplateForm.reset()
  }

}
