import { Routes } from "@angular/router";
import { LoginComponent } from "./components/login/login.component";
import { RegisterComponent } from "./components/register/register.component";
import { anonymousGuard } from "@core/guards/anonymous.guard";

export const authRoutes: Routes = [
    { path: 'login', loadComponent: () => LoginComponent, canActivate: [anonymousGuard] },
    { path: 'register', loadComponent: () => RegisterComponent, canActivate: [anonymousGuard] },

    { path: '', pathMatch: 'full', redirectTo: '/auth/login' }
]