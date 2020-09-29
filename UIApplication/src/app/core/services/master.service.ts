import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()

export class MasterService {

  private MasterUrl = 'http://127.0.0.1:8004/api/Master';  // URL to web api

  constructor(private http: HttpClient) { }

  getTypes(): Observable<any> {
    var reqHeader = new HttpHeaders({ 'Content-Type': 'application/json', 'No-Auth':'True'});    
    return this.http.get<any>(this.MasterUrl + '/Types', {headers : reqHeader});
  }

  getEmailTokens(): Observable<any> {
    // return of(Users);
    return this.http.get<any>(this.MasterUrl + '/EmailToken');
  }

  getRunNumerStatus(): Observable<any> {
    // return of(Users);
    return this.http.get<any>(this.MasterUrl + '/RunNumberStatus');
  }

}
