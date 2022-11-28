import { Component } from '@angular/core';
import { VoterComponent } from './voters/voter/voter.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'votingapp-ui';
}
