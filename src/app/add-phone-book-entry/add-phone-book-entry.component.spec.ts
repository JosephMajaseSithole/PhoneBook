import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPhoneBookEntryComponent } from './add-phone-book-entry.component';

describe('AddPhoneBookEntryComponent', () => {
  let component: AddPhoneBookEntryComponent;
  let fixture: ComponentFixture<AddPhoneBookEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddPhoneBookEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddPhoneBookEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
