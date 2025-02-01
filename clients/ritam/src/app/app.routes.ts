import { Routes } from '@angular/router';
import { LayoutComponent } from '@app-core/components/layout/layout.component';
import { authRoutes } from './feature/auth/auth.routes';

export const routes: Routes = [
    { path: 'login', component: LayoutComponent, children: authRoutes }
];
