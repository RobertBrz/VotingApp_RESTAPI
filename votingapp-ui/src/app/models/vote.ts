export class Vote{
    voterId:number;
    candidateId:number;

    constructor(voterId :number, candidateId:number){
this.candidateId = candidateId;
this.voterId = voterId;
    }
}