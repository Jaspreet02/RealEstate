import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './components/user/user.component';
import { UserDetailComponent } from './components/user/userDetail.component';
import { AdminHeaderComponent } from '../core/header/admin-header/admin-header.component';
import { SuperHeaderComponent } from '../core/header/super-header/super-header.component';
import { UserHeaderComponent } from '../core/header/user-header/user-header.component';
import { UpdatePasswordComponent } from './components/user/updatePassword.component';
import { DashboardComponent } from './components/Dashboard/dashboard.component';
import {AppHeaderComponent } from '../core/header/app-header/app-header.component';
import { LoginComponent } from './components/login/login.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'login', component: LoginComponent }, 
  { path: 'dashboard', component: AppHeaderComponent },  
  { path: 'admin', component : AdminHeaderComponent,
    children : [
      { path: 'users', component: UserComponent },
      { path: 'user/:id', component: UserDetailComponent },
      { path: 'user', component: UserDetailComponent },
      { path: 'changePassword', component: UpdatePasswordComponent }
    ]},
    { path: 'landlord', component : UserHeaderComponent,
      children : [
        { path: 'changePassword', component: UpdatePasswordComponent }
      ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class RoutingModule { }