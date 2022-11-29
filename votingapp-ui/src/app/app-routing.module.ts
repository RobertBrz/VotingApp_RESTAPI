import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CandidateDetailsComponent } from './candidates/candidate-details/candidate-details.component';
import { CandidateComponent } from './candidates/candidate/candidate.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DoVoteComponent } from './do-vote/do-vote.component';
import { AddVoterComponent } from './voters/add-voter/add-voter.component';
import { VoterDetailsComponent } from './voters/voter-details/voter-details.component';
import { VoterComponent } from './voters/voter/voter.component';

const routes: Routes = [
  {path:'voters', component:VoterComponent},
  {path:'',redirectTo:'/dashboard', pathMatch:'full'},
  {path:'dashboard', component:DashboardComponent},
  {path:'voter/detail/:id', component:VoterDetailsComponent},
  {path:'candidates', component:CandidateComponent},
  {path:'addVoters', component:AddVoterComponent},
  {path: 'candidate/detail/:id' , component:CandidateDetailsComponent},
  {path:'vote',component:DoVoteComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
