import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, EventEmitter, Input, Output } from '@angular/core';
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
  @Input({required: true})
  public text: string;

  @Input()
  public icon?: string;

  @Input()
  public type : 'button' | 'submit' = 'button';

  @Output()
  public onButtonClick = new EventEmitter<void>();

  public buttonClicked() {
    this.onButtonClick.emit();
  }
}
