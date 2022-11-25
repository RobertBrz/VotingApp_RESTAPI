import { Component  ,OnInit} from '@angular/core';
import { VoterService } from '../services/voter.service';
import { IVoter } from '../models/voter';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-voter',
  templateUrl: './voter.component.html',
  styleUrls: ['./voter.component.scss']
})
export class VoterComponent implements OnInit {

  voters : IVoter[] = [];

constructor(private voterService:VoterService){
}

  ngOnInit(): void {
    this.getVoters();
  }

getVoters():void {
  this.voterService.getVoters()
  .subscribe(voters => this.voters = voters);
}

}
