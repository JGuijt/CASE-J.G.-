import { Component, OnInit, ViewChild, ElementRef  } from '@angular/core';
import { HttpEventType, HttpErrorResponse } from '@angular/common/http';
import { of } from 'rxjs';  
import { catchError, map } from 'rxjs/operators';  
import { UploadFileService} from  '../../service/upload-file.service';

@Component({
  selector: 'upload-file',
  templateUrl: './upload-file.component.html',
  styleUrls: ['./upload-file.component.css']
})
export class UploadFileComponent implements OnInit {

  fileToUpload: File = undefined;
  constructor(private uploadFileService: UploadFileService) { }

  ngOnInit(): void {
  
  }
  
  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
    console.log(this.fileToUpload);
    console.log("File filled")
  }

  uploadFileToServer() {
    this.uploadFileService.postFile(this.fileToUpload).subscribe(data => {console.log("sent file"); console.log(data);}
  ,error => {console.log(error);  });
  }


}


