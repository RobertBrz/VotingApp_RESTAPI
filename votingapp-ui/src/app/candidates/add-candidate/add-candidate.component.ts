import { Component } from '@angular/core';
import { CandidateServiceService } from '../../services/candidate-service.service';
import {Location} from '@angular/common';
import { Candidate } from '../../models/candidate';

@Component({
  selector: 'app-add-candidate',
  templateUrl: './add-candidate.component.html',
  styleUrls: ['./add-candidate.component.scss']
})
export class AddCandidateComponent {

candidate =  new Candidate(0,0,"");

constructor(private candidateService: CandidateServiceService,
  private location:Location){
}

goBack():void{
  this.location.back();
}

postNewCandidate():void{
  this.candidateService.postCandidate(this.candidate).subscribe(p=>console.log(p));
}

}
