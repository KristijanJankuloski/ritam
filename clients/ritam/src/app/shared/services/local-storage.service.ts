import { Injectable } from '@angular/core';
import { User } from '@core/models/user.model';

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {
  private readonly localeKey = 'LOCALE';
  private readonly userKey = 'USER';

  constructor() { }

  // LOCALE
  public set locale(locale: string | null) {
    if (locale == null){
      localStorage.removeItem(this.localeKey);
      return;
    }
    localStorage.setItem(this.localeKey, locale);
  }

  public get locale(): string | null {
    return localStorage.getItem(this.localeKey);
  }

  // USER
  public set user(user: User | null) {
    if (user == null){
      localStorage.removeItem(this.userKey);
      return;
    }
    localStorage.setItem(this.userKey, JSON.stringify(user));
  }

  public get user(): User | null {
    const userString = localStorage.getItem(this.userKey);
    if (!userString){
      return null;
    }

    const userObject = JSON.parse(userString);
    if (!userObject){
      return null;
    }

    return userObject as User;
  }
}
