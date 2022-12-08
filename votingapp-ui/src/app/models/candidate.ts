import { Voter } from "./voter";

export interface ICandidate{
    id: number ;
    pesel: number;
    name :string;
    votes: number;
}


export class Candidate implements ICandidate{
    id: number;
    pesel: number;
    name: string;
    votes: number;

constructor(id: number, pesel:number, name : string ){
    this.id  =id;
    this.pesel = pesel;
    this.name  = name;
    this.votes  = 0;
}
}
