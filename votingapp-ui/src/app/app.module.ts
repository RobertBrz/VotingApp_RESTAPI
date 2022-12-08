import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VoterComponent } from './voters/voter/voter.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule} from '@angular/forms';
import { MessageComponent } from './message/message.component';
import { VoterDetailsComponent } from './voters/voter-details/voter-details.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CandidateComponent } from './candidates/candidate/candidate.component';
import { AddVoterComponent } from './voters/add-voter/add-voter.component';
import { CandidateDetailsComponent } from './candidates/candidate-details/candidate-details.component';
import { DoVoteComponent } from './do-vote/do-vote.component';
import { AnimationPageComponent } from './animation-page/animation-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddCandidateComponent } from './candidates/add-candidate/add-candidate.component';
import { NewVoterConfirmationComponent } from './voters/new-voter-confirmation/new-voter-confirmation.component';
import { FacebookModule } from 'ngx-facebook';
import { AddCandidateConfirmationComponent } from './candidates/add-candidate-confirmation/add-candidate-confirmation.component';

@NgModule({
  declarations: [
    AppComponent,
    VoterComponent,
    MessageComponent,
    VoterDetailsComponent,
    DashboardComponent,
    CandidateComponent,
    AddVoterComponent,
    CandidateDetailsComponent,
    DoVoteComponent,
    AnimationPageComponent,
    AddCandidateComponent,
    NewVoterConfirmationComponent,
    AddCandidateConfirmationComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    FacebookModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
