import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import { Property } from '../../shared/models/property';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()

export class PropertyService {

  private Url = 'http://localhost:8004/api/Property';  // URL to web api

  constructor( private http: HttpClient) {}

  getProperties(typeId:number,cityId: number,intersection: string,prize:number[],pageNumber: number, pageSize: number,sortField: string, sortOrder: string): Observable<PagedResponse<Property>> {
   // return of(Users);
   return this.http.get<PagedResponse<Property>>(this.Url + '/GetAllWithImages/'+ typeId + '/' + cityId + '/' + intersection + '/' + pageNumber + '/' + pageSize + '/' + sortField + '/' + sortOrder + '?rent=' + prize[0] * 50 + '&rent=' + prize[1] * 50);
  // return this.http.get<PagedResponse<Property>>(this.Url );
  }

    /** POST: add a new user to the server */
    getProperty (id: string): Observable<Property> {
      return this.http.get<Property>(this.Url + '/' + id);
    }

  /** POST: add a new user to the server */
  addUser (user: Property): Observable<Property> {
    const url = `${this.Url}`;
    return this.http.post<Property>(url, user, httpOptions);
  }

  /** DELETE: delete the user from the server */
  deleteUser (user: Property | string): Observable<Property> {
    const id = typeof user === 'string' ? user : user.propertyId;
    const url = `${this.Url}/Delete/${id}`;

    return this.http.delete<Property>(url, httpOptions);
  }

  /** PUT: update the user on the server */
  updateUser (user: Property): Observable<any> {
    const url = `${this.Url}/Put/${user.propertyId}`;
    return this.http.put(url, user, httpOptions);
  }
}

export interface PagedResponse<T> {
  count: number;
  result: T[];
}
