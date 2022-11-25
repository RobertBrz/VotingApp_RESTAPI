import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MessageService {

  constructor() { }


  messageList:string[] = [];

addMessage(message:string ): void {
this.messageList.push(message);
}

clear(){
  this.messageList = [];
}
}
