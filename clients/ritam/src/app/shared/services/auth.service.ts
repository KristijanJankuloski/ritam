import { Injectable, signal } from '@angular/core';
import { User } from '@core/models/user.model';
import { LocalStorageService } from './local-storage.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private _currentUser = signal<User | null>(null);

  public currentUser = this._currentUser.asReadonly();

  constructor(localStorageService: LocalStorageService) {
    const user = localStorageService.user;
    this._currentUser.set(user);
  }
}
