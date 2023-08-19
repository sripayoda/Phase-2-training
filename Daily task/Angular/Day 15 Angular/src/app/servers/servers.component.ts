import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
  serverId: number = 1001;
  serverStatus: string = 'Offline';

  addNewServer: boolean = false;
  serverCreated: string = 'Not Yet';
  serverName: string ='';

  serversList = ['Sql','Oracle'];

  constructor()
  {
    setTimeout(() => {
      this.addNewServer = true;
    }, 5000);
  }

  /*onServerNameEntry(event: Event)
  {
    console.log(event);
    this.serverName = (<HTMLInputElement>event.target).value;
  }*/

  onServerCreation()
  {
    this.serverCreated='Created';
    this.serversList.push(this.serverName);
  }

  getServerId()
  {
    return this.serverId;
  }

  getServerStatus()
  {
    return this.serverStatus;
  }

}
