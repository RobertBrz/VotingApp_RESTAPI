import { Component } from '@angular/core';
import {trigger,state, style , animate , transition} from '@angular/animations';

@Component({
  selector: 'app-animation-page',
  templateUrl: './animation-page.component.html',
  styleUrls: ['./animation-page.component.scss'],
  animations:[
    trigger('openClose',[
      state ('open' ,style({
        height:'200px',
    opacity:1,
    backgroundColor:'yellow'
      })),
      state('closed', style({
        height:'100px',
        opacity:0.8, 
        backgoundColor:'blue'
      })),
      transition('open => closed', [animate('1s')]),
      transition('closed => open', [animate('0.5s')])
    ]),
  ]
})
export class AnimationPageComponent {
 
  isOpen   = true;

  toogle(){
    this.isOpen = !this.isOpen;
  }
  
}
