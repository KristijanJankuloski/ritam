import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ButtonComponent } from '@shared/components/button/button.component';
import { PasswordInputComponent } from '@shared/components/password-input/password-input.component';
import { SimpleCardComponent } from '@shared/components/simple-card/simple-card.component';
import { TextInputFloatComponent } from '@shared/components/text-input-float/text-input-float.component';

@Component({
  selector: 'app-login',
  imports: [
    CommonModule,
    SimpleCardComponent,
    TextInputFloatComponent,
    PasswordInputComponent,
    ReactiveFormsModule,
    ButtonComponent
  ],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {
  public loginForm: FormGroup;

  public ngOnInit(): void {
    this.loginForm = new FormGroup({
      username: new FormControl(null, [Validators.required]),
      password: new FormControl(null, [Validators.required])
    });
  }
}
