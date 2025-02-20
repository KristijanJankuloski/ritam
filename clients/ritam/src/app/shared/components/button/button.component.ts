import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, EventEmitter, input, Input, output, Output } from '@angular/core';
import { TranslatePipe } from '@ngx-translate/core';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'shared-button',
  imports: [CommonModule, ButtonModule, TranslatePipe],
  templateUrl: './button.component.html',
  styleUrl: './button.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ButtonComponent {
  public text = input.required<string>();

  public icon? = input<string>();

  public type = input<'button' | 'submit'>('button');

  public disable = input(false);

  public onButtonClick = output<void>();

  public buttonClicked() {
    this.onButtonClick.emit();
  }
}
