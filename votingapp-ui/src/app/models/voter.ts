export interface IVoter{
    id:number;
    pesel :number ;
    name : string ;
}


export class Voter implements IVoter{
    id: number;
    pesel: number;
    name: string;

constructor(id: number, pesel:number, name : string ){
    this.id  =id;
    this.pesel = pesel;
    this.name  = name;
}

}