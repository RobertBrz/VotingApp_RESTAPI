import { Component } from '@angular/core';
import {Location} from '@angular/common';

@Component({
  selector: 'app-candidate-details',
  templateUrl: './candidate-details.component.html',
  styleUrls: ['./candidate-details.component.scss']
})
export class CandidateDetailsComponent {

constructor(private location :Location){
  
}

  goBack():void{
this.location.back();
  }
}
