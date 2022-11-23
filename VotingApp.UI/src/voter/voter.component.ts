import { Component, OnInit } from '@angular/core'
import { Observable } from 'rxjs';
import { IVoter } from '../Shared/interfaces';
import { VoterService } from 'src/Services/voter.service';

@Component({
  selector: 'voterselector',
  templateUrl: './voter.component.html',
  styleUrls: ['./voter.component.css']
})

export class VoterComponent implements OnInit {

  public voters$!: Observable<IVoter[]>;
  public param: string = 'test';


  constructor(private voterService: VoterService) {

  }

  ngOnInit(): void {
    this.voters$ = this.getVoters();
  }

  getVoters(): Observable<IVoter[]> {
    return this.voterService.getVoters();
  }
}
