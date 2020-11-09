import { Component, OnInit } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { AccountService } from '../../../core/services/account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  errorMessage : string;
  isLoginError : boolean = false; 
  value: boolean;
  constructor(private accountService : AccountService,private router : Router,private fb: FormBuilder) { }

  ngOnInit() {   
    this.value = false; 
  }

  OnSubmit(userName,password){  
    this.isLoginError = false;  
     this.accountService.userAuthentication(userName,password).subscribe((data : any)=>{
      localStorage.setItem('userToken',data.access_token);
      localStorage.setItem('role',data.role);
     this.router.navigate(['/' + data.role.toLowerCase() + '/dashboard']);
    },
    (err : HttpErrorResponse)=>{
      this.errorMessage = err.error;
      this.isLoginError = true;
    });
  }
}
