import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailCastComponent } from './detail-cast.component';

describe('DetailCastComponent', () => {
  let component: DetailCastComponent;
  let fixture: ComponentFixture<DetailCastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailCastComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailCastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
