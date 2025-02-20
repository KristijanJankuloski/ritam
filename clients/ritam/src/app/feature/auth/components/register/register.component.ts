import { CommonModule } from '@angular/common';
import { Component, HostListener, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ButtonComponent } from '@shared/components/button/button.component';
import { PasswordInputComponent } from '@shared/components/password-input/password-input.component';
import { SimpleCardComponent } from '@shared/components/simple-card/simple-card.component';
import { TextInputFloatComponent } from '@shared/components/text-input-float/text-input-float.component';
import { RegisterWrapper } from './register.wrapper';
import { CustomFormValidators } from '@shared/validators/custom-form-validators';
import { TranslatePipe } from '@ngx-translate/core';

@Component({
  selector: 'app-register',
  imports: [
    CommonModule,
    SimpleCardComponent,
    ReactiveFormsModule,
    TextInputFloatComponent,
    PasswordInputComponent,
    ButtonComponent,
    TranslatePipe
  ],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent implements OnInit {
  public wrapper = new RegisterWrapper();
  public formGroup: FormGroup;

  public ngOnInit(): void {
    this.formGroup = new FormGroup({
      fullName: new FormControl(null, [Validators.required, Validators.minLength(3)]),
      email: new FormControl(null, [Validators.required, Validators.email]),
      username: new FormControl(null, [Validators.required, Validators.minLength(4)]),
      password: new FormControl(null, [Validators.required, Validators.minLength(6)]),
      passwordReppeated: new FormControl(null, [Validators.required])
    }, [CustomFormValidators.passwordsMatch(this.wrapper.passwordControlName, this.wrapper.passwrodReppeatedControlName)]);
  }

  public submit(): void {
    if (this.formGroup.invalid){
      return;
    }
  }

  @HostListener('document:keydown.Enter', ['$event'])
  public handleEnterKeyPress(event: KeyboardEvent): void {
    this.submit();
  }
}
