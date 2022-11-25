import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { VoterDetailsComponent } from './voter-details/voter-details.component';
import { VoterComponent } from './voter/voter.component';

const routes: Routes = [
  {path:'voters', component:VoterComponent},
  {path:'',redirectTo:'/dashboard', pathMatch:'full'},
  {path:'dashboard', component:DashboardComponent},
  {path:'detail/:id', component:VoterDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
