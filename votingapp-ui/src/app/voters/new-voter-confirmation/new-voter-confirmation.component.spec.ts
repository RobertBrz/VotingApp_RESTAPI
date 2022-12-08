import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewVoterConfirmationComponent } from './new-voter-confirmation.component';

describe('NewVoterConfirmationComponent', () => {
  let component: NewVoterConfirmationComponent;
  let fixture: ComponentFixture<NewVoterConfirmationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewVoterConfirmationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewVoterConfirmationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
