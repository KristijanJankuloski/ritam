import { CommonModule } from '@angular/common';
import { Component, inject, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';
import { MenuModule } from 'primeng/menu';
import { ButtonModule } from 'primeng/button';
import { TranslatePipe, TranslateService } from '@ngx-translate/core';
import { Router } from '@angular/router';
import { LocalStorageService } from '@shared/services/local-storage.service';

@Component({
  selector: 'app-header',
  imports: [CommonModule, MenubarModule, MenuModule, ButtonModule, TranslatePipe],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent implements OnInit {
  private readonly translateService = inject(TranslateService);
  private readonly localStorageService = inject(LocalStorageService);

  public rightMenuItems?: MenuItem[];
  public shouldShowItems = true;

  public ngOnInit(): void {
    this.rightMenuItems = [
      {
        label: 'header.menu-language',
        icon: '',
        items: [
          {
            label: 'English',
            icon: '/img/en-flag.svg',
            command: () => {
              this.changeLanguage('en');
            }
          },
          {
            label: 'Македонски',
            icon: '/img/mk-flag.svg',
            command: () => {
              this.changeLanguage('mk');
            }
          }
        ]
      }
    ]
  }

  public changeLanguage(language: string): void {
    this.localStorageService.locale = language;
    this.translateService.use(language);
  }
}
