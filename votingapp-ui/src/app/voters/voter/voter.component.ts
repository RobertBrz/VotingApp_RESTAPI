import { Component  ,OnInit} from '@angular/core';
import { VoterService } from '../../services/voter.service';
import { IVoter } from '../../models/voter';
import { FormsModule } from '@angular/forms';
import { MessageService } from '../../services/message.service';
import { VoterDetailsComponent } from '../voter-details/voter-details.component';
import {Location} from '@angular/common';


@Component({
  selector: 'app-voter',
  templateUrl: './voter.component.html',
  styleUrls: ['./voter.component.scss']
})
export class VoterComponent implements OnInit {

  voters : IVoter[] = [];

constructor(private voterService:VoterService
  ,private messageService:MessageService,
  private location :  Location){
}

  ngOnInit(): void {
    this.getVoters();
  }

getVoters():void {
  this.voterService.getVoters()
  .subscribe(voters => this.voters = voters);
}
onSelect(voter :IVoter):void{
  this.messageService.addMessage("Selected Voter id={"+voter.name +"}")
}

goBack():void{
  this.location.back();
}

}
