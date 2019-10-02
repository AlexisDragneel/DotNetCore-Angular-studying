import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RecursiveStringComponent } from './recursive-string.component';

describe('RecursiveStringComponent', () => {
  let component: RecursiveStringComponent;
  let fixture: ComponentFixture<RecursiveStringComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RecursiveStringComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RecursiveStringComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
