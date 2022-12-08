import { Component, OnInit } from '@angular/core';
import { Candidate, ICandidate } from '../models/candidate';
import { Vote } from '../models/vote';
import { IVoter, Voter } from '../models/voter';
import { CandidateServiceService } from '../services/candidate-service.service';
import { VoterService } from '../services/voter.service';

@Component({
  selector: 'app-do-vote',
  templateUrl: './do-vote.component.html',
  styleUrls: ['./do-vote.component.scss']
})
export class DoVoteComponent implements OnInit {

votersArray : IVoter[]=[];
candidatesArray: ICandidate[]=[];
selectedVoter!: Voter;
selectedCandidate!:Candidate;

  constructor(private voterService: VoterService,
    private candidateService: CandidateServiceService){

    }
  ngOnInit(): void {
    this.voterService.getVoters().subscribe(v=>this.votersArray = v);
    this.candidateService.getCandidates().subscribe(c=>this.candidatesArray = c);
  }

  doVote():void{
   this.voterService.vote(new Vote(this.selectedVoter.id, this.selectedCandidate.id)).subscribe();
  }
}
