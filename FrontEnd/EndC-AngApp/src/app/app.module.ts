import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http'
import { AppRoutingModule} from './app-routing.module' 

import { AppComponent } from './app.component';
import { CursusComponent } from './cursus/cursus.component';
import { CursusService } from './service/cursus.service';
import { UploadFileComponent } from './upload/upload-file/upload-file.component';
import { UploadFileService } from './service/upload-file.service';

@NgModule({
  declarations: [
    AppComponent,
    CursusComponent,
    UploadFileComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule  
  ],
  providers: [HttpClientModule, CursusService, UploadFileService],
  bootstrap: [AppComponent]
})
export class AppModule { }
