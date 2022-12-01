import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { IVoter } from '../models/voter';
import { VoterService } from '../services/voter.service';

@Component({
  selector: 'app-newnavigation',
  templateUrl: './newnavigation.component.html',
  styleUrls: ['./newnavigation.component.scss']
})
export class NewnavigationComponent {

  voters :IVoter[]=[];

constructor(private voterService:VoterService){
}

  getVoters():void{
  this.voterService.getVoters().subscribe (v=>this.voters = v);
  this.voters.forEach(v=>console.log(v.name));
  }
}
