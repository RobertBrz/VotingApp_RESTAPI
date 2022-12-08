import { Component, OnInit } from '@angular/core';
import { VoterComponent } from './voters/voter/voter.component';
import { FacebookService, InitParams } from 'ngx-facebook';
import { FacebookModule } from 'ngx-facebook';
import { concatWith } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'votingapp-ui';

  constructor(private facebookService: FacebookService) { }

    ngOnInit(): void {
      this.initFacebookService();
    }

    private initFacebookService(): void {
      const initParams: InitParams = { xfbml:true, version:'v3.2'};
     var response  =  this.facebookService.init(initParams);
     console.log(response);
    }
}
