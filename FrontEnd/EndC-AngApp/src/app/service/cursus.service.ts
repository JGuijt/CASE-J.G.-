import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cursus } from '../model/cursus';





@Injectable({
  providedIn: 'root'
})
export class CursusService {
  url = "https://localhost:44354/api/home";
  cursussen: Cursus[];
  constructor(private httpClient: HttpClient  ) { }
  
  getAllCursus(): Observable<Cursus[]> {
    return this.httpClient.get<Cursus[]>(this.url);
    
  }
}

