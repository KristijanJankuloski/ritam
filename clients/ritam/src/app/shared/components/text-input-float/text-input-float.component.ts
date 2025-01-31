import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, computed, input } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { TranslatePipe } from '@ngx-translate/core';
import { FloatLabelModule } from 'primeng/floatlabel';
import { InputTextModule } from 'primeng/inputtext';

@Component({
  selector: 'shared-text-input-float',
  imports: [CommonModule, ReactiveFormsModule, FloatLabelModule, InputTextModule, TranslatePipe],
  templateUrl: './text-input-float.component.html',
  styleUrl: './text-input-float.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class TextInputFloatComponent {
  public label = input.required<string>();

  public controlName = input.required<string>();

  public parentFrom = input.required<FormGroup>();

  public formControl = computed(() => {
    return this.parentFrom().controls[this.controlName()] as FormControl;
  });
}
