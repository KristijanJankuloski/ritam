import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { providePrimeNG } from 'primeng/config';
import Aura from '@primeng/themes/aura';
import { routes } from './app.routes';
import {provideTranslateService} from "@ngx-translate/core";
import { provideHttpClient } from '@angular/common/http';
import { provideToastr } from 'ngx-toastr';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes),
    provideHttpClient(),
    provideAnimationsAsync(),
    providePrimeNG({
        theme: {
          preset: Aura,
          options: {
            darkModeSelector: 'light'
          }
      }
    }),
    provideTranslateService({
      defaultLanguage: 'en'
     }),
     provideToastr({ positionClass: 'toast-bottom-right', progressBar: true, timeOut: 5000 })
  ]
};
