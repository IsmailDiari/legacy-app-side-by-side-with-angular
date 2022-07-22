import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { environment } from '../../environments/environment';
import { AnotherModuleModule } from './another-module.module';


if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic()
  .bootstrapModule(AnotherModuleModule)
  .catch((err) => console.error(err));
