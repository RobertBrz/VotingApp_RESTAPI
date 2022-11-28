import { Component ,OnInit} from '@angular/core';
import { ICandidate } from '../../models/candidate';
import { CandidateServiceService } from '../../services/candidate-service.service';
import {Location} from '@angular/common';


@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.scss']
})
export class CandidateComponent implements OnInit {

candidates :  ICandidate[]=[];

  constructor(private candidateService: CandidateServiceService ,
    private locaiton:Location
    ){

  }
  ngOnInit(): void {
    this.getCandidates();
  }


  getCandidates() :void {
this.candidateService.getCandidates().subscribe(c=>this.candidates  = c);
  }


  goBack():void {
this.locaiton.back();
  }
}
