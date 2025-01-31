import { Routes } from '@angular/router';
import { LoginComponent } from './feature/auth/components/login/login.component';

export const routes: Routes = [
    { path: 'login', loadComponent: () => LoginComponent }
];
