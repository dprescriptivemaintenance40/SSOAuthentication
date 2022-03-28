import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { AuthGuardService } from './Shared/AuthGuard';

const routes: Routes = [
  {
    path:"Login", component:LoginComponent
  },
  {
    path: '', redirectTo: 'Login', pathMatch: 'full'
  },
  {
    path:"Dashboard", component:DashboardComponent, canActivate:[AuthGuardService]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
