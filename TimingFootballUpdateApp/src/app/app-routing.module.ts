import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FootballUpdatesComponent } from '../app/components/football-updates/football-updates.component';

const routes: Routes = [
  // ... other routes ...
  { path: 'football-updates', component: FootballUpdatesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
