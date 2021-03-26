import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { CursusService } from './cursus.service';
import { UploadFileService } from './upload-file.service';
import { Cursus } from '../model/cursus';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { Observable } from 'rxjs';

describe('Service: CursusService', () => {
  let sut: CursusService;
  let httpTestingController: HttpTestingController;
  let httpClient: HttpClient;


  beforeEach(() => {
    TestBed.configureTestingModule({imports: [HttpClientTestingModule]});
    sut = TestBed.inject(CursusService);
    httpClient = TestBed.inject(HttpClient);
    httpTestingController = TestBed.inject(HttpTestingController);
  });

  it('should be created', () => {
    expect(sut).toBeTruthy();
  });

});


