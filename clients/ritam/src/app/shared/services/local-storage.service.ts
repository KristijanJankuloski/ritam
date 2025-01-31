import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {
  private readonly localeKey = 'LOCALE';

  constructor() { }

  public set locale(locale: string) {
    localStorage.setItem(this.localeKey, locale);
  }

  public get locale() {
    return localStorage.getItem(this.localeKey);
  }
}
