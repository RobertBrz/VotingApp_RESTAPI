import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewnavigationComponent } from './newnavigation.component';

describe('NewnavigationComponent', () => {
  let component: NewnavigationComponent;
  let fixture: ComponentFixture<NewnavigationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewnavigationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewnavigationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
