import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateCraftsmanComponent } from './create-craftsman.component';

describe('CreateCraftsmanComponent', () => {
  let component: CreateCraftsmanComponent;
  let fixture: ComponentFixture<CreateCraftsmanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateCraftsmanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateCraftsmanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
