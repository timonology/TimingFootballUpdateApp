import { Component, OnInit } from '@angular/core';
import { SignalrService} from '../../services/signalr.service';

@Component({
  selector: 'app-football-updates',
  templateUrl: './football-updates.component.html',
  styleUrls: ['./football-updates.component.css']
})
export class FootballUpdatesComponent implements OnInit {
  matches: any[] = [];

  constructor(private signalRService: SignalrService) { }

  ngOnInit(): void {
    this.signalRService.startStreaming();
    this.signalRService.listenForMatches((match) => {
      if (this.matches.length < 5) {
        this.matches.unshift(match); // Add the new match to the beginning of the list
      } else {
        this.matches.pop(); // Remove the last match when the list reaches 5
        this.matches.unshift(match);
      }
    });
  }

  stopStreaming() {
    this.signalRService.stopStreaming();
  }

}
