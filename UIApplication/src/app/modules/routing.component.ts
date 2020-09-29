import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './components/user/user.component';
import { UserDetailComponent } from './components/user/userDetail.component';
import { LandlordHeaderComponent } from '../core/header/landlord-header/landlord-header.component';
import { UpdatePasswordComponent } from './components/user/updatePassword.component';
import {AppHeaderComponent } from '../core/header/app-header/app-header.component';
import { LoginComponent } from './components/login/login.component';
import { PropertyComponent } from './components/Dashboard/Property.component';
import { AdminHeaderComponent } from 'app/core/header/admin-header/admin-header.component';

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