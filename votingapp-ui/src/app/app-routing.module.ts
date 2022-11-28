import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CandidateComponent } from './candidates/candidate/candidate.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AddVoterComponent } from './voters/add-voter/add-voter.component';
import { VoterDetailsComponent } from './voters/voter-details/voter-details.component';
import { VoterComponent } from './voters/voter/voter.component';

const routes: Routes = [
  {path:'voters', component:VoterComponent},
  {path:'',redirectTo:'/dashboard', pathMatch:'full'},
  {path:'dashboard', component:DashboardComponent},
  {path:'detail/:id', component:VoterDetailsComponent},
  {path:'candidates', component:CandidateComponent},
  {path:'addVoters', component:AddVoterComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
