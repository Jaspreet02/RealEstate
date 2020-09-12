import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './components/user/user.component';
import { UserDetailComponent } from './components/user/userDetail.component';
import { LandlordHeaderComponent } from '../core/header/landlord-header/landlord-header.component';
import { SuperHeaderComponent } from '../core/header/super-header/super-header.component';
import { UserHeaderComponent } from '../core/header/user-header/user-header.component';
import { UpdatePasswordComponent } from './components/user/updatePassword.component';
import { DashboardComponent } from './components/Dashboard/dashboard.component';
import {AppHeaderComponent } from '../core/header/app-header/app-header.component';
import { LoginComponent } from './components/login/login.component';
import { PropertyComponent } from './components/Dashboard/Property.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'login', component: LoginComponent }, 
  { path: 'dashboard', component: AppHeaderComponent },  
  { path: 'admin', component : LandlordHeaderComponent,
    children : [
      { path: 'users', component: UserComponent },
      { path: 'user/:id', component: UserDetailComponent },
      { path: 'user', component: UserDetailComponent },
      { path: 'changePassword', component: UpdatePasswordComponent }
    ]},
    { path: 'landlord', component : LandlordHeaderComponent,
      children : [
        { path: 'changePassword', component: UpdatePasswordComponent },
        { path: 'property', component: PropertyComponent},
        { path: 'property/:id', component: PropertyComponent}
      ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class RoutingModule { }