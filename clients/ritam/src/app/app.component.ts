import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './core/components/header/header.component';
import { TranslateService } from '@ngx-translate/core';
import translationsEN from "../../public/i18n/en.json";
import translationsMK from "../../public/i18n/mk.json";
import { LocalStorageService } from '@shared/services/local-storage.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeaderComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ritam';

  constructor(
    private translateService: TranslateService,
    private localStorageService: LocalStorageService) {
    translateService.setTranslation('en', translationsEN);
    translateService.setTranslation('mk', translationsMK);
    translateService.addLangs(['en', 'mk']);
    translateService.setDefaultLang('en');

    const defaultLanguage = localStorageService.locale ?? 'mk';
    translateService.use(defaultLanguage);
  }
}
