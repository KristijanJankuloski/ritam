import { CommonModule } from '@angular/common';
import { Component, computed, input } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { TranslatePipe } from '@ngx-translate/core';
import { FloatLabelModule } from 'primeng/floatlabel';
import { PasswordModule } from 'primeng/password';

@Component({
  selector: 'shared-password-input',
  imports: [CommonModule, ReactiveFormsModule, PasswordModule, FloatLabelModule, TranslatePipe],
  templateUrl: './password-input.component.html',
  styleUrl: './password-input.component.css'
})
export class PasswordInputComponent {
  public label = input.required<string>();

  public controlName = input.required<string>();

  public parentFrom = input.required<FormGroup>();

  public feedback = input(false);

  public formControl = computed(() => {
    return this.parentFrom().controls[this.controlName()] as FormControl;
  });
}
