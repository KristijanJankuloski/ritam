import { Injectable, signal } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NavBarService {
  public shrinkPanel = signal(false);
  constructor() { }
}
