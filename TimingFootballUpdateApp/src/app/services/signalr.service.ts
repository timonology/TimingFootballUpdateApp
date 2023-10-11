import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import * as signalR from "@microsoft/signalr";
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SignalrService {
  private hubConnection: signalR.HubConnection;

  constructor(private http: HttpClient) {
    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl('https://localhost:7068/footballupdate', {
        // skipNegotiation: true,
        // transport: signalR.HttpTransportType.WebSockets
      })
      .configureLogging(signalR.LogLevel.Information) 
      .build();
  }

  startStreaming() {
    this.hubConnection.start().then(() => {
      this.hubConnection.invoke('StartStreaming');
    }).catch(err => console.log('Error while starting connection: ' + err));
  }

  stopStreaming() {
    this.hubConnection.invoke('StopStreaming').catch(err => console.log('Error while stopping connection: ' + err));
  }

  listenForMatches(callback: (match: any) => void) {
    this.hubConnection.on('ReceiveFootballMatch', (data: any) => {
      callback(data);
    });
  }


  TestApp(){
    let reqHeader = new HttpHeaders();
    reqHeader.append('Content-Type', 'application/json');

    let body = {
    }
    return this.http.post<any>(`https://localhost:7068/start`, body, { headers: reqHeader });
  }
}
