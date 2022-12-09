import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { CandidateServiceService } from '../../services/candidate-service.service';
import { ActivatedRoute } from '@angular/router';
import { ICandidate } from '../../models/candidate';
import { MessageService } from '../../services/message.service';


@Component({
  selector: 'app-candidate-details',
  templateUrl: './candidate-details.component.html',
  styleUrls: ['./candidate-details.component.scss']
})
export class CandidateDetailsComponent implements OnInit {

  constructor(private location: Location,
    private candidateService: CandidateServiceService,
    private route: ActivatedRoute,
    private messageService: MessageService
  ) {
  }

  candidate!: ICandidate;

  ngOnInit(): void {
    this.getCanidateDetials();
  }

  goBack(): void {
    this.location.back();
  }

  getCanidateDetials(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.messageService.addMessage("picked candidate id : " + id);
    this.candidateService.getCandidate(id).subscribe(c => this.candidate = c);
  }
}
