import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TextInputFloatComponent } from './text-input-float.component';

describe('TextInputFloatComponent', () => {
  let component: TextInputFloatComponent;
  let fixture: ComponentFixture<TextInputFloatComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TextInputFloatComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TextInputFloatComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
