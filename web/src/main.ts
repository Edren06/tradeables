import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppModule } from './app/app.module'; // Adjust the path accordingly

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch((err) => console.error(err));