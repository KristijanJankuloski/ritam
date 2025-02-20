import { inject, Injectable } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {
  private readonly toastr = inject(ToastrService);
  private readonly translate = inject(TranslateService);

  public error(message: string): void {
    this.toastr.error(this.translate.instant(message), this.translate.instant('toastr.error'));
  }

  public warning(message: string): void {
    this.toastr.warning(this.translate.instant(message), this.translate.instant('toastr.warning'));
  }

  public success(message: string): void {
    this.toastr.success(this.translate.instant(message), this.translate.instant('toastr.success'));
  }
}
