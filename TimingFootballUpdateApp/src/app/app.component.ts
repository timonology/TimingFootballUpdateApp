import { Component } from '@angular/core';
import { SignalrService } from "../app/services/signalr.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TimingFootballUpdateApp';

  constructor(private signalRService: SignalrService) { }

  ngOnInit() {
    this.signalRService.TestApp().subscribe({
        next: (result) => {
          console.log("testing app...")
            console.log(result)
        }
      })
  }
}
