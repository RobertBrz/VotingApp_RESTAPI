import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCandidateConfirmationComponent } from './add-candidate-confirmation.component';

describe('AddCandidateConfirmationComponent', () => {
  let component: AddCandidateConfirmationComponent;
  let fixture: ComponentFixture<AddCandidateConfirmationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCandidateConfirmationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddCandidateConfirmationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
