import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnimationPageComponent } from './animation-page/animation-page.component';
import { AddCandidateConfirmationComponent } from './candidates/add-candidate-confirmation/add-candidate-confirmation.component';
import { AddCandidateComponent } from './candidates/add-candidate/add-candidate.component';
import { CandidateDetailsComponent } from './candidates/candidate-details/candidate-details.component';
import { CandidateComponent } from './candidates/candidate/candidate.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { DoVoteComponent } from './do-vote/do-vote.component';
import { AddVoterComponent } from './voters/add-voter/add-voter.component';
import { NewVoterConfirmationComponent } from './voters/new-voter-confirmation/new-voter-confirmation.component';
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
  {path:'vote',component:DoVoteComponent},
  { path: 'lazy', loadChildren: () => import('./lazy/lazy.module').then(m => m.LazyModule) },
  {path : 'animation', component: AnimationPageComponent},
  {path: 'addCandidate',component:AddCandidateComponent},
  {path:'newVoterConfirmation', component:NewVoterConfirmationComponent},
  {path:'newCandidateConfirmation', component:AddCandidateConfirmationComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
