import { Component, OnInit } from '@angular/core';
import {Observable, VirtualTimeScheduler} from 'rxjs';

import { Cursus } from '../model/cursus';
import { CursusService } from '../service/cursus.service';

@Component({
  selector: 'cursus',
  templateUrl: './cursus.component.html',
  styleUrls: ['./cursus.component.css']
})
export class CursusComponent implements OnInit {
  allCursussen: Observable<Cursus[]>;


  constructor(private cursusService: CursusService) {

   }



  ngOnInit(): void {
    this.loadAllCursussen();

  }
  loadAllCursussen() {
    this.allCursussen = this.cursusService.getAllCursus();
    //to check if holds values
    this.allCursussen.subscribe(res => console.log(res));

  }

  
}




//naam webservice zit
//dan heeft clietn call gemaakt
//of een errro daatrna te zien krijgt
//clinet mist 
//feth


