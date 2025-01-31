import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, computed, Input } from '@angular/core';
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
  @Input({required: true})
  label: string;

  @Input({required: true})
  controlName: string;

  @Input({required: true})
  parentFrom: FormGroup;

  formControl = computed(() => {
    return this.parentFrom.controls[this.controlName] as FormControl;
  });
}
