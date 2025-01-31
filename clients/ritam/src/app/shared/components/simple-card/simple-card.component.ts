import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { TranslatePipe } from '@ngx-translate/core';
import { CardModule } from 'primeng/card';

@Component({
  selector: 'shared-simple-card',
  imports: [CommonModule, CardModule, TranslatePipe],
  templateUrl: './simple-card.component.html',
  styleUrl: './simple-card.component.css'
})
export class SimpleCardComponent {
  @Input()
  header?: string;
}
