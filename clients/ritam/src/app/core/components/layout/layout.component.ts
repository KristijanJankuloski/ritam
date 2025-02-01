import { CommonModule } from '@angular/common';
import { Component, inject, OnInit } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';
import { TranslatePipe } from '@ngx-translate/core';
import { MenuItem } from 'primeng/api';
import { PanelMenu } from 'primeng/panelmenu';

@Component({
  selector: 'app-layout',
  imports: [CommonModule, PanelMenu, TranslatePipe, RouterOutlet],
  templateUrl: './layout.component.html',
  styleUrl: './layout.component.css'
})
export class LayoutComponent implements OnInit {
  private readonly router = inject(Router);

  public items: MenuItem[];

  public ngOnInit(): void {
    this.items = [
      {
        label: 'layout.menu-people',
        icon: 'pi pi-user',
        items: [
          {
            label: 'layout.menu-people-list',
            icon: 'pi pi-list',
            command: () => this.navigate(['/people'])
          },
          {
            label: 'layout.menu-people-add',
            icon: 'pi pi-user-plus',
            command: () => this.navigate(['/people', 'add'])
          }
        ]
      },
      {
        label: 'layout.menu-events',
        icon: '',
        items: [
          {
            label: 'layout.menu-events-list',
            icon: 'pi pi-list',
            command: () => this.navigate(['/events'])
          }
        ]
      }
    ]
  }

  public navigate(route: string[]): void {
    this.router.navigate(route);
  }
}
