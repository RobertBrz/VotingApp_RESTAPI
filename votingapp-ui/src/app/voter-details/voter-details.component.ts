import { Component, OnInit, Input } from '@angular/core';
import { IVoter } from '../models/voter';
import {Location} from '@angular/common';
import { VoterService } from '../services/voter.service';
import { ActivatedRoute } from '@angular/router';
import { MessageService } from '../services/message.service';

@Component({
  selector: 'app-voter-details',
  templateUrl: './voter-details.component.html',
  styleUrls: ['./voter-details.component.scss']
})

export class VoterDetailsComponent  implements OnInit{

constructor(
private route:ActivatedRoute,
private voterServices: VoterService,
private location :  Location,
private messageService :MessageService
){
}

goBack():void{
  this.location.back();
}

ngOnInit(): void {
this.getHero();
}

 public voter! :IVoter;

getHero():void{
 const id  = Number(this.route.snapshot.paramMap.get('id'));
 this .messageService.addMessage("id is "+id);
 this.voterServices.getVoter(id).subscribe(voter=>this.voter = voter);
}
}
