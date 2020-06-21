import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import { ChangePasswordBindingModel } from '../../shared/models/changePasswordBindingModel';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json'  })
};

@Injectable()

export class AccountService {

  private userUrl = 'http://localhost:8004/Account';  // URL to web api

  constructor( private http: HttpClient) {}

  userAuthentication(userName: string, password: string):Observable<any>  {
    var data = {"Username" : userName, "Password" : password};
    var reqHeader = new HttpHeaders({ 'Content-Type': 'application/x-www-urlencoded', 'No-Auth':'True'});
    return this.http.post('http://127.0.0.1:8004/Account/Login', data, {responseType : 'text'});
  }

  private serializeObj(obj) {
    var result = [];
    for (var property in obj)
        result.push(encodeURIComponent(property) + "=" + encodeURIComponent(obj[property]));

    return result.join("&");
}

  /** POST: add a new user to the server */
  changePassword (entity: ChangePasswordBindingModel): Observable<any> {
    const url = `http://127.0.0.1:8004/Account/ChangePassword`;
    return this.http.post<ChangePasswordBindingModel>(url, entity, httpOptions);
  }

}

export interface PagedResponse<T> {
  Count: number;
  Result: T[];
}
