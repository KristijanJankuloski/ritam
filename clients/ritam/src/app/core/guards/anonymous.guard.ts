import { inject } from '@angular/core';
import { CanActivateFn } from '@angular/router';
import { AuthService } from '@shared/services/auth.service';

export const anonymousGuard: CanActivateFn = (route, state) => {
  const authService = inject(AuthService);

  if (authService.currentUser()){
    return false;
  }

  return true;
};
