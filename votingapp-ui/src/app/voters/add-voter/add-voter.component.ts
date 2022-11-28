import { Component } from '@angular/core';
import { Voter } from '../../models/voter';
import { MessageService } from '../../services/message.service';
import { VoterService } from '../../services/voter.service';

@Component({
  selector: 'app-add-voter',
  templateUrl: './add-voter.component.html',
  styleUrls: ['./add-voter.component.scss']
})
export class AddVoterComponent {

  voter   =  new Voter(0, 0,"");

constructor (private voterService :  VoterService
  
  ){
}

postNewVoter():void {
this.voterService.postVoter(this.voter).subscribe(p=>console.log(p));
}

}
