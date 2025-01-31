import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, computed, Input } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { TranslatePipe } from '@ngx-translate/core';
import { FloatLabelModule } from 'primeng/floatlabel';
import { PasswordModule } from 'primeng/password';

@Component({
  selector: 'shared-password-input',
  imports: [CommonModule, ReactiveFormsModule, PasswordModule, FloatLabelModule, TranslatePipe],
  templateUrl: './password-input.component.html',
  styleUrl: './password-input.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class PasswordInputComponent {
  @Input({required: true})
  label: string;

  @Input({required: true})
  controlName: string;

  @Input({required: true})
  parentFrom: FormGroup;

  @Input()
  feedback = false;

  formControl = computed(() => {
    return this.parentFrom.controls[this.controlName] as FormControl;
  });
}
