import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateToolboxComponent } from './create-toolbox.component';

describe('CreateToolboxComponent', () => {
  let component: CreateToolboxComponent;
  let fixture: ComponentFixture<CreateToolboxComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateToolboxComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateToolboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
