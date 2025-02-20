import { Routes } from '@angular/router';
import { authRoutes } from './feature/auth/auth.routes';
import { LayoutComponent } from '@core/components/layout/layout.component';
import { peopleRoutes } from './feature/people/people.routes';
import { authGuard } from '@core/guards/auth.guard';

export const routes: Routes = [
    { path: 'auth', children: authRoutes },
    { path: '', component: LayoutComponent, children: [
        { path: 'people', children: peopleRoutes, canActivate: [authGuard] },

        { path: '', pathMatch: 'full', redirectTo: '/auth' }
    ] },
];
