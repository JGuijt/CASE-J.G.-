import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpErrorResponse, HttpEventType } from  '@angular/common/http';  
import { map } from  'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UploadFileService {
  
  url: string= "https://localhost:44354/api/home"

  constructor(private httpClient: HttpClient) { }
  postFile(fileToUpload: File): Observable<any> {
    const endpoint = this.url;
    const formData: FormData = new FormData();
    formData.append('GoodFile', fileToUpload, fileToUpload.name);


    return this.httpClient.post(endpoint, formData, 
      {reportProgress: true,
      observe: 'events'});



    
  }

  
  }

